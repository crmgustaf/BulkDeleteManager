
namespace BulkDeleteManager
{
    partial class BDM
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbReloadJobs = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.xrmBulkDeleteNames = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrmDataGridViewShowJobs = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.failurecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.successcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.stateCodeLabel = new System.Windows.Forms.Label();
            this.stateCodeOptionSet = new Rappen.XTB.Helpers.Controls.XRMColumnOptionSet();
            this.xrmRecordHost1 = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.btnCountResult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.xrmEntity = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.startTimeDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statuscodeLabel = new System.Windows.Forms.Label();
            this.statusCodeOptionSet = new Rappen.XTB.Helpers.Controls.XRMColumnOptionSet();
            this.txtFetchXML = new ScintillaNET.Scintilla();
            this.xrmRecurrencyPattern = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.label2 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.cmbRecurrancePattern = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveNewButton = new System.Windows.Forms.Button();
            this.xrmCTRecurrenceStart = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnextrun = new System.Windows.Forms.Label();
            this.xrmColumnNextRun = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.labelfetchxml = new System.Windows.Forms.Label();
            this.labelbulkdelete = new System.Windows.Forms.Label();
            this.ChangeQuery = new System.Windows.Forms.Button();
            this.xrmColumnName = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrmBulkDeleteNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrmDataGridViewShowJobs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbReloadJobs});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(983, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(153, 22);
            this.toolStripButton1.Text = "Create new Bulk Delete Job";
            this.toolStripButton1.Click += new System.EventHandler(this.tsbCreateBulkDeleteJobs_Click);
            // 
            // tsbReloadJobs
            // 
            this.tsbReloadJobs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReloadJobs.Enabled = false;
            this.tsbReloadJobs.Name = "tsbReloadJobs";
            this.tsbReloadJobs.Size = new System.Drawing.Size(146, 22);
            this.tsbReloadJobs.Text = "(Re)Load Bulk Delete Jobs";
            this.tsbReloadJobs.Click += new System.EventHandler(this.tsbReloadJobs_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(983, 611);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btDelete);
            this.splitContainer2.Panel2.Controls.Add(this.btCancel);
            this.splitContainer2.Panel2.Controls.Add(this.stateCodeLabel);
            this.splitContainer2.Panel2.Controls.Add(this.stateCodeOptionSet);
            this.splitContainer2.Panel2.Controls.Add(this.btnCountResult);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.xrmEntity);
            this.splitContainer2.Panel2.Controls.Add(this.startTimeDateLabel);
            this.splitContainer2.Panel2.Controls.Add(this.startDateTimePicker);
            this.splitContainer2.Panel2.Controls.Add(this.statuscodeLabel);
            this.splitContainer2.Panel2.Controls.Add(this.statusCodeOptionSet);
            this.splitContainer2.Panel2.Controls.Add(this.txtFetchXML);
            this.splitContainer2.Panel2.Controls.Add(this.xrmRecurrencyPattern);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.numInterval);
            this.splitContainer2.Panel2.Controls.Add(this.cmbRecurrancePattern);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.SaveNewButton);
            this.splitContainer2.Panel2.Controls.Add(this.xrmCTRecurrenceStart);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.labelnextrun);
            this.splitContainer2.Panel2.Controls.Add(this.xrmColumnNextRun);
            this.splitContainer2.Panel2.Controls.Add(this.labelfetchxml);
            this.splitContainer2.Panel2.Controls.Add(this.labelbulkdelete);
            this.splitContainer2.Panel2.Controls.Add(this.ChangeQuery);
            this.splitContainer2.Panel2.Controls.Add(this.xrmColumnName);
            this.splitContainer2.Size = new System.Drawing.Size(983, 611);
            this.splitContainer2.SplitterDistance = 282;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 35);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.xrmBulkDeleteNames);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.xrmDataGridViewShowJobs);
            this.splitContainer3.Size = new System.Drawing.Size(282, 576);
            this.splitContainer3.SplitterDistance = 414;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 2;
            // 
            // xrmBulkDeleteNames
            // 
            this.xrmBulkDeleteNames.AllowUserToAddRows = false;
            this.xrmBulkDeleteNames.AllowUserToDeleteRows = false;
            this.xrmBulkDeleteNames.AllowUserToOrderColumns = true;
            this.xrmBulkDeleteNames.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xrmBulkDeleteNames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.xrmBulkDeleteNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xrmBulkDeleteNames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.xrmBulkDeleteNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xrmBulkDeleteNames.ColumnHeadersVisible = false;
            this.xrmBulkDeleteNames.ColumnOrder = "";
            this.xrmBulkDeleteNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.xrmBulkDeleteNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrmBulkDeleteNames.FilterColumns = "";
            this.xrmBulkDeleteNames.Location = new System.Drawing.Point(0, 0);
            this.xrmBulkDeleteNames.Margin = new System.Windows.Forms.Padding(2);
            this.xrmBulkDeleteNames.Name = "xrmBulkDeleteNames";
            this.xrmBulkDeleteNames.ReadOnly = true;
            this.xrmBulkDeleteNames.RowHeadersVisible = false;
            this.xrmBulkDeleteNames.RowHeadersWidth = 51;
            this.xrmBulkDeleteNames.RowTemplate.Height = 24;
            this.xrmBulkDeleteNames.Service = null;
            this.xrmBulkDeleteNames.Size = new System.Drawing.Size(282, 414);
            this.xrmBulkDeleteNames.TabIndex = 0;
            this.xrmBulkDeleteNames.RecordEnter += new Rappen.XTB.Helpers.Controls.XRMRecordEventHandler(this.xrmBulkDeleteNames_RecordEnter);
            // 
            // name
            // 
            this.name.HeaderText = "Bulk Delete Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 6;
            // 
            // xrmDataGridViewShowJobs
            // 
            this.xrmDataGridViewShowJobs.AllowUserToAddRows = false;
            this.xrmDataGridViewShowJobs.AllowUserToDeleteRows = false;
            this.xrmDataGridViewShowJobs.AllowUserToOrderColumns = true;
            this.xrmDataGridViewShowJobs.AllowUserToResizeColumns = false;
            this.xrmDataGridViewShowJobs.AllowUserToResizeRows = false;
            this.xrmDataGridViewShowJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xrmDataGridViewShowJobs.ColumnOrder = "";
            this.xrmDataGridViewShowJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.failurecount,
            this.successcount});
            this.xrmDataGridViewShowJobs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xrmDataGridViewShowJobs.FilterColumns = "";
            this.xrmDataGridViewShowJobs.Location = new System.Drawing.Point(0, 2);
            this.xrmDataGridViewShowJobs.Margin = new System.Windows.Forms.Padding(2);
            this.xrmDataGridViewShowJobs.Name = "xrmDataGridViewShowJobs";
            this.xrmDataGridViewShowJobs.ReadOnly = true;
            this.xrmDataGridViewShowJobs.RowHeadersWidth = 51;
            this.xrmDataGridViewShowJobs.RowTemplate.Height = 24;
            this.xrmDataGridViewShowJobs.Service = null;
            this.xrmDataGridViewShowJobs.Size = new System.Drawing.Size(282, 154);
            this.xrmDataGridViewShowJobs.TabIndex = 0;
            // 
            // failurecount
            // 
            this.failurecount.HeaderText = "failurecount";
            this.failurecount.MinimumWidth = 6;
            this.failurecount.Name = "failurecount";
            this.failurecount.ReadOnly = true;
            this.failurecount.Width = 125;
            // 
            // successcount
            // 
            this.successcount.HeaderText = "successcount";
            this.successcount.MinimumWidth = 6;
            this.successcount.Name = "successcount";
            this.successcount.ReadOnly = true;
            this.successcount.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 35);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bulk Deletes";
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(572, 499);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 27);
            this.btDelete.TabIndex = 56;
            this.btDelete.Text = "Delete Job";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Enabled = false;
            this.btCancel.Location = new System.Drawing.Point(572, 532);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(88, 27);
            this.btCancel.TabIndex = 55;
            this.btCancel.Text = "Cancel Job";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // stateCodeLabel
            // 
            this.stateCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stateCodeLabel.AutoSize = true;
            this.stateCodeLabel.Location = new System.Drawing.Point(384, 471);
            this.stateCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateCodeLabel.Name = "stateCodeLabel";
            this.stateCodeLabel.Size = new System.Drawing.Size(59, 13);
            this.stateCodeLabel.TabIndex = 54;
            this.stateCodeLabel.Text = "Statecode:";
            // 
            // stateCodeOptionSet
            // 
            this.stateCodeOptionSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stateCodeOptionSet.Column = "statecode";
            this.stateCodeOptionSet.Enabled = false;
            this.stateCodeOptionSet.FormattingEnabled = true;
            this.stateCodeOptionSet.Location = new System.Drawing.Point(385, 486);
            this.stateCodeOptionSet.Margin = new System.Windows.Forms.Padding(2);
            this.stateCodeOptionSet.Name = "stateCodeOptionSet";
            this.stateCodeOptionSet.RecordHost = this.xrmRecordHost1;
            this.stateCodeOptionSet.Size = new System.Drawing.Size(92, 21);
            this.stateCodeOptionSet.TabIndex = 53;
            // 
            // xrmRecordHost1
            // 
            this.xrmRecordHost1.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmRecordHost1.LogicalName = null;
            this.xrmRecordHost1.Record = null;
            this.xrmRecordHost1.Service = null;
            // 
            // btnCountResult
            // 
            this.btnCountResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountResult.Enabled = false;
            this.btnCountResult.Location = new System.Drawing.Point(494, 396);
            this.btnCountResult.Name = "btnCountResult";
            this.btnCountResult.Size = new System.Drawing.Size(167, 33);
            this.btnCountResult.TabIndex = 52;
            this.btnCountResult.Text = "Count Records...";
            this.btnCountResult.UseVisualStyleBackColor = true;
            this.btnCountResult.Click += new System.EventHandler(this.btnCountResult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Table (Entity)";
            // 
            // xrmEntity
            // 
            this.xrmEntity.FormattingEnabled = true;
            this.xrmEntity.Location = new System.Drawing.Point(13, 66);
            this.xrmEntity.Name = "xrmEntity";
            this.xrmEntity.Size = new System.Drawing.Size(250, 21);
            this.xrmEntity.TabIndex = 50;
            this.xrmEntity.SelectedIndexChanged += new System.EventHandler(this.xrmEntity_SelectedIndexChanged);
            // 
            // startTimeDateLabel
            // 
            this.startTimeDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startTimeDateLabel.AutoSize = true;
            this.startTimeDateLabel.Location = new System.Drawing.Point(286, 517);
            this.startTimeDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeDateLabel.Name = "startTimeDateLabel";
            this.startTimeDateLabel.Size = new System.Drawing.Size(84, 13);
            this.startTimeDateLabel.TabIndex = 49;
            this.startTimeDateLabel.Text = "Start Time Date:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(289, 535);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.startDateTimePicker.TabIndex = 48;
            // 
            // statuscodeLabel
            // 
            this.statuscodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statuscodeLabel.AutoSize = true;
            this.statuscodeLabel.Location = new System.Drawing.Point(286, 470);
            this.statuscodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statuscodeLabel.Name = "statuscodeLabel";
            this.statuscodeLabel.Size = new System.Drawing.Size(64, 13);
            this.statuscodeLabel.TabIndex = 47;
            this.statuscodeLabel.Text = "Statuscode:";
            // 
            // statusCodeOptionSet
            // 
            this.statusCodeOptionSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusCodeOptionSet.Column = "statuscode";
            this.statusCodeOptionSet.Enabled = false;
            this.statusCodeOptionSet.FormattingEnabled = true;
            this.statusCodeOptionSet.Location = new System.Drawing.Point(289, 486);
            this.statusCodeOptionSet.Margin = new System.Windows.Forms.Padding(2);
            this.statusCodeOptionSet.Name = "statusCodeOptionSet";
            this.statusCodeOptionSet.RecordHost = this.xrmRecordHost1;
            this.statusCodeOptionSet.Size = new System.Drawing.Size(92, 21);
            this.statusCodeOptionSet.TabIndex = 46;
            // 
            // txtFetchXML
            // 
            this.txtFetchXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFetchXML.Location = new System.Drawing.Point(13, 108);
            this.txtFetchXML.Name = "txtFetchXML";
            this.txtFetchXML.Size = new System.Drawing.Size(647, 281);
            this.txtFetchXML.TabIndex = 45;
            // 
            // xrmRecurrencyPattern
            // 
            this.xrmRecurrencyPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xrmRecurrencyPattern.Column = "recurrencepattern";
            this.xrmRecurrencyPattern.DisplayFormat = "";
            this.xrmRecurrencyPattern.Location = new System.Drawing.Point(13, 487);
            this.xrmRecurrencyPattern.Margin = new System.Windows.Forms.Padding(2);
            this.xrmRecurrencyPattern.Name = "xrmRecurrencyPattern";
            this.xrmRecurrencyPattern.ReadOnly = true;
            this.xrmRecurrencyPattern.RecordHost = this.xrmRecordHost1;
            this.xrmRecurrencyPattern.Size = new System.Drawing.Size(250, 20);
            this.xrmRecurrencyPattern.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Interval";
            // 
            // numInterval
            // 
            this.numInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numInterval.Location = new System.Drawing.Point(139, 463);
            this.numInterval.Margin = new System.Windows.Forms.Padding(2);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(80, 20);
            this.numInterval.TabIndex = 42;
            this.numInterval.ValueChanged += new System.EventHandler(this.cmbRecurrancePattern_SelectedIndexChanged);
            // 
            // cmbRecurrancePattern
            // 
            this.cmbRecurrancePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbRecurrancePattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecurrancePattern.Enabled = false;
            this.cmbRecurrancePattern.FormattingEnabled = true;
            this.cmbRecurrancePattern.Items.AddRange(new object[] {
            "MONTHLY",
            "WEEKLY",
            "DAILY",
            "HOURLY",
            "-none-"});
            this.cmbRecurrancePattern.Location = new System.Drawing.Point(13, 463);
            this.cmbRecurrancePattern.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRecurrancePattern.Name = "cmbRecurrancePattern";
            this.cmbRecurrancePattern.Size = new System.Drawing.Size(92, 21);
            this.cmbRecurrancePattern.TabIndex = 41;
            this.cmbRecurrancePattern.SelectedIndexChanged += new System.EventHandler(this.cmbRecurrancePattern_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(6, 6);
            this.button2.TabIndex = 40;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SaveNewButton
            // 
            this.SaveNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveNewButton.Enabled = false;
            this.SaveNewButton.Location = new System.Drawing.Point(572, 571);
            this.SaveNewButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveNewButton.Name = "SaveNewButton";
            this.SaveNewButton.Size = new System.Drawing.Size(89, 26);
            this.SaveNewButton.TabIndex = 39;
            this.SaveNewButton.Text = "Save";
            this.SaveNewButton.UseVisualStyleBackColor = true;
            this.SaveNewButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // xrmCTRecurrenceStart
            // 
            this.xrmCTRecurrenceStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xrmCTRecurrenceStart.Column = "recurrencestarttime";
            this.xrmCTRecurrenceStart.DisplayFormat = "";
            this.xrmCTRecurrenceStart.Location = new System.Drawing.Point(13, 532);
            this.xrmCTRecurrenceStart.Margin = new System.Windows.Forms.Padding(2);
            this.xrmCTRecurrenceStart.Name = "xrmCTRecurrenceStart";
            this.xrmCTRecurrenceStart.RecordHost = this.xrmRecordHost1;
            this.xrmCTRecurrenceStart.Size = new System.Drawing.Size(250, 20);
            this.xrmCTRecurrenceStart.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 517);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Recurrence start:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Recurrency pattern:";
            // 
            // labelnextrun
            // 
            this.labelnextrun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelnextrun.AutoSize = true;
            this.labelnextrun.Location = new System.Drawing.Point(10, 555);
            this.labelnextrun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnextrun.Name = "labelnextrun";
            this.labelnextrun.Size = new System.Drawing.Size(55, 13);
            this.labelnextrun.TabIndex = 8;
            this.labelnextrun.Text = "Next Run:";
            // 
            // xrmColumnNextRun
            // 
            this.xrmColumnNextRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xrmColumnNextRun.Column = "postponeuntil";
            this.xrmColumnNextRun.DisplayFormat = "";
            this.xrmColumnNextRun.Location = new System.Drawing.Point(13, 571);
            this.xrmColumnNextRun.Margin = new System.Windows.Forms.Padding(2);
            this.xrmColumnNextRun.Name = "xrmColumnNextRun";
            this.xrmColumnNextRun.ReadOnly = true;
            this.xrmColumnNextRun.RecordHost = this.xrmRecordHost1;
            this.xrmColumnNextRun.Size = new System.Drawing.Size(250, 20);
            this.xrmColumnNextRun.TabIndex = 6;
            // 
            // labelfetchxml
            // 
            this.labelfetchxml.AutoSize = true;
            this.labelfetchxml.Location = new System.Drawing.Point(11, 92);
            this.labelfetchxml.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfetchxml.Name = "labelfetchxml";
            this.labelfetchxml.Size = new System.Drawing.Size(56, 13);
            this.labelfetchxml.TabIndex = 4;
            this.labelfetchxml.Text = "FetchXML";
            // 
            // labelbulkdelete
            // 
            this.labelbulkdelete.AutoSize = true;
            this.labelbulkdelete.Location = new System.Drawing.Point(10, 11);
            this.labelbulkdelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelbulkdelete.Name = "labelbulkdelete";
            this.labelbulkdelete.Size = new System.Drawing.Size(35, 13);
            this.labelbulkdelete.TabIndex = 3;
            this.labelbulkdelete.Text = "Name";
            // 
            // ChangeQuery
            // 
            this.ChangeQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeQuery.Enabled = false;
            this.ChangeQuery.Image = global::BulkDeleteManager.Properties.Resources.FXB_24;
            this.ChangeQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeQuery.Location = new System.Drawing.Point(13, 396);
            this.ChangeQuery.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeQuery.Name = "ChangeQuery";
            this.ChangeQuery.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ChangeQuery.Size = new System.Drawing.Size(184, 33);
            this.ChangeQuery.TabIndex = 30;
            this.ChangeQuery.Text = "Change FetchXML";
            this.ChangeQuery.UseVisualStyleBackColor = true;
            this.ChangeQuery.Click += new System.EventHandler(this.ChangeQuery_Click);
            // 
            // xrmColumnName
            // 
            this.xrmColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xrmColumnName.Column = "name";
            this.xrmColumnName.DisplayFormat = "";
            this.xrmColumnName.Location = new System.Drawing.Point(14, 24);
            this.xrmColumnName.Margin = new System.Windows.Forms.Padding(2);
            this.xrmColumnName.Name = "xrmColumnName";
            this.xrmColumnName.RecordHost = this.xrmRecordHost1;
            this.xrmColumnName.Size = new System.Drawing.Size(646, 20);
            this.xrmColumnName.TabIndex = 10;
            // 
            // BDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "BDM";
            this.Size = new System.Drawing.Size(983, 636);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.BDM_ConnectionUpdated);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xrmBulkDeleteNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrmDataGridViewShowJobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Rappen.XTB.Helpers.Controls.XRMDataGridView xrmBulkDeleteNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmColumnName;
        private Rappen.XTB.Helpers.Controls.XRMRecordHost xrmRecordHost1;
        private System.Windows.Forms.Button ChangeQuery;
        private System.Windows.Forms.Label labelfetchxml;
        private System.Windows.Forms.Label labelbulkdelete;
        private System.Windows.Forms.Label labelnextrun;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmColumnNextRun;
        private System.Windows.Forms.Label label1;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmCTRecurrenceStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SaveNewButton;
        private System.Windows.Forms.ComboBox cmbRecurrancePattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numInterval;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmRecurrencyPattern;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private ScintillaNET.Scintilla txtFetchXML;
        private Rappen.XTB.Helpers.Controls.XRMColumnOptionSet statusCodeOptionSet;
        private System.Windows.Forms.Label statuscodeLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startTimeDateLabel;
        private System.Windows.Forms.Label label5;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox xrmEntity;
        private System.Windows.Forms.Button btnCountResult;
        private Rappen.XTB.Helpers.Controls.XRMColumnOptionSet stateCodeOptionSet;
        private System.Windows.Forms.Label stateCodeLabel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Rappen.XTB.Helpers.Controls.XRMDataGridView xrmDataGridViewShowJobs;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn failurecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn successcount;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ToolStripButton tsbReloadJobs;
    }
}
