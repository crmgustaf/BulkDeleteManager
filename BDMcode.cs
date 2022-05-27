using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using XrmToolBox.Extensibility;

namespace BulkDeleteManager
{
    partial class BDM
    {
        private const string FetchTemplate = @"<fetch>
  <entity name='{0}'>
    <attribute name = '{1}'/>
    <filter>
      <condition attribute='modifiedon' operator='olderthan-x-years' value='100' />
    </filter>
  </entity>
</fetch>";

        private void LoadMetadata()
        {
            
            ConnectionDetail.MetadataCacheLoader.ContinueWith(metaload =>
            {
                Invoke((MethodInvoker)delegate
                {
                    Enabled = true;
                    if (!metaload.IsFaulted)
                    {
                        xrmEntity.DataSource = metaload.Result?.EntityMetadata;
                        GetBulkDeleteJobs();
                    }
                    else
                    {
                        MessageBox.Show("Unable to load metadata. Remove the metadata cache in the XRMToolbox folder and try again");
                    }
                });
            });
        }

        private void GetBulkDeleteJobs()
        {
            var query_operationtype = 13;
            var query = new QueryExpression("asyncoperation");
            query.ColumnSet.AddColumns("name","statecode", "operationtype", "messagename", "primaryentitytype", "message", "ownerid", "friendlymessage", "recurrencestarttime", "recurrencepattern", "postponeuntil", "statuscode", "data");
            query.AddOrder("name", OrderType.Ascending);
            query.Criteria.AddCondition("recurrencepattern", ConditionOperator.NotNull);
            query.Criteria.AddCondition("operationtype", ConditionOperator.Equal, query_operationtype);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting bulk deletion jobs",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error, "Load Bulk Data Deleting Jobs");
                    }
                    if (args.Result is EntityCollection result)
                    {
                        xrmBulkDeleteNames.DataSource = result;
                    }
                }
            });
        }

        private void getAndSetAsyncOperationsJobs(Guid asyncoperationid)
        {
            var query = new QueryExpression("bulkdeleteoperation");
            query.ColumnSet.AddColumns("statecode", "failurecount", "successcount", "statuscode");
            query.AddOrder("name", OrderType.Ascending);
            query.Criteria.AddCondition("asyncoperationid", ConditionOperator.Equal, asyncoperationid);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting jobs",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error, "Load Bulk Data Deleting Jobs");
                    }
                    if (args.Result is EntityCollection result)
                    {
                        xrmDataGridViewShowJobs.DataSource = result;
                    }
                }
            });
        }

        

        private XmlDocument ParseFetchXml(string bulkdatafield)
        {
            const string xpathfetch = "/BulkDeleteData/QuerySet/string";
            XmlDocument docdata = new XmlDocument();
            docdata.LoadXml(bulkdatafield);
            string escFetchXml = docdata.SelectSingleNode(xpathfetch).InnerText;


            string fetchxml = Regex.Unescape(escFetchXml);
            XmlDocument docout = new XmlDocument();
            docout.LoadXml(fetchxml);
            return docout;
        }

        private string GetEntityName(string fetchxml)
        {
            var docout = new XmlDocument();
            docout.LoadXml(fetchxml);
            var node = docout.SelectSingleNode("fetch/entity");
            if (node != null && node.Attributes != null && node.Attributes["name"] != null)
            {
                return node.Attributes["name"].Value;
            }
            return null;
        }

        private void SetFetchXML(string fetchxml)
        {
            txtFetchXML.Text = fetchxml;
            txtFetchXML.FormatXML();
            var entityname = GetEntityName(fetchxml);
            xrmEntity.SetSelected(entityname);
        }

        private void CreateBulkDelete()
        {
            PopulateDetails(null);
        }

        private void PopulateDetails(Entity entity)
        {
            //Left to add: primaryentitytype, ownerid, recurrencestarttime

            xrmRecordHost1.Record = entity;

            if (xrmRecordHost1.Record == null)
            {
                xrmEntity.Enabled = true;
                xrmEntity.SelectedIndex = -1;
                txtFetchXML.Text = null;
                cmbRecurrancePattern.SelectedItem = cmbRecurrancePattern.Items[2];
                numInterval.Value = 0;
                startDateTimePicker.Value = DateTime.Now;
                xrmCTRecurrenceStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
                btCancel.Visible = false;
            }
            else
            {
                getAndSetAsyncOperationsJobs(entity.Id);
                xrmEntity.Enabled = false;
                SetFetchXML(ParseFetchXml(xrmRecordHost1.Record["data"].ToString()).InnerXml);

                string recurrancePattern = (String)xrmRecordHost1.Record["recurrencepattern"];

                var recurr = new Recurrency(recurrancePattern);
                cmbRecurrancePattern.SelectedItem = recurr.Frequence;
                numInterval.Value = recurr.Interval;
                if (xrmRecordHost1.Record.TryGetAttributeValue("recurrencestarttime", out DateTime starttime))
                {
                    startDateTimePicker.Value = starttime;
                }

                int statuscode = ((Microsoft.Xrm.Sdk.OptionSetValue)xrmRecordHost1.Record["statuscode"]).Value;
                btCancel.Visible = true;
                if (statuscode == 0 || statuscode == 10 || statuscode == 20 || statuscode == 21)
                {
                    btCancel.Enabled = true;
                }
                else
                {
                    btCancel.Enabled = false;
                }

                if (statuscode == 32)
                {
                    btDelete.Enabled = true;
                }
                else
                {
                    btDelete.Enabled = false;
                }
            }
        }

        private void PopulateTemplateFetch(EntityMetadata selectedEntity)
        {
            if (selectedEntity == null)
            {
                return;
            }
            var fetch = string.Format(FetchTemplate, selectedEntity.LogicalName, selectedEntity.PrimaryIdAttribute);
            SetFetchXML(fetch);
        }

        private void SaveNew()
        {
            if (xrmRecordHost1.Id != null && !xrmRecordHost1.Id.Equals(Guid.Empty))
            {
                MessageBox.Show("You have not selected create new Bulk Delete job.", "Save new", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bulkDeleteRequest = new BulkDeleteRequest();
            bulkDeleteRequest.JobName = xrmColumnName.Text;

            bulkDeleteRequest.StartDateTime = startDateTimePicker.Value;
            bulkDeleteRequest.RecurrencePattern = Recurrency.ToString("DAILY", (int)numInterval.Value); //has to be DAILY for bulk delete.

            //Set email activity properties.
            //Required
            bulkDeleteRequest.ToRecipients = new Guid[] { };
            bulkDeleteRequest.SendEmailNotification = false;
            bulkDeleteRequest.CCRecipients = new Guid[] { };

            // Make the save async
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Saving...",
                AsyncArgument = new { request = bulkDeleteRequest, fetch = txtFetchXML.Text },
                Work = (worker, args) =>
                {
                    var dynamicargs = args.Argument as dynamic;
                    var fetchxml = dynamicargs.fetch as string;
                    var request = dynamicargs.request as BulkDeleteRequest;

                    var query = (FetchXmlToQueryExpressionResponse)Service.Execute(new FetchXmlToQueryExpressionRequest { FetchXml = fetchxml });
                    request.QuerySet = new QueryExpression[] { query.Query };

                    //Add handling for: Incorrect priviliges (prvBulkDelete missing)
                    // Principal user (Id=c966c897-49a7-e711-80e5-3863bb35ff88, type=8, roleCount=2, privilegeCount=1255, accessMode=4), is missing prvBulkDelete privilege (Id=b75a726f-e7aa-44ae-9282-f8776d913bbb) on OTC=0 for entity '' (LocalizedName=''). context.Caller=c966c897-49a7-e711-80e5-3863bb35ff88
                    //Delete privilige is needed on entity aswell
                    args.Result = Service.Execute(request);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error, "Save Error");
                    }
                    else if (args.Result is BulkDeleteResponse response)
                    {
                        MessageBox.Show("The Bulk Delete Job has been created", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetBulkDeleteJobs();
                    }
                }
            });
        }

        private void CountCurrently(string fetchxml)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Counting results...",
                AsyncArgument = fetchxml,
                Work = (worker, args) =>
                {
                    var fetch = args.Argument as string;
                    args.Result = Service.RetrieveMultiple(new FetchExpression(fetch)); //Need to handle missing privilige exception
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        ShowErrorDialog(args.Error);
                    }
                    else if (args.Result is EntityCollection result)
                    {
                        MessageBox.Show($"Currently {result.Entities.Count} hits.");
                    }
                }
            });
        }

        private void CancelJob()
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to cancel this job?", "Please confirm", MessageBoxButtons.OKCancel);
            Guid asyncoopertionid = xrmRecordHost1.Id;
            if (((int)dr) == 1)
            {
                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Cancelling job...",
                    AsyncArgument = asyncoopertionid,
                    Work = (worker, args) =>
                    {
                        var entityRef = new Entity("asyncoperation", xrmRecordHost1.Id);
                        entityRef["statuscode"] = new OptionSetValue(32);
                        entityRef["statecode"] = new OptionSetValue(3);
                        try
                        {
                            Service.Update(entityRef);
                            args.Result = "OK";
                        }
                        catch (Exception e)
                        {
                            args.Result = e;
                        }
                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Result is Exception e)
                        {
                            ShowErrorDialog(e);
                        }
                        else if (args.Result is String s)
                        {
                            MessageBox.Show("Job canceled");
                        }
                        GetBulkDeleteJobs();
                    }
                });
            }
            else
            {
                //Nothing
            }
        }

        private void DeleteJob()
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this job?\nPlease note that not all Bulk Delete Records can be removed.", "Please confirm", MessageBoxButtons.OKCancel);
            Guid asyncoopertionid = xrmRecordHost1.Id;
            if (((int)dr) == 1)
            {
                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Deleting job...",
                    AsyncArgument = asyncoopertionid,
                    Work = (worker, args) =>
                    {
                        try
                        {
                            Service.Delete("asyncoperation", xrmRecordHost1.Id);
                            args.Result = "OK";
                        }
                        catch (Exception e)
                        {
                            args.Result = e;
                        }
                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Result is Exception e)
                        {
                            ShowErrorDialog(e);
                        }
                        else if (args.Result is String s)
                        {
                            MessageBox.Show("Job deleted");
                        }
                        GetBulkDeleteJobs();
                    }
                });
            }
            else
            {
                //Nothing
            }
        }
        private void ReloadJobs()
        {
            GetBulkDeleteJobs();
        }

    }
}
