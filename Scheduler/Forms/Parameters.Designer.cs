using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class Parameters
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
            this.instancesToolStrip = new System.Windows.Forms.ToolStrip();
            this.instancesAddButton = new System.Windows.Forms.ToolStripButton();
            this.instancesDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.instancesEditButton = new System.Windows.Forms.ToolStripButton();
            this.instancesValidateButton = new System.Windows.Forms.ToolStripButton();
            this.usersToolStrip = new System.Windows.Forms.ToolStrip();
            this.usersAddButton = new System.Windows.Forms.ToolStripButton();
            this.usersDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.usersEditButton = new System.Windows.Forms.ToolStripButton();
            this.dataJobsToolStrip = new System.Windows.Forms.ToolStrip();
            this.dataJobsAddButton = new System.Windows.Forms.ToolStripButton();
            this.dataJobsDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.dataJobsEditButton = new System.Windows.Forms.ToolStripButton();
            this.jobGroupsToolStrip = new System.Windows.Forms.ToolStrip();
            this.jobGroupsAddButton = new System.Windows.Forms.ToolStripButton();
            this.jobGroupsDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.jobGroupsEditButton = new System.Windows.Forms.ToolStripButton();
            this.instancesGroupBox = new System.Windows.Forms.GroupBox();
            this.instancesGrid = new System.Windows.Forms.DataGridView();
            this.instanceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instanceAosUri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instanceAadTenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instanceAzureAuthEndpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.userLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataJobsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataJobsGrid = new System.Windows.Forms.DataGridView();
            this.dataJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataJobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataJobActivityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataJobEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadJobsFolderGroupBox = new System.Windows.Forms.GroupBox();
            this.downloadErrorsFolderLabel = new System.Windows.Forms.Label();
            this.downloadErrorsFolder = new System.Windows.Forms.TextBox();
            this.processingJobsFoldersGroupBox = new System.Windows.Forms.GroupBox();
            this.processingSuccessFolderLabel = new System.Windows.Forms.Label();
            this.processingSuccessFolder = new System.Windows.Forms.TextBox();
            this.processingErrorsFolderLabel = new System.Windows.Forms.Label();
            this.processingErrorsFolder = new System.Windows.Forms.TextBox();
            this.uploadJobsFoldersGroupBox = new System.Windows.Forms.GroupBox();
            this.uploadInputFolderLabel = new System.Windows.Forms.Label();
            this.uploadInputFolder = new System.Windows.Forms.TextBox();
            this.uploadSuccessFolderLabel = new System.Windows.Forms.Label();
            this.uploadSuccessFolder = new System.Windows.Forms.TextBox();
            this.uploadErrorsFolderLabel = new System.Windows.Forms.Label();
            this.uploadErrorsFolder = new System.Windows.Forms.TextBox();
            this.jobGroupsGroupBox = new System.Windows.Forms.GroupBox();
            this.jobGroupsGrid = new System.Windows.Forms.DataGridView();
            this.jobGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foldersGroupBox = new System.Windows.Forms.GroupBox();
            this.applicationsGroupBox = new System.Windows.Forms.GroupBox();
            this.applicationsGrid = new System.Windows.Forms.DataGridView();
            this.applicationsToolStrip = new System.Windows.Forms.ToolStrip();
            this.applicationsAddButton = new System.Windows.Forms.ToolStripButton();
            this.applicationsDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.applicationsEditButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.applicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationSecret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instancesToolStrip.SuspendLayout();
            this.usersToolStrip.SuspendLayout();
            this.dataJobsToolStrip.SuspendLayout();
            this.jobGroupsToolStrip.SuspendLayout();
            this.instancesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instancesGrid)).BeginInit();
            this.usersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.dataJobsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJobsGrid)).BeginInit();
            this.downloadJobsFolderGroupBox.SuspendLayout();
            this.processingJobsFoldersGroupBox.SuspendLayout();
            this.uploadJobsFoldersGroupBox.SuspendLayout();
            this.jobGroupsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobGroupsGrid)).BeginInit();
            this.foldersGroupBox.SuspendLayout();
            this.applicationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsGrid)).BeginInit();
            this.applicationsToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // instancesToolStrip
            // 
            this.instancesToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instancesToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.instancesToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.instancesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instancesAddButton,
            this.instancesDeleteButton,
            this.instancesEditButton,
            this.instancesValidateButton});
            this.instancesToolStrip.Location = new System.Drawing.Point(6, 365);
            this.instancesToolStrip.Name = "instancesToolStrip";
            this.instancesToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.instancesToolStrip.Size = new System.Drawing.Size(638, 32);
            this.instancesToolStrip.TabIndex = 2;
            // 
            // instancesAddButton
            // 
            this.instancesAddButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Add_16xMD;
            this.instancesAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instancesAddButton.Name = "instancesAddButton";
            this.instancesAddButton.Size = new System.Drawing.Size(70, 29);
            this.instancesAddButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Add;
            this.instancesAddButton.Click += new System.EventHandler(this.AxInstancesAddButton_Click);
            // 
            // instancesDeleteButton
            // 
            this.instancesDeleteButton.Enabled = false;
            this.instancesDeleteButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Remove_16xMD;
            this.instancesDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instancesDeleteButton.Name = "instancesDeleteButton";
            this.instancesDeleteButton.Size = new System.Drawing.Size(86, 29);
            this.instancesDeleteButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete;
            this.instancesDeleteButton.Click += new System.EventHandler(this.AxInstancesDeleteButton_Click);
            // 
            // instancesEditButton
            // 
            this.instancesEditButton.Enabled = false;
            this.instancesEditButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Edit_16xMD;
            this.instancesEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instancesEditButton.Name = "instancesEditButton";
            this.instancesEditButton.Size = new System.Drawing.Size(66, 29);
            this.instancesEditButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Edit;
            this.instancesEditButton.Click += new System.EventHandler(this.InstancesEditButton_Click);
            // 
            // instancesValidateButton
            // 
            this.instancesValidateButton.Enabled = false;
            this.instancesValidateButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.ValidateDocument_16x;
            this.instancesValidateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.instancesValidateButton.Name = "instancesValidateButton";
            this.instancesValidateButton.Size = new System.Drawing.Size(98, 29);
            this.instancesValidateButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Validate;
            this.instancesValidateButton.Click += new System.EventHandler(this.InstancesValidateButton_Click);
            // 
            // usersToolStrip
            // 
            this.usersToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.usersToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersAddButton,
            this.usersDeleteButton,
            this.usersEditButton});
            this.usersToolStrip.Location = new System.Drawing.Point(6, 365);
            this.usersToolStrip.Name = "usersToolStrip";
            this.usersToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.usersToolStrip.Size = new System.Drawing.Size(310, 32);
            this.usersToolStrip.TabIndex = 3;
            // 
            // usersAddButton
            // 
            this.usersAddButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Add_16xMD;
            this.usersAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usersAddButton.Name = "usersAddButton";
            this.usersAddButton.Size = new System.Drawing.Size(70, 29);
            this.usersAddButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Add;
            this.usersAddButton.Click += new System.EventHandler(this.UsersAddButton_Click);
            // 
            // usersDeleteButton
            // 
            this.usersDeleteButton.Enabled = false;
            this.usersDeleteButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Remove_16xMD;
            this.usersDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usersDeleteButton.Name = "usersDeleteButton";
            this.usersDeleteButton.Size = new System.Drawing.Size(86, 29);
            this.usersDeleteButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete;
            this.usersDeleteButton.Click += new System.EventHandler(this.UsersDeleteButton_Click);
            // 
            // usersEditButton
            // 
            this.usersEditButton.Enabled = false;
            this.usersEditButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Edit_16xMD;
            this.usersEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usersEditButton.Name = "usersEditButton";
            this.usersEditButton.Size = new System.Drawing.Size(66, 29);
            this.usersEditButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Edit;
            this.usersEditButton.Click += new System.EventHandler(this.UsersEditButton_Click);
            // 
            // dataJobsToolStrip
            // 
            this.dataJobsToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataJobsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.dataJobsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dataJobsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataJobsAddButton,
            this.dataJobsDeleteButton,
            this.dataJobsEditButton});
            this.dataJobsToolStrip.Location = new System.Drawing.Point(6, 365);
            this.dataJobsToolStrip.Name = "dataJobsToolStrip";
            this.dataJobsToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.dataJobsToolStrip.Size = new System.Drawing.Size(307, 32);
            this.dataJobsToolStrip.TabIndex = 3;
            // 
            // dataJobsAddButton
            // 
            this.dataJobsAddButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Add_16xMD;
            this.dataJobsAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dataJobsAddButton.Name = "dataJobsAddButton";
            this.dataJobsAddButton.Size = new System.Drawing.Size(70, 29);
            this.dataJobsAddButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Add;
            this.dataJobsAddButton.Click += new System.EventHandler(this.DataJobsAddButton_Click);
            // 
            // dataJobsDeleteButton
            // 
            this.dataJobsDeleteButton.Enabled = false;
            this.dataJobsDeleteButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Remove_16xMD;
            this.dataJobsDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dataJobsDeleteButton.Name = "dataJobsDeleteButton";
            this.dataJobsDeleteButton.Size = new System.Drawing.Size(86, 29);
            this.dataJobsDeleteButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete;
            this.dataJobsDeleteButton.Click += new System.EventHandler(this.DataJobsDeleteButton_Click);
            // 
            // dataJobsEditButton
            // 
            this.dataJobsEditButton.Enabled = false;
            this.dataJobsEditButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Edit_16xMD;
            this.dataJobsEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dataJobsEditButton.Name = "dataJobsEditButton";
            this.dataJobsEditButton.Size = new System.Drawing.Size(66, 29);
            this.dataJobsEditButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Edit;
            this.dataJobsEditButton.Click += new System.EventHandler(this.DataJobsEditButton_Click);
            // 
            // jobGroupsToolStrip
            // 
            this.jobGroupsToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jobGroupsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.jobGroupsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.jobGroupsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobGroupsAddButton,
            this.jobGroupsDeleteButton,
            this.jobGroupsEditButton});
            this.jobGroupsToolStrip.Location = new System.Drawing.Point(6, 365);
            this.jobGroupsToolStrip.Name = "jobGroupsToolStrip";
            this.jobGroupsToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.jobGroupsToolStrip.Size = new System.Drawing.Size(307, 32);
            this.jobGroupsToolStrip.TabIndex = 4;
            // 
            // jobGroupsAddButton
            // 
            this.jobGroupsAddButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Add_16xMD;
            this.jobGroupsAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.jobGroupsAddButton.Name = "jobGroupsAddButton";
            this.jobGroupsAddButton.Size = new System.Drawing.Size(70, 29);
            this.jobGroupsAddButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Add;
            this.jobGroupsAddButton.Click += new System.EventHandler(this.JobGroupsAddButton_Click);
            // 
            // jobGroupsDeleteButton
            // 
            this.jobGroupsDeleteButton.Enabled = false;
            this.jobGroupsDeleteButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Remove_16xMD;
            this.jobGroupsDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.jobGroupsDeleteButton.Name = "jobGroupsDeleteButton";
            this.jobGroupsDeleteButton.Size = new System.Drawing.Size(86, 29);
            this.jobGroupsDeleteButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete;
            this.jobGroupsDeleteButton.Click += new System.EventHandler(this.JobGroupsDeleteButton_Click);
            // 
            // jobGroupsEditButton
            // 
            this.jobGroupsEditButton.Enabled = false;
            this.jobGroupsEditButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Edit_16xMD;
            this.jobGroupsEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.jobGroupsEditButton.Name = "jobGroupsEditButton";
            this.jobGroupsEditButton.Size = new System.Drawing.Size(66, 29);
            this.jobGroupsEditButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Edit;
            this.jobGroupsEditButton.Click += new System.EventHandler(this.JobGroupsEditButton_Click);
            // 
            // instancesGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.instancesGroupBox, 2);
            this.instancesGroupBox.Controls.Add(this.instancesGrid);
            this.instancesGroupBox.Controls.Add(this.instancesToolStrip);
            this.instancesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancesGroupBox.Location = new System.Drawing.Point(4, 5);
            this.instancesGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instancesGroupBox.Name = "instancesGroupBox";
            this.instancesGroupBox.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.instancesGroupBox.Size = new System.Drawing.Size(650, 403);
            this.instancesGroupBox.TabIndex = 1;
            this.instancesGroupBox.TabStop = false;
            this.instancesGroupBox.Text = Resources.Dynamics_365_for_Operations_instances;
            // 
            // instancesGrid
            // 
            this.instancesGrid.AllowUserToAddRows = false;
            this.instancesGrid.AllowUserToDeleteRows = false;
            this.instancesGrid.AllowUserToResizeRows = false;
            this.instancesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.instancesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.instancesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instancesGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.instancesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instancesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instanceName,
            this.instanceAosUri,
            this.instanceAadTenant,
            this.instanceAzureAuthEndpoint});
            this.instancesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancesGrid.Location = new System.Drawing.Point(6, 31);
            this.instancesGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instancesGrid.MultiSelect = false;
            this.instancesGrid.Name = "instancesGrid";
            this.instancesGrid.ReadOnly = true;
            this.instancesGrid.RowHeadersVisible = false;
            this.instancesGrid.RowHeadersWidth = 4;
            this.instancesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instancesGrid.Size = new System.Drawing.Size(638, 334);
            this.instancesGrid.TabIndex = 0;
            this.instancesGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstancesGrid_CellContentDoubleClick);
            this.instancesGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.InstancesDataGridView_RowsRemoved);
            this.instancesGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.InstancesDataGridView_RowStateChanged);
            this.instancesGrid.SelectionChanged += new System.EventHandler(this.InstancesDataGridView_SelectionChanged);
            // 
            // instanceName
            // 
            this.instanceName.DataPropertyName = "Name";
            this.instanceName.FillWeight = 40F;
            this.instanceName.HeaderText = Resources.NameLabel;
            this.instanceName.Name = "instanceName";
            this.instanceName.ReadOnly = true;
            this.instanceName.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Friendly_name_used_only_in_Recurring_Integrations_App;
            // 
            // instanceAosUri
            // 
            this.instanceAosUri.DataPropertyName = "AosUri";
            this.instanceAosUri.FillWeight = 40F;
            this.instanceAosUri.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.AOS_URL;
            this.instanceAosUri.Name = "instanceAosUri";
            this.instanceAosUri.ReadOnly = true;
            // 
            // instanceAadTenant
            // 
            this.instanceAadTenant.DataPropertyName = "AadTenant";
            this.instanceAadTenant.FillWeight = 20F;
            this.instanceAadTenant.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Tenant;
            this.instanceAadTenant.Name = "instanceAadTenant";
            this.instanceAadTenant.ReadOnly = true;
            this.instanceAadTenant.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Uri_or_Guid;
            // 
            // instanceAzureAuthEndpoint
            // 
            this.instanceAzureAuthEndpoint.DataPropertyName = "AzureAuthEndpoint";
            this.instanceAzureAuthEndpoint.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Authentication_endpoint;
            this.instanceAzureAuthEndpoint.Name = "instanceAzureAuthEndpoint";
            this.instanceAzureAuthEndpoint.ReadOnly = true;
            this.instanceAzureAuthEndpoint.Visible = false;
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Controls.Add(this.usersDataGrid);
            this.usersGroupBox.Controls.Add(this.usersToolStrip);
            this.usersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGroupBox.Location = new System.Drawing.Point(332, 418);
            this.usersGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.usersGroupBox.Size = new System.Drawing.Size(322, 403);
            this.usersGroupBox.TabIndex = 0;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = Resources.User_credentials;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToAddRows = false;
            this.usersDataGrid.AllowUserToDeleteRows = false;
            this.usersDataGrid.AllowUserToResizeRows = false;
            this.usersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.usersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usersDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userLogin,
            this.userPassword});
            this.usersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersDataGrid.Location = new System.Drawing.Point(6, 31);
            this.usersDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usersDataGrid.MultiSelect = false;
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.RowHeadersVisible = false;
            this.usersDataGrid.RowHeadersWidth = 4;
            this.usersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGrid.Size = new System.Drawing.Size(310, 334);
            this.usersDataGrid.TabIndex = 1;
            this.usersDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellContentDoubleClick);
            this.usersDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.UsersDataGridView_RowsRemoved);
            this.usersDataGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.UsersDataGridView_RowStateChanged);
            // 
            // userLogin
            // 
            this.userLogin.DataPropertyName = "Login";
            this.userLogin.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.User_login_UPN;
            this.userLogin.Name = "userLogin";
            this.userLogin.ReadOnly = true;
            this.userLogin.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.User_login_like_admin_contoso_com;
            // 
            // userPassword
            // 
            this.userPassword.DataPropertyName = "Password";
            this.userPassword.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Password;
            this.userPassword.Name = "userPassword";
            this.userPassword.ReadOnly = true;
            this.userPassword.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Password;
            this.userPassword.Visible = false;
            // 
            // dataJobsGroupBox
            // 
            this.dataJobsGroupBox.Controls.Add(this.dataJobsGrid);
            this.dataJobsGroupBox.Controls.Add(this.dataJobsToolStrip);
            this.dataJobsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataJobsGroupBox.Location = new System.Drawing.Point(662, 5);
            this.dataJobsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataJobsGroupBox.Name = "dataJobsGroupBox";
            this.dataJobsGroupBox.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.dataJobsGroupBox.Size = new System.Drawing.Size(319, 403);
            this.dataJobsGroupBox.TabIndex = 0;
            this.dataJobsGroupBox.TabStop = false;
            this.dataJobsGroupBox.Text = Resources.Data_jobs;
            // 
            // dataJobsGrid
            // 
            this.dataJobsGrid.AllowUserToAddRows = false;
            this.dataJobsGrid.AllowUserToDeleteRows = false;
            this.dataJobsGrid.AllowUserToResizeRows = false;
            this.dataJobsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataJobsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataJobsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataJobsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataJobsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJobsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataJobName,
            this.dataJobType,
            this.dataJobActivityId,
            this.dataJobEntityName});
            this.dataJobsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataJobsGrid.Location = new System.Drawing.Point(6, 31);
            this.dataJobsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataJobsGrid.MultiSelect = false;
            this.dataJobsGrid.Name = "dataJobsGrid";
            this.dataJobsGrid.ReadOnly = true;
            this.dataJobsGrid.RowHeadersVisible = false;
            this.dataJobsGrid.RowHeadersWidth = 4;
            this.dataJobsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataJobsGrid.Size = new System.Drawing.Size(307, 334);
            this.dataJobsGrid.TabIndex = 0;
            this.dataJobsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataJobsGrid_CellContentDoubleClick);
            this.dataJobsGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataJobsDataGridView_RowsRemoved);
            this.dataJobsGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataJobsDataGridView_RowStateChanged);
            // 
            // dataJobName
            // 
            this.dataJobName.DataPropertyName = "Name";
            this.dataJobName.HeaderText = Resources.NameLabel;
            this.dataJobName.MinimumWidth = 50;
            this.dataJobName.Name = "dataJobName";
            this.dataJobName.ReadOnly = true;
            this.dataJobName.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Friendly_name_used_only_in_Recurring_Integrations_App;
            // 
            // dataJobType
            // 
            this.dataJobType.DataPropertyName = "Type";
            this.dataJobType.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Type;
            this.dataJobType.MinimumWidth = 50;
            this.dataJobType.Name = "dataJobType";
            this.dataJobType.ReadOnly = true;
            // 
            // dataJobActivityId
            // 
            this.dataJobActivityId.DataPropertyName = "ActivityId";
            this.dataJobActivityId.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Activity_Id;
            this.dataJobActivityId.Name = "dataJobActivityId";
            this.dataJobActivityId.ReadOnly = true;
            this.dataJobActivityId.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Activity_Id_Guid_of_this_data_job_configured_in_Dynamics;
            this.dataJobActivityId.Visible = false;
            // 
            // dataJobEntityName
            // 
            this.dataJobEntityName.DataPropertyName = "EntityName";
            this.dataJobEntityName.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Entity_name;
            this.dataJobEntityName.Name = "dataJobEntityName";
            this.dataJobEntityName.ReadOnly = true;
            this.dataJobEntityName.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Entity_name_for_this_data_job_configured_in_Dynamics;
            this.dataJobEntityName.Visible = false;
            // 
            // downloadJobsFolderGroupBox
            // 
            this.downloadJobsFolderGroupBox.Controls.Add(this.downloadErrorsFolderLabel);
            this.downloadJobsFolderGroupBox.Controls.Add(this.downloadErrorsFolder);
            this.downloadJobsFolderGroupBox.Location = new System.Drawing.Point(10, 325);
            this.downloadJobsFolderGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.downloadJobsFolderGroupBox.Name = "downloadJobsFolderGroupBox";
            this.downloadJobsFolderGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.downloadJobsFolderGroupBox.Size = new System.Drawing.Size(260, 72);
            this.downloadJobsFolderGroupBox.TabIndex = 2;
            this.downloadJobsFolderGroupBox.TabStop = false;
            this.downloadJobsFolderGroupBox.Text = Resources.Download_jobs_folders_names;
            // 
            // downloadErrorsFolderLabel
            // 
            this.downloadErrorsFolderLabel.AutoSize = true;
            this.downloadErrorsFolderLabel.Location = new System.Drawing.Point(55, 32);
            this.downloadErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadErrorsFolderLabel.Name = "downloadErrorsFolderLabel";
            this.downloadErrorsFolderLabel.Size = new System.Drawing.Size(52, 20);
            this.downloadErrorsFolderLabel.TabIndex = 7;
            this.downloadErrorsFolderLabel.Text = Resources.Errors;
            // 
            // downloadErrorsFolder
            // 
            this.downloadErrorsFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RecurringIntegrationsScheduler.Properties.Settings.Default, "DownloadErrorsFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadErrorsFolder.Location = new System.Drawing.Point(118, 29);
            this.downloadErrorsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.downloadErrorsFolder.Name = "downloadErrorsFolder";
            this.downloadErrorsFolder.Size = new System.Drawing.Size(127, 26);
            this.downloadErrorsFolder.TabIndex = 9;
            this.downloadErrorsFolder.Text = global::RecurringIntegrationsScheduler.Properties.Settings.Default.DownloadErrorsFolder;
            // 
            // processingJobsFoldersGroupBox
            // 
            this.processingJobsFoldersGroupBox.Controls.Add(this.processingSuccessFolderLabel);
            this.processingJobsFoldersGroupBox.Controls.Add(this.processingSuccessFolder);
            this.processingJobsFoldersGroupBox.Controls.Add(this.processingErrorsFolderLabel);
            this.processingJobsFoldersGroupBox.Controls.Add(this.processingErrorsFolder);
            this.processingJobsFoldersGroupBox.Location = new System.Drawing.Point(10, 199);
            this.processingJobsFoldersGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingJobsFoldersGroupBox.Name = "processingJobsFoldersGroupBox";
            this.processingJobsFoldersGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingJobsFoldersGroupBox.Size = new System.Drawing.Size(260, 116);
            this.processingJobsFoldersGroupBox.TabIndex = 1;
            this.processingJobsFoldersGroupBox.TabStop = false;
            this.processingJobsFoldersGroupBox.Text = Resources.Monitoring_jobs_folders_names;
            // 
            // processingSuccessFolderLabel
            // 
            this.processingSuccessFolderLabel.AutoSize = true;
            this.processingSuccessFolderLabel.Location = new System.Drawing.Point(39, 39);
            this.processingSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processingSuccessFolderLabel.Name = "processingSuccessFolderLabel";
            this.processingSuccessFolderLabel.Size = new System.Drawing.Size(70, 20);
            this.processingSuccessFolderLabel.TabIndex = 9;
            this.processingSuccessFolderLabel.Text = Resources.Success;
            // 
            // processingSuccessFolder
            // 
            this.processingSuccessFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RecurringIntegrationsScheduler.Properties.Settings.Default, "ProcessingSuccessFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.processingSuccessFolder.Location = new System.Drawing.Point(118, 35);
            this.processingSuccessFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingSuccessFolder.Name = "processingSuccessFolder";
            this.processingSuccessFolder.Size = new System.Drawing.Size(127, 26);
            this.processingSuccessFolder.TabIndex = 12;
            this.processingSuccessFolder.Text = global::RecurringIntegrationsScheduler.Properties.Settings.Default.ProcessingSuccessFolder;
            // 
            // processingErrorsFolderLabel
            // 
            this.processingErrorsFolderLabel.AutoSize = true;
            this.processingErrorsFolderLabel.Location = new System.Drawing.Point(55, 76);
            this.processingErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processingErrorsFolderLabel.Name = "processingErrorsFolderLabel";
            this.processingErrorsFolderLabel.Size = new System.Drawing.Size(52, 20);
            this.processingErrorsFolderLabel.TabIndex = 13;
            this.processingErrorsFolderLabel.Text = Resources.Errors;
            // 
            // processingErrorsFolder
            // 
            this.processingErrorsFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RecurringIntegrationsScheduler.Properties.Settings.Default, "ProcessingErrorsFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.processingErrorsFolder.Location = new System.Drawing.Point(118, 72);
            this.processingErrorsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingErrorsFolder.Name = "processingErrorsFolder";
            this.processingErrorsFolder.Size = new System.Drawing.Size(127, 26);
            this.processingErrorsFolder.TabIndex = 14;
            this.processingErrorsFolder.Text = global::RecurringIntegrationsScheduler.Properties.Settings.Default.ProcessingErrorsFolder;
            // 
            // uploadJobsFoldersGroupBox
            // 
            this.uploadJobsFoldersGroupBox.Controls.Add(this.uploadInputFolderLabel);
            this.uploadJobsFoldersGroupBox.Controls.Add(this.uploadInputFolder);
            this.uploadJobsFoldersGroupBox.Controls.Add(this.uploadSuccessFolderLabel);
            this.uploadJobsFoldersGroupBox.Controls.Add(this.uploadSuccessFolder);
            this.uploadJobsFoldersGroupBox.Controls.Add(this.uploadErrorsFolderLabel);
            this.uploadJobsFoldersGroupBox.Controls.Add(this.uploadErrorsFolder);
            this.uploadJobsFoldersGroupBox.Location = new System.Drawing.Point(10, 31);
            this.uploadJobsFoldersGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadJobsFoldersGroupBox.Name = "uploadJobsFoldersGroupBox";
            this.uploadJobsFoldersGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadJobsFoldersGroupBox.Size = new System.Drawing.Size(260, 158);
            this.uploadJobsFoldersGroupBox.TabIndex = 0;
            this.uploadJobsFoldersGroupBox.TabStop = false;
            this.uploadJobsFoldersGroupBox.Text = Resources.Upload_jobs_folders_names;
            // 
            // uploadInputFolderLabel
            // 
            this.uploadInputFolderLabel.AutoSize = true;
            this.uploadInputFolderLabel.Location = new System.Drawing.Point(19, 42);
            this.uploadInputFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uploadInputFolderLabel.Name = "uploadInputFolderLabel";
            this.uploadInputFolderLabel.Size = new System.Drawing.Size(90, 20);
            this.uploadInputFolderLabel.TabIndex = 0;
            this.uploadInputFolderLabel.Text = Resources.Input_folder;
            // 
            // uploadInputFolder
            // 
            this.uploadInputFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RecurringIntegrationsScheduler.Properties.Settings.Default, "UploadInputFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uploadInputFolder.Location = new System.Drawing.Point(118, 39);
            this.uploadInputFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadInputFolder.Name = "uploadInputFolder";
            this.uploadInputFolder.Size = new System.Drawing.Size(127, 26);
            this.uploadInputFolder.TabIndex = 4;
            this.uploadInputFolder.Text = global::RecurringIntegrationsScheduler.Properties.Settings.Default.UploadInputFolder;
            // 
            // uploadSuccessFolderLabel
            // 
            this.uploadSuccessFolderLabel.AutoSize = true;
            this.uploadSuccessFolderLabel.Location = new System.Drawing.Point(30, 80);
            this.uploadSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uploadSuccessFolderLabel.Name = "uploadSuccessFolderLabel";
            this.uploadSuccessFolderLabel.Size = new System.Drawing.Size(70, 20);
            this.uploadSuccessFolderLabel.TabIndex = 1;
            this.uploadSuccessFolderLabel.Text = Resources.Success;
            // 
            // uploadSuccessFolder
            // 
            this.uploadSuccessFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RecurringIntegrationsScheduler.Properties.Settings.Default, "UploadSuccessFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uploadSuccessFolder.Location = new System.Drawing.Point(118, 76);
            this.uploadSuccessFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadSuccessFolder.Name = "uploadSuccessFolder";
            this.uploadSuccessFolder.Size = new System.Drawing.Size(127, 26);
            this.uploadSuccessFolder.TabIndex = 5;
            this.uploadSuccessFolder.Text = global::RecurringIntegrationsScheduler.Properties.Settings.Default.UploadSuccessFolder;
            // 
            // uploadErrorsFolderLabel
            // 
            this.uploadErrorsFolderLabel.AutoSize = true;
            this.uploadErrorsFolderLabel.Location = new System.Drawing.Point(55, 118);
            this.uploadErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uploadErrorsFolderLabel.Name = "uploadErrorsFolderLabel";
            this.uploadErrorsFolderLabel.Size = new System.Drawing.Size(52, 20);
            this.uploadErrorsFolderLabel.TabIndex = 3;
            this.uploadErrorsFolderLabel.Text = Resources.Errors;
            // 
            // uploadErrorsFolder
            // 
            this.uploadErrorsFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RecurringIntegrationsScheduler.Properties.Settings.Default, "UploadErrorsFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uploadErrorsFolder.Location = new System.Drawing.Point(118, 114);
            this.uploadErrorsFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadErrorsFolder.Name = "uploadErrorsFolder";
            this.uploadErrorsFolder.Size = new System.Drawing.Size(127, 26);
            this.uploadErrorsFolder.TabIndex = 7;
            this.uploadErrorsFolder.Text = global::RecurringIntegrationsScheduler.Properties.Settings.Default.UploadErrorsFolder;
            // 
            // jobGroupsGroupBox
            // 
            this.jobGroupsGroupBox.Controls.Add(this.jobGroupsGrid);
            this.jobGroupsGroupBox.Controls.Add(this.jobGroupsToolStrip);
            this.jobGroupsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobGroupsGroupBox.Location = new System.Drawing.Point(662, 418);
            this.jobGroupsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobGroupsGroupBox.Name = "jobGroupsGroupBox";
            this.jobGroupsGroupBox.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.jobGroupsGroupBox.Size = new System.Drawing.Size(319, 403);
            this.jobGroupsGroupBox.TabIndex = 1;
            this.jobGroupsGroupBox.TabStop = false;
            this.jobGroupsGroupBox.Text = Resources.Job_groups;
            // 
            // jobGroupsGrid
            // 
            this.jobGroupsGrid.AllowUserToAddRows = false;
            this.jobGroupsGrid.AllowUserToDeleteRows = false;
            this.jobGroupsGrid.AllowUserToResizeRows = false;
            this.jobGroupsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobGroupsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.jobGroupsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jobGroupsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.jobGroupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobGroupsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobGroupName});
            this.jobGroupsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobGroupsGrid.Location = new System.Drawing.Point(6, 31);
            this.jobGroupsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobGroupsGrid.MultiSelect = false;
            this.jobGroupsGrid.Name = "jobGroupsGrid";
            this.jobGroupsGrid.ReadOnly = true;
            this.jobGroupsGrid.RowHeadersVisible = false;
            this.jobGroupsGrid.RowHeadersWidth = 4;
            this.jobGroupsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobGroupsGrid.Size = new System.Drawing.Size(307, 334);
            this.jobGroupsGrid.TabIndex = 1;
            this.jobGroupsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobGroupsGrid_CellContentDoubleClick);
            this.jobGroupsGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.JobGroupsDataGridView_RowsRemoved);
            this.jobGroupsGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.JobGroupsDataGridView_RowStateChanged);
            // 
            // jobGroupName
            // 
            this.jobGroupName.DataPropertyName = "Name";
            this.jobGroupName.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Group_name;
            this.jobGroupName.Name = "jobGroupName";
            this.jobGroupName.ReadOnly = true;
            // 
            // foldersGroupBox
            // 
            this.foldersGroupBox.Controls.Add(this.uploadJobsFoldersGroupBox);
            this.foldersGroupBox.Controls.Add(this.processingJobsFoldersGroupBox);
            this.foldersGroupBox.Controls.Add(this.downloadJobsFolderGroupBox);
            this.foldersGroupBox.Location = new System.Drawing.Point(988, 4);
            this.foldersGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.foldersGroupBox.Name = "foldersGroupBox";
            this.foldersGroupBox.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.tableLayoutPanel1.SetRowSpan(this.foldersGroupBox, 2);
            this.foldersGroupBox.Size = new System.Drawing.Size(282, 410);
            this.foldersGroupBox.TabIndex = 2;
            this.foldersGroupBox.TabStop = false;
            this.foldersGroupBox.Text = Resources.Default_folder_names;
            // 
            // applicationsGroupBox
            // 
            this.applicationsGroupBox.Controls.Add(this.applicationsGrid);
            this.applicationsGroupBox.Controls.Add(this.applicationsToolStrip);
            this.applicationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsGroupBox.Location = new System.Drawing.Point(4, 418);
            this.applicationsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applicationsGroupBox.Name = "applicationsGroupBox";
            this.applicationsGroupBox.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.applicationsGroupBox.Size = new System.Drawing.Size(320, 403);
            this.applicationsGroupBox.TabIndex = 8;
            this.applicationsGroupBox.TabStop = false;
            this.applicationsGroupBox.Text = Resources.Azure_AD_applications;
            // 
            // applicationsGrid
            // 
            this.applicationsGrid.AllowUserToAddRows = false;
            this.applicationsGrid.AllowUserToDeleteRows = false;
            this.applicationsGrid.AllowUserToResizeRows = false;
            this.applicationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.applicationsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.applicationsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.applicationsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.applicationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicationName,
            this.applicationType,
            this.applicationClientId,
            this.applicationSecret});
            this.applicationsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsGrid.Location = new System.Drawing.Point(6, 31);
            this.applicationsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applicationsGrid.MultiSelect = false;
            this.applicationsGrid.Name = "applicationsGrid";
            this.applicationsGrid.ReadOnly = true;
            this.applicationsGrid.RowHeadersVisible = false;
            this.applicationsGrid.RowHeadersWidth = 4;
            this.applicationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applicationsGrid.Size = new System.Drawing.Size(308, 334);
            this.applicationsGrid.TabIndex = 1;
            this.applicationsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApplicationsGrid_CellContentDoubleClick);
            this.applicationsGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ApplicationsGrid_RowsRemoved);
            this.applicationsGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.ApplicationsGrid_RowStateChanged);
            // 
            // applicationsToolStrip
            // 
            this.applicationsToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applicationsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.applicationsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.applicationsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsAddButton,
            this.applicationsDeleteButton,
            this.applicationsEditButton});
            this.applicationsToolStrip.Location = new System.Drawing.Point(6, 365);
            this.applicationsToolStrip.Name = "applicationsToolStrip";
            this.applicationsToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.applicationsToolStrip.Size = new System.Drawing.Size(308, 32);
            this.applicationsToolStrip.TabIndex = 4;
            // 
            // applicationsAddButton
            // 
            this.applicationsAddButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Add_16xMD;
            this.applicationsAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applicationsAddButton.Name = "applicationsAddButton";
            this.applicationsAddButton.Size = new System.Drawing.Size(70, 29);
            this.applicationsAddButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Add;
            this.applicationsAddButton.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Add_Azure_application;
            this.applicationsAddButton.Click += new System.EventHandler(this.ApplicationsAddButton_Click);
            // 
            // applicationsDeleteButton
            // 
            this.applicationsDeleteButton.Enabled = false;
            this.applicationsDeleteButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Remove_16xMD;
            this.applicationsDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applicationsDeleteButton.Name = "applicationsDeleteButton";
            this.applicationsDeleteButton.Size = new System.Drawing.Size(86, 29);
            this.applicationsDeleteButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete;
            this.applicationsDeleteButton.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Delete_Azure_application;
            this.applicationsDeleteButton.Click += new System.EventHandler(this.ApplicationsDeleteButton_Click);
            // 
            // applicationsEditButton
            // 
            this.applicationsEditButton.Enabled = false;
            this.applicationsEditButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Edit_16xMD;
            this.applicationsEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applicationsEditButton.Name = "applicationsEditButton";
            this.applicationsEditButton.Size = new System.Drawing.Size(66, 29);
            this.applicationsEditButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Edit;
            this.applicationsEditButton.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Edit_Azure_application;
            this.applicationsEditButton.Click += new System.EventHandler(this.ApplicationsEditButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.45238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.jobGroupsGroupBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataJobsGroupBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.foldersGroupBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.instancesGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersGroupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.applicationsGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1275, 826);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // applicationName
            // 
            this.applicationName.DataPropertyName = "Name";
            this.applicationName.HeaderText = Resources.NameLabel;
            this.applicationName.Name = "applicationName";
            this.applicationName.ReadOnly = true;
            // 
            // applicationType
            // 
            this.applicationType.DataPropertyName = "AuthenticationType";
            this.applicationType.HeaderText = Resources.Auth_type;
            this.applicationType.Name = "applicationType";
            this.applicationType.ReadOnly = true;
            // 
            // applicationClientId
            // 
            this.applicationClientId.DataPropertyName = "ClientId";
            this.applicationClientId.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Client_Id;
            this.applicationClientId.Name = "applicationClientId";
            this.applicationClientId.ReadOnly = true;
            this.applicationClientId.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Application_client_Id_GUID;
            this.applicationClientId.Visible = false;
            // 
            // applicationSecret
            // 
            this.applicationSecret.DataPropertyName = "Secret";
            this.applicationSecret.HeaderText = global::RecurringIntegrationsScheduler.Properties.Resources.Secret;
            this.applicationSecret.Name = "applicationSecret";
            this.applicationSecret.ReadOnly = true;
            this.applicationSecret.ToolTipText = global::RecurringIntegrationsScheduler.Properties.Resources.Web_application_client_secret;
            this.applicationSecret.Visible = false;
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 826);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1190, 736);
            this.Name = "Parameters";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = Resources.Parameters;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.instancesToolStrip.ResumeLayout(false);
            this.instancesToolStrip.PerformLayout();
            this.usersToolStrip.ResumeLayout(false);
            this.usersToolStrip.PerformLayout();
            this.dataJobsToolStrip.ResumeLayout(false);
            this.dataJobsToolStrip.PerformLayout();
            this.jobGroupsToolStrip.ResumeLayout(false);
            this.jobGroupsToolStrip.PerformLayout();
            this.instancesGroupBox.ResumeLayout(false);
            this.instancesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instancesGrid)).EndInit();
            this.usersGroupBox.ResumeLayout(false);
            this.usersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.dataJobsGroupBox.ResumeLayout(false);
            this.dataJobsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJobsGrid)).EndInit();
            this.downloadJobsFolderGroupBox.ResumeLayout(false);
            this.downloadJobsFolderGroupBox.PerformLayout();
            this.processingJobsFoldersGroupBox.ResumeLayout(false);
            this.processingJobsFoldersGroupBox.PerformLayout();
            this.uploadJobsFoldersGroupBox.ResumeLayout(false);
            this.uploadJobsFoldersGroupBox.PerformLayout();
            this.jobGroupsGroupBox.ResumeLayout(false);
            this.jobGroupsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobGroupsGrid)).EndInit();
            this.foldersGroupBox.ResumeLayout(false);
            this.applicationsGroupBox.ResumeLayout(false);
            this.applicationsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsGrid)).EndInit();
            this.applicationsToolStrip.ResumeLayout(false);
            this.applicationsToolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox dataJobsGroupBox;
        private System.Windows.Forms.DataGridView dataJobsGrid;
        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.GroupBox downloadJobsFolderGroupBox;
        private System.Windows.Forms.TextBox downloadErrorsFolder;
        private System.Windows.Forms.Label downloadErrorsFolderLabel;
        private System.Windows.Forms.GroupBox processingJobsFoldersGroupBox;
        private System.Windows.Forms.TextBox processingSuccessFolder;
        private System.Windows.Forms.Label processingSuccessFolderLabel;
        private System.Windows.Forms.GroupBox uploadJobsFoldersGroupBox;
        private System.Windows.Forms.TextBox uploadErrorsFolder;
        private System.Windows.Forms.TextBox uploadSuccessFolder;
        private System.Windows.Forms.TextBox uploadInputFolder;
        private System.Windows.Forms.Label uploadErrorsFolderLabel;
        private System.Windows.Forms.Label uploadSuccessFolderLabel;
        private System.Windows.Forms.Label uploadInputFolderLabel;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.GroupBox jobGroupsGroupBox;
        private System.Windows.Forms.DataGridView jobGroupsGrid;
        private System.Windows.Forms.GroupBox instancesGroupBox;
        private System.Windows.Forms.DataGridView instancesGrid;
        private System.Windows.Forms.ToolStrip instancesToolStrip;
        private System.Windows.Forms.ToolStripButton instancesAddButton;
        private System.Windows.Forms.ToolStripButton instancesDeleteButton;
        private System.Windows.Forms.ToolStrip usersToolStrip;
        private System.Windows.Forms.ToolStripButton usersAddButton;
        private System.Windows.Forms.ToolStripButton usersDeleteButton;
        private System.Windows.Forms.ToolStrip dataJobsToolStrip;
        private System.Windows.Forms.ToolStripButton dataJobsAddButton;
        private System.Windows.Forms.ToolStripButton dataJobsDeleteButton;
        private System.Windows.Forms.ToolStrip jobGroupsToolStrip;
        private System.Windows.Forms.ToolStripButton jobGroupsAddButton;
        private System.Windows.Forms.ToolStripButton jobGroupsDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobGroupName;
        private System.Windows.Forms.ToolStripButton instancesValidateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword;
        private System.Windows.Forms.TextBox processingErrorsFolder;
        private System.Windows.Forms.Label processingErrorsFolderLabel;
        private System.Windows.Forms.GroupBox foldersGroupBox;
        private System.Windows.Forms.GroupBox applicationsGroupBox;
        private System.Windows.Forms.DataGridView applicationsGrid;
        private System.Windows.Forms.ToolStripButton instancesEditButton;
        private System.Windows.Forms.ToolStripButton usersEditButton;
        private System.Windows.Forms.ToolStripButton dataJobsEditButton;
        private System.Windows.Forms.ToolStripButton jobGroupsEditButton;
        private System.Windows.Forms.ToolStrip applicationsToolStrip;
        private System.Windows.Forms.ToolStripButton applicationsAddButton;
        private System.Windows.Forms.ToolStripButton applicationsDeleteButton;
        private System.Windows.Forms.ToolStripButton applicationsEditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanceAosUri;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanceAadTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn instanceAzureAuthEndpoint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataJobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataJobActivityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataJobEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationSecret;
    }
}