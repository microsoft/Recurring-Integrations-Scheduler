using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class ExportJobV3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportJobV3));
            this.useStandardSubfolder = new System.Windows.Forms.CheckBox();
            this.errorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.errorsFolder = new System.Windows.Forms.TextBox();
            this.errorsFolderLabel = new System.Windows.Forms.Label();
            this.downloadFolderBrowserButton = new System.Windows.Forms.Button();
            this.downloadFolder = new System.Windows.Forms.TextBox();
            this.downloadFolderLabel = new System.Windows.Forms.Label();
            this.jobDescription = new System.Windows.Forms.TextBox();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.jobGroupComboBox = new System.Windows.Forms.ComboBox();
            this.jobGroupLabel = new System.Windows.Forms.Label();
            this.jobName = new System.Windows.Forms.TextBox();
            this.jobNameLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.retryPolicyGroupBox = new System.Windows.Forms.GroupBox();
            this.retriesLabel = new System.Windows.Forms.Label();
            this.retriesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.delayLabel = new System.Windows.Forms.Label();
            this.retriesDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBoxExceptions = new System.Windows.Forms.GroupBox();
            this.pauseOnExceptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.jobTabControl = new System.Windows.Forms.TabControl();
            this.exportJobOverviewTabPage = new System.Windows.Forms.TabPage();
            this.jobIdentificationGroupBox = new System.Windows.Forms.GroupBox();
            this.jobControlGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.verboseLoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.pauseIndefinitelyCheckBox = new System.Windows.Forms.CheckBox();
            this.foldersGroupBox = new System.Windows.Forms.GroupBox();
            this.exportJobDetailsTabPage = new System.Windows.Forms.TabPage();
            this.exportDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataProjectLabel = new System.Windows.Forms.Label();
            this.dataProject = new System.Windows.Forms.TextBox();
            this.unzipCheckBox = new System.Windows.Forms.CheckBox();
            this.addTimestampCheckBox = new System.Windows.Forms.CheckBox();
            this.deletePackageCheckBox = new System.Windows.Forms.CheckBox();
            this.delayBetweenStatusCheckLabel = new System.Windows.Forms.Label();
            this.delayBetweenStatusCheckNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.delayBetweenAttemptsLabel = new System.Windows.Forms.Label();
            this.delayBetweenAttemptsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sourceCompanyGroupBox = new System.Windows.Forms.GroupBox();
            this.legalEntityLabel = new System.Windows.Forms.Label();
            this.legalEntity = new System.Windows.Forms.TextBox();
            this.exportJobRecurrenceTabPage = new System.Windows.Forms.TabPage();
            this.triggerTypePanel = new System.Windows.Forms.Panel();
            this.simpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.cronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.simpleTriggerJobGroupBox = new System.Windows.Forms.GroupBox();
            this.runEveryLabel = new System.Windows.Forms.Label();
            this.hoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.andOrLabel = new System.Windows.Forms.Label();
            this.minutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.startAtLabel = new System.Windows.Forms.Label();
            this.startAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cronTriggerGroupBox = new System.Windows.Forms.GroupBox();
            this.cronExpressionLabel = new System.Windows.Forms.Label();
            this.cronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.cronTriggerInfoTextBox = new System.Windows.Forms.TextBox();
            this.buildCronLabel = new System.Windows.Forms.Label();
            this.cronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.calculateNextRunsButton = new System.Windows.Forms.Button();
            this.calculatedRunsTextBox = new System.Windows.Forms.TextBox();
            this.moreExamplesButton = new System.Windows.Forms.Button();
            this.connectionTabPage = new System.Windows.Forms.TabPage();
            this.axDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.instanceLabel = new System.Windows.Forms.Label();
            this.instanceComboBox = new System.Windows.Forms.ComboBox();
            this.authMethodPanel = new System.Windows.Forms.Panel();
            this.userAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.serviceAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.aadApplicationLabel = new System.Windows.Forms.Label();
            this.appRegistrationComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.customOdataTabPage = new System.Windows.Forms.TabPage();
            this.customODataGroupBox = new System.Windows.Forms.GroupBox();
            this.exportToPackageLabel = new System.Windows.Forms.Label();
            this.exportToPackageTextBox = new System.Windows.Forms.TextBox();
            this.getExecutionSummaryStatusLabel = new System.Windows.Forms.Label();
            this.getExecutionSummaryStatusTextBox = new System.Windows.Forms.TextBox();
            this.getExportedPackageUrlLabel = new System.Windows.Forms.Label();
            this.getExportedPackageUrlTextBox = new System.Windows.Forms.TextBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.retryPolicyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).BeginInit();
            this.groupBoxExceptions.SuspendLayout();
            this.jobTabControl.SuspendLayout();
            this.exportJobOverviewTabPage.SuspendLayout();
            this.jobIdentificationGroupBox.SuspendLayout();
            this.jobControlGroupBox.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.foldersGroupBox.SuspendLayout();
            this.exportJobDetailsTabPage.SuspendLayout();
            this.exportDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenStatusCheckNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenAttemptsNumericUpDown)).BeginInit();
            this.sourceCompanyGroupBox.SuspendLayout();
            this.exportJobRecurrenceTabPage.SuspendLayout();
            this.triggerTypePanel.SuspendLayout();
            this.simpleTriggerJobGroupBox.SuspendLayout();
            this.cronTriggerGroupBox.SuspendLayout();
            this.connectionTabPage.SuspendLayout();
            this.axDetailsGroupBox.SuspendLayout();
            this.authMethodPanel.SuspendLayout();
            this.customOdataTabPage.SuspendLayout();
            this.customODataGroupBox.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // useStandardSubfolder
            // 
            this.useStandardSubfolder.AutoSize = true;
            this.useStandardSubfolder.Checked = true;
            this.useStandardSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useStandardSubfolder.Location = new System.Drawing.Point(9, 137);
            this.useStandardSubfolder.Margin = new System.Windows.Forms.Padding(6);
            this.useStandardSubfolder.Name = "useStandardSubfolder";
            this.useStandardSubfolder.Size = new System.Drawing.Size(253, 29);
            this.useStandardSubfolder.TabIndex = 6;
            this.useStandardSubfolder.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Use_default_folder_names;
            this.useStandardSubfolder.UseVisualStyleBackColor = true;
            this.useStandardSubfolder.CheckedChanged += new System.EventHandler(this.UseStandardSubfolder_CheckedChanged);
            // 
            // errorsFolderBrowserButton
            // 
            this.errorsFolderBrowserButton.Enabled = false;
            this.errorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.errorsFolderBrowserButton.Location = new System.Drawing.Point(358, 201);
            this.errorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.errorsFolderBrowserButton.Name = "errorsFolderBrowserButton";
            this.errorsFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.errorsFolderBrowserButton.TabIndex = 8;
            this.errorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.errorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.errorsFolderBrowserButton.Click += new System.EventHandler(this.ErrorsFolderBrowserButton_Click);
            // 
            // errorsFolder
            // 
            this.errorsFolder.Enabled = false;
            this.errorsFolder.Location = new System.Drawing.Point(9, 209);
            this.errorsFolder.Margin = new System.Windows.Forms.Padding(6);
            this.errorsFolder.Name = "errorsFolder";
            this.errorsFolder.Size = new System.Drawing.Size(340, 29);
            this.errorsFolder.TabIndex = 7;
            // 
            // errorsFolderLabel
            // 
            this.errorsFolderLabel.AutoSize = true;
            this.errorsFolderLabel.Location = new System.Drawing.Point(6, 175);
            this.errorsFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorsFolderLabel.Name = "errorsFolderLabel";
            this.errorsFolderLabel.Size = new System.Drawing.Size(117, 25);
            this.errorsFolderLabel.TabIndex = 11;
            this.errorsFolderLabel.Text = "Errors folder";
            // 
            // downloadFolderBrowserButton
            // 
            this.downloadFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.downloadFolderBrowserButton.Location = new System.Drawing.Point(358, 90);
            this.downloadFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.downloadFolderBrowserButton.Name = "downloadFolderBrowserButton";
            this.downloadFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.downloadFolderBrowserButton.TabIndex = 5;
            this.downloadFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.downloadFolderBrowserButton.UseVisualStyleBackColor = true;
            this.downloadFolderBrowserButton.Click += new System.EventHandler(this.DownloadFolderBrowserButton_Click);
            // 
            // downloadFolder
            // 
            this.downloadFolder.Location = new System.Drawing.Point(9, 96);
            this.downloadFolder.Margin = new System.Windows.Forms.Padding(6);
            this.downloadFolder.Name = "downloadFolder";
            this.downloadFolder.Size = new System.Drawing.Size(340, 29);
            this.downloadFolder.TabIndex = 4;
            this.downloadFolder.TextChanged += new System.EventHandler(this.DownloadFolder_TextChanged);
            // 
            // downloadFolderLabel
            // 
            this.downloadFolderLabel.AutoSize = true;
            this.downloadFolderLabel.Location = new System.Drawing.Point(6, 63);
            this.downloadFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.downloadFolderLabel.Name = "downloadFolderLabel";
            this.downloadFolderLabel.Size = new System.Drawing.Size(152, 25);
            this.downloadFolderLabel.TabIndex = 8;
            this.downloadFolderLabel.Text = "Download folder";
            // 
            // jobDescription
            // 
            this.jobDescription.Location = new System.Drawing.Point(13, 198);
            this.jobDescription.Margin = new System.Windows.Forms.Padding(6);
            this.jobDescription.Multiline = true;
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.Size = new System.Drawing.Size(371, 161);
            this.jobDescription.TabIndex = 3;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(7, 166);
            this.jobDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(231, 25);
            this.jobDescriptionLabel.TabIndex = 4;
            this.jobDescriptionLabel.Text = "Job description (optional)";
            // 
            // jobGroupComboBox
            // 
            this.jobGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobGroupComboBox.FormattingEnabled = true;
            this.jobGroupComboBox.Location = new System.Drawing.Point(149, 105);
            this.jobGroupComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.jobGroupComboBox.Name = "jobGroupComboBox";
            this.jobGroupComboBox.Size = new System.Drawing.Size(235, 32);
            this.jobGroupComboBox.Sorted = true;
            this.jobGroupComboBox.TabIndex = 2;
            // 
            // jobGroupLabel
            // 
            this.jobGroupLabel.AutoSize = true;
            this.jobGroupLabel.Location = new System.Drawing.Point(7, 111);
            this.jobGroupLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobGroupLabel.Name = "jobGroupLabel";
            this.jobGroupLabel.Size = new System.Drawing.Size(130, 25);
            this.jobGroupLabel.TabIndex = 2;
            this.jobGroupLabel.Text = "RIS job group";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(149, 57);
            this.jobName.Margin = new System.Windows.Forms.Padding(6);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(235, 29);
            this.jobName.TabIndex = 1;
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Location = new System.Drawing.Point(7, 63);
            this.jobNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(129, 25);
            this.jobNameLabel.TabIndex = 0;
            this.jobNameLabel.Text = "RIS job name";
            // 
            // retryPolicyGroupBox
            // 
            this.retryPolicyGroupBox.Controls.Add(this.retriesLabel);
            this.retryPolicyGroupBox.Controls.Add(this.retriesCountUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.delayLabel);
            this.retryPolicyGroupBox.Controls.Add(this.retriesDelayUpDown);
            this.retryPolicyGroupBox.Location = new System.Drawing.Point(13, 41);
            this.retryPolicyGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.retryPolicyGroupBox.Name = "retryPolicyGroupBox";
            this.retryPolicyGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.retryPolicyGroupBox.Size = new System.Drawing.Size(370, 124);
            this.retryPolicyGroupBox.TabIndex = 7;
            this.retryPolicyGroupBox.TabStop = false;
            this.retryPolicyGroupBox.Text = "Retry policy";
            // 
            // retriesLabel
            // 
            this.retriesLabel.AutoSize = true;
            this.retriesLabel.Location = new System.Drawing.Point(13, 37);
            this.retriesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.retriesLabel.Name = "retriesLabel";
            this.retriesLabel.Size = new System.Drawing.Size(160, 25);
            this.retriesLabel.TabIndex = 0;
            this.retriesLabel.Text = "Number of retries";
            // 
            // retriesCountUpDown
            // 
            this.retriesCountUpDown.Location = new System.Drawing.Point(191, 28);
            this.retriesCountUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.retriesCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.retriesCountUpDown.Name = "retriesCountUpDown";
            this.retriesCountUpDown.Size = new System.Drawing.Size(88, 29);
            this.retriesCountUpDown.TabIndex = 6;
            this.retriesCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(13, 81);
            this.delayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(155, 25);
            this.delayLabel.TabIndex = 2;
            this.delayLabel.Text = "Delay (seconds)";
            // 
            // retriesDelayUpDown
            // 
            this.retriesDelayUpDown.Location = new System.Drawing.Point(191, 72);
            this.retriesDelayUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.retriesDelayUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.retriesDelayUpDown.Name = "retriesDelayUpDown";
            this.retriesDelayUpDown.Size = new System.Drawing.Size(88, 29);
            this.retriesDelayUpDown.TabIndex = 7;
            this.retriesDelayUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBoxExceptions
            // 
            this.groupBoxExceptions.Controls.Add(this.pauseOnExceptionsCheckBox);
            this.groupBoxExceptions.Location = new System.Drawing.Point(13, 175);
            this.groupBoxExceptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExceptions.Name = "groupBoxExceptions";
            this.groupBoxExceptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxExceptions.Size = new System.Drawing.Size(370, 74);
            this.groupBoxExceptions.TabIndex = 10;
            this.groupBoxExceptions.TabStop = false;
            this.groupBoxExceptions.Text = "Exceptions";
            // 
            // pauseOnExceptionsCheckBox
            // 
            this.pauseOnExceptionsCheckBox.AutoSize = true;
            this.pauseOnExceptionsCheckBox.Checked = true;
            this.pauseOnExceptionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pauseOnExceptionsCheckBox.Location = new System.Drawing.Point(17, 31);
            this.pauseOnExceptionsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.pauseOnExceptionsCheckBox.Name = "pauseOnExceptionsCheckBox";
            this.pauseOnExceptionsCheckBox.Size = new System.Drawing.Size(329, 29);
            this.pauseOnExceptionsCheckBox.TabIndex = 0;
            this.pauseOnExceptionsCheckBox.Text = "Pause job when exception occurs";
            this.pauseOnExceptionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // jobTabControl
            // 
            this.jobTabControl.Controls.Add(this.exportJobOverviewTabPage);
            this.jobTabControl.Controls.Add(this.exportJobDetailsTabPage);
            this.jobTabControl.Controls.Add(this.exportJobRecurrenceTabPage);
            this.jobTabControl.Controls.Add(this.connectionTabPage);
            this.jobTabControl.Controls.Add(this.customOdataTabPage);
            this.jobTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobTabControl.Location = new System.Drawing.Point(0, 0);
            this.jobTabControl.Margin = new System.Windows.Forms.Padding(6);
            this.jobTabControl.Name = "jobTabControl";
            this.jobTabControl.SelectedIndex = 0;
            this.jobTabControl.Size = new System.Drawing.Size(1294, 876);
            this.jobTabControl.TabIndex = 12;
            // 
            // exportJobOverviewTabPage
            // 
            this.exportJobOverviewTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.exportJobOverviewTabPage.Controls.Add(this.jobIdentificationGroupBox);
            this.exportJobOverviewTabPage.Controls.Add(this.jobControlGroupBox);
            this.exportJobOverviewTabPage.Controls.Add(this.foldersGroupBox);
            this.exportJobOverviewTabPage.Location = new System.Drawing.Point(4, 33);
            this.exportJobOverviewTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.exportJobOverviewTabPage.Name = "exportJobOverviewTabPage";
            this.exportJobOverviewTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.exportJobOverviewTabPage.Size = new System.Drawing.Size(1286, 839);
            this.exportJobOverviewTabPage.TabIndex = 0;
            this.exportJobOverviewTabPage.Text = "Export job overview";
            // 
            // jobIdentificationGroupBox
            // 
            this.jobIdentificationGroupBox.Controls.Add(this.jobNameLabel);
            this.jobIdentificationGroupBox.Controls.Add(this.jobName);
            this.jobIdentificationGroupBox.Controls.Add(this.jobGroupLabel);
            this.jobIdentificationGroupBox.Controls.Add(this.jobGroupComboBox);
            this.jobIdentificationGroupBox.Controls.Add(this.jobDescriptionLabel);
            this.jobIdentificationGroupBox.Controls.Add(this.jobDescription);
            this.jobIdentificationGroupBox.Location = new System.Drawing.Point(7, 7);
            this.jobIdentificationGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.jobIdentificationGroupBox.Name = "jobIdentificationGroupBox";
            this.jobIdentificationGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.jobIdentificationGroupBox.Size = new System.Drawing.Size(392, 375);
            this.jobIdentificationGroupBox.TabIndex = 11;
            this.jobIdentificationGroupBox.TabStop = false;
            this.jobIdentificationGroupBox.Text = "Job identification";
            // 
            // jobControlGroupBox
            // 
            this.jobControlGroupBox.Controls.Add(this.groupBoxLogging);
            this.jobControlGroupBox.Controls.Add(this.retryPolicyGroupBox);
            this.jobControlGroupBox.Controls.Add(this.groupBoxExceptions);
            this.jobControlGroupBox.Controls.Add(this.pauseIndefinitelyCheckBox);
            this.jobControlGroupBox.Location = new System.Drawing.Point(7, 390);
            this.jobControlGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.jobControlGroupBox.Name = "jobControlGroupBox";
            this.jobControlGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.jobControlGroupBox.Size = new System.Drawing.Size(392, 382);
            this.jobControlGroupBox.TabIndex = 13;
            this.jobControlGroupBox.TabStop = false;
            this.jobControlGroupBox.Text = "Job control";
            // 
            // groupBoxLogging
            // 
            this.groupBoxLogging.Controls.Add(this.verboseLoggingCheckBox);
            this.groupBoxLogging.Location = new System.Drawing.Point(13, 257);
            this.groupBoxLogging.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogging.Name = "groupBoxLogging";
            this.groupBoxLogging.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogging.Size = new System.Drawing.Size(370, 74);
            this.groupBoxLogging.TabIndex = 13;
            this.groupBoxLogging.TabStop = false;
            this.groupBoxLogging.Text = "Verbose logging";
            // 
            // verboseLoggingCheckBox
            // 
            this.verboseLoggingCheckBox.AutoSize = true;
            this.verboseLoggingCheckBox.Location = new System.Drawing.Point(17, 31);
            this.verboseLoggingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.verboseLoggingCheckBox.Name = "verboseLoggingCheckBox";
            this.verboseLoggingCheckBox.Size = new System.Drawing.Size(216, 29);
            this.verboseLoggingCheckBox.TabIndex = 0;
            this.verboseLoggingCheckBox.Text = "Use verbose logging";
            this.verboseLoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // pauseIndefinitelyCheckBox
            // 
            this.pauseIndefinitelyCheckBox.AutoSize = true;
            this.pauseIndefinitelyCheckBox.Location = new System.Drawing.Point(13, 345);
            this.pauseIndefinitelyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.pauseIndefinitelyCheckBox.Name = "pauseIndefinitelyCheckBox";
            this.pauseIndefinitelyCheckBox.Size = new System.Drawing.Size(357, 29);
            this.pauseIndefinitelyCheckBox.TabIndex = 14;
            this.pauseIndefinitelyCheckBox.Text = "Don\'t execute the job. Always pause.";
            this.pauseIndefinitelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // foldersGroupBox
            // 
            this.foldersGroupBox.Controls.Add(this.downloadFolderLabel);
            this.foldersGroupBox.Controls.Add(this.downloadFolder);
            this.foldersGroupBox.Controls.Add(this.downloadFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.useStandardSubfolder);
            this.foldersGroupBox.Controls.Add(this.errorsFolderLabel);
            this.foldersGroupBox.Controls.Add(this.errorsFolder);
            this.foldersGroupBox.Controls.Add(this.errorsFolderBrowserButton);
            this.foldersGroupBox.Location = new System.Drawing.Point(409, 7);
            this.foldersGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.foldersGroupBox.Name = "foldersGroupBox";
            this.foldersGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.foldersGroupBox.Size = new System.Drawing.Size(409, 266);
            this.foldersGroupBox.TabIndex = 12;
            this.foldersGroupBox.TabStop = false;
            this.foldersGroupBox.Text = "Folders";
            // 
            // exportJobDetailsTabPage
            // 
            this.exportJobDetailsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.exportJobDetailsTabPage.Controls.Add(this.exportDetailsGroupBox);
            this.exportJobDetailsTabPage.Controls.Add(this.sourceCompanyGroupBox);
            this.exportJobDetailsTabPage.Location = new System.Drawing.Point(4, 33);
            this.exportJobDetailsTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.exportJobDetailsTabPage.Name = "exportJobDetailsTabPage";
            this.exportJobDetailsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.exportJobDetailsTabPage.Size = new System.Drawing.Size(1301, 789);
            this.exportJobDetailsTabPage.TabIndex = 1;
            this.exportJobDetailsTabPage.Text = "Export job details";
            // 
            // exportDetailsGroupBox
            // 
            this.exportDetailsGroupBox.Controls.Add(this.dataProjectLabel);
            this.exportDetailsGroupBox.Controls.Add(this.dataProject);
            this.exportDetailsGroupBox.Controls.Add(this.unzipCheckBox);
            this.exportDetailsGroupBox.Controls.Add(this.addTimestampCheckBox);
            this.exportDetailsGroupBox.Controls.Add(this.deletePackageCheckBox);
            this.exportDetailsGroupBox.Controls.Add(this.delayBetweenStatusCheckLabel);
            this.exportDetailsGroupBox.Controls.Add(this.delayBetweenStatusCheckNumericUpDown);
            this.exportDetailsGroupBox.Controls.Add(this.delayBetweenAttemptsLabel);
            this.exportDetailsGroupBox.Controls.Add(this.delayBetweenAttemptsNumericUpDown);
            this.exportDetailsGroupBox.Location = new System.Drawing.Point(7, 7);
            this.exportDetailsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.exportDetailsGroupBox.Name = "exportDetailsGroupBox";
            this.exportDetailsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.exportDetailsGroupBox.Size = new System.Drawing.Size(422, 401);
            this.exportDetailsGroupBox.TabIndex = 1;
            this.exportDetailsGroupBox.TabStop = false;
            this.exportDetailsGroupBox.Text = "Job details";
            // 
            // dataProjectLabel
            // 
            this.dataProjectLabel.AutoSize = true;
            this.dataProjectLabel.Location = new System.Drawing.Point(7, 37);
            this.dataProjectLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dataProjectLabel.Name = "dataProjectLabel";
            this.dataProjectLabel.Size = new System.Drawing.Size(116, 25);
            this.dataProjectLabel.TabIndex = 16;
            this.dataProjectLabel.Text = "Data project";
            // 
            // dataProject
            // 
            this.dataProject.Location = new System.Drawing.Point(13, 72);
            this.dataProject.Margin = new System.Windows.Forms.Padding(6);
            this.dataProject.Name = "dataProject";
            this.dataProject.Size = new System.Drawing.Size(387, 29);
            this.dataProject.TabIndex = 12;
            // 
            // unzipCheckBox
            // 
            this.unzipCheckBox.AutoSize = true;
            this.unzipCheckBox.Location = new System.Drawing.Point(13, 120);
            this.unzipCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unzipCheckBox.Name = "unzipCheckBox";
            this.unzipCheckBox.Size = new System.Drawing.Size(197, 29);
            this.unzipCheckBox.TabIndex = 9;
            this.unzipCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Unzip_package_file;
            this.unzipCheckBox.UseVisualStyleBackColor = true;
            this.unzipCheckBox.CheckedChanged += new System.EventHandler(this.UnzipCheckBox_CheckedChanged);
            // 
            // addTimestampCheckBox
            // 
            this.addTimestampCheckBox.AutoSize = true;
            this.addTimestampCheckBox.Enabled = false;
            this.addTimestampCheckBox.Location = new System.Drawing.Point(13, 162);
            this.addTimestampCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addTimestampCheckBox.Name = "addTimestampCheckBox";
            this.addTimestampCheckBox.Size = new System.Drawing.Size(315, 29);
            this.addTimestampCheckBox.TabIndex = 10;
            this.addTimestampCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Make_exported_file_name_unique;
            this.addTimestampCheckBox.UseVisualStyleBackColor = true;
            // 
            // deletePackageCheckBox
            // 
            this.deletePackageCheckBox.AutoSize = true;
            this.deletePackageCheckBox.Enabled = false;
            this.deletePackageCheckBox.Location = new System.Drawing.Point(13, 205);
            this.deletePackageCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deletePackageCheckBox.Name = "deletePackageCheckBox";
            this.deletePackageCheckBox.Size = new System.Drawing.Size(203, 29);
            this.deletePackageCheckBox.TabIndex = 11;
            this.deletePackageCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete_package_file;
            this.deletePackageCheckBox.UseVisualStyleBackColor = true;
            // 
            // delayBetweenStatusCheckLabel
            // 
            this.delayBetweenStatusCheckLabel.AutoSize = true;
            this.delayBetweenStatusCheckLabel.Location = new System.Drawing.Point(11, 257);
            this.delayBetweenStatusCheckLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.delayBetweenStatusCheckLabel.Name = "delayBetweenStatusCheckLabel";
            this.delayBetweenStatusCheckLabel.Size = new System.Drawing.Size(305, 25);
            this.delayBetweenStatusCheckLabel.TabIndex = 20;
            this.delayBetweenStatusCheckLabel.Text = "Delay between status check (sec)";
            // 
            // delayBetweenStatusCheckNumericUpDown
            // 
            this.delayBetweenStatusCheckNumericUpDown.Location = new System.Drawing.Point(328, 253);
            this.delayBetweenStatusCheckNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.delayBetweenStatusCheckNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.delayBetweenStatusCheckNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.delayBetweenStatusCheckNumericUpDown.Name = "delayBetweenStatusCheckNumericUpDown";
            this.delayBetweenStatusCheckNumericUpDown.Size = new System.Drawing.Size(75, 29);
            this.delayBetweenStatusCheckNumericUpDown.TabIndex = 14;
            this.delayBetweenStatusCheckNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // delayBetweenAttemptsLabel
            // 
            this.delayBetweenAttemptsLabel.Location = new System.Drawing.Point(11, 312);
            this.delayBetweenAttemptsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.delayBetweenAttemptsLabel.Name = "delayBetweenAttemptsLabel";
            this.delayBetweenAttemptsLabel.Size = new System.Drawing.Size(273, 78);
            this.delayBetweenAttemptsLabel.TabIndex = 24;
            this.delayBetweenAttemptsLabel.Text = "Delay between attempts to download exported package (seconds)";
            // 
            // delayBetweenAttemptsNumericUpDown
            // 
            this.delayBetweenAttemptsNumericUpDown.Location = new System.Drawing.Point(328, 336);
            this.delayBetweenAttemptsNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.delayBetweenAttemptsNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.delayBetweenAttemptsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayBetweenAttemptsNumericUpDown.Name = "delayBetweenAttemptsNumericUpDown";
            this.delayBetweenAttemptsNumericUpDown.Size = new System.Drawing.Size(75, 29);
            this.delayBetweenAttemptsNumericUpDown.TabIndex = 23;
            this.delayBetweenAttemptsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sourceCompanyGroupBox
            // 
            this.sourceCompanyGroupBox.Controls.Add(this.legalEntityLabel);
            this.sourceCompanyGroupBox.Controls.Add(this.legalEntity);
            this.sourceCompanyGroupBox.Location = new System.Drawing.Point(7, 419);
            this.sourceCompanyGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.sourceCompanyGroupBox.Name = "sourceCompanyGroupBox";
            this.sourceCompanyGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.sourceCompanyGroupBox.Size = new System.Drawing.Size(422, 109);
            this.sourceCompanyGroupBox.TabIndex = 23;
            this.sourceCompanyGroupBox.TabStop = false;
            this.sourceCompanyGroupBox.Text = "Source company";
            // 
            // legalEntityLabel
            // 
            this.legalEntityLabel.AutoSize = true;
            this.legalEntityLabel.Location = new System.Drawing.Point(9, 61);
            this.legalEntityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.legalEntityLabel.Name = "legalEntityLabel";
            this.legalEntityLabel.Size = new System.Drawing.Size(215, 25);
            this.legalEntityLabel.TabIndex = 22;
            this.legalEntityLabel.Text = "Legal entity DataAreaId";
            // 
            // legalEntity
            // 
            this.legalEntity.Location = new System.Drawing.Point(237, 55);
            this.legalEntity.Margin = new System.Windows.Forms.Padding(6);
            this.legalEntity.Name = "legalEntity";
            this.legalEntity.Size = new System.Drawing.Size(164, 29);
            this.legalEntity.TabIndex = 13;
            // 
            // exportJobRecurrenceTabPage
            // 
            this.exportJobRecurrenceTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.exportJobRecurrenceTabPage.Controls.Add(this.triggerTypePanel);
            this.exportJobRecurrenceTabPage.Controls.Add(this.simpleTriggerJobGroupBox);
            this.exportJobRecurrenceTabPage.Controls.Add(this.cronTriggerGroupBox);
            this.exportJobRecurrenceTabPage.Location = new System.Drawing.Point(4, 33);
            this.exportJobRecurrenceTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.exportJobRecurrenceTabPage.Name = "exportJobRecurrenceTabPage";
            this.exportJobRecurrenceTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.exportJobRecurrenceTabPage.Size = new System.Drawing.Size(1286, 839);
            this.exportJobRecurrenceTabPage.TabIndex = 2;
            this.exportJobRecurrenceTabPage.Text = "Export job recurrence";
            // 
            // triggerTypePanel
            // 
            this.triggerTypePanel.Controls.Add(this.simpleTriggerRadioButton);
            this.triggerTypePanel.Controls.Add(this.cronTriggerRadioButton);
            this.triggerTypePanel.Location = new System.Drawing.Point(9, 9);
            this.triggerTypePanel.Margin = new System.Windows.Forms.Padding(6);
            this.triggerTypePanel.Name = "triggerTypePanel";
            this.triggerTypePanel.Size = new System.Drawing.Size(838, 46);
            this.triggerTypePanel.TabIndex = 29;
            // 
            // simpleTriggerRadioButton
            // 
            this.simpleTriggerRadioButton.AutoSize = true;
            this.simpleTriggerRadioButton.Checked = true;
            this.simpleTriggerRadioButton.Location = new System.Drawing.Point(11, 6);
            this.simpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.simpleTriggerRadioButton.Name = "simpleTriggerRadioButton";
            this.simpleTriggerRadioButton.Size = new System.Drawing.Size(156, 29);
            this.simpleTriggerRadioButton.TabIndex = 22;
            this.simpleTriggerRadioButton.TabStop = true;
            this.simpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.simpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // cronTriggerRadioButton
            // 
            this.cronTriggerRadioButton.AutoSize = true;
            this.cronTriggerRadioButton.Location = new System.Drawing.Point(425, 6);
            this.cronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.cronTriggerRadioButton.Name = "cronTriggerRadioButton";
            this.cronTriggerRadioButton.Size = new System.Drawing.Size(139, 29);
            this.cronTriggerRadioButton.TabIndex = 23;
            this.cronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.cronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.cronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.CronTriggerRadioButton_CheckedChanged);
            // 
            // simpleTriggerJobGroupBox
            // 
            this.simpleTriggerJobGroupBox.Controls.Add(this.runEveryLabel);
            this.simpleTriggerJobGroupBox.Controls.Add(this.hoursDateTimePicker);
            this.simpleTriggerJobGroupBox.Controls.Add(this.hoursLabel);
            this.simpleTriggerJobGroupBox.Controls.Add(this.andOrLabel);
            this.simpleTriggerJobGroupBox.Controls.Add(this.minutesDateTimePicker);
            this.simpleTriggerJobGroupBox.Controls.Add(this.minutesLabel);
            this.simpleTriggerJobGroupBox.Controls.Add(this.startAtLabel);
            this.simpleTriggerJobGroupBox.Controls.Add(this.startAtDateTimePicker);
            this.simpleTriggerJobGroupBox.Location = new System.Drawing.Point(9, 65);
            this.simpleTriggerJobGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.simpleTriggerJobGroupBox.Name = "simpleTriggerJobGroupBox";
            this.simpleTriggerJobGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.simpleTriggerJobGroupBox.Size = new System.Drawing.Size(403, 155);
            this.simpleTriggerJobGroupBox.TabIndex = 30;
            this.simpleTriggerJobGroupBox.TabStop = false;
            // 
            // runEveryLabel
            // 
            this.runEveryLabel.AutoSize = true;
            this.runEveryLabel.Location = new System.Drawing.Point(6, 26);
            this.runEveryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.runEveryLabel.Name = "runEveryLabel";
            this.runEveryLabel.Size = new System.Drawing.Size(146, 25);
            this.runEveryLabel.TabIndex = 22;
            this.runEveryLabel.Text = "Run job every...";
            // 
            // hoursDateTimePicker
            // 
            this.hoursDateTimePicker.CustomFormat = "HH";
            this.hoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hoursDateTimePicker.Location = new System.Drawing.Point(160, 18);
            this.hoursDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.hoursDateTimePicker.Name = "hoursDateTimePicker";
            this.hoursDateTimePicker.ShowUpDown = true;
            this.hoursDateTimePicker.Size = new System.Drawing.Size(76, 29);
            this.hoursDateTimePicker.TabIndex = 19;
            this.hoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(240, 26);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(75, 25);
            this.hoursLabel.TabIndex = 4;
            this.hoursLabel.Text = "hour(s)";
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // andOrLabel
            // 
            this.andOrLabel.AutoSize = true;
            this.andOrLabel.Location = new System.Drawing.Point(84, 66);
            this.andOrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.andOrLabel.Name = "andOrLabel";
            this.andOrLabel.Size = new System.Drawing.Size(68, 25);
            this.andOrLabel.TabIndex = 31;
            this.andOrLabel.Text = "and/or";
            // 
            // minutesDateTimePicker
            // 
            this.minutesDateTimePicker.CustomFormat = "mm";
            this.minutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.minutesDateTimePicker.Location = new System.Drawing.Point(160, 59);
            this.minutesDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.minutesDateTimePicker.Name = "minutesDateTimePicker";
            this.minutesDateTimePicker.ShowUpDown = true;
            this.minutesDateTimePicker.Size = new System.Drawing.Size(76, 29);
            this.minutesDateTimePicker.TabIndex = 20;
            this.minutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 1, 0, 0);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(240, 66);
            this.minutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(94, 25);
            this.minutesLabel.TabIndex = 5;
            this.minutesLabel.Text = "minute(s)";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // startAtLabel
            // 
            this.startAtLabel.AutoSize = true;
            this.startAtLabel.Location = new System.Drawing.Point(51, 105);
            this.startAtLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startAtLabel.Name = "startAtLabel";
            this.startAtLabel.Size = new System.Drawing.Size(96, 25);
            this.startAtLabel.TabIndex = 3;
            this.startAtLabel.Text = "starting at";
            this.startAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // startAtDateTimePicker
            // 
            this.startAtDateTimePicker.CustomFormat = "HH:mm:ss";
            this.startAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startAtDateTimePicker.Location = new System.Drawing.Point(160, 100);
            this.startAtDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.startAtDateTimePicker.Name = "startAtDateTimePicker";
            this.startAtDateTimePicker.ShowUpDown = true;
            this.startAtDateTimePicker.Size = new System.Drawing.Size(130, 29);
            this.startAtDateTimePicker.TabIndex = 21;
            this.startAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // cronTriggerGroupBox
            // 
            this.cronTriggerGroupBox.Controls.Add(this.cronExpressionLabel);
            this.cronTriggerGroupBox.Controls.Add(this.cronExpressionTextBox);
            this.cronTriggerGroupBox.Controls.Add(this.cronTriggerInfoTextBox);
            this.cronTriggerGroupBox.Controls.Add(this.buildCronLabel);
            this.cronTriggerGroupBox.Controls.Add(this.cronmakerLinkLabel);
            this.cronTriggerGroupBox.Controls.Add(this.cronDocsLinkLabel);
            this.cronTriggerGroupBox.Controls.Add(this.calculateNextRunsButton);
            this.cronTriggerGroupBox.Controls.Add(this.calculatedRunsTextBox);
            this.cronTriggerGroupBox.Controls.Add(this.moreExamplesButton);
            this.cronTriggerGroupBox.Enabled = false;
            this.cronTriggerGroupBox.Location = new System.Drawing.Point(420, 65);
            this.cronTriggerGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.cronTriggerGroupBox.Name = "cronTriggerGroupBox";
            this.cronTriggerGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.cronTriggerGroupBox.Size = new System.Drawing.Size(429, 633);
            this.cronTriggerGroupBox.TabIndex = 3;
            this.cronTriggerGroupBox.TabStop = false;
            // 
            // cronExpressionLabel
            // 
            this.cronExpressionLabel.AutoSize = true;
            this.cronExpressionLabel.Location = new System.Drawing.Point(11, 26);
            this.cronExpressionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cronExpressionLabel.Name = "cronExpressionLabel";
            this.cronExpressionLabel.Size = new System.Drawing.Size(155, 25);
            this.cronExpressionLabel.TabIndex = 23;
            this.cronExpressionLabel.Text = "Cron expression";
            // 
            // cronExpressionTextBox
            // 
            this.cronExpressionTextBox.Location = new System.Drawing.Point(17, 54);
            this.cronExpressionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.cronExpressionTextBox.Name = "cronExpressionTextBox";
            this.cronExpressionTextBox.Size = new System.Drawing.Size(391, 29);
            this.cronExpressionTextBox.TabIndex = 24;
            this.cronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // cronTriggerInfoTextBox
            // 
            this.cronTriggerInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cronTriggerInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cronTriggerInfoTextBox.Location = new System.Drawing.Point(17, 94);
            this.cronTriggerInfoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.cronTriggerInfoTextBox.Multiline = true;
            this.cronTriggerInfoTextBox.Name = "cronTriggerInfoTextBox";
            this.cronTriggerInfoTextBox.Size = new System.Drawing.Size(394, 271);
            this.cronTriggerInfoTextBox.TabIndex = 25;
            this.cronTriggerInfoTextBox.TabStop = false;
            this.cronTriggerInfoTextBox.Text = resources.GetString("cronTriggerInfoTextBox.Text");
            // 
            // buildCronLabel
            // 
            this.buildCronLabel.AutoSize = true;
            this.buildCronLabel.Location = new System.Drawing.Point(11, 371);
            this.buildCronLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buildCronLabel.Name = "buildCronLabel";
            this.buildCronLabel.Size = new System.Drawing.Size(219, 25);
            this.buildCronLabel.TabIndex = 26;
            this.buildCronLabel.Text = "Build cron expression at";
            // 
            // cronmakerLinkLabel
            // 
            this.cronmakerLinkLabel.AutoSize = true;
            this.cronmakerLinkLabel.Location = new System.Drawing.Point(231, 371);
            this.cronmakerLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cronmakerLinkLabel.Name = "cronmakerLinkLabel";
            this.cronmakerLinkLabel.Size = new System.Drawing.Size(146, 25);
            this.cronmakerLinkLabel.TabIndex = 24;
            this.cronmakerLinkLabel.TabStop = true;
            this.cronmakerLinkLabel.Text = "cronmaker.com";
            this.cronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // cronDocsLinkLabel
            // 
            this.cronDocsLinkLabel.AutoSize = true;
            this.cronDocsLinkLabel.Location = new System.Drawing.Point(11, 406);
            this.cronDocsLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cronDocsLinkLabel.Name = "cronDocsLinkLabel";
            this.cronDocsLinkLabel.Size = new System.Drawing.Size(316, 25);
            this.cronDocsLinkLabel.TabIndex = 30;
            this.cronDocsLinkLabel.TabStop = true;
            this.cronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.cronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // calculateNextRunsButton
            // 
            this.calculateNextRunsButton.Location = new System.Drawing.Point(17, 443);
            this.calculateNextRunsButton.Margin = new System.Windows.Forms.Padding(6);
            this.calculateNextRunsButton.Name = "calculateNextRunsButton";
            this.calculateNextRunsButton.Size = new System.Drawing.Size(193, 66);
            this.calculateNextRunsButton.TabIndex = 25;
            this.calculateNextRunsButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Calculate_next_100_runs_of_cron_trigger;
            this.calculateNextRunsButton.UseVisualStyleBackColor = true;
            this.calculateNextRunsButton.Click += new System.EventHandler(this.CalculateNextRunsButton_Click);
            // 
            // calculatedRunsTextBox
            // 
            this.calculatedRunsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsTextBox.Location = new System.Drawing.Point(17, 517);
            this.calculatedRunsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.calculatedRunsTextBox.Multiline = true;
            this.calculatedRunsTextBox.Name = "calculatedRunsTextBox";
            this.calculatedRunsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsTextBox.Size = new System.Drawing.Size(263, 98);
            this.calculatedRunsTextBox.TabIndex = 26;
            this.calculatedRunsTextBox.TabStop = false;
            // 
            // moreExamplesButton
            // 
            this.moreExamplesButton.Location = new System.Drawing.Point(290, 517);
            this.moreExamplesButton.Margin = new System.Windows.Forms.Padding(6);
            this.moreExamplesButton.Name = "moreExamplesButton";
            this.moreExamplesButton.Size = new System.Drawing.Size(121, 102);
            this.moreExamplesButton.TabIndex = 27;
            this.moreExamplesButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesButton.UseVisualStyleBackColor = true;
            this.moreExamplesButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
            // 
            // connectionTabPage
            // 
            this.connectionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.connectionTabPage.Controls.Add(this.axDetailsGroupBox);
            this.connectionTabPage.Location = new System.Drawing.Point(4, 33);
            this.connectionTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.connectionTabPage.Name = "connectionTabPage";
            this.connectionTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.connectionTabPage.Size = new System.Drawing.Size(1301, 789);
            this.connectionTabPage.TabIndex = 3;
            this.connectionTabPage.Text = "Connection";
            // 
            // axDetailsGroupBox
            // 
            this.axDetailsGroupBox.Controls.Add(this.instanceLabel);
            this.axDetailsGroupBox.Controls.Add(this.instanceComboBox);
            this.axDetailsGroupBox.Controls.Add(this.authMethodPanel);
            this.axDetailsGroupBox.Controls.Add(this.aadApplicationLabel);
            this.axDetailsGroupBox.Controls.Add(this.appRegistrationComboBox);
            this.axDetailsGroupBox.Controls.Add(this.userLabel);
            this.axDetailsGroupBox.Controls.Add(this.userComboBox);
            this.axDetailsGroupBox.Location = new System.Drawing.Point(7, 7);
            this.axDetailsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.axDetailsGroupBox.Name = "axDetailsGroupBox";
            this.axDetailsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.axDetailsGroupBox.Size = new System.Drawing.Size(484, 242);
            this.axDetailsGroupBox.TabIndex = 2;
            this.axDetailsGroupBox.TabStop = false;
            this.axDetailsGroupBox.Text = "Dynamics connection details";
            // 
            // instanceLabel
            // 
            this.instanceLabel.AutoSize = true;
            this.instanceLabel.Location = new System.Drawing.Point(13, 39);
            this.instanceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.instanceLabel.Name = "instanceLabel";
            this.instanceLabel.Size = new System.Drawing.Size(86, 25);
            this.instanceLabel.TabIndex = 16;
            this.instanceLabel.Text = "Instance";
            // 
            // instanceComboBox
            // 
            this.instanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceComboBox.FormattingEnabled = true;
            this.instanceComboBox.Location = new System.Drawing.Point(108, 35);
            this.instanceComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.instanceComboBox.Name = "instanceComboBox";
            this.instanceComboBox.Size = new System.Drawing.Size(365, 32);
            this.instanceComboBox.TabIndex = 14;
            // 
            // authMethodPanel
            // 
            this.authMethodPanel.Controls.Add(this.userAuthRadioButton);
            this.authMethodPanel.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodPanel.Location = new System.Drawing.Point(13, 83);
            this.authMethodPanel.Margin = new System.Windows.Forms.Padding(6);
            this.authMethodPanel.Name = "authMethodPanel";
            this.authMethodPanel.Size = new System.Drawing.Size(464, 46);
            this.authMethodPanel.TabIndex = 31;
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(6, 6);
            this.userAuthRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(204, 29);
            this.userAuthRadioButton.TabIndex = 15;
            this.userAuthRadioButton.TabStop = true;
            this.userAuthRadioButton.Text = "User authentication";
            this.userAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // serviceAuthRadioButton
            // 
            this.serviceAuthRadioButton.AutoSize = true;
            this.serviceAuthRadioButton.Location = new System.Drawing.Point(220, 6);
            this.serviceAuthRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.serviceAuthRadioButton.Name = "serviceAuthRadioButton";
            this.serviceAuthRadioButton.Size = new System.Drawing.Size(229, 29);
            this.serviceAuthRadioButton.TabIndex = 16;
            this.serviceAuthRadioButton.Text = "Service authentication";
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // aadApplicationLabel
            // 
            this.aadApplicationLabel.AutoSize = true;
            this.aadApplicationLabel.Location = new System.Drawing.Point(17, 146);
            this.aadApplicationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aadApplicationLabel.Name = "aadApplicationLabel";
            this.aadApplicationLabel.Size = new System.Drawing.Size(202, 25);
            this.aadApplicationLabel.TabIndex = 34;
            this.aadApplicationLabel.Text = "Azure app registration";
            // 
            // appRegistrationComboBox
            // 
            this.appRegistrationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appRegistrationComboBox.FormattingEnabled = true;
            this.appRegistrationComboBox.Location = new System.Drawing.Point(226, 140);
            this.appRegistrationComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.appRegistrationComboBox.Name = "appRegistrationComboBox";
            this.appRegistrationComboBox.Size = new System.Drawing.Size(248, 32);
            this.appRegistrationComboBox.TabIndex = 17;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(165, 190);
            this.userLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 25);
            this.userLabel.TabIndex = 19;
            this.userLabel.Text = "User";
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(226, 186);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(248, 32);
            this.userComboBox.TabIndex = 18;
            // 
            // customOdataTabPage
            // 
            this.customOdataTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.customOdataTabPage.Controls.Add(this.customODataGroupBox);
            this.customOdataTabPage.Location = new System.Drawing.Point(4, 33);
            this.customOdataTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.customOdataTabPage.Name = "customOdataTabPage";
            this.customOdataTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.customOdataTabPage.Size = new System.Drawing.Size(1301, 789);
            this.customOdataTabPage.TabIndex = 4;
            this.customOdataTabPage.Text = "Custom OData actions";
            // 
            // customODataGroupBox
            // 
            this.customODataGroupBox.Controls.Add(this.exportToPackageLabel);
            this.customODataGroupBox.Controls.Add(this.exportToPackageTextBox);
            this.customODataGroupBox.Controls.Add(this.getExecutionSummaryStatusLabel);
            this.customODataGroupBox.Controls.Add(this.getExecutionSummaryStatusTextBox);
            this.customODataGroupBox.Controls.Add(this.getExportedPackageUrlLabel);
            this.customODataGroupBox.Controls.Add(this.getExportedPackageUrlTextBox);
            this.customODataGroupBox.Location = new System.Drawing.Point(7, 7);
            this.customODataGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.customODataGroupBox.Name = "customODataGroupBox";
            this.customODataGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.customODataGroupBox.Size = new System.Drawing.Size(1282, 188);
            this.customODataGroupBox.TabIndex = 22;
            this.customODataGroupBox.TabStop = false;
            this.customODataGroupBox.Text = "Custom OData actions relative paths";
            // 
            // exportToPackageLabel
            // 
            this.exportToPackageLabel.AutoSize = true;
            this.exportToPackageLabel.Location = new System.Drawing.Point(154, 44);
            this.exportToPackageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exportToPackageLabel.Name = "exportToPackageLabel";
            this.exportToPackageLabel.Size = new System.Drawing.Size(169, 25);
            this.exportToPackageLabel.TabIndex = 17;
            this.exportToPackageLabel.Text = "ExportToPackage";
            // 
            // exportToPackageTextBox
            // 
            this.exportToPackageTextBox.Location = new System.Drawing.Point(332, 39);
            this.exportToPackageTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exportToPackageTextBox.Name = "exportToPackageTextBox";
            this.exportToPackageTextBox.Size = new System.Drawing.Size(937, 29);
            this.exportToPackageTextBox.TabIndex = 16;
            // 
            // getExecutionSummaryStatusLabel
            // 
            this.getExecutionSummaryStatusLabel.AutoSize = true;
            this.getExecutionSummaryStatusLabel.Location = new System.Drawing.Point(61, 92);
            this.getExecutionSummaryStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getExecutionSummaryStatusLabel.Name = "getExecutionSummaryStatusLabel";
            this.getExecutionSummaryStatusLabel.Size = new System.Drawing.Size(269, 25);
            this.getExecutionSummaryStatusLabel.TabIndex = 19;
            this.getExecutionSummaryStatusLabel.Text = "GetExecutionSummaryStatus";
            // 
            // getExecutionSummaryStatusTextBox
            // 
            this.getExecutionSummaryStatusTextBox.Location = new System.Drawing.Point(332, 87);
            this.getExecutionSummaryStatusTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getExecutionSummaryStatusTextBox.Name = "getExecutionSummaryStatusTextBox";
            this.getExecutionSummaryStatusTextBox.Size = new System.Drawing.Size(937, 29);
            this.getExecutionSummaryStatusTextBox.TabIndex = 18;
            // 
            // getExportedPackageUrlLabel
            // 
            this.getExportedPackageUrlLabel.AutoSize = true;
            this.getExportedPackageUrlLabel.Location = new System.Drawing.Point(101, 140);
            this.getExportedPackageUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getExportedPackageUrlLabel.Name = "getExportedPackageUrlLabel";
            this.getExportedPackageUrlLabel.Size = new System.Drawing.Size(222, 25);
            this.getExportedPackageUrlLabel.TabIndex = 21;
            this.getExportedPackageUrlLabel.Text = "GetExportedPackageUrl";
            // 
            // getExportedPackageUrlTextBox
            // 
            this.getExportedPackageUrlTextBox.Location = new System.Drawing.Point(332, 135);
            this.getExportedPackageUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getExportedPackageUrlTextBox.Name = "getExportedPackageUrlTextBox";
            this.getExportedPackageUrlTextBox.Size = new System.Drawing.Size(937, 29);
            this.getExportedPackageUrlTextBox.TabIndex = 20;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripButton,
            this.addToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 876);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1294, 40);
            this.mainToolStrip.TabIndex = 11;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelToolStripButton.Image")));
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(79, 34);
            this.cancelToolStripButton.Text = "Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.CancelToolStripButton_Click);
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(90, 34);
            this.addToolStripButton.Text = "Add job";
            this.addToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // ExportJobV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1294, 916);
            this.Controls.Add(this.jobTabControl);
            this.Controls.Add(this.mainToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1318, 980);
            this.Name = "ExportJobV3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ExportJobForm_Load);
            this.retryPolicyGroupBox.ResumeLayout(false);
            this.retryPolicyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).EndInit();
            this.groupBoxExceptions.ResumeLayout(false);
            this.groupBoxExceptions.PerformLayout();
            this.jobTabControl.ResumeLayout(false);
            this.exportJobOverviewTabPage.ResumeLayout(false);
            this.jobIdentificationGroupBox.ResumeLayout(false);
            this.jobIdentificationGroupBox.PerformLayout();
            this.jobControlGroupBox.ResumeLayout(false);
            this.jobControlGroupBox.PerformLayout();
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.foldersGroupBox.ResumeLayout(false);
            this.foldersGroupBox.PerformLayout();
            this.exportJobDetailsTabPage.ResumeLayout(false);
            this.exportDetailsGroupBox.ResumeLayout(false);
            this.exportDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenStatusCheckNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenAttemptsNumericUpDown)).EndInit();
            this.sourceCompanyGroupBox.ResumeLayout(false);
            this.sourceCompanyGroupBox.PerformLayout();
            this.exportJobRecurrenceTabPage.ResumeLayout(false);
            this.triggerTypePanel.ResumeLayout(false);
            this.triggerTypePanel.PerformLayout();
            this.simpleTriggerJobGroupBox.ResumeLayout(false);
            this.simpleTriggerJobGroupBox.PerformLayout();
            this.cronTriggerGroupBox.ResumeLayout(false);
            this.cronTriggerGroupBox.PerformLayout();
            this.connectionTabPage.ResumeLayout(false);
            this.axDetailsGroupBox.ResumeLayout(false);
            this.axDetailsGroupBox.PerformLayout();
            this.authMethodPanel.ResumeLayout(false);
            this.authMethodPanel.PerformLayout();
            this.customOdataTabPage.ResumeLayout(false);
            this.customODataGroupBox.ResumeLayout(false);
            this.customODataGroupBox.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button downloadFolderBrowserButton;
        private System.Windows.Forms.TextBox downloadFolder;
        private System.Windows.Forms.Label downloadFolderLabel;
        private System.Windows.Forms.TextBox jobDescription;
        private System.Windows.Forms.Label jobDescriptionLabel;
        private System.Windows.Forms.ComboBox jobGroupComboBox;
        private System.Windows.Forms.Label jobGroupLabel;
        private System.Windows.Forms.TextBox jobName;
        private System.Windows.Forms.Label jobNameLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button errorsFolderBrowserButton;
        private System.Windows.Forms.TextBox errorsFolder;
        private System.Windows.Forms.Label errorsFolderLabel;
        private System.Windows.Forms.CheckBox useStandardSubfolder;
        private System.Windows.Forms.GroupBox retryPolicyGroupBox;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Label retriesLabel;
        private System.Windows.Forms.NumericUpDown retriesDelayUpDown;
        private System.Windows.Forms.NumericUpDown retriesCountUpDown;
        private System.Windows.Forms.GroupBox groupBoxExceptions;
        private System.Windows.Forms.CheckBox pauseOnExceptionsCheckBox;
        private System.Windows.Forms.TabControl jobTabControl;
        private System.Windows.Forms.TabPage exportJobOverviewTabPage;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.TabPage exportJobDetailsTabPage;
        private System.Windows.Forms.TabPage exportJobRecurrenceTabPage;
        private System.Windows.Forms.TabPage connectionTabPage;
        private System.Windows.Forms.TabPage customOdataTabPage;
        private System.Windows.Forms.GroupBox jobIdentificationGroupBox;
        private System.Windows.Forms.GroupBox foldersGroupBox;
        private System.Windows.Forms.GroupBox exportDetailsGroupBox;
        private System.Windows.Forms.Label delayBetweenAttemptsLabel;
        private System.Windows.Forms.NumericUpDown delayBetweenAttemptsNumericUpDown;
        private System.Windows.Forms.CheckBox addTimestampCheckBox;
        private System.Windows.Forms.Label legalEntityLabel;
        private System.Windows.Forms.TextBox legalEntity;
        private System.Windows.Forms.Label delayBetweenStatusCheckLabel;
        private System.Windows.Forms.NumericUpDown delayBetweenStatusCheckNumericUpDown;
        private System.Windows.Forms.Label dataProjectLabel;
        private System.Windows.Forms.TextBox dataProject;
        private System.Windows.Forms.CheckBox deletePackageCheckBox;
        private System.Windows.Forms.CheckBox unzipCheckBox;
        private System.Windows.Forms.GroupBox cronTriggerGroupBox;
        private System.Windows.Forms.Button moreExamplesButton;
        private System.Windows.Forms.TextBox calculatedRunsTextBox;
        private System.Windows.Forms.Button calculateNextRunsButton;
        private System.Windows.Forms.LinkLabel cronDocsLinkLabel;
        private System.Windows.Forms.Panel triggerTypePanel;
        private System.Windows.Forms.RadioButton cronTriggerRadioButton;
        private System.Windows.Forms.RadioButton simpleTriggerRadioButton;
        private System.Windows.Forms.Label buildCronLabel;
        private System.Windows.Forms.TextBox cronTriggerInfoTextBox;
        private System.Windows.Forms.LinkLabel cronmakerLinkLabel;
        private System.Windows.Forms.Label cronExpressionLabel;
        private System.Windows.Forms.TextBox cronExpressionTextBox;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label startAtLabel;
        private System.Windows.Forms.DateTimePicker startAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker minutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker hoursDateTimePicker;
        private System.Windows.Forms.GroupBox axDetailsGroupBox;
        private System.Windows.Forms.Label aadApplicationLabel;
        private System.Windows.Forms.ComboBox appRegistrationComboBox;
        private System.Windows.Forms.Panel authMethodPanel;
        private System.Windows.Forms.RadioButton serviceAuthRadioButton;
        private System.Windows.Forms.RadioButton userAuthRadioButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label instanceLabel;
        private System.Windows.Forms.ComboBox instanceComboBox;
        private System.Windows.Forms.GroupBox jobControlGroupBox;
        private System.Windows.Forms.CheckBox pauseIndefinitelyCheckBox;
        private System.Windows.Forms.GroupBox sourceCompanyGroupBox;
        private System.Windows.Forms.Label getExportedPackageUrlLabel;
        private System.Windows.Forms.TextBox getExportedPackageUrlTextBox;
        private System.Windows.Forms.Label getExecutionSummaryStatusLabel;
        private System.Windows.Forms.TextBox getExecutionSummaryStatusTextBox;
        private System.Windows.Forms.Label exportToPackageLabel;
        private System.Windows.Forms.TextBox exportToPackageTextBox;
        private System.Windows.Forms.GroupBox customODataGroupBox;
        private System.Windows.Forms.GroupBox simpleTriggerJobGroupBox;
        private System.Windows.Forms.Label runEveryLabel;
        private System.Windows.Forms.Label andOrLabel;
        private System.Windows.Forms.GroupBox groupBoxLogging;
        private System.Windows.Forms.CheckBox verboseLoggingCheckBox;
    }
}