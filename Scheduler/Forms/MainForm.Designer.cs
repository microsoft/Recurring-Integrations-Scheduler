using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.connectToServerButton = new System.Windows.Forms.ToolStripButton();
            this.privateSchedulerButton = new System.Windows.Forms.ToolStripButton();
            this.saveScheduleButton = new System.Windows.Forms.ToolStripButton();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.jobsDataGridView = new System.Windows.Forms.DataGridView();
            this.Instance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextFireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreviousFireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeJobToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openInputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSuccessfulUploadsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFailedUploadsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSuccessfulProcessingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFailedProcessingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSuccessfulDownloadsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStrip = new System.Windows.Forms.ToolStrip();
            this.instanceFilter = new System.Windows.Forms.ToolStripTextBox();
            this.jobNameFilter = new System.Windows.Forms.ToolStripTextBox();
            this.addJobsDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.addUploadJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDownloadJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImportJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExportJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJobButton = new System.Windows.Forms.ToolStripButton();
            this.editJobButton = new System.Windows.Forms.ToolStripButton();
            this.pauseResumeDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.pauseJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseAllJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeAllJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mainMenuToolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.jobsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuToolStrip
            // 
            this.mainMenuToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToServerButton,
            this.privateSchedulerButton,
            this.saveScheduleButton,
            this.settingsButton,
            this.aboutButton});
            this.mainMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuToolStrip.Name = "mainMenuToolStrip";
            this.mainMenuToolStrip.Size = new System.Drawing.Size(1132, 32);
            this.mainMenuToolStrip.TabIndex = 0;
            this.mainMenuToolStrip.Text = "";
            // 
            // connectToServerButton
            // 
            this.connectToServerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectToServerButton.Image = ((System.Drawing.Image)(resources.GetObject("connectToServerButton.Image")));
            this.connectToServerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectToServerButton.Name = "connectToServerButton";
            this.connectToServerButton.Size = new System.Drawing.Size(161, 29);
            this.connectToServerButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Connect_to_service;
            this.connectToServerButton.Click += new System.EventHandler(this.ConnectToServerButton_Click);
            // 
            // privateSchedulerButton
            // 
            this.privateSchedulerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.privateSchedulerButton.Image = ((System.Drawing.Image)(resources.GetObject("privateSchedulerButton.Image")));
            this.privateSchedulerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.privateSchedulerButton.Name = "privateSchedulerButton";
            this.privateSchedulerButton.Size = new System.Drawing.Size(224, 29);
            this.privateSchedulerButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Start_standalone_scheduler;
            this.privateSchedulerButton.Click += new System.EventHandler(this.PrivateSchedulerButton_Click);
            // 
            // saveScheduleButton
            // 
            this.saveScheduleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveScheduleButton.Enabled = false;
            this.saveScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveScheduleButton.Image")));
            this.saveScheduleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveScheduleButton.Name = "saveScheduleButton";
            this.saveScheduleButton.Size = new System.Drawing.Size(155, 29);
            this.saveScheduleButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Save_schedule_file;
            this.saveScheduleButton.Click += new System.EventHandler(this.SaveScheduleButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(103, 29);
            this.settingsButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Parameters;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(66, 29);
            this.aboutButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.A_bout;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnectionStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 474);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1132, 30);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripConnectionStatus
            // 
            this.toolStripConnectionStatus.Name = "toolStripConnectionStatus";
            this.toolStripConnectionStatus.Size = new System.Drawing.Size(129, 25);
            this.toolStripConnectionStatus.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Not_connected;
            // 
            // jobsDataGridView
            // 
            this.jobsDataGridView.AllowUserToAddRows = false;
            this.jobsDataGridView.AllowUserToDeleteRows = false;
            this.jobsDataGridView.AllowUserToOrderColumns = true;
            this.jobsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.jobsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jobsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instance,
            this.JobName,
            this.JobGroup,
            this.JobDescription,
            this.JobType,
            this.NextFireTime,
            this.PreviousFireTime,
            this.Status});
            this.jobsDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.jobsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.jobsDataGridView.Location = new System.Drawing.Point(0, 32);
            this.jobsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobsDataGridView.MultiSelect = false;
            this.jobsDataGridView.Name = "jobsDataGridView";
            this.jobsDataGridView.ReadOnly = true;
            this.jobsDataGridView.RowHeadersVisible = false;
            this.jobsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.jobsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobsDataGridView.Size = new System.Drawing.Size(1132, 410);
            this.jobsDataGridView.TabIndex = 3;
            this.jobsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobsDataGridView_CellContentDoubleClick);
            this.jobsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.JobsDataGridView_CellFormatting);
            this.jobsDataGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.JobsDataGridView_RowStateChanged);
            this.jobsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JobsDataGridView_MouseDown);
            // 
            // Instance
            // 
            this.Instance.DataPropertyName = "Instance";
            this.Instance.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Instance;
            this.Instance.Name = "Instance";
            this.Instance.ReadOnly = true;
            // 
            // JobName
            // 
            this.JobName.DataPropertyName = "JobName";
            this.JobName.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Job_name;
            this.JobName.Name = "JobName";
            this.JobName.ReadOnly = true;
            // 
            // JobGroup
            // 
            this.JobGroup.DataPropertyName = "JobGroup";
            this.JobGroup.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Job_group;
            this.JobGroup.Name = "JobGroup";
            this.JobGroup.ReadOnly = true;
            // 
            // JobDescription
            // 
            this.JobDescription.DataPropertyName = "JobDescription";
            this.JobDescription.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Description;
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.ReadOnly = true;
            // 
            // JobType
            // 
            this.JobType.DataPropertyName = "JobType";
            this.JobType.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Job_type;
            this.JobType.Name = "JobType";
            this.JobType.ReadOnly = true;
            // 
            // NextFireTime
            // 
            this.NextFireTime.DataPropertyName = "NextFireTime";
            this.NextFireTime.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Next_run;
            this.NextFireTime.Name = "NextFireTime";
            this.NextFireTime.ReadOnly = true;
            // 
            // PreviousFireTime
            // 
            this.PreviousFireTime.DataPropertyName = "PreviousFireTime";
            this.PreviousFireTime.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Last_run;
            this.PreviousFireTime.Name = "PreviousFireTime";
            this.PreviousFireTime.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "JobStatus";
            this.Status.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Trigger_status;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editJobMenuItem,
            this.pauseJobMenuItem,
            this.resumeJobToolStripMenuItem1,
            this.deletJobMenuItem,
            this.toolStripSeparator1,
            this.openInputFolderToolStripMenuItem,
            this.openSuccessfulUploadsFolderToolStripMenuItem,
            this.openFailedUploadsFolderToolStripMenuItem,
            this.openSuccessfulProcessingFolderToolStripMenuItem,
            this.openFailedProcessingFolderToolStripMenuItem,
            this.openSuccessfulDownloadsFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(358, 310);
            // 
            // editJobMenuItem
            // 
            this.editJobMenuItem.Name = "editJobMenuItem";
            this.editJobMenuItem.Size = new System.Drawing.Size(357, 30);
            this.editJobMenuItem.Text = Resources.Edit_job;
            this.editJobMenuItem.Click += new System.EventHandler(this.EditJobButton_Click);
            // 
            // pauseJobMenuItem
            // 
            this.pauseJobMenuItem.Name = "pauseJobMenuItem";
            this.pauseJobMenuItem.Size = new System.Drawing.Size(357, 30);
            this.pauseJobMenuItem.Text = Resources.Pause_job;
            this.pauseJobMenuItem.Click += new System.EventHandler(this.PauseJobButton_Click);
            // 
            // resumeJobToolStripMenuItem1
            // 
            this.resumeJobToolStripMenuItem1.Name = "resumeJobToolStripMenuItem1";
            this.resumeJobToolStripMenuItem1.Size = new System.Drawing.Size(357, 30);
            this.resumeJobToolStripMenuItem1.Text = Resources.Resume_job;
            this.resumeJobToolStripMenuItem1.Click += new System.EventHandler(this.ResumeJobButton_Click);
            // 
            // deletJobMenuItem
            // 
            this.deletJobMenuItem.Name = "deletJobMenuItem";
            this.deletJobMenuItem.Size = new System.Drawing.Size(357, 30);
            this.deletJobMenuItem.Text = Resources.Delete_job;
            this.deletJobMenuItem.Click += new System.EventHandler(this.DeleteJobButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(354, 6);
            // 
            // openInputFolderToolStripMenuItem
            // 
            this.openInputFolderToolStripMenuItem.Name = "openInputFolderToolStripMenuItem";
            this.openInputFolderToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.openInputFolderToolStripMenuItem.Text = Resources.Open_input_folder;
            this.openInputFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenInputFolderToolStripMenuItem_Click);
            // 
            // openSuccessfulUploadsFolderToolStripMenuItem
            // 
            this.openSuccessfulUploadsFolderToolStripMenuItem.Name = "openSuccessfulUploadsFolderToolStripMenuItem";
            this.openSuccessfulUploadsFolderToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.openSuccessfulUploadsFolderToolStripMenuItem.Text = Resources.Open_successful_uploads_folder;
            this.openSuccessfulUploadsFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenSuccessfulUploadsFolderToolStripMenuItem_Click);
            // 
            // openFailedUploadsFolderToolStripMenuItem
            // 
            this.openFailedUploadsFolderToolStripMenuItem.Name = "openFailedUploadsFolderToolStripMenuItem";
            this.openFailedUploadsFolderToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.openFailedUploadsFolderToolStripMenuItem.Text = Resources.Open_failed_uploads_folder;
            this.openFailedUploadsFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFailedUploadsFolderToolStripMenuItem_Click);
            // 
            // openSuccessfulProcessingFolderToolStripMenuItem
            // 
            this.openSuccessfulProcessingFolderToolStripMenuItem.Name = "openSuccessfulProcessingFolderToolStripMenuItem";
            this.openSuccessfulProcessingFolderToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.openSuccessfulProcessingFolderToolStripMenuItem.Text = Resources.Open_successful_processing_folder;
            this.openSuccessfulProcessingFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenSuccessfulProcessingFolderToolStripMenuItem_Click);
            // 
            // openFailedProcessingFolderToolStripMenuItem
            // 
            this.openFailedProcessingFolderToolStripMenuItem.Name = "openFailedProcessingFolderToolStripMenuItem";
            this.openFailedProcessingFolderToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.openFailedProcessingFolderToolStripMenuItem.Text = Resources.Open_failed_processing_folder;
            this.openFailedProcessingFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFailedProcessingFolderToolStripMenuItem_Click);
            // 
            // openSuccessfulDownloadsFolderToolStripMenuItem
            // 
            this.openSuccessfulDownloadsFolderToolStripMenuItem.Name = "openSuccessfulDownloadsFolderToolStripMenuItem";
            this.openSuccessfulDownloadsFolderToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.openSuccessfulDownloadsFolderToolStripMenuItem.Text = Resources.Open_successful_downloads_folder;
            this.openSuccessfulDownloadsFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenSuccessfulDownloadsFolderToolStripMenuItem_Click);
            // 
            // jobsToolStrip
            // 
            this.jobsToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jobsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.jobsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instanceFilter,
            this.jobNameFilter,
            this.addJobsDropDownButton,
            this.deleteJobButton,
            this.editJobButton,
            this.pauseResumeDropDownButton,
            this.refreshButton});
            this.jobsToolStrip.Location = new System.Drawing.Point(0, 442);
            this.jobsToolStrip.Name = "jobsToolStrip";
            this.jobsToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.jobsToolStrip.Size = new System.Drawing.Size(1132, 32);
            this.jobsToolStrip.TabIndex = 4;
            this.jobsToolStrip.Text = "";
            // 
            // instanceFilter
            // 
            this.instanceFilter.Enabled = false;
            this.instanceFilter.Name = "instanceFilter";
            this.instanceFilter.Size = new System.Drawing.Size(112, 32);
            this.instanceFilter.ToolTipText = Resources.Filter_instances;
            this.instanceFilter.TextChanged += new System.EventHandler(this.InstanceFilter_TextChanged);
            // 
            // jobNameFilter
            // 
            this.jobNameFilter.Enabled = false;
            this.jobNameFilter.Name = "jobNameFilter";
            this.jobNameFilter.Size = new System.Drawing.Size(112, 32);
            this.jobNameFilter.ToolTipText = Resources.Filter_job_names;
            this.jobNameFilter.TextChanged += new System.EventHandler(this.JobNameFilter_TextChanged);
            // 
            // addJobsDropDownButton
            // 
            this.addJobsDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addJobsDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImportJobMenuItem,
            this.addExportJobMenuItem,
            this.addUploadJobMenuItem,
            this.addDownloadJobMenuItem});
            this.addJobsDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("addJobsDropDownButton.Image")));
            this.addJobsDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addJobsDropDownButton.Name = "addJobsDropDownButton";
            this.addJobsDropDownButton.Size = new System.Drawing.Size(95, 29);
            this.addJobsDropDownButton.Text = Resources.Add_job;
            // 
            // addUploadJobMenuItem
            // 
            this.addUploadJobMenuItem.Enabled = false;
            this.addUploadJobMenuItem.Name = "addUploadJobMenuItem";
            this.addUploadJobMenuItem.Size = new System.Drawing.Size(351, 30);
            this.addUploadJobMenuItem.Text = Resources.Add_upload_job;
            this.addUploadJobMenuItem.Click += new System.EventHandler(this.AddUploadJobMenuItem_Click);
            // 
            // addDownloadJobMenuItem
            // 
            this.addDownloadJobMenuItem.Enabled = false;
            this.addDownloadJobMenuItem.Name = "addDownloadJobMenuItem";
            this.addDownloadJobMenuItem.Size = new System.Drawing.Size(351, 30);
            this.addDownloadJobMenuItem.Text = Resources.Add_download_job;
            this.addDownloadJobMenuItem.Click += new System.EventHandler(this.AddDownloadJobMenuItem_Click);
            // 
            // addImportJobMenuItem
            // 
            this.addImportJobMenuItem.Enabled = false;
            this.addImportJobMenuItem.Name = "addImportJobMenuItem";
            this.addImportJobMenuItem.Size = new System.Drawing.Size(351, 30);
            this.addImportJobMenuItem.Text = Resources.Add_import_job;
            this.addImportJobMenuItem.Click += new System.EventHandler(this.AddImportJobMenuItem_Click);
            // 
            // addExportJobMenuItem
            // 
            this.addExportJobMenuItem.Enabled = false;
            this.addExportJobMenuItem.Name = "addExportJobMenuItem";
            this.addExportJobMenuItem.Size = new System.Drawing.Size(351, 30);
            this.addExportJobMenuItem.Text = Resources.Add_export_job;
            this.addExportJobMenuItem.Click += new System.EventHandler(this.AddExportJobMenuItem_Click);
            // 
            // deleteJobButton
            // 
            this.deleteJobButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteJobButton.Enabled = false;
            this.deleteJobButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteJobButton.Image")));
            this.deleteJobButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteJobButton.Name = "deleteJobButton";
            this.deleteJobButton.Size = new System.Drawing.Size(97, 29);
            this.deleteJobButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete_job;
            this.deleteJobButton.ToolTipText = Resources.Delete_job;
            this.deleteJobButton.Click += new System.EventHandler(this.DeleteJobButton_Click);
            // 
            // editJobButton
            // 
            this.editJobButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editJobButton.Enabled = false;
            this.editJobButton.Image = ((System.Drawing.Image)(resources.GetObject("editJobButton.Image")));
            this.editJobButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editJobButton.Name = "editJobButton";
            this.editJobButton.Size = new System.Drawing.Size(77, 29);
            this.editJobButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Edit_job;
            this.editJobButton.Click += new System.EventHandler(this.EditJobButton_Click);
            // 
            // pauseResumeDropDownButton
            // 
            this.pauseResumeDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pauseResumeDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseJobToolStripMenuItem,
            this.pauseAllJobsToolStripMenuItem,
            this.resumeJobToolStripMenuItem,
            this.resumeAllJobsToolStripMenuItem});
            this.pauseResumeDropDownButton.Enabled = false;
            this.pauseResumeDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseResumeDropDownButton.Image")));
            this.pauseResumeDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseResumeDropDownButton.Name = "pauseResumeDropDownButton";
            this.pauseResumeDropDownButton.Size = new System.Drawing.Size(144, 29);
            this.pauseResumeDropDownButton.Text = Resources.Pause_Resume;
            // 
            // pauseJobToolStripMenuItem
            // 
            this.pauseJobToolStripMenuItem.Name = "pauseJobToolStripMenuItem";
            this.pauseJobToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.pauseJobToolStripMenuItem.Text = Resources.Pause_job;
            this.pauseJobToolStripMenuItem.Click += new System.EventHandler(this.PauseJobToolStripMenuItem_Click);
            // 
            // pauseAllJobsToolStripMenuItem
            // 
            this.pauseAllJobsToolStripMenuItem.Name = "pauseAllJobsToolStripMenuItem";
            this.pauseAllJobsToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.pauseAllJobsToolStripMenuItem.Text = Resources.Pause_all_jobs;
            this.pauseAllJobsToolStripMenuItem.Click += new System.EventHandler(this.PauseAllJobsToolStripMenuItem_Click);
            // 
            // resumeJobToolStripMenuItem
            // 
            this.resumeJobToolStripMenuItem.Name = "resumeJobToolStripMenuItem";
            this.resumeJobToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.resumeJobToolStripMenuItem.Text = Resources.Resume_job;
            this.resumeJobToolStripMenuItem.Click += new System.EventHandler(this.ResumeJobToolStripMenuItem_Click);
            // 
            // resumeAllJobsToolStripMenuItem
            // 
            this.resumeAllJobsToolStripMenuItem.Name = "resumeAllJobsToolStripMenuItem";
            this.resumeAllJobsToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.resumeAllJobsToolStripMenuItem.Text = Resources.Resume_all_jobs;
            this.resumeAllJobsToolStripMenuItem.Click += new System.EventHandler(this.ResumeAllJobsToolStripMenuItem_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshButton.Enabled = false;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 29);
            this.refreshButton.Text = Resources.Refresh_grid;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 504);
            this.Controls.Add(this.jobsDataGridView);
            this.Controls.Add(this.jobsToolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1010, 361);
            this.Name = "MainForm";
            this.Text = Resources.Recurring_Integrations_Scheduler;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.mainMenuToolStrip.ResumeLayout(false);
            this.mainMenuToolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.jobsToolStrip.ResumeLayout(false);
            this.jobsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainMenuToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripConnectionStatus;
        private System.Windows.Forms.DataGridView jobsDataGridView;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStrip jobsToolStrip;
        private System.Windows.Forms.ToolStripButton deleteJobButton;
        private System.Windows.Forms.ToolStripButton aboutButton;
        private System.Windows.Forms.ToolStripButton connectToServerButton;
        private System.Windows.Forms.ToolStripButton saveScheduleButton;
        private System.Windows.Forms.ToolStripButton privateSchedulerButton;
        private System.Windows.Forms.ToolStripButton editJobButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instance;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextFireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreviousFireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openInputFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSuccessfulUploadsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFailedUploadsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSuccessfulProcessingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFailedProcessingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSuccessfulDownloadsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton pauseResumeDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem pauseJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseAllJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeAllJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox instanceFilter;
        private System.Windows.Forms.ToolStripTextBox jobNameFilter;
        private System.Windows.Forms.ToolStripMenuItem editJobMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseJobMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeJobToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletJobMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton addJobsDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem addUploadJobMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDownloadJobMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImportJobMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExportJobMenuItem;
    }
}