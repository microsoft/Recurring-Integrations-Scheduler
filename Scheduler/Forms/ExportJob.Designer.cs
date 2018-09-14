using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class ExportJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportJob));
            this.jobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addTimestampCheckBox = new System.Windows.Forms.CheckBox();
            this.legalEntityLabel = new System.Windows.Forms.Label();
            this.legalEntity = new System.Windows.Forms.TextBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.dataProjectLabel = new System.Windows.Forms.Label();
            this.dataProject = new System.Windows.Forms.TextBox();
            this.deletePackageCheckBox = new System.Windows.Forms.CheckBox();
            this.unzipCheckBox = new System.Windows.Forms.CheckBox();
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
            this.axDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.aadApplicationLabel = new System.Windows.Forms.Label();
            this.aadApplicationComboBox = new System.Windows.Forms.ComboBox();
            this.authMethodPanel = new System.Windows.Forms.Panel();
            this.serviceAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.userAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.userLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.instanceLabel = new System.Windows.Forms.Label();
            this.instanceComboBox = new System.Windows.Forms.ComboBox();
            this.recurrenceGroupBox = new System.Windows.Forms.GroupBox();
            this.moreExamplesButton = new System.Windows.Forms.Button();
            this.calculatedRunsTextBox = new System.Windows.Forms.TextBox();
            this.calculateNextRunsButton = new System.Windows.Forms.Button();
            this.cronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.triggerTypePanel = new System.Windows.Forms.Panel();
            this.cronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.simpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.buildCronLabel = new System.Windows.Forms.Label();
            this.cronTriggerInfoTextBox = new System.Windows.Forms.TextBox();
            this.cronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cronExpressionLabel = new System.Windows.Forms.Label();
            this.cronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.startAtLabel = new System.Windows.Forms.Label();
            this.startAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.addJobButton = new System.Windows.Forms.ToolStripButton();
            this.customActionsButton = new System.Windows.Forms.ToolStripButton();
            this.retryPolicyGroupBox = new System.Windows.Forms.GroupBox();
            this.retriesDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.retriesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxExceptions = new System.Windows.Forms.GroupBox();
            this.pauseOnExceptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.pauseIndefinitelyCheckBox = new System.Windows.Forms.CheckBox();
            this.jobDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            this.axDetailsGroupBox.SuspendLayout();
            this.authMethodPanel.SuspendLayout();
            this.recurrenceGroupBox.SuspendLayout();
            this.triggerTypePanel.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.retryPolicyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).BeginInit();
            this.groupBoxExceptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Controls.Add(this.addTimestampCheckBox);
            this.jobDetailsGroupBox.Controls.Add(this.legalEntityLabel);
            this.jobDetailsGroupBox.Controls.Add(this.legalEntity);
            this.jobDetailsGroupBox.Controls.Add(this.intervalLabel);
            this.jobDetailsGroupBox.Controls.Add(this.interval);
            this.jobDetailsGroupBox.Controls.Add(this.dataProjectLabel);
            this.jobDetailsGroupBox.Controls.Add(this.dataProject);
            this.jobDetailsGroupBox.Controls.Add(this.deletePackageCheckBox);
            this.jobDetailsGroupBox.Controls.Add(this.unzipCheckBox);
            this.jobDetailsGroupBox.Controls.Add(this.useStandardSubfolder);
            this.jobDetailsGroupBox.Controls.Add(this.errorsFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.errorsFolder);
            this.jobDetailsGroupBox.Controls.Add(this.errorsFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.downloadFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.downloadFolder);
            this.jobDetailsGroupBox.Controls.Add(this.downloadFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescription);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescriptionLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobGroupComboBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobGroupLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobName);
            this.jobDetailsGroupBox.Controls.Add(this.jobNameLabel);
            this.jobDetailsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.jobDetailsGroupBox.Name = "jobDetailsGroupBox";
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(230, 390);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job details";
            // 
            // addTimestampCheckBox
            // 
            this.addTimestampCheckBox.AutoSize = true;
            this.addTimestampCheckBox.Enabled = false;
            this.addTimestampCheckBox.Location = new System.Drawing.Point(11, 256);
            this.addTimestampCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addTimestampCheckBox.Name = "addTimestampCheckBox";
            this.addTimestampCheckBox.Size = new System.Drawing.Size(177, 17);
            this.addTimestampCheckBox.TabIndex = 10;
            this.addTimestampCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Make_exported_file_name_unique;
            this.addTimestampCheckBox.UseVisualStyleBackColor = true;
            // 
            // legalEntityLabel
            // 
            this.legalEntityLabel.AutoSize = true;
            this.legalEntityLabel.Location = new System.Drawing.Point(10, 325);
            this.legalEntityLabel.Name = "legalEntityLabel";
            this.legalEntityLabel.Size = new System.Drawing.Size(61, 13);
            this.legalEntityLabel.TabIndex = 22;
            this.legalEntityLabel.Text = "Legal entity";
            // 
            // legalEntity
            // 
            this.legalEntity.Location = new System.Drawing.Point(80, 323);
            this.legalEntity.Name = "legalEntity";
            this.legalEntity.Size = new System.Drawing.Size(65, 20);
            this.legalEntity.TabIndex = 13;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(10, 350);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(136, 13);
            this.intervalLabel.TabIndex = 20;
            this.intervalLabel.Text = "Status check interval (sec.)";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(147, 349);
            this.interval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.interval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(74, 20);
            this.interval.TabIndex = 14;
            this.interval.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // dataProjectLabel
            // 
            this.dataProjectLabel.AutoSize = true;
            this.dataProjectLabel.Location = new System.Drawing.Point(10, 302);
            this.dataProjectLabel.Name = "dataProjectLabel";
            this.dataProjectLabel.Size = new System.Drawing.Size(65, 13);
            this.dataProjectLabel.TabIndex = 16;
            this.dataProjectLabel.Text = "Data project";
            // 
            // dataProject
            // 
            this.dataProject.Location = new System.Drawing.Point(79, 300);
            this.dataProject.Name = "dataProject";
            this.dataProject.Size = new System.Drawing.Size(148, 20);
            this.dataProject.TabIndex = 12;
            // 
            // deletePackageCheckBox
            // 
            this.deletePackageCheckBox.AutoSize = true;
            this.deletePackageCheckBox.Enabled = false;
            this.deletePackageCheckBox.Location = new System.Drawing.Point(11, 277);
            this.deletePackageCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deletePackageCheckBox.Name = "deletePackageCheckBox";
            this.deletePackageCheckBox.Size = new System.Drawing.Size(118, 17);
            this.deletePackageCheckBox.TabIndex = 11;
            this.deletePackageCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Delete_package_file;
            this.deletePackageCheckBox.UseVisualStyleBackColor = true;
            // 
            // unzipCheckBox
            // 
            this.unzipCheckBox.AutoSize = true;
            this.unzipCheckBox.Location = new System.Drawing.Point(12, 235);
            this.unzipCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unzipCheckBox.Name = "unzipCheckBox";
            this.unzipCheckBox.Size = new System.Drawing.Size(114, 17);
            this.unzipCheckBox.TabIndex = 9;
            this.unzipCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Unzip_package_file;
            this.unzipCheckBox.UseVisualStyleBackColor = true;
            this.unzipCheckBox.CheckedChanged += new System.EventHandler(this.UnzipCheckBox_CheckedChanged);
            // 
            // useStandardSubfolder
            // 
            this.useStandardSubfolder.AutoSize = true;
            this.useStandardSubfolder.Checked = true;
            this.useStandardSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useStandardSubfolder.Location = new System.Drawing.Point(12, 172);
            this.useStandardSubfolder.Name = "useStandardSubfolder";
            this.useStandardSubfolder.Size = new System.Drawing.Size(143, 17);
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
            this.errorsFolderBrowserButton.Location = new System.Drawing.Point(202, 207);
            this.errorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.errorsFolderBrowserButton.Name = "errorsFolderBrowserButton";
            this.errorsFolderBrowserButton.Size = new System.Drawing.Size(24, 26);
            this.errorsFolderBrowserButton.TabIndex = 8;
            this.errorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.errorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.errorsFolderBrowserButton.Click += new System.EventHandler(this.ErrorsFolderBrowserButton_Click);
            // 
            // errorsFolder
            // 
            this.errorsFolder.Enabled = false;
            this.errorsFolder.Location = new System.Drawing.Point(12, 209);
            this.errorsFolder.Name = "errorsFolder";
            this.errorsFolder.Size = new System.Drawing.Size(187, 20);
            this.errorsFolder.TabIndex = 7;
            // 
            // errorsFolderLabel
            // 
            this.errorsFolderLabel.AutoSize = true;
            this.errorsFolderLabel.Location = new System.Drawing.Point(9, 192);
            this.errorsFolderLabel.Name = "errorsFolderLabel";
            this.errorsFolderLabel.Size = new System.Drawing.Size(63, 13);
            this.errorsFolderLabel.TabIndex = 11;
            this.errorsFolderLabel.Text = "Errors folder";
            // 
            // downloadFolderBrowserButton
            // 
            this.downloadFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.downloadFolderBrowserButton.Location = new System.Drawing.Point(202, 144);
            this.downloadFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.downloadFolderBrowserButton.Name = "downloadFolderBrowserButton";
            this.downloadFolderBrowserButton.Size = new System.Drawing.Size(24, 26);
            this.downloadFolderBrowserButton.TabIndex = 5;
            this.downloadFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.downloadFolderBrowserButton.UseVisualStyleBackColor = true;
            this.downloadFolderBrowserButton.Click += new System.EventHandler(this.DownloadFolderBrowserButton_Click);
            // 
            // downloadFolder
            // 
            this.downloadFolder.Location = new System.Drawing.Point(13, 147);
            this.downloadFolder.Name = "downloadFolder";
            this.downloadFolder.Size = new System.Drawing.Size(187, 20);
            this.downloadFolder.TabIndex = 4;
            this.downloadFolder.TextChanged += new System.EventHandler(this.DownloadFolder_TextChanged);
            // 
            // downloadFolderLabel
            // 
            this.downloadFolderLabel.AutoSize = true;
            this.downloadFolderLabel.Location = new System.Drawing.Point(10, 130);
            this.downloadFolderLabel.Name = "downloadFolderLabel";
            this.downloadFolderLabel.Size = new System.Drawing.Size(84, 13);
            this.downloadFolderLabel.TabIndex = 8;
            this.downloadFolderLabel.Text = "Download folder";
            // 
            // jobDescription
            // 
            this.jobDescription.Location = new System.Drawing.Point(11, 91);
            this.jobDescription.Multiline = true;
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.Size = new System.Drawing.Size(211, 35);
            this.jobDescription.TabIndex = 3;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(9, 74);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.jobDescriptionLabel.TabIndex = 4;
            this.jobDescriptionLabel.Text = "Description";
            // 
            // jobGroupComboBox
            // 
            this.jobGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobGroupComboBox.FormattingEnabled = true;
            this.jobGroupComboBox.Location = new System.Drawing.Point(50, 49);
            this.jobGroupComboBox.Name = "jobGroupComboBox";
            this.jobGroupComboBox.Size = new System.Drawing.Size(173, 21);
            this.jobGroupComboBox.Sorted = true;
            this.jobGroupComboBox.TabIndex = 2;
            // 
            // jobGroupLabel
            // 
            this.jobGroupLabel.AutoSize = true;
            this.jobGroupLabel.Location = new System.Drawing.Point(9, 52);
            this.jobGroupLabel.Name = "jobGroupLabel";
            this.jobGroupLabel.Size = new System.Drawing.Size(36, 13);
            this.jobGroupLabel.TabIndex = 2;
            this.jobGroupLabel.Text = "Group";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(50, 17);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(173, 20);
            this.jobName.TabIndex = 1;
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Location = new System.Drawing.Point(9, 20);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(35, 13);
            this.jobNameLabel.TabIndex = 0;
            this.jobNameLabel.Text = "Name";
            // 
            // axDetailsGroupBox
            // 
            this.axDetailsGroupBox.Controls.Add(this.aadApplicationLabel);
            this.axDetailsGroupBox.Controls.Add(this.aadApplicationComboBox);
            this.axDetailsGroupBox.Controls.Add(this.authMethodPanel);
            this.axDetailsGroupBox.Controls.Add(this.userLabel);
            this.axDetailsGroupBox.Controls.Add(this.userComboBox);
            this.axDetailsGroupBox.Controls.Add(this.instanceLabel);
            this.axDetailsGroupBox.Controls.Add(this.instanceComboBox);
            this.axDetailsGroupBox.Location = new System.Drawing.Point(247, 13);
            this.axDetailsGroupBox.Name = "axDetailsGroupBox";
            this.axDetailsGroupBox.Size = new System.Drawing.Size(230, 127);
            this.axDetailsGroupBox.TabIndex = 1;
            this.axDetailsGroupBox.TabStop = false;
            this.axDetailsGroupBox.Text = "Dynamics details";
            // 
            // aadApplicationLabel
            // 
            this.aadApplicationLabel.AutoSize = true;
            this.aadApplicationLabel.Location = new System.Drawing.Point(9, 78);
            this.aadApplicationLabel.Name = "aadApplicationLabel";
            this.aadApplicationLabel.Size = new System.Drawing.Size(83, 13);
            this.aadApplicationLabel.TabIndex = 34;
            this.aadApplicationLabel.Text = "AAD application";
            // 
            // aadApplicationComboBox
            // 
            this.aadApplicationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aadApplicationComboBox.FormattingEnabled = true;
            this.aadApplicationComboBox.Location = new System.Drawing.Point(103, 75);
            this.aadApplicationComboBox.Name = "aadApplicationComboBox";
            this.aadApplicationComboBox.Size = new System.Drawing.Size(121, 21);
            this.aadApplicationComboBox.TabIndex = 17;
            // 
            // authMethodPanel
            // 
            this.authMethodPanel.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodPanel.Controls.Add(this.userAuthRadioButton);
            this.authMethodPanel.Location = new System.Drawing.Point(8, 44);
            this.authMethodPanel.Name = "authMethodPanel";
            this.authMethodPanel.Size = new System.Drawing.Size(215, 25);
            this.authMethodPanel.TabIndex = 31;
            // 
            // serviceAuthRadioButton
            // 
            this.serviceAuthRadioButton.AutoSize = true;
            this.serviceAuthRadioButton.Location = new System.Drawing.Point(118, 3);
            this.serviceAuthRadioButton.Name = "serviceAuthRadioButton";
            this.serviceAuthRadioButton.Size = new System.Drawing.Size(85, 17);
            this.serviceAuthRadioButton.TabIndex = 16;
            this.serviceAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Service_auth;
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(3, 3);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(71, 17);
            this.userAuthRadioButton.TabIndex = 15;
            this.userAuthRadioButton.TabStop = true;
            this.userAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.User_auth;
            this.userAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(62, 104);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(29, 13);
            this.userLabel.TabIndex = 19;
            this.userLabel.Text = "User";
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(103, 101);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 18;
            // 
            // instanceLabel
            // 
            this.instanceLabel.AutoSize = true;
            this.instanceLabel.Location = new System.Drawing.Point(19, 20);
            this.instanceLabel.Name = "instanceLabel";
            this.instanceLabel.Size = new System.Drawing.Size(48, 13);
            this.instanceLabel.TabIndex = 16;
            this.instanceLabel.Text = "Instance";
            // 
            // instanceComboBox
            // 
            this.instanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceComboBox.FormattingEnabled = true;
            this.instanceComboBox.Location = new System.Drawing.Point(76, 17);
            this.instanceComboBox.Name = "instanceComboBox";
            this.instanceComboBox.Size = new System.Drawing.Size(147, 21);
            this.instanceComboBox.TabIndex = 14;
            // 
            // recurrenceGroupBox
            // 
            this.recurrenceGroupBox.Controls.Add(this.pauseIndefinitelyCheckBox);
            this.recurrenceGroupBox.Controls.Add(this.moreExamplesButton);
            this.recurrenceGroupBox.Controls.Add(this.calculatedRunsTextBox);
            this.recurrenceGroupBox.Controls.Add(this.calculateNextRunsButton);
            this.recurrenceGroupBox.Controls.Add(this.cronDocsLinkLabel);
            this.recurrenceGroupBox.Controls.Add(this.triggerTypePanel);
            this.recurrenceGroupBox.Controls.Add(this.buildCronLabel);
            this.recurrenceGroupBox.Controls.Add(this.cronTriggerInfoTextBox);
            this.recurrenceGroupBox.Controls.Add(this.cronmakerLinkLabel);
            this.recurrenceGroupBox.Controls.Add(this.cronExpressionLabel);
            this.recurrenceGroupBox.Controls.Add(this.cronExpressionTextBox);
            this.recurrenceGroupBox.Controls.Add(this.minutesLabel);
            this.recurrenceGroupBox.Controls.Add(this.hoursLabel);
            this.recurrenceGroupBox.Controls.Add(this.startAtLabel);
            this.recurrenceGroupBox.Controls.Add(this.startAtDateTimePicker);
            this.recurrenceGroupBox.Controls.Add(this.minutesDateTimePicker);
            this.recurrenceGroupBox.Controls.Add(this.hoursDateTimePicker);
            this.recurrenceGroupBox.Location = new System.Drawing.Point(483, 13);
            this.recurrenceGroupBox.Name = "recurrenceGroupBox";
            this.recurrenceGroupBox.Size = new System.Drawing.Size(230, 455);
            this.recurrenceGroupBox.TabIndex = 2;
            this.recurrenceGroupBox.TabStop = false;
            this.recurrenceGroupBox.Text = "Recurrence";
            // 
            // moreExamplesButton
            // 
            this.moreExamplesButton.Location = new System.Drawing.Point(158, 380);
            this.moreExamplesButton.Name = "moreExamplesButton";
            this.moreExamplesButton.Size = new System.Drawing.Size(66, 66);
            this.moreExamplesButton.TabIndex = 27;
            this.moreExamplesButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesButton.UseVisualStyleBackColor = true;
            this.moreExamplesButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
            // 
            // calculatedRunsTextBox
            // 
            this.calculatedRunsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsTextBox.Location = new System.Drawing.Point(6, 380);
            this.calculatedRunsTextBox.Multiline = true;
            this.calculatedRunsTextBox.Name = "calculatedRunsTextBox";
            this.calculatedRunsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsTextBox.Size = new System.Drawing.Size(145, 66);
            this.calculatedRunsTextBox.TabIndex = 26;
            this.calculatedRunsTextBox.TabStop = false;
            // 
            // calculateNextRunsButton
            // 
            this.calculateNextRunsButton.Enabled = false;
            this.calculateNextRunsButton.Location = new System.Drawing.Point(6, 348);
            this.calculateNextRunsButton.Name = "calculateNextRunsButton";
            this.calculateNextRunsButton.Size = new System.Drawing.Size(218, 23);
            this.calculateNextRunsButton.TabIndex = 25;
            this.calculateNextRunsButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Calculate_next_100_runs_of_cron_trigger;
            this.calculateNextRunsButton.UseVisualStyleBackColor = true;
            this.calculateNextRunsButton.Click += new System.EventHandler(this.CalculateNextRunsButton_Click);
            // 
            // cronDocsLinkLabel
            // 
            this.cronDocsLinkLabel.AutoSize = true;
            this.cronDocsLinkLabel.Location = new System.Drawing.Point(6, 328);
            this.cronDocsLinkLabel.Name = "cronDocsLinkLabel";
            this.cronDocsLinkLabel.Size = new System.Drawing.Size(172, 13);
            this.cronDocsLinkLabel.TabIndex = 30;
            this.cronDocsLinkLabel.TabStop = true;
            this.cronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.cronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // triggerTypePanel
            // 
            this.triggerTypePanel.Controls.Add(this.cronTriggerRadioButton);
            this.triggerTypePanel.Controls.Add(this.simpleTriggerRadioButton);
            this.triggerTypePanel.Location = new System.Drawing.Point(9, 78);
            this.triggerTypePanel.Name = "triggerTypePanel";
            this.triggerTypePanel.Size = new System.Drawing.Size(214, 23);
            this.triggerTypePanel.TabIndex = 29;
            // 
            // cronTriggerRadioButton
            // 
            this.cronTriggerRadioButton.AutoSize = true;
            this.cronTriggerRadioButton.Location = new System.Drawing.Point(129, 5);
            this.cronTriggerRadioButton.Name = "cronTriggerRadioButton";
            this.cronTriggerRadioButton.Size = new System.Drawing.Size(79, 17);
            this.cronTriggerRadioButton.TabIndex = 23;
            this.cronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.cronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.cronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.CronTriggerRadioButton_CheckedChanged);
            // 
            // simpleTriggerRadioButton
            // 
            this.simpleTriggerRadioButton.AutoSize = true;
            this.simpleTriggerRadioButton.Checked = true;
            this.simpleTriggerRadioButton.Location = new System.Drawing.Point(3, 3);
            this.simpleTriggerRadioButton.Name = "simpleTriggerRadioButton";
            this.simpleTriggerRadioButton.Size = new System.Drawing.Size(88, 17);
            this.simpleTriggerRadioButton.TabIndex = 22;
            this.simpleTriggerRadioButton.TabStop = true;
            this.simpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.simpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // buildCronLabel
            // 
            this.buildCronLabel.AutoSize = true;
            this.buildCronLabel.Location = new System.Drawing.Point(6, 307);
            this.buildCronLabel.Name = "buildCronLabel";
            this.buildCronLabel.Size = new System.Drawing.Size(119, 13);
            this.buildCronLabel.TabIndex = 26;
            this.buildCronLabel.Text = "Build cron expression at";
            // 
            // cronTriggerInfoTextBox
            // 
            this.cronTriggerInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cronTriggerInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cronTriggerInfoTextBox.Location = new System.Drawing.Point(9, 149);
            this.cronTriggerInfoTextBox.Multiline = true;
            this.cronTriggerInfoTextBox.Name = "cronTriggerInfoTextBox";
            this.cronTriggerInfoTextBox.Size = new System.Drawing.Size(208, 155);
            this.cronTriggerInfoTextBox.TabIndex = 25;
            this.cronTriggerInfoTextBox.TabStop = false;
            this.cronTriggerInfoTextBox.Text = resources.GetString("cronTriggerInfoTextBox.Text");
            // 
            // cronmakerLinkLabel
            // 
            this.cronmakerLinkLabel.AutoSize = true;
            this.cronmakerLinkLabel.Location = new System.Drawing.Point(124, 307);
            this.cronmakerLinkLabel.Name = "cronmakerLinkLabel";
            this.cronmakerLinkLabel.Size = new System.Drawing.Size(80, 13);
            this.cronmakerLinkLabel.TabIndex = 24;
            this.cronmakerLinkLabel.TabStop = true;
            this.cronmakerLinkLabel.Text = "cronmaker.com";
            this.cronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // cronExpressionLabel
            // 
            this.cronExpressionLabel.AutoSize = true;
            this.cronExpressionLabel.Location = new System.Drawing.Point(6, 107);
            this.cronExpressionLabel.Name = "cronExpressionLabel";
            this.cronExpressionLabel.Size = new System.Drawing.Size(82, 13);
            this.cronExpressionLabel.TabIndex = 23;
            this.cronExpressionLabel.Text = "Cron expression";
            // 
            // cronExpressionTextBox
            // 
            this.cronExpressionTextBox.Enabled = false;
            this.cronExpressionTextBox.Location = new System.Drawing.Point(9, 123);
            this.cronExpressionTextBox.Name = "cronExpressionTextBox";
            this.cronExpressionTextBox.Size = new System.Drawing.Size(215, 20);
            this.cronExpressionTextBox.TabIndex = 24;
            this.cronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(64, 55);
            this.minutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(19, 13);
            this.minutesLabel.TabIndex = 5;
            this.minutesLabel.Text = "M:";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(6, 55);
            this.hoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(18, 13);
            this.hoursLabel.TabIndex = 4;
            this.hoursLabel.Text = "H:";
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // startAtLabel
            // 
            this.startAtLabel.AutoSize = true;
            this.startAtLabel.Location = new System.Drawing.Point(126, 55);
            this.startAtLabel.Name = "startAtLabel";
            this.startAtLabel.Size = new System.Drawing.Size(39, 13);
            this.startAtLabel.TabIndex = 3;
            this.startAtLabel.Text = "start at";
            this.startAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // startAtDateTimePicker
            // 
            this.startAtDateTimePicker.CustomFormat = "HH:mm";
            this.startAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startAtDateTimePicker.Location = new System.Drawing.Point(165, 52);
            this.startAtDateTimePicker.Name = "startAtDateTimePicker";
            this.startAtDateTimePicker.ShowUpDown = true;
            this.startAtDateTimePicker.Size = new System.Drawing.Size(52, 20);
            this.startAtDateTimePicker.TabIndex = 21;
            this.startAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // minutesDateTimePicker
            // 
            this.minutesDateTimePicker.CustomFormat = "mm";
            this.minutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.minutesDateTimePicker.Location = new System.Drawing.Point(83, 52);
            this.minutesDateTimePicker.Name = "minutesDateTimePicker";
            this.minutesDateTimePicker.ShowUpDown = true;
            this.minutesDateTimePicker.Size = new System.Drawing.Size(35, 20);
            this.minutesDateTimePicker.TabIndex = 20;
            this.minutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 1, 0, 0);
            // 
            // hoursDateTimePicker
            // 
            this.hoursDateTimePicker.CustomFormat = "HH";
            this.hoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hoursDateTimePicker.Location = new System.Drawing.Point(24, 52);
            this.hoursDateTimePicker.Name = "hoursDateTimePicker";
            this.hoursDateTimePicker.ShowUpDown = true;
            this.hoursDateTimePicker.Size = new System.Drawing.Size(35, 20);
            this.hoursDateTimePicker.TabIndex = 19;
            this.hoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelButton,
            this.addJobButton,
            this.customActionsButton});
            this.bottomToolStrip.Location = new System.Drawing.Point(0, 471);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.Size = new System.Drawing.Size(720, 25);
            this.bottomToolStrip.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(47, 22);
            this.cancelButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cancel;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addJobButton
            // 
            this.addJobButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addJobButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addJobButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(97, 22);
            this.addJobButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Add_to_schedule;
            this.addJobButton.Click += new System.EventHandler(this.AddJobButton_Click);
            // 
            // customActionsButton
            // 
            this.customActionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.customActionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customActionsButton.Name = "customActionsButton";
            this.customActionsButton.Size = new System.Drawing.Size(129, 22);
            this.customActionsButton.Text = "Custom Odata actions";
            this.customActionsButton.Click += new System.EventHandler(this.CustomActionsButton_Click);
            // 
            // retryPolicyGroupBox
            // 
            this.retryPolicyGroupBox.Controls.Add(this.retriesDelayUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.retriesCountUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.label2);
            this.retryPolicyGroupBox.Controls.Add(this.label1);
            this.retryPolicyGroupBox.Location = new System.Drawing.Point(246, 146);
            this.retryPolicyGroupBox.Name = "retryPolicyGroupBox";
            this.retryPolicyGroupBox.Size = new System.Drawing.Size(231, 67);
            this.retryPolicyGroupBox.TabIndex = 7;
            this.retryPolicyGroupBox.TabStop = false;
            this.retryPolicyGroupBox.Text = "Retry policy";
            // 
            // retriesDelayUpDown
            // 
            this.retriesDelayUpDown.Location = new System.Drawing.Point(104, 39);
            this.retriesDelayUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.retriesDelayUpDown.Name = "retriesDelayUpDown";
            this.retriesDelayUpDown.Size = new System.Drawing.Size(66, 20);
            this.retriesDelayUpDown.TabIndex = 7;
            this.retriesDelayUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // retriesCountUpDown
            // 
            this.retriesCountUpDown.Location = new System.Drawing.Point(104, 15);
            this.retriesCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.retriesCountUpDown.Name = "retriesCountUpDown";
            this.retriesCountUpDown.Size = new System.Drawing.Size(66, 20);
            this.retriesCountUpDown.TabIndex = 6;
            this.retriesCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay (seconds)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of retries";
            // 
            // groupBoxExceptions
            // 
            this.groupBoxExceptions.Controls.Add(this.pauseOnExceptionsCheckBox);
            this.groupBoxExceptions.Location = new System.Drawing.Point(246, 218);
            this.groupBoxExceptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxExceptions.Name = "groupBoxExceptions";
            this.groupBoxExceptions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxExceptions.Size = new System.Drawing.Size(230, 38);
            this.groupBoxExceptions.TabIndex = 10;
            this.groupBoxExceptions.TabStop = false;
            this.groupBoxExceptions.Text = "Exceptions";
            // 
            // pauseOnExceptionsCheckBox
            // 
            this.pauseOnExceptionsCheckBox.AutoSize = true;
            this.pauseOnExceptionsCheckBox.Checked = true;
            this.pauseOnExceptionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pauseOnExceptionsCheckBox.Location = new System.Drawing.Point(9, 17);
            this.pauseOnExceptionsCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pauseOnExceptionsCheckBox.Name = "pauseOnExceptionsCheckBox";
            this.pauseOnExceptionsCheckBox.Size = new System.Drawing.Size(186, 17);
            this.pauseOnExceptionsCheckBox.TabIndex = 0;
            this.pauseOnExceptionsCheckBox.Text = "Pause job when exception occurs";
            this.pauseOnExceptionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pauseIndefinitelyCheckBox
            // 
            this.pauseIndefinitelyCheckBox.AutoSize = true;
            this.pauseIndefinitelyCheckBox.Location = new System.Drawing.Point(9, 23);
            this.pauseIndefinitelyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.pauseIndefinitelyCheckBox.Name = "pauseIndefinitelyCheckBox";
            this.pauseIndefinitelyCheckBox.Size = new System.Drawing.Size(125, 17);
            this.pauseIndefinitelyCheckBox.TabIndex = 0;
            this.pauseIndefinitelyCheckBox.Text = "Pause job indefinitely";
            this.pauseIndefinitelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(720, 496);
            this.Controls.Add(this.bottomToolStrip);
            this.Controls.Add(this.groupBoxExceptions);
            this.Controls.Add(this.retryPolicyGroupBox);
            this.Controls.Add(this.recurrenceGroupBox);
            this.Controls.Add(this.axDetailsGroupBox);
            this.Controls.Add(this.jobDetailsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(736, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(736, 511);
            this.Name = "ExportJob";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ExportJobForm_Load);
            this.jobDetailsGroupBox.ResumeLayout(false);
            this.jobDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            this.axDetailsGroupBox.ResumeLayout(false);
            this.axDetailsGroupBox.PerformLayout();
            this.authMethodPanel.ResumeLayout(false);
            this.authMethodPanel.PerformLayout();
            this.recurrenceGroupBox.ResumeLayout(false);
            this.recurrenceGroupBox.PerformLayout();
            this.triggerTypePanel.ResumeLayout(false);
            this.triggerTypePanel.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.retryPolicyGroupBox.ResumeLayout(false);
            this.retryPolicyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).EndInit();
            this.groupBoxExceptions.ResumeLayout(false);
            this.groupBoxExceptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox jobDetailsGroupBox;
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
        private System.Windows.Forms.GroupBox recurrenceGroupBox;
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
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.LinkLabel cronDocsLinkLabel;
        private System.Windows.Forms.TextBox calculatedRunsTextBox;
        private System.Windows.Forms.Button calculateNextRunsButton;
        private System.Windows.Forms.Button moreExamplesButton;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripButton addJobButton;
        private System.Windows.Forms.CheckBox unzipCheckBox;
        private System.Windows.Forms.CheckBox deletePackageCheckBox;
        private System.Windows.Forms.Panel authMethodPanel;
        private System.Windows.Forms.RadioButton serviceAuthRadioButton;
        private System.Windows.Forms.RadioButton userAuthRadioButton;
        private System.Windows.Forms.Label aadApplicationLabel;
        private System.Windows.Forms.ComboBox aadApplicationComboBox;
        private System.Windows.Forms.Label dataProjectLabel;
        private System.Windows.Forms.TextBox dataProject;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.Label legalEntityLabel;
        private System.Windows.Forms.TextBox legalEntity;
        private System.Windows.Forms.CheckBox addTimestampCheckBox;
        private System.Windows.Forms.GroupBox retryPolicyGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown retriesDelayUpDown;
        private System.Windows.Forms.NumericUpDown retriesCountUpDown;
        private System.Windows.Forms.GroupBox groupBoxExceptions;
        private System.Windows.Forms.CheckBox pauseOnExceptionsCheckBox;
        private System.Windows.Forms.ToolStripButton customActionsButton;
        private System.Windows.Forms.CheckBox pauseIndefinitelyCheckBox;
    }
}