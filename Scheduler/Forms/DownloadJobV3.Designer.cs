using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class DownloadJobV3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadJobV3));
            this.jobIdentificationGroupBox = new System.Windows.Forms.GroupBox();
            this.jobNameLabel = new System.Windows.Forms.Label();
            this.jobName = new System.Windows.Forms.TextBox();
            this.jobGroupLabel = new System.Windows.Forms.Label();
            this.jobGroupComboBox = new System.Windows.Forms.ComboBox();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.jobDescription = new System.Windows.Forms.TextBox();
            this.useStandardSubfolder = new System.Windows.Forms.CheckBox();
            this.errorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.errorsFolder = new System.Windows.Forms.TextBox();
            this.errorsFolderLabel = new System.Windows.Forms.Label();
            this.downloadFolderBrowserButton = new System.Windows.Forms.Button();
            this.downloadFolder = new System.Windows.Forms.TextBox();
            this.downloadFolderLabel = new System.Windows.Forms.Label();
            this.delayBetweenFilesLabel = new System.Windows.Forms.Label();
            this.delayBetweenFilesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deletePackageCheckBox = new System.Windows.Forms.CheckBox();
            this.addTimestampCheckBox = new System.Windows.Forms.CheckBox();
            this.unzipCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.cronTriggerJobGroupBox = new System.Windows.Forms.GroupBox();
            this.cronExpressionLabel = new System.Windows.Forms.Label();
            this.cronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.cronTriggerInfoTextBox = new System.Windows.Forms.TextBox();
            this.buildCronLabel = new System.Windows.Forms.Label();
            this.cronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.calculateNextRunsButton = new System.Windows.Forms.Button();
            this.calculatedRunsTextBox = new System.Windows.Forms.TextBox();
            this.moreExamplesButton = new System.Windows.Forms.Button();
            this.triggerTypePanel = new System.Windows.Forms.Panel();
            this.simpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.cronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.startAtLabel = new System.Windows.Forms.Label();
            this.startAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pauseIndefinitelyCheckBox = new System.Windows.Forms.CheckBox();
            this.retryPolicyGroupBox = new System.Windows.Forms.GroupBox();
            this.retriesLabel = new System.Windows.Forms.Label();
            this.retriesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.retriesDelayLabel = new System.Windows.Forms.Label();
            this.retriesDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBoxExceptions = new System.Windows.Forms.GroupBox();
            this.pauseOnExceptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.jobTabControl = new System.Windows.Forms.TabControl();
            this.jobOverviewTabPage = new System.Windows.Forms.TabPage();
            this.jobControlGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.verboseLoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.foldersGroupBox = new System.Windows.Forms.GroupBox();
            this.jobDetailsTabPage = new System.Windows.Forms.TabPage();
            this.jobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataJobLabel = new System.Windows.Forms.Label();
            this.dataJobComboBox = new System.Windows.Forms.ComboBox();
            this.recurrenceTabPage = new System.Windows.Forms.TabPage();
            this.simpleTriggerJobGroupBox = new System.Windows.Forms.GroupBox();
            this.runEveryLabel = new System.Windows.Forms.Label();
            this.andOrLabel = new System.Windows.Forms.Label();
            this.connectionTabPage = new System.Windows.Forms.TabPage();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.jobIdentificationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenFilesNumericUpDown)).BeginInit();
            this.axDetailsGroupBox.SuspendLayout();
            this.authMethodPanel.SuspendLayout();
            this.cronTriggerJobGroupBox.SuspendLayout();
            this.triggerTypePanel.SuspendLayout();
            this.retryPolicyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).BeginInit();
            this.groupBoxExceptions.SuspendLayout();
            this.jobTabControl.SuspendLayout();
            this.jobOverviewTabPage.SuspendLayout();
            this.jobControlGroupBox.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.foldersGroupBox.SuspendLayout();
            this.jobDetailsTabPage.SuspendLayout();
            this.jobDetailsGroupBox.SuspendLayout();
            this.recurrenceTabPage.SuspendLayout();
            this.simpleTriggerJobGroupBox.SuspendLayout();
            this.connectionTabPage.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.jobIdentificationGroupBox.TabIndex = 0;
            this.jobIdentificationGroupBox.TabStop = false;
            this.jobIdentificationGroupBox.Text = "Job identification";
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
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(149, 57);
            this.jobName.Margin = new System.Windows.Forms.Padding(6);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(235, 29);
            this.jobName.TabIndex = 1;
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
            // jobDescription
            // 
            this.jobDescription.Location = new System.Drawing.Point(13, 198);
            this.jobDescription.Margin = new System.Windows.Forms.Padding(6);
            this.jobDescription.Multiline = true;
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.Size = new System.Drawing.Size(371, 161);
            this.jobDescription.TabIndex = 3;
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
            this.useStandardSubfolder.TabIndex = 8;
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
            this.errorsFolderBrowserButton.TabIndex = 7;
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
            this.errorsFolder.TabIndex = 6;
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
            // delayBetweenFilesLabel
            // 
            this.delayBetweenFilesLabel.Location = new System.Drawing.Point(11, 257);
            this.delayBetweenFilesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.delayBetweenFilesLabel.Name = "delayBetweenFilesLabel";
            this.delayBetweenFilesLabel.Size = new System.Drawing.Size(273, 78);
            this.delayBetweenFilesLabel.TabIndex = 26;
            this.delayBetweenFilesLabel.Text = "Delay between attempts to download exported files from blob storage (seconds)";
            // 
            // delayBetweenFilesNumericUpDown
            // 
            this.delayBetweenFilesNumericUpDown.Location = new System.Drawing.Point(293, 277);
            this.delayBetweenFilesNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.delayBetweenFilesNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.delayBetweenFilesNumericUpDown.Name = "delayBetweenFilesNumericUpDown";
            this.delayBetweenFilesNumericUpDown.Size = new System.Drawing.Size(112, 29);
            this.delayBetweenFilesNumericUpDown.TabIndex = 25;
            this.delayBetweenFilesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deletePackageCheckBox
            // 
            this.deletePackageCheckBox.AutoSize = true;
            this.deletePackageCheckBox.Enabled = false;
            this.deletePackageCheckBox.Location = new System.Drawing.Point(13, 205);
            this.deletePackageCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.deletePackageCheckBox.Name = "deletePackageCheckBox";
            this.deletePackageCheckBox.Size = new System.Drawing.Size(203, 29);
            this.deletePackageCheckBox.TabIndex = 14;
            this.deletePackageCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete_package_file;
            this.deletePackageCheckBox.UseVisualStyleBackColor = true;
            // 
            // addTimestampCheckBox
            // 
            this.addTimestampCheckBox.AutoSize = true;
            this.addTimestampCheckBox.Enabled = false;
            this.addTimestampCheckBox.Location = new System.Drawing.Point(13, 162);
            this.addTimestampCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.addTimestampCheckBox.Name = "addTimestampCheckBox";
            this.addTimestampCheckBox.Size = new System.Drawing.Size(315, 29);
            this.addTimestampCheckBox.TabIndex = 13;
            this.addTimestampCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Make_exported_file_name_unique;
            this.addTimestampCheckBox.UseVisualStyleBackColor = true;
            // 
            // unzipCheckBox
            // 
            this.unzipCheckBox.AutoSize = true;
            this.unzipCheckBox.Location = new System.Drawing.Point(13, 120);
            this.unzipCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.unzipCheckBox.Name = "unzipCheckBox";
            this.unzipCheckBox.Size = new System.Drawing.Size(197, 29);
            this.unzipCheckBox.TabIndex = 12;
            this.unzipCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Unzip_package_file;
            this.unzipCheckBox.UseVisualStyleBackColor = true;
            this.unzipCheckBox.CheckedChanged += new System.EventHandler(this.UnzipCheckBox_CheckedChanged);
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
            this.axDetailsGroupBox.Location = new System.Drawing.Point(15, 11);
            this.axDetailsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.axDetailsGroupBox.Name = "axDetailsGroupBox";
            this.axDetailsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.axDetailsGroupBox.Size = new System.Drawing.Size(484, 242);
            this.axDetailsGroupBox.TabIndex = 1;
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
            this.instanceComboBox.TabIndex = 9;
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
            this.appRegistrationComboBox.TabIndex = 33;
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
            this.userComboBox.TabIndex = 10;
            // 
            // cronTriggerJobGroupBox
            // 
            this.cronTriggerJobGroupBox.Controls.Add(this.cronExpressionLabel);
            this.cronTriggerJobGroupBox.Controls.Add(this.cronExpressionTextBox);
            this.cronTriggerJobGroupBox.Controls.Add(this.cronTriggerInfoTextBox);
            this.cronTriggerJobGroupBox.Controls.Add(this.buildCronLabel);
            this.cronTriggerJobGroupBox.Controls.Add(this.cronmakerLinkLabel);
            this.cronTriggerJobGroupBox.Controls.Add(this.cronDocsLinkLabel);
            this.cronTriggerJobGroupBox.Controls.Add(this.calculateNextRunsButton);
            this.cronTriggerJobGroupBox.Controls.Add(this.calculatedRunsTextBox);
            this.cronTriggerJobGroupBox.Controls.Add(this.moreExamplesButton);
            this.cronTriggerJobGroupBox.Enabled = false;
            this.cronTriggerJobGroupBox.Location = new System.Drawing.Point(420, 65);
            this.cronTriggerJobGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.cronTriggerJobGroupBox.Name = "cronTriggerJobGroupBox";
            this.cronTriggerJobGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.cronTriggerJobGroupBox.Size = new System.Drawing.Size(429, 633);
            this.cronTriggerJobGroupBox.TabIndex = 2;
            this.cronTriggerJobGroupBox.TabStop = false;
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
            this.cronExpressionTextBox.TabIndex = 17;
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
            this.calculateNextRunsButton.TabIndex = 18;
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
            this.calculatedRunsTextBox.TabIndex = 32;
            this.calculatedRunsTextBox.TabStop = false;
            // 
            // moreExamplesButton
            // 
            this.moreExamplesButton.Location = new System.Drawing.Point(290, 517);
            this.moreExamplesButton.Margin = new System.Windows.Forms.Padding(6);
            this.moreExamplesButton.Name = "moreExamplesButton";
            this.moreExamplesButton.Size = new System.Drawing.Size(121, 102);
            this.moreExamplesButton.TabIndex = 19;
            this.moreExamplesButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesButton.UseVisualStyleBackColor = true;
            this.moreExamplesButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
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
            this.simpleTriggerRadioButton.TabIndex = 15;
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
            this.cronTriggerRadioButton.TabIndex = 16;
            this.cronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.cronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.cronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.CronTriggerRadioButton_CheckedChanged);
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
            this.startAtDateTimePicker.TabIndex = 14;
            this.startAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
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
            this.minutesDateTimePicker.TabIndex = 13;
            this.minutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 1, 0, 0);
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
            this.hoursDateTimePicker.TabIndex = 12;
            this.hoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // pauseIndefinitelyCheckBox
            // 
            this.pauseIndefinitelyCheckBox.AutoSize = true;
            this.pauseIndefinitelyCheckBox.Location = new System.Drawing.Point(13, 345);
            this.pauseIndefinitelyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.pauseIndefinitelyCheckBox.Name = "pauseIndefinitelyCheckBox";
            this.pauseIndefinitelyCheckBox.Size = new System.Drawing.Size(357, 29);
            this.pauseIndefinitelyCheckBox.TabIndex = 0;
            this.pauseIndefinitelyCheckBox.Text = "Don\'t execute the job. Always pause.";
            this.pauseIndefinitelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // retryPolicyGroupBox
            // 
            this.retryPolicyGroupBox.Controls.Add(this.retriesLabel);
            this.retryPolicyGroupBox.Controls.Add(this.retriesCountUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.retriesDelayLabel);
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
            // retriesDelayLabel
            // 
            this.retriesDelayLabel.AutoSize = true;
            this.retriesDelayLabel.Location = new System.Drawing.Point(13, 81);
            this.retriesDelayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.retriesDelayLabel.Name = "retriesDelayLabel";
            this.retriesDelayLabel.Size = new System.Drawing.Size(155, 25);
            this.retriesDelayLabel.TabIndex = 2;
            this.retriesDelayLabel.Text = "Delay (seconds)";
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
            60,
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
            this.jobTabControl.Controls.Add(this.jobOverviewTabPage);
            this.jobTabControl.Controls.Add(this.jobDetailsTabPage);
            this.jobTabControl.Controls.Add(this.recurrenceTabPage);
            this.jobTabControl.Controls.Add(this.connectionTabPage);
            this.jobTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobTabControl.Location = new System.Drawing.Point(0, 0);
            this.jobTabControl.Margin = new System.Windows.Forms.Padding(6);
            this.jobTabControl.Name = "jobTabControl";
            this.jobTabControl.SelectedIndex = 0;
            this.jobTabControl.Size = new System.Drawing.Size(1309, 922);
            this.jobTabControl.TabIndex = 12;
            // 
            // jobOverviewTabPage
            // 
            this.jobOverviewTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.jobOverviewTabPage.Controls.Add(this.jobIdentificationGroupBox);
            this.jobOverviewTabPage.Controls.Add(this.jobControlGroupBox);
            this.jobOverviewTabPage.Controls.Add(this.foldersGroupBox);
            this.jobOverviewTabPage.Location = new System.Drawing.Point(4, 33);
            this.jobOverviewTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.jobOverviewTabPage.Name = "jobOverviewTabPage";
            this.jobOverviewTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.jobOverviewTabPage.Size = new System.Drawing.Size(1301, 885);
            this.jobOverviewTabPage.TabIndex = 0;
            this.jobOverviewTabPage.Text = "Download job overview";
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
            this.jobControlGroupBox.TabIndex = 12;
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
            this.foldersGroupBox.TabIndex = 11;
            this.foldersGroupBox.TabStop = false;
            this.foldersGroupBox.Text = "Folders";
            // 
            // jobDetailsTabPage
            // 
            this.jobDetailsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.jobDetailsTabPage.Controls.Add(this.jobDetailsGroupBox);
            this.jobDetailsTabPage.Location = new System.Drawing.Point(4, 33);
            this.jobDetailsTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.jobDetailsTabPage.Name = "jobDetailsTabPage";
            this.jobDetailsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.jobDetailsTabPage.Size = new System.Drawing.Size(1301, 885);
            this.jobDetailsTabPage.TabIndex = 1;
            this.jobDetailsTabPage.Text = "Download job details";
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Controls.Add(this.dataJobLabel);
            this.jobDetailsGroupBox.Controls.Add(this.dataJobComboBox);
            this.jobDetailsGroupBox.Controls.Add(this.unzipCheckBox);
            this.jobDetailsGroupBox.Controls.Add(this.addTimestampCheckBox);
            this.jobDetailsGroupBox.Controls.Add(this.deletePackageCheckBox);
            this.jobDetailsGroupBox.Controls.Add(this.delayBetweenFilesLabel);
            this.jobDetailsGroupBox.Controls.Add(this.delayBetweenFilesNumericUpDown);
            this.jobDetailsGroupBox.Location = new System.Drawing.Point(7, 7);
            this.jobDetailsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.jobDetailsGroupBox.Name = "jobDetailsGroupBox";
            this.jobDetailsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(422, 347);
            this.jobDetailsGroupBox.TabIndex = 27;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job details";
            // 
            // dataJobLabel
            // 
            this.dataJobLabel.AutoSize = true;
            this.dataJobLabel.Location = new System.Drawing.Point(7, 37);
            this.dataJobLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dataJobLabel.Name = "dataJobLabel";
            this.dataJobLabel.Size = new System.Drawing.Size(195, 25);
            this.dataJobLabel.TabIndex = 29;
            this.dataJobLabel.Text = "Data job in Dynamics";
            // 
            // dataJobComboBox
            // 
            this.dataJobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataJobComboBox.FormattingEnabled = true;
            this.dataJobComboBox.Location = new System.Drawing.Point(13, 72);
            this.dataJobComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.dataJobComboBox.Name = "dataJobComboBox";
            this.dataJobComboBox.Size = new System.Drawing.Size(389, 32);
            this.dataJobComboBox.TabIndex = 28;
            // 
            // recurrenceTabPage
            // 
            this.recurrenceTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.recurrenceTabPage.Controls.Add(this.triggerTypePanel);
            this.recurrenceTabPage.Controls.Add(this.simpleTriggerJobGroupBox);
            this.recurrenceTabPage.Controls.Add(this.cronTriggerJobGroupBox);
            this.recurrenceTabPage.Location = new System.Drawing.Point(4, 33);
            this.recurrenceTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.recurrenceTabPage.Name = "recurrenceTabPage";
            this.recurrenceTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.recurrenceTabPage.Size = new System.Drawing.Size(1301, 885);
            this.recurrenceTabPage.TabIndex = 2;
            this.recurrenceTabPage.Text = "Download job recurrence";
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
            this.runEveryLabel.TabIndex = 32;
            this.runEveryLabel.Text = "Run job every...";
            // 
            // andOrLabel
            // 
            this.andOrLabel.AutoSize = true;
            this.andOrLabel.Location = new System.Drawing.Point(84, 66);
            this.andOrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.andOrLabel.Name = "andOrLabel";
            this.andOrLabel.Size = new System.Drawing.Size(68, 25);
            this.andOrLabel.TabIndex = 33;
            this.andOrLabel.Text = "and/or";
            // 
            // connectionTabPage
            // 
            this.connectionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.connectionTabPage.Controls.Add(this.axDetailsGroupBox);
            this.connectionTabPage.Location = new System.Drawing.Point(4, 33);
            this.connectionTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.connectionTabPage.Name = "connectionTabPage";
            this.connectionTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.connectionTabPage.Size = new System.Drawing.Size(1301, 885);
            this.connectionTabPage.TabIndex = 3;
            this.connectionTabPage.Text = "Connection";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripButton,
            this.addToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 922);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1309, 40);
            this.mainToolStrip.TabIndex = 13;
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
            // DownloadJobV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1309, 962);
            this.Controls.Add(this.jobTabControl);
            this.Controls.Add(this.mainToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1318, 980);
            this.Name = "DownloadJobV3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.DownloadJobForm_Load);
            this.jobIdentificationGroupBox.ResumeLayout(false);
            this.jobIdentificationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenFilesNumericUpDown)).EndInit();
            this.axDetailsGroupBox.ResumeLayout(false);
            this.axDetailsGroupBox.PerformLayout();
            this.authMethodPanel.ResumeLayout(false);
            this.authMethodPanel.PerformLayout();
            this.cronTriggerJobGroupBox.ResumeLayout(false);
            this.cronTriggerJobGroupBox.PerformLayout();
            this.triggerTypePanel.ResumeLayout(false);
            this.triggerTypePanel.PerformLayout();
            this.retryPolicyGroupBox.ResumeLayout(false);
            this.retryPolicyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).EndInit();
            this.groupBoxExceptions.ResumeLayout(false);
            this.groupBoxExceptions.PerformLayout();
            this.jobTabControl.ResumeLayout(false);
            this.jobOverviewTabPage.ResumeLayout(false);
            this.jobControlGroupBox.ResumeLayout(false);
            this.jobControlGroupBox.PerformLayout();
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.foldersGroupBox.ResumeLayout(false);
            this.foldersGroupBox.PerformLayout();
            this.jobDetailsTabPage.ResumeLayout(false);
            this.jobDetailsGroupBox.ResumeLayout(false);
            this.jobDetailsGroupBox.PerformLayout();
            this.recurrenceTabPage.ResumeLayout(false);
            this.simpleTriggerJobGroupBox.ResumeLayout(false);
            this.simpleTriggerJobGroupBox.PerformLayout();
            this.connectionTabPage.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox jobIdentificationGroupBox;
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
        private System.Windows.Forms.GroupBox axDetailsGroupBox;
        private System.Windows.Forms.Label instanceLabel;
        private System.Windows.Forms.ComboBox instanceComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.GroupBox cronTriggerJobGroupBox;
        private System.Windows.Forms.DateTimePicker startAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker minutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker hoursDateTimePicker;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label startAtLabel;
        private System.Windows.Forms.Label buildCronLabel;
        private System.Windows.Forms.TextBox cronTriggerInfoTextBox;
        private System.Windows.Forms.LinkLabel cronmakerLinkLabel;
        private System.Windows.Forms.Label cronExpressionLabel;
        private System.Windows.Forms.TextBox cronExpressionTextBox;
        private System.Windows.Forms.Panel triggerTypePanel;
        private System.Windows.Forms.RadioButton cronTriggerRadioButton;
        private System.Windows.Forms.RadioButton simpleTriggerRadioButton;
        private System.Windows.Forms.LinkLabel cronDocsLinkLabel;
        private System.Windows.Forms.TextBox calculatedRunsTextBox;
        private System.Windows.Forms.Button calculateNextRunsButton;
        private System.Windows.Forms.Button moreExamplesButton;
        private System.Windows.Forms.CheckBox addTimestampCheckBox;
        private System.Windows.Forms.CheckBox unzipCheckBox;
        private System.Windows.Forms.CheckBox deletePackageCheckBox;
        private System.Windows.Forms.Panel authMethodPanel;
        private System.Windows.Forms.RadioButton serviceAuthRadioButton;
        private System.Windows.Forms.RadioButton userAuthRadioButton;
        private System.Windows.Forms.Label aadApplicationLabel;
        private System.Windows.Forms.ComboBox appRegistrationComboBox;
        private System.Windows.Forms.GroupBox retryPolicyGroupBox;
        private System.Windows.Forms.Label retriesDelayLabel;
        private System.Windows.Forms.Label retriesLabel;
        private System.Windows.Forms.NumericUpDown retriesDelayUpDown;
        private System.Windows.Forms.NumericUpDown retriesCountUpDown;
        private System.Windows.Forms.GroupBox groupBoxExceptions;
        private System.Windows.Forms.CheckBox pauseOnExceptionsCheckBox;
        private System.Windows.Forms.CheckBox pauseIndefinitelyCheckBox;
        private System.Windows.Forms.Label delayBetweenFilesLabel;
        private System.Windows.Forms.NumericUpDown delayBetweenFilesNumericUpDown;
        private System.Windows.Forms.TabControl jobTabControl;
        private System.Windows.Forms.TabPage jobOverviewTabPage;
        private System.Windows.Forms.TabPage jobDetailsTabPage;
        private System.Windows.Forms.TabPage recurrenceTabPage;
        private System.Windows.Forms.TabPage connectionTabPage;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.GroupBox foldersGroupBox;
        private System.Windows.Forms.GroupBox jobControlGroupBox;
        private System.Windows.Forms.GroupBox jobDetailsGroupBox;
        private System.Windows.Forms.GroupBox simpleTriggerJobGroupBox;
        private System.Windows.Forms.Label runEveryLabel;
        private System.Windows.Forms.Label andOrLabel;
        private System.Windows.Forms.ComboBox dataJobComboBox;
        private System.Windows.Forms.Label dataJobLabel;
        private System.Windows.Forms.GroupBox groupBoxLogging;
        private System.Windows.Forms.CheckBox verboseLoggingCheckBox;
    }
}