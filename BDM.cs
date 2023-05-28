using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace BulkDeleteManager
{
    public partial class BDM : PluginControlBase, IMessageBusHost, IGitHubPlugin
    {
        private Settings mySettings;

        public string RepositoryName => "BulkDeleteManager";

        public string UserName => "crmgustaf";

        public event EventHandler<MessageBusEventArgs> OnOutgoingMessage;

        public BDM()
        {
            InitializeComponent();
            txtFetchXML.ConfigureForXml();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void tsbCreateBulkDeleteJobs_Click(object sender, EventArgs e)
        {
            ExecuteMethod(CreateBulkDelete);
        }

        private void BDM_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            Enabled = false;
            xrmBulkDeleteNames.DataSource = null;
            xrmRecordHost1.Record = null;

            xrmBulkDeleteNames.Service = e.Service;
            xrmRecordHost1.Service = e.Service;

            ExecuteMethod(LoadMetadata);
        }

        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            if (message.SourcePlugin == "FetchXML Builder" &&
                     message.TargetArgument is string fetchxml &&
                     !string.IsNullOrWhiteSpace(fetchxml))
            {
                SetFetchXML(fetchxml);
            }
        }

        private void ChangeQuery_Click(object sender, EventArgs e)
        {
            OnOutgoingMessage(this, new MessageBusEventArgs("FetchXML Builder")
            {
                TargetArgument = txtFetchXML.Text
            });
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveNew();
        }

        private void cmbRecurrancePattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            xrmRecurrencyPattern.Text = Recurrency.ToString(cmbRecurrancePattern.Text, (int)numInterval.Value);
        }

        private void xrmBulkDeleteNames_RecordEnter(object sender, Rappen.XTB.Helpers.Controls.XRMRecordEventArgs e)
        {
            PopulateDetails(e.Entity);
        }

        private void xrmEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (xrmEntity.Enabled && xrmEntity.SelectedEntity != null)
            {
                PopulateTemplateFetch(xrmEntity.SelectedEntity);
            }
        }

        private void btnCountResult_Click(object sender, EventArgs e)
        {
            CountCurrently(txtFetchXML.Text);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ExecuteMethod(CancelJob);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            ExecuteMethod(DeleteJob);
        }

        private void tsbReloadJobs_Click(object sender, EventArgs e)
        {
            ExecuteMethod(ReloadJobs);
        }
    }
}