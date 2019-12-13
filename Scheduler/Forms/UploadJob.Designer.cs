using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class UploadJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadJob));
            this.jobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownIntervalUploads = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.processingErrorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.processingErrorsFolderTextBox = new System.Windows.Forms.TextBox();
            this.processingErrorsFolderLabel = new System.Windows.Forms.Label();
            this.statusFileExtensionTextBox = new System.Windows.Forms.TextBox();
            this.statusFileExtensionLabel = new System.Windows.Forms.Label();
            this.dataPackageCheckBox = new System.Windows.Forms.CheckBox();
            this.legalEntityTextBox = new System.Windows.Forms.TextBox();
            this.LegalEntityLabel = new System.Windows.Forms.Label();
            this.inputFolderBrowserButton = new System.Windows.Forms.Button();
            this.inputFolderTextBox = new System.Windows.Forms.TextBox();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.processingSuccessFolderBrowserButton = new System.Windows.Forms.Button();
            this.processingSuccessFolderTextBox = new System.Windows.Forms.TextBox();
            this.processingSuccessFolderLabel = new System.Windows.Forms.Label();
            this.uploadSuccessFolderBrowserButton = new System.Windows.Forms.Button();
            this.uploadSuccessFolderTextBox = new System.Windows.Forms.TextBox();
            this.uploadSuccessFolderLabel = new System.Windows.Forms.Label();
            this.useStandardSubfolder = new System.Windows.Forms.CheckBox();
            this.uploadErrorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.uploadErrorsFolderTextBox = new System.Windows.Forms.TextBox();
            this.uploadErrorsFolderLabel = new System.Windows.Forms.Label();
            this.topUploadFolderBrowserButton = new System.Windows.Forms.Button();
            this.topUploadFolderTextBox = new System.Windows.Forms.TextBox();
            this.topUploadFolderLabel = new System.Windows.Forms.Label();
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
            this.dataJobLabel = new System.Windows.Forms.Label();
            this.dataJobComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.instanceLabel = new System.Windows.Forms.Label();
            this.instanceComboBox = new System.Windows.Forms.ComboBox();
            this.recurrenceGroupBox = new System.Windows.Forms.GroupBox();
            this.pauseIndefinitelyCheckBox = new System.Windows.Forms.CheckBox();
            this.getCronScheduleForProcButton = new System.Windows.Forms.Button();
            this.moreExamplesButton = new System.Windows.Forms.Button();
            this.calculatedRunsTextBox = new System.Windows.Forms.TextBox();
            this.getCronScheduleForUploadButton = new System.Windows.Forms.Button();
            this.cronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.upJobTriggerTypePanel = new System.Windows.Forms.Panel();
            this.upJobCronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.upJobSimpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.buildCronLabel = new System.Windows.Forms.Label();
            this.cronTriggerInfoTextBox = new System.Windows.Forms.TextBox();
            this.cronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.upJobCronExpressionLabel = new System.Windows.Forms.Label();
            this.upJobCronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.upJobMinutesLabel = new System.Windows.Forms.Label();
            this.upJobHoursLabel = new System.Windows.Forms.Label();
            this.upJobStartAtLabel = new System.Windows.Forms.Label();
            this.upJobStartAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.upJobMinutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.upJobHoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.downloadFolderLabel = new System.Windows.Forms.Label();
            this.processingJobGroupBox = new System.Windows.Forms.GroupBox();
            this.procJobTriggerTypePanel = new System.Windows.Forms.Panel();
            this.procJobCronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.procJobSimpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.procJobCronExpressionLabel = new System.Windows.Forms.Label();
            this.procJobCronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.procJobMinutesLabel = new System.Windows.Forms.Label();
            this.procJobHoursLabel = new System.Windows.Forms.Label();
            this.procJobStartAtLabel = new System.Windows.Forms.Label();
            this.procJobStartAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.procJobMinutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.procJobHoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.useMonitoringJobCheckBox = new System.Windows.Forms.CheckBox();
            this.fileSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderDescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.orderAscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.searchPatternLabel = new System.Windows.Forms.Label();
            this.retryPolicyGroupBox = new System.Windows.Forms.GroupBox();
            this.retriesDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.retriesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxExceptions = new System.Windows.Forms.GroupBox();
            this.pauseOnExceptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.addJobButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.numericUpDownStatusCheckInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.jobDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalUploads)).BeginInit();
            this.axDetailsGroupBox.SuspendLayout();
            this.authMethodPanel.SuspendLayout();
            this.recurrenceGroupBox.SuspendLayout();
            this.upJobTriggerTypePanel.SuspendLayout();
            this.processingJobGroupBox.SuspendLayout();
            this.procJobTriggerTypePanel.SuspendLayout();
            this.fileSelectionGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.retryPolicyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).BeginInit();
            this.groupBoxExceptions.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatusCheckInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Controls.Add(this.numericUpDownIntervalUploads);
            this.jobDetailsGroupBox.Controls.Add(this.labelInterval);
            this.jobDetailsGroupBox.Controls.Add(this.processingErrorsFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.processingErrorsFolderTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.processingErrorsFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.statusFileExtensionTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.statusFileExtensionLabel);
            this.jobDetailsGroupBox.Controls.Add(this.dataPackageCheckBox);
            this.jobDetailsGroupBox.Controls.Add(this.legalEntityTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.LegalEntityLabel);
            this.jobDetailsGroupBox.Controls.Add(this.inputFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.inputFolderTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.inputFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.processingSuccessFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.processingSuccessFolderTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.processingSuccessFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.uploadSuccessFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.uploadSuccessFolderTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.uploadSuccessFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.useStandardSubfolder);
            this.jobDetailsGroupBox.Controls.Add(this.uploadErrorsFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.uploadErrorsFolderTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.uploadErrorsFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.topUploadFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.topUploadFolderTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.topUploadFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescription);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescriptionLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobGroupComboBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobGroupLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobName);
            this.jobDetailsGroupBox.Controls.Add(this.jobNameLabel);
            this.jobDetailsGroupBox.Location = new System.Drawing.Point(24, 24);
            this.jobDetailsGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.jobDetailsGroupBox.Name = "jobDetailsGroupBox";
            this.jobDetailsGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(420, 931);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job details";
            // 
            // numericUpDownIntervalUploads
            // 
            this.numericUpDownIntervalUploads.Location = new System.Drawing.Point(290, 884);
            this.numericUpDownIntervalUploads.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDownIntervalUploads.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownIntervalUploads.Name = "numericUpDownIntervalUploads";
            this.numericUpDownIntervalUploads.Size = new System.Drawing.Size(121, 29);
            this.numericUpDownIntervalUploads.TabIndex = 30;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(13, 888);
            this.labelInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(270, 25);
            this.labelInterval.TabIndex = 29;
            this.labelInterval.Text = "Delay between uploads (sec.)";
            // 
            // processingErrorsFolderBrowserButton
            // 
            this.processingErrorsFolderBrowserButton.Enabled = false;
            this.processingErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingErrorsFolderBrowserButton.Location = new System.Drawing.Point(367, 679);
            this.processingErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingErrorsFolderBrowserButton.Name = "processingErrorsFolderBrowserButton";
            this.processingErrorsFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.processingErrorsFolderBrowserButton.TabIndex = 27;
            this.processingErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingErrorsFolderBrowserButton.Click += new System.EventHandler(this.ProcessingErrorsFolderBrowserButton_Click);
            // 
            // processingErrorsFolderTextBox
            // 
            this.processingErrorsFolderTextBox.Enabled = false;
            this.processingErrorsFolderTextBox.Location = new System.Drawing.Point(20, 686);
            this.processingErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.processingErrorsFolderTextBox.Name = "processingErrorsFolderTextBox";
            this.processingErrorsFolderTextBox.Size = new System.Drawing.Size(339, 29);
            this.processingErrorsFolderTextBox.TabIndex = 26;
            // 
            // processingErrorsFolderLabel
            // 
            this.processingErrorsFolderLabel.AutoSize = true;
            this.processingErrorsFolderLabel.Location = new System.Drawing.Point(15, 654);
            this.processingErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.processingErrorsFolderLabel.Name = "processingErrorsFolderLabel";
            this.processingErrorsFolderLabel.Size = new System.Drawing.Size(217, 25);
            this.processingErrorsFolderLabel.TabIndex = 28;
            this.processingErrorsFolderLabel.Text = "Processing errors folder";
            // 
            // statusFileExtensionTextBox
            // 
            this.statusFileExtensionTextBox.Enabled = false;
            this.statusFileExtensionTextBox.Location = new System.Drawing.Point(260, 838);
            this.statusFileExtensionTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.statusFileExtensionTextBox.Name = "statusFileExtensionTextBox";
            this.statusFileExtensionTextBox.Size = new System.Drawing.Size(143, 29);
            this.statusFileExtensionTextBox.TabIndex = 25;
            this.statusFileExtensionTextBox.Text = ".Status";
            this.statusFileExtensionTextBox.Leave += new System.EventHandler(this.StatusFileExtensionTextBox_Leave);
            // 
            // statusFileExtensionLabel
            // 
            this.statusFileExtensionLabel.AutoSize = true;
            this.statusFileExtensionLabel.Location = new System.Drawing.Point(66, 844);
            this.statusFileExtensionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.statusFileExtensionLabel.Name = "statusFileExtensionLabel";
            this.statusFileExtensionLabel.Size = new System.Drawing.Size(186, 25);
            this.statusFileExtensionLabel.TabIndex = 24;
            this.statusFileExtensionLabel.Text = "Status file extension";
            // 
            // dataPackageCheckBox
            // 
            this.dataPackageCheckBox.AutoSize = true;
            this.dataPackageCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataPackageCheckBox.Location = new System.Drawing.Point(22, 750);
            this.dataPackageCheckBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataPackageCheckBox.Name = "dataPackageCheckBox";
            this.dataPackageCheckBox.Size = new System.Drawing.Size(259, 29);
            this.dataPackageCheckBox.TabIndex = 23;
            this.dataPackageCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Uploading_data_packages;
            this.dataPackageCheckBox.UseVisualStyleBackColor = true;
            // 
            // legalEntityTextBox
            // 
            this.legalEntityTextBox.Location = new System.Drawing.Point(260, 794);
            this.legalEntityTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.legalEntityTextBox.Name = "legalEntityTextBox";
            this.legalEntityTextBox.Size = new System.Drawing.Size(143, 29);
            this.legalEntityTextBox.TabIndex = 22;
            // 
            // LegalEntityLabel
            // 
            this.LegalEntityLabel.AutoSize = true;
            this.LegalEntityLabel.Location = new System.Drawing.Point(51, 798);
            this.LegalEntityLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LegalEntityLabel.Name = "LegalEntityLabel";
            this.LegalEntityLabel.Size = new System.Drawing.Size(198, 25);
            this.LegalEntityLabel.TabIndex = 21;
            this.LegalEntityLabel.Text = "Legal entity (optional)";
            // 
            // inputFolderBrowserButton
            // 
            this.inputFolderBrowserButton.Enabled = false;
            this.inputFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.inputFolderBrowserButton.Location = new System.Drawing.Point(367, 386);
            this.inputFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.inputFolderBrowserButton.Name = "inputFolderBrowserButton";
            this.inputFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.inputFolderBrowserButton.TabIndex = 19;
            this.inputFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.inputFolderBrowserButton.UseVisualStyleBackColor = true;
            this.inputFolderBrowserButton.Click += new System.EventHandler(this.InputFolderButton_Click);
            // 
            // inputFolderTextBox
            // 
            this.inputFolderTextBox.Enabled = false;
            this.inputFolderTextBox.Location = new System.Drawing.Point(20, 394);
            this.inputFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputFolderTextBox.Name = "inputFolderTextBox";
            this.inputFolderTextBox.Size = new System.Drawing.Size(339, 29);
            this.inputFolderTextBox.TabIndex = 18;
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(15, 360);
            this.inputFolderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(140, 25);
            this.inputFolderLabel.TabIndex = 20;
            this.inputFolderLabel.Text = "Input subfolder";
            // 
            // processingSuccessFolderBrowserButton
            // 
            this.processingSuccessFolderBrowserButton.Enabled = false;
            this.processingSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingSuccessFolderBrowserButton.Location = new System.Drawing.Point(367, 606);
            this.processingSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingSuccessFolderBrowserButton.Name = "processingSuccessFolderBrowserButton";
            this.processingSuccessFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.processingSuccessFolderBrowserButton.TabIndex = 16;
            this.processingSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingSuccessFolderBrowserButton.Click += new System.EventHandler(this.ProcessingSuccessFolderButton_Click);
            // 
            // processingSuccessFolderTextBox
            // 
            this.processingSuccessFolderTextBox.Enabled = false;
            this.processingSuccessFolderTextBox.Location = new System.Drawing.Point(20, 613);
            this.processingSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.processingSuccessFolderTextBox.Name = "processingSuccessFolderTextBox";
            this.processingSuccessFolderTextBox.Size = new System.Drawing.Size(339, 29);
            this.processingSuccessFolderTextBox.TabIndex = 15;
            // 
            // processingSuccessFolderLabel
            // 
            this.processingSuccessFolderLabel.AutoSize = true;
            this.processingSuccessFolderLabel.Location = new System.Drawing.Point(15, 580);
            this.processingSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.processingSuccessFolderLabel.Name = "processingSuccessFolderLabel";
            this.processingSuccessFolderLabel.Size = new System.Drawing.Size(239, 25);
            this.processingSuccessFolderLabel.TabIndex = 17;
            this.processingSuccessFolderLabel.Text = "Processing success folder";
            // 
            // uploadSuccessFolderBrowserButton
            // 
            this.uploadSuccessFolderBrowserButton.Enabled = false;
            this.uploadSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadSuccessFolderBrowserButton.Location = new System.Drawing.Point(367, 460);
            this.uploadSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadSuccessFolderBrowserButton.Name = "uploadSuccessFolderBrowserButton";
            this.uploadSuccessFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.uploadSuccessFolderBrowserButton.TabIndex = 13;
            this.uploadSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadSuccessFolderBrowserButton.Click += new System.EventHandler(this.UploadSuccessFolderButton_Click);
            // 
            // uploadSuccessFolderTextBox
            // 
            this.uploadSuccessFolderTextBox.Enabled = false;
            this.uploadSuccessFolderTextBox.Location = new System.Drawing.Point(20, 467);
            this.uploadSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uploadSuccessFolderTextBox.Name = "uploadSuccessFolderTextBox";
            this.uploadSuccessFolderTextBox.Size = new System.Drawing.Size(339, 29);
            this.uploadSuccessFolderTextBox.TabIndex = 12;
            // 
            // uploadSuccessFolderLabel
            // 
            this.uploadSuccessFolderLabel.AutoSize = true;
            this.uploadSuccessFolderLabel.Location = new System.Drawing.Point(15, 434);
            this.uploadSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uploadSuccessFolderLabel.Name = "uploadSuccessFolderLabel";
            this.uploadSuccessFolderLabel.Size = new System.Drawing.Size(204, 25);
            this.uploadSuccessFolderLabel.TabIndex = 14;
            this.uploadSuccessFolderLabel.Text = "Upload success folder";
            // 
            // useStandardSubfolder
            // 
            this.useStandardSubfolder.AutoSize = true;
            this.useStandardSubfolder.Checked = true;
            this.useStandardSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useStandardSubfolder.Location = new System.Drawing.Point(18, 322);
            this.useStandardSubfolder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.useStandardSubfolder.Name = "useStandardSubfolder";
            this.useStandardSubfolder.Size = new System.Drawing.Size(295, 29);
            this.useStandardSubfolder.TabIndex = 8;
            this.useStandardSubfolder.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Use_default_subfolders_names;
            this.useStandardSubfolder.UseVisualStyleBackColor = true;
            this.useStandardSubfolder.CheckedChanged += new System.EventHandler(this.UseStandardSubfolder_CheckedChanged);
            // 
            // uploadErrorsFolderBrowserButton
            // 
            this.uploadErrorsFolderBrowserButton.Enabled = false;
            this.uploadErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadErrorsFolderBrowserButton.Location = new System.Drawing.Point(367, 532);
            this.uploadErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadErrorsFolderBrowserButton.Name = "uploadErrorsFolderBrowserButton";
            this.uploadErrorsFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.uploadErrorsFolderBrowserButton.TabIndex = 7;
            this.uploadErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadErrorsFolderBrowserButton.Click += new System.EventHandler(this.UploadErrorsFolderBrowserButton_Click);
            // 
            // uploadErrorsFolderTextBox
            // 
            this.uploadErrorsFolderTextBox.Enabled = false;
            this.uploadErrorsFolderTextBox.Location = new System.Drawing.Point(20, 539);
            this.uploadErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uploadErrorsFolderTextBox.Name = "uploadErrorsFolderTextBox";
            this.uploadErrorsFolderTextBox.Size = new System.Drawing.Size(339, 29);
            this.uploadErrorsFolderTextBox.TabIndex = 6;
            // 
            // uploadErrorsFolderLabel
            // 
            this.uploadErrorsFolderLabel.AutoSize = true;
            this.uploadErrorsFolderLabel.Location = new System.Drawing.Point(15, 508);
            this.uploadErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uploadErrorsFolderLabel.Name = "uploadErrorsFolderLabel";
            this.uploadErrorsFolderLabel.Size = new System.Drawing.Size(182, 25);
            this.uploadErrorsFolderLabel.TabIndex = 11;
            this.uploadErrorsFolderLabel.Text = "Upload errors folder";
            // 
            // topUploadFolderBrowserButton
            // 
            this.topUploadFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topUploadFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.topUploadFolderBrowserButton.Location = new System.Drawing.Point(367, 274);
            this.topUploadFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.topUploadFolderBrowserButton.Name = "topUploadFolderBrowserButton";
            this.topUploadFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.topUploadFolderBrowserButton.TabIndex = 5;
            this.topUploadFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.topUploadFolderBrowserButton.UseVisualStyleBackColor = true;
            this.topUploadFolderBrowserButton.Click += new System.EventHandler(this.TopUploadFolderBrowserButton_Click);
            // 
            // topUploadFolderTextBox
            // 
            this.topUploadFolderTextBox.Location = new System.Drawing.Point(20, 281);
            this.topUploadFolderTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.topUploadFolderTextBox.Name = "topUploadFolderTextBox";
            this.topUploadFolderTextBox.Size = new System.Drawing.Size(339, 29);
            this.topUploadFolderTextBox.TabIndex = 4;
            this.topUploadFolderTextBox.TextChanged += new System.EventHandler(this.TopUploadFolder_TextChanged);
            // 
            // topUploadFolderLabel
            // 
            this.topUploadFolderLabel.AutoSize = true;
            this.topUploadFolderLabel.Location = new System.Drawing.Point(15, 247);
            this.topUploadFolderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.topUploadFolderLabel.Name = "topUploadFolderLabel";
            this.topUploadFolderLabel.Size = new System.Drawing.Size(164, 25);
            this.topUploadFolderLabel.TabIndex = 8;
            this.topUploadFolderLabel.Text = "Top upload folder";
            // 
            // jobDescription
            // 
            this.jobDescription.Location = new System.Drawing.Point(22, 174);
            this.jobDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.jobDescription.Multiline = true;
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.Size = new System.Drawing.Size(383, 63);
            this.jobDescription.TabIndex = 3;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(15, 140);
            this.jobDescriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(109, 25);
            this.jobDescriptionLabel.TabIndex = 4;
            this.jobDescriptionLabel.Text = "Description";
            // 
            // jobGroupComboBox
            // 
            this.jobGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobGroupComboBox.FormattingEnabled = true;
            this.jobGroupComboBox.Location = new System.Drawing.Point(92, 90);
            this.jobGroupComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.jobGroupComboBox.Name = "jobGroupComboBox";
            this.jobGroupComboBox.Size = new System.Drawing.Size(314, 32);
            this.jobGroupComboBox.Sorted = true;
            this.jobGroupComboBox.TabIndex = 2;
            // 
            // jobGroupLabel
            // 
            this.jobGroupLabel.AutoSize = true;
            this.jobGroupLabel.Location = new System.Drawing.Point(15, 96);
            this.jobGroupLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.jobGroupLabel.Name = "jobGroupLabel";
            this.jobGroupLabel.Size = new System.Drawing.Size(66, 25);
            this.jobGroupLabel.TabIndex = 2;
            this.jobGroupLabel.Text = "Group";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(92, 31);
            this.jobName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(314, 29);
            this.jobName.TabIndex = 1;
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Location = new System.Drawing.Point(15, 37);
            this.jobNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(64, 25);
            this.jobNameLabel.TabIndex = 0;
            this.jobNameLabel.Text = "Name";
            // 
            // axDetailsGroupBox
            // 
            this.axDetailsGroupBox.Controls.Add(this.aadApplicationLabel);
            this.axDetailsGroupBox.Controls.Add(this.aadApplicationComboBox);
            this.axDetailsGroupBox.Controls.Add(this.authMethodPanel);
            this.axDetailsGroupBox.Controls.Add(this.dataJobLabel);
            this.axDetailsGroupBox.Controls.Add(this.dataJobComboBox);
            this.axDetailsGroupBox.Controls.Add(this.userLabel);
            this.axDetailsGroupBox.Controls.Add(this.userComboBox);
            this.axDetailsGroupBox.Controls.Add(this.instanceLabel);
            this.axDetailsGroupBox.Controls.Add(this.instanceComboBox);
            this.axDetailsGroupBox.Location = new System.Drawing.Point(458, 212);
            this.axDetailsGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.axDetailsGroupBox.Name = "axDetailsGroupBox";
            this.axDetailsGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.axDetailsGroupBox.Size = new System.Drawing.Size(422, 298);
            this.axDetailsGroupBox.TabIndex = 1;
            this.axDetailsGroupBox.TabStop = false;
            this.axDetailsGroupBox.Text = "Dynamics details";
            // 
            // aadApplicationLabel
            // 
            this.aadApplicationLabel.AutoSize = true;
            this.aadApplicationLabel.Location = new System.Drawing.Point(22, 194);
            this.aadApplicationLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aadApplicationLabel.Name = "aadApplicationLabel";
            this.aadApplicationLabel.Size = new System.Drawing.Size(152, 25);
            this.aadApplicationLabel.TabIndex = 32;
            this.aadApplicationLabel.Text = "AAD application";
            // 
            // aadApplicationComboBox
            // 
            this.aadApplicationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aadApplicationComboBox.FormattingEnabled = true;
            this.aadApplicationComboBox.Location = new System.Drawing.Point(194, 188);
            this.aadApplicationComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.aadApplicationComboBox.Name = "aadApplicationComboBox";
            this.aadApplicationComboBox.Size = new System.Drawing.Size(212, 32);
            this.aadApplicationComboBox.TabIndex = 31;
            // 
            // authMethodPanel
            // 
            this.authMethodPanel.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodPanel.Controls.Add(this.userAuthRadioButton);
            this.authMethodPanel.Location = new System.Drawing.Point(15, 131);
            this.authMethodPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.authMethodPanel.Name = "authMethodPanel";
            this.authMethodPanel.Size = new System.Drawing.Size(392, 46);
            this.authMethodPanel.TabIndex = 30;
            // 
            // serviceAuthRadioButton
            // 
            this.serviceAuthRadioButton.AutoSize = true;
            this.serviceAuthRadioButton.Location = new System.Drawing.Point(216, 6);
            this.serviceAuthRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.serviceAuthRadioButton.Name = "serviceAuthRadioButton";
            this.serviceAuthRadioButton.Size = new System.Drawing.Size(146, 29);
            this.serviceAuthRadioButton.TabIndex = 16;
            this.serviceAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Service_auth;
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(5, 6);
            this.userAuthRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(121, 29);
            this.userAuthRadioButton.TabIndex = 15;
            this.userAuthRadioButton.TabStop = true;
            this.userAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.User_auth;
            this.userAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // dataJobLabel
            // 
            this.dataJobLabel.AutoSize = true;
            this.dataJobLabel.Location = new System.Drawing.Point(37, 86);
            this.dataJobLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dataJobLabel.Name = "dataJobLabel";
            this.dataJobLabel.Size = new System.Drawing.Size(84, 25);
            this.dataJobLabel.TabIndex = 22;
            this.dataJobLabel.Text = "Data job";
            // 
            // dataJobComboBox
            // 
            this.dataJobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataJobComboBox.FormattingEnabled = true;
            this.dataJobComboBox.Location = new System.Drawing.Point(139, 83);
            this.dataJobComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataJobComboBox.Name = "dataJobComboBox";
            this.dataJobComboBox.Size = new System.Drawing.Size(266, 32);
            this.dataJobComboBox.TabIndex = 11;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(125, 242);
            this.userLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 25);
            this.userLabel.TabIndex = 19;
            this.userLabel.Text = "User";
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(194, 236);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(212, 32);
            this.userComboBox.TabIndex = 10;
            // 
            // instanceLabel
            // 
            this.instanceLabel.AutoSize = true;
            this.instanceLabel.Location = new System.Drawing.Point(37, 41);
            this.instanceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.instanceLabel.Name = "instanceLabel";
            this.instanceLabel.Size = new System.Drawing.Size(86, 25);
            this.instanceLabel.TabIndex = 16;
            this.instanceLabel.Text = "Instance";
            // 
            // instanceComboBox
            // 
            this.instanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceComboBox.FormattingEnabled = true;
            this.instanceComboBox.Location = new System.Drawing.Point(139, 35);
            this.instanceComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.instanceComboBox.Name = "instanceComboBox";
            this.instanceComboBox.Size = new System.Drawing.Size(266, 32);
            this.instanceComboBox.TabIndex = 9;
            // 
            // recurrenceGroupBox
            // 
            this.recurrenceGroupBox.Controls.Add(this.pauseIndefinitelyCheckBox);
            this.recurrenceGroupBox.Controls.Add(this.getCronScheduleForProcButton);
            this.recurrenceGroupBox.Controls.Add(this.moreExamplesButton);
            this.recurrenceGroupBox.Controls.Add(this.calculatedRunsTextBox);
            this.recurrenceGroupBox.Controls.Add(this.getCronScheduleForUploadButton);
            this.recurrenceGroupBox.Controls.Add(this.cronDocsLinkLabel);
            this.recurrenceGroupBox.Controls.Add(this.upJobTriggerTypePanel);
            this.recurrenceGroupBox.Controls.Add(this.buildCronLabel);
            this.recurrenceGroupBox.Controls.Add(this.cronTriggerInfoTextBox);
            this.recurrenceGroupBox.Controls.Add(this.cronmakerLinkLabel);
            this.recurrenceGroupBox.Controls.Add(this.upJobCronExpressionLabel);
            this.recurrenceGroupBox.Controls.Add(this.upJobCronExpressionTextBox);
            this.recurrenceGroupBox.Controls.Add(this.upJobMinutesLabel);
            this.recurrenceGroupBox.Controls.Add(this.upJobHoursLabel);
            this.recurrenceGroupBox.Controls.Add(this.upJobStartAtLabel);
            this.recurrenceGroupBox.Controls.Add(this.upJobStartAtDateTimePicker);
            this.recurrenceGroupBox.Controls.Add(this.upJobMinutesDateTimePicker);
            this.recurrenceGroupBox.Controls.Add(this.upJobHoursDateTimePicker);
            this.recurrenceGroupBox.Location = new System.Drawing.Point(891, 24);
            this.recurrenceGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.recurrenceGroupBox.Name = "recurrenceGroupBox";
            this.recurrenceGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.recurrenceGroupBox.Size = new System.Drawing.Size(422, 830);
            this.recurrenceGroupBox.TabIndex = 2;
            this.recurrenceGroupBox.TabStop = false;
            this.recurrenceGroupBox.Text = "Recurrence";
            // 
            // pauseIndefinitelyCheckBox
            // 
            this.pauseIndefinitelyCheckBox.AutoSize = true;
            this.pauseIndefinitelyCheckBox.Location = new System.Drawing.Point(17, 31);
            this.pauseIndefinitelyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.pauseIndefinitelyCheckBox.Name = "pauseIndefinitelyCheckBox";
            this.pauseIndefinitelyCheckBox.Size = new System.Drawing.Size(221, 29);
            this.pauseIndefinitelyCheckBox.TabIndex = 0;
            this.pauseIndefinitelyCheckBox.Text = "Pause job indefinitely";
            this.pauseIndefinitelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // getCronScheduleForProcButton
            // 
            this.getCronScheduleForProcButton.Enabled = false;
            this.getCronScheduleForProcButton.Location = new System.Drawing.Point(218, 620);
            this.getCronScheduleForProcButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.getCronScheduleForProcButton.Name = "getCronScheduleForProcButton";
            this.getCronScheduleForProcButton.Size = new System.Drawing.Size(193, 66);
            this.getCronScheduleForProcButton.TabIndex = 33;
            this.getCronScheduleForProcButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Get_cron_schedule_for_monitor_job;
            this.getCronScheduleForProcButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForProcButton.Click += new System.EventHandler(this.GetCronScheduleForProcButton_Click);
            // 
            // moreExamplesButton
            // 
            this.moreExamplesButton.Location = new System.Drawing.Point(290, 694);
            this.moreExamplesButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.moreExamplesButton.Name = "moreExamplesButton";
            this.moreExamplesButton.Size = new System.Drawing.Size(121, 102);
            this.moreExamplesButton.TabIndex = 19;
            this.moreExamplesButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesButton.UseVisualStyleBackColor = true;
            this.moreExamplesButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
            // 
            // calculatedRunsTextBox
            // 
            this.calculatedRunsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsTextBox.Location = new System.Drawing.Point(17, 694);
            this.calculatedRunsTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.calculatedRunsTextBox.Multiline = true;
            this.calculatedRunsTextBox.Name = "calculatedRunsTextBox";
            this.calculatedRunsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsTextBox.Size = new System.Drawing.Size(263, 98);
            this.calculatedRunsTextBox.TabIndex = 32;
            this.calculatedRunsTextBox.TabStop = false;
            // 
            // getCronScheduleForUploadButton
            // 
            this.getCronScheduleForUploadButton.Enabled = false;
            this.getCronScheduleForUploadButton.Location = new System.Drawing.Point(17, 620);
            this.getCronScheduleForUploadButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.getCronScheduleForUploadButton.Name = "getCronScheduleForUploadButton";
            this.getCronScheduleForUploadButton.Size = new System.Drawing.Size(193, 66);
            this.getCronScheduleForUploadButton.TabIndex = 18;
            this.getCronScheduleForUploadButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Get_cron_schedule_for_upload_job;
            this.getCronScheduleForUploadButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForUploadButton.Click += new System.EventHandler(this.GetCronScheduleForUploadButton_Click);
            // 
            // cronDocsLinkLabel
            // 
            this.cronDocsLinkLabel.AutoSize = true;
            this.cronDocsLinkLabel.Location = new System.Drawing.Point(11, 586);
            this.cronDocsLinkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cronDocsLinkLabel.Name = "cronDocsLinkLabel";
            this.cronDocsLinkLabel.Size = new System.Drawing.Size(316, 25);
            this.cronDocsLinkLabel.TabIndex = 30;
            this.cronDocsLinkLabel.TabStop = true;
            this.cronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.cronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // upJobTriggerTypePanel
            // 
            this.upJobTriggerTypePanel.Controls.Add(this.upJobCronTriggerRadioButton);
            this.upJobTriggerTypePanel.Controls.Add(this.upJobSimpleTriggerRadioButton);
            this.upJobTriggerTypePanel.Location = new System.Drawing.Point(17, 137);
            this.upJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.upJobTriggerTypePanel.Name = "upJobTriggerTypePanel";
            this.upJobTriggerTypePanel.Size = new System.Drawing.Size(381, 46);
            this.upJobTriggerTypePanel.TabIndex = 29;
            // 
            // upJobCronTriggerRadioButton
            // 
            this.upJobCronTriggerRadioButton.AutoSize = true;
            this.upJobCronTriggerRadioButton.Location = new System.Drawing.Point(216, 6);
            this.upJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.upJobCronTriggerRadioButton.Name = "upJobCronTriggerRadioButton";
            this.upJobCronTriggerRadioButton.Size = new System.Drawing.Size(139, 29);
            this.upJobCronTriggerRadioButton.TabIndex = 16;
            this.upJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.upJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.upJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.UpJobCronTriggerRadioButton_CheckedChanged);
            // 
            // upJobSimpleTriggerRadioButton
            // 
            this.upJobSimpleTriggerRadioButton.AutoSize = true;
            this.upJobSimpleTriggerRadioButton.Checked = true;
            this.upJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(5, 6);
            this.upJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.upJobSimpleTriggerRadioButton.Name = "upJobSimpleTriggerRadioButton";
            this.upJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(156, 29);
            this.upJobSimpleTriggerRadioButton.TabIndex = 15;
            this.upJobSimpleTriggerRadioButton.TabStop = true;
            this.upJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.upJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // buildCronLabel
            // 
            this.buildCronLabel.AutoSize = true;
            this.buildCronLabel.Location = new System.Drawing.Point(11, 548);
            this.buildCronLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buildCronLabel.Name = "buildCronLabel";
            this.buildCronLabel.Size = new System.Drawing.Size(219, 25);
            this.buildCronLabel.TabIndex = 26;
            this.buildCronLabel.Text = "Build cron expression at";
            // 
            // cronTriggerInfoTextBox
            // 
            this.cronTriggerInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cronTriggerInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cronTriggerInfoTextBox.Location = new System.Drawing.Point(17, 271);
            this.cronTriggerInfoTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cronTriggerInfoTextBox.Multiline = true;
            this.cronTriggerInfoTextBox.Name = "cronTriggerInfoTextBox";
            this.cronTriggerInfoTextBox.Size = new System.Drawing.Size(394, 271);
            this.cronTriggerInfoTextBox.TabIndex = 25;
            this.cronTriggerInfoTextBox.TabStop = false;
            this.cronTriggerInfoTextBox.Text = resources.GetString("cronTriggerInfoTextBox.Text");
            // 
            // cronmakerLinkLabel
            // 
            this.cronmakerLinkLabel.AutoSize = true;
            this.cronmakerLinkLabel.Location = new System.Drawing.Point(231, 548);
            this.cronmakerLinkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cronmakerLinkLabel.Name = "cronmakerLinkLabel";
            this.cronmakerLinkLabel.Size = new System.Drawing.Size(146, 25);
            this.cronmakerLinkLabel.TabIndex = 24;
            this.cronmakerLinkLabel.TabStop = true;
            this.cronmakerLinkLabel.Text = "cronmaker.com";
            this.cronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // upJobCronExpressionLabel
            // 
            this.upJobCronExpressionLabel.AutoSize = true;
            this.upJobCronExpressionLabel.Location = new System.Drawing.Point(11, 194);
            this.upJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.upJobCronExpressionLabel.Name = "upJobCronExpressionLabel";
            this.upJobCronExpressionLabel.Size = new System.Drawing.Size(155, 25);
            this.upJobCronExpressionLabel.TabIndex = 23;
            this.upJobCronExpressionLabel.Text = "Cron expression";
            // 
            // upJobCronExpressionTextBox
            // 
            this.upJobCronExpressionTextBox.Enabled = false;
            this.upJobCronExpressionTextBox.Location = new System.Drawing.Point(17, 223);
            this.upJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.upJobCronExpressionTextBox.Name = "upJobCronExpressionTextBox";
            this.upJobCronExpressionTextBox.Size = new System.Drawing.Size(390, 29);
            this.upJobCronExpressionTextBox.TabIndex = 17;
            this.upJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // upJobMinutesLabel
            // 
            this.upJobMinutesLabel.AutoSize = true;
            this.upJobMinutesLabel.Location = new System.Drawing.Point(117, 94);
            this.upJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.upJobMinutesLabel.Name = "upJobMinutesLabel";
            this.upJobMinutesLabel.Size = new System.Drawing.Size(35, 25);
            this.upJobMinutesLabel.TabIndex = 5;
            this.upJobMinutesLabel.Text = "M:";
            this.upJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobHoursLabel
            // 
            this.upJobHoursLabel.AutoSize = true;
            this.upJobHoursLabel.Location = new System.Drawing.Point(11, 94);
            this.upJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.upJobHoursLabel.Name = "upJobHoursLabel";
            this.upJobHoursLabel.Size = new System.Drawing.Size(32, 25);
            this.upJobHoursLabel.TabIndex = 4;
            this.upJobHoursLabel.Text = "H:";
            this.upJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobStartAtLabel
            // 
            this.upJobStartAtLabel.AutoSize = true;
            this.upJobStartAtLabel.Location = new System.Drawing.Point(231, 94);
            this.upJobStartAtLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.upJobStartAtLabel.Name = "upJobStartAtLabel";
            this.upJobStartAtLabel.Size = new System.Drawing.Size(70, 25);
            this.upJobStartAtLabel.TabIndex = 3;
            this.upJobStartAtLabel.Text = "start at";
            this.upJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobStartAtDateTimePicker
            // 
            this.upJobStartAtDateTimePicker.CustomFormat = "HH:mm";
            this.upJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobStartAtDateTimePicker.Location = new System.Drawing.Point(303, 89);
            this.upJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.upJobStartAtDateTimePicker.Name = "upJobStartAtDateTimePicker";
            this.upJobStartAtDateTimePicker.ShowUpDown = true;
            this.upJobStartAtDateTimePicker.Size = new System.Drawing.Size(92, 29);
            this.upJobStartAtDateTimePicker.TabIndex = 14;
            this.upJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // upJobMinutesDateTimePicker
            // 
            this.upJobMinutesDateTimePicker.CustomFormat = "mm";
            this.upJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobMinutesDateTimePicker.Location = new System.Drawing.Point(152, 89);
            this.upJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.upJobMinutesDateTimePicker.Name = "upJobMinutesDateTimePicker";
            this.upJobMinutesDateTimePicker.ShowUpDown = true;
            this.upJobMinutesDateTimePicker.Size = new System.Drawing.Size(60, 29);
            this.upJobMinutesDateTimePicker.TabIndex = 13;
            this.upJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 1, 0, 0);
            // 
            // upJobHoursDateTimePicker
            // 
            this.upJobHoursDateTimePicker.CustomFormat = "HH";
            this.upJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobHoursDateTimePicker.Location = new System.Drawing.Point(44, 89);
            this.upJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.upJobHoursDateTimePicker.Name = "upJobHoursDateTimePicker";
            this.upJobHoursDateTimePicker.ShowUpDown = true;
            this.upJobHoursDateTimePicker.Size = new System.Drawing.Size(60, 29);
            this.upJobHoursDateTimePicker.TabIndex = 12;
            this.upJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // downloadFolderLabel
            // 
            this.downloadFolderLabel.AutoSize = true;
            this.downloadFolderLabel.Location = new System.Drawing.Point(9, 157);
            this.downloadFolderLabel.Name = "downloadFolderLabel";
            this.downloadFolderLabel.Size = new System.Drawing.Size(90, 13);
            this.downloadFolderLabel.TabIndex = 8;
            this.downloadFolderLabel.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Top_upload_folder;
            // 
            // processingJobGroupBox
            // 
            this.processingJobGroupBox.Controls.Add(this.numericUpDownStatusCheckInterval);
            this.processingJobGroupBox.Controls.Add(this.label3);
            this.processingJobGroupBox.Controls.Add(this.procJobTriggerTypePanel);
            this.processingJobGroupBox.Controls.Add(this.procJobCronExpressionLabel);
            this.processingJobGroupBox.Controls.Add(this.procJobCronExpressionTextBox);
            this.processingJobGroupBox.Controls.Add(this.procJobMinutesLabel);
            this.processingJobGroupBox.Controls.Add(this.procJobHoursLabel);
            this.processingJobGroupBox.Controls.Add(this.procJobStartAtLabel);
            this.processingJobGroupBox.Controls.Add(this.procJobStartAtDateTimePicker);
            this.processingJobGroupBox.Controls.Add(this.procJobMinutesDateTimePicker);
            this.processingJobGroupBox.Controls.Add(this.procJobHoursDateTimePicker);
            this.processingJobGroupBox.Enabled = false;
            this.processingJobGroupBox.Location = new System.Drawing.Point(458, 559);
            this.processingJobGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.processingJobGroupBox.Name = "processingJobGroupBox";
            this.processingJobGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.processingJobGroupBox.Size = new System.Drawing.Size(422, 288);
            this.processingJobGroupBox.TabIndex = 4;
            this.processingJobGroupBox.TabStop = false;
            this.processingJobGroupBox.Text = "Processing monitor job";
            // 
            // procJobTriggerTypePanel
            // 
            this.procJobTriggerTypePanel.Controls.Add(this.procJobCronTriggerRadioButton);
            this.procJobTriggerTypePanel.Controls.Add(this.procJobSimpleTriggerRadioButton);
            this.procJobTriggerTypePanel.Location = new System.Drawing.Point(17, 89);
            this.procJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.procJobTriggerTypePanel.Name = "procJobTriggerTypePanel";
            this.procJobTriggerTypePanel.Size = new System.Drawing.Size(381, 46);
            this.procJobTriggerTypePanel.TabIndex = 38;
            // 
            // procJobCronTriggerRadioButton
            // 
            this.procJobCronTriggerRadioButton.AutoSize = true;
            this.procJobCronTriggerRadioButton.Location = new System.Drawing.Point(216, 4);
            this.procJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.procJobCronTriggerRadioButton.Name = "procJobCronTriggerRadioButton";
            this.procJobCronTriggerRadioButton.Size = new System.Drawing.Size(139, 29);
            this.procJobCronTriggerRadioButton.TabIndex = 16;
            this.procJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.procJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.procJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.ProcJobCronTriggerRadioButton_CheckedChanged);
            // 
            // procJobSimpleTriggerRadioButton
            // 
            this.procJobSimpleTriggerRadioButton.AutoSize = true;
            this.procJobSimpleTriggerRadioButton.Checked = true;
            this.procJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(5, 6);
            this.procJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.procJobSimpleTriggerRadioButton.Name = "procJobSimpleTriggerRadioButton";
            this.procJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(156, 29);
            this.procJobSimpleTriggerRadioButton.TabIndex = 15;
            this.procJobSimpleTriggerRadioButton.TabStop = true;
            this.procJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.procJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // procJobCronExpressionLabel
            // 
            this.procJobCronExpressionLabel.AutoSize = true;
            this.procJobCronExpressionLabel.Location = new System.Drawing.Point(11, 146);
            this.procJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.procJobCronExpressionLabel.Name = "procJobCronExpressionLabel";
            this.procJobCronExpressionLabel.Size = new System.Drawing.Size(155, 25);
            this.procJobCronExpressionLabel.TabIndex = 37;
            this.procJobCronExpressionLabel.Text = "Cron expression";
            // 
            // procJobCronExpressionTextBox
            // 
            this.procJobCronExpressionTextBox.Enabled = false;
            this.procJobCronExpressionTextBox.Location = new System.Drawing.Point(17, 175);
            this.procJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.procJobCronExpressionTextBox.Name = "procJobCronExpressionTextBox";
            this.procJobCronExpressionTextBox.Size = new System.Drawing.Size(390, 29);
            this.procJobCronExpressionTextBox.TabIndex = 36;
            this.procJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // procJobMinutesLabel
            // 
            this.procJobMinutesLabel.AutoSize = true;
            this.procJobMinutesLabel.Location = new System.Drawing.Point(117, 46);
            this.procJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.procJobMinutesLabel.Name = "procJobMinutesLabel";
            this.procJobMinutesLabel.Size = new System.Drawing.Size(35, 25);
            this.procJobMinutesLabel.TabIndex = 32;
            this.procJobMinutesLabel.Text = "M:";
            this.procJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobHoursLabel
            // 
            this.procJobHoursLabel.AutoSize = true;
            this.procJobHoursLabel.Location = new System.Drawing.Point(11, 46);
            this.procJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.procJobHoursLabel.Name = "procJobHoursLabel";
            this.procJobHoursLabel.Size = new System.Drawing.Size(32, 25);
            this.procJobHoursLabel.TabIndex = 31;
            this.procJobHoursLabel.Text = "H:";
            this.procJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobStartAtLabel
            // 
            this.procJobStartAtLabel.AutoSize = true;
            this.procJobStartAtLabel.Location = new System.Drawing.Point(231, 46);
            this.procJobStartAtLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.procJobStartAtLabel.Name = "procJobStartAtLabel";
            this.procJobStartAtLabel.Size = new System.Drawing.Size(70, 25);
            this.procJobStartAtLabel.TabIndex = 30;
            this.procJobStartAtLabel.Text = "start at";
            this.procJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobStartAtDateTimePicker
            // 
            this.procJobStartAtDateTimePicker.CustomFormat = "HH:mm";
            this.procJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobStartAtDateTimePicker.Location = new System.Drawing.Point(303, 41);
            this.procJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.procJobStartAtDateTimePicker.Name = "procJobStartAtDateTimePicker";
            this.procJobStartAtDateTimePicker.ShowUpDown = true;
            this.procJobStartAtDateTimePicker.Size = new System.Drawing.Size(92, 29);
            this.procJobStartAtDateTimePicker.TabIndex = 35;
            this.procJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // procJobMinutesDateTimePicker
            // 
            this.procJobMinutesDateTimePicker.CustomFormat = "mm";
            this.procJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobMinutesDateTimePicker.Location = new System.Drawing.Point(152, 41);
            this.procJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.procJobMinutesDateTimePicker.Name = "procJobMinutesDateTimePicker";
            this.procJobMinutesDateTimePicker.ShowUpDown = true;
            this.procJobMinutesDateTimePicker.Size = new System.Drawing.Size(60, 29);
            this.procJobMinutesDateTimePicker.TabIndex = 34;
            this.procJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 30, 0, 0);
            // 
            // procJobHoursDateTimePicker
            // 
            this.procJobHoursDateTimePicker.CustomFormat = "HH";
            this.procJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobHoursDateTimePicker.Location = new System.Drawing.Point(44, 41);
            this.procJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.procJobHoursDateTimePicker.Name = "procJobHoursDateTimePicker";
            this.procJobHoursDateTimePicker.ShowUpDown = true;
            this.procJobHoursDateTimePicker.Size = new System.Drawing.Size(60, 29);
            this.procJobHoursDateTimePicker.TabIndex = 33;
            this.procJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // useMonitoringJobCheckBox
            // 
            this.useMonitoringJobCheckBox.AutoSize = true;
            this.useMonitoringJobCheckBox.Location = new System.Drawing.Point(457, 524);
            this.useMonitoringJobCheckBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.useMonitoringJobCheckBox.Name = "useMonitoringJobCheckBox";
            this.useMonitoringJobCheckBox.Size = new System.Drawing.Size(200, 29);
            this.useMonitoringJobCheckBox.TabIndex = 0;
            this.useMonitoringJobCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Add_monitoring_job;
            this.useMonitoringJobCheckBox.UseVisualStyleBackColor = true;
            this.useMonitoringJobCheckBox.CheckedChanged += new System.EventHandler(this.UseMonitoringJobCheckBox_CheckedChanged);
            // 
            // fileSelectionGroupBox
            // 
            this.fileSelectionGroupBox.Controls.Add(this.orderByComboBox);
            this.fileSelectionGroupBox.Controls.Add(this.panel1);
            this.fileSelectionGroupBox.Controls.Add(this.searchPatternTextBox);
            this.fileSelectionGroupBox.Controls.Add(this.orderLabel);
            this.fileSelectionGroupBox.Controls.Add(this.orderByLabel);
            this.fileSelectionGroupBox.Controls.Add(this.searchPatternLabel);
            this.fileSelectionGroupBox.Location = new System.Drawing.Point(458, 24);
            this.fileSelectionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileSelectionGroupBox.Name = "fileSelectionGroupBox";
            this.fileSelectionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.fileSelectionGroupBox.Size = new System.Drawing.Size(422, 179);
            this.fileSelectionGroupBox.TabIndex = 5;
            this.fileSelectionGroupBox.TabStop = false;
            this.fileSelectionGroupBox.Text = "Files filter and order";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(106, 76);
            this.orderByComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(305, 32);
            this.orderByComboBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderDescendingRadioButton);
            this.panel1.Controls.Add(this.orderAscendingRadioButton);
            this.panel1.Location = new System.Drawing.Point(81, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 44);
            this.panel1.TabIndex = 4;
            // 
            // orderDescendingRadioButton
            // 
            this.orderDescendingRadioButton.AutoSize = true;
            this.orderDescendingRadioButton.Location = new System.Drawing.Point(183, 4);
            this.orderDescendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderDescendingRadioButton.Name = "orderDescendingRadioButton";
            this.orderDescendingRadioButton.Size = new System.Drawing.Size(141, 29);
            this.orderDescendingRadioButton.TabIndex = 1;
            this.orderDescendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Descending;
            this.orderDescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderAscendingRadioButton
            // 
            this.orderAscendingRadioButton.AutoSize = true;
            this.orderAscendingRadioButton.Checked = true;
            this.orderAscendingRadioButton.Location = new System.Drawing.Point(7, 4);
            this.orderAscendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderAscendingRadioButton.Name = "orderAscendingRadioButton";
            this.orderAscendingRadioButton.Size = new System.Drawing.Size(130, 29);
            this.orderAscendingRadioButton.TabIndex = 0;
            this.orderAscendingRadioButton.TabStop = true;
            this.orderAscendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Ascending;
            this.orderAscendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Location = new System.Drawing.Point(158, 34);
            this.searchPatternTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(253, 29);
            this.searchPatternTextBox.TabIndex = 3;
            this.searchPatternTextBox.Text = "*.*";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(7, 124);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(62, 25);
            this.orderLabel.TabIndex = 2;
            this.orderLabel.Text = "Order";
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(7, 79);
            this.orderByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(88, 25);
            this.orderByLabel.TabIndex = 1;
            this.orderByLabel.Text = "Order by";
            // 
            // searchPatternLabel
            // 
            this.searchPatternLabel.AutoSize = true;
            this.searchPatternLabel.Location = new System.Drawing.Point(7, 37);
            this.searchPatternLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchPatternLabel.Name = "searchPatternLabel";
            this.searchPatternLabel.Size = new System.Drawing.Size(140, 25);
            this.searchPatternLabel.TabIndex = 0;
            this.searchPatternLabel.Text = "Search pattern";
            // 
            // retryPolicyGroupBox
            // 
            this.retryPolicyGroupBox.Controls.Add(this.retriesDelayUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.retriesCountUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.label2);
            this.retryPolicyGroupBox.Controls.Add(this.label1);
            this.retryPolicyGroupBox.Location = new System.Drawing.Point(457, 868);
            this.retryPolicyGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.retryPolicyGroupBox.Name = "retryPolicyGroupBox";
            this.retryPolicyGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.retryPolicyGroupBox.Size = new System.Drawing.Size(423, 150);
            this.retryPolicyGroupBox.TabIndex = 6;
            this.retryPolicyGroupBox.TabStop = false;
            this.retryPolicyGroupBox.Text = "Retry policy";
            // 
            // retriesDelayUpDown
            // 
            this.retriesDelayUpDown.Location = new System.Drawing.Point(183, 78);
            this.retriesDelayUpDown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.retriesDelayUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.retriesDelayUpDown.Name = "retriesDelayUpDown";
            this.retriesDelayUpDown.Size = new System.Drawing.Size(121, 29);
            this.retriesDelayUpDown.TabIndex = 5;
            this.retriesDelayUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // retriesCountUpDown
            // 
            this.retriesCountUpDown.Location = new System.Drawing.Point(183, 34);
            this.retriesCountUpDown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.retriesCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.retriesCountUpDown.Name = "retriesCountUpDown";
            this.retriesCountUpDown.Size = new System.Drawing.Size(121, 29);
            this.retriesCountUpDown.TabIndex = 4;
            this.retriesCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay (seconds)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of retries";
            // 
            // groupBoxExceptions
            // 
            this.groupBoxExceptions.Controls.Add(this.pauseOnExceptionsCheckBox);
            this.groupBoxExceptions.Location = new System.Drawing.Point(891, 877);
            this.groupBoxExceptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExceptions.Name = "groupBoxExceptions";
            this.groupBoxExceptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxExceptions.Size = new System.Drawing.Size(422, 78);
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
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.addJobButton);
            this.groupBoxButtons.Controls.Add(this.cancelButton);
            this.groupBoxButtons.Location = new System.Drawing.Point(24, 1020);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxButtons.Size = new System.Drawing.Size(1288, 88);
            this.groupBoxButtons.TabIndex = 12;
            this.groupBoxButtons.TabStop = false;
            // 
            // addJobButton
            // 
            this.addJobButton.Location = new System.Drawing.Point(867, 30);
            this.addJobButton.Margin = new System.Windows.Forms.Padding(4);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(198, 41);
            this.addJobButton.TabIndex = 2;
            this.addJobButton.Text = "Add to schedule";
            this.addJobButton.UseVisualStyleBackColor = true;
            this.addJobButton.Click += new System.EventHandler(this.AddJobButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1083, 30);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(198, 41);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // numericUpDownStatusCheckInterval
            // 
            this.numericUpDownStatusCheckInterval.Location = new System.Drawing.Point(289, 228);
            this.numericUpDownStatusCheckInterval.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDownStatusCheckInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownStatusCheckInterval.Name = "numericUpDownStatusCheckInterval";
            this.numericUpDownStatusCheckInterval.Size = new System.Drawing.Size(121, 29);
            this.numericUpDownStatusCheckInterval.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Status check interval (sec.)";
            // 
            // UploadJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1315, 1121);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxExceptions);
            this.Controls.Add(this.retryPolicyGroupBox);
            this.Controls.Add(this.fileSelectionGroupBox);
            this.Controls.Add(this.processingJobGroupBox);
            this.Controls.Add(this.recurrenceGroupBox);
            this.Controls.Add(this.axDetailsGroupBox);
            this.Controls.Add(this.jobDetailsGroupBox);
            this.Controls.Add(this.useMonitoringJobCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1337, 1020);
            this.Name = "UploadJob";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UploadJobForm_Load);
            this.jobDetailsGroupBox.ResumeLayout(false);
            this.jobDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalUploads)).EndInit();
            this.axDetailsGroupBox.ResumeLayout(false);
            this.axDetailsGroupBox.PerformLayout();
            this.authMethodPanel.ResumeLayout(false);
            this.authMethodPanel.PerformLayout();
            this.recurrenceGroupBox.ResumeLayout(false);
            this.recurrenceGroupBox.PerformLayout();
            this.upJobTriggerTypePanel.ResumeLayout(false);
            this.upJobTriggerTypePanel.PerformLayout();
            this.processingJobGroupBox.ResumeLayout(false);
            this.processingJobGroupBox.PerformLayout();
            this.procJobTriggerTypePanel.ResumeLayout(false);
            this.procJobTriggerTypePanel.PerformLayout();
            this.fileSelectionGroupBox.ResumeLayout(false);
            this.fileSelectionGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.retryPolicyGroupBox.ResumeLayout(false);
            this.retryPolicyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).EndInit();
            this.groupBoxExceptions.ResumeLayout(false);
            this.groupBoxExceptions.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatusCheckInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox jobDetailsGroupBox;
        private System.Windows.Forms.Button topUploadFolderBrowserButton;
        private System.Windows.Forms.TextBox topUploadFolderTextBox;
        private System.Windows.Forms.Label topUploadFolderLabel;
        private System.Windows.Forms.TextBox jobDescription;
        private System.Windows.Forms.Label jobDescriptionLabel;
        private System.Windows.Forms.ComboBox jobGroupComboBox;
        private System.Windows.Forms.Label jobGroupLabel;
        private System.Windows.Forms.TextBox jobName;
        private System.Windows.Forms.Label jobNameLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button uploadErrorsFolderBrowserButton;
        private System.Windows.Forms.TextBox uploadErrorsFolderTextBox;
        private System.Windows.Forms.Label uploadErrorsFolderLabel;
        private System.Windows.Forms.CheckBox useStandardSubfolder;
        private System.Windows.Forms.GroupBox axDetailsGroupBox;
        private System.Windows.Forms.Label instanceLabel;
        private System.Windows.Forms.ComboBox instanceComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label dataJobLabel;
        private System.Windows.Forms.ComboBox dataJobComboBox;
        private System.Windows.Forms.GroupBox recurrenceGroupBox;
        private System.Windows.Forms.DateTimePicker upJobStartAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker upJobMinutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker upJobHoursDateTimePicker;
        private System.Windows.Forms.Label upJobMinutesLabel;
        private System.Windows.Forms.Label upJobHoursLabel;
        private System.Windows.Forms.Label upJobStartAtLabel;
        private System.Windows.Forms.Label buildCronLabel;
        private System.Windows.Forms.TextBox cronTriggerInfoTextBox;
        private System.Windows.Forms.LinkLabel cronmakerLinkLabel;
        private System.Windows.Forms.Label upJobCronExpressionLabel;
        private System.Windows.Forms.TextBox upJobCronExpressionTextBox;
        private System.Windows.Forms.Panel upJobTriggerTypePanel;
        private System.Windows.Forms.RadioButton upJobCronTriggerRadioButton;
        private System.Windows.Forms.RadioButton upJobSimpleTriggerRadioButton;
        private System.Windows.Forms.LinkLabel cronDocsLinkLabel;
        private System.Windows.Forms.TextBox calculatedRunsTextBox;
        private System.Windows.Forms.Button getCronScheduleForUploadButton;
        private System.Windows.Forms.Button moreExamplesButton;
        private System.Windows.Forms.Label downloadFolderLabel;
        private System.Windows.Forms.Button inputFolderBrowserButton;
        private System.Windows.Forms.TextBox inputFolderTextBox;
        private System.Windows.Forms.Label inputFolderLabel;
        private System.Windows.Forms.Button processingSuccessFolderBrowserButton;
        private System.Windows.Forms.TextBox processingSuccessFolderTextBox;
        private System.Windows.Forms.Label processingSuccessFolderLabel;
        private System.Windows.Forms.Button uploadSuccessFolderBrowserButton;
        private System.Windows.Forms.TextBox uploadSuccessFolderTextBox;
        private System.Windows.Forms.Label uploadSuccessFolderLabel;
        private System.Windows.Forms.GroupBox processingJobGroupBox;
        private System.Windows.Forms.CheckBox useMonitoringJobCheckBox;
        private System.Windows.Forms.Panel procJobTriggerTypePanel;
        private System.Windows.Forms.RadioButton procJobCronTriggerRadioButton;
        private System.Windows.Forms.RadioButton procJobSimpleTriggerRadioButton;
        private System.Windows.Forms.Label procJobCronExpressionLabel;
        private System.Windows.Forms.TextBox procJobCronExpressionTextBox;
        private System.Windows.Forms.Label procJobMinutesLabel;
        private System.Windows.Forms.Label procJobHoursLabel;
        private System.Windows.Forms.Label procJobStartAtLabel;
        private System.Windows.Forms.DateTimePicker procJobStartAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker procJobMinutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker procJobHoursDateTimePicker;
        private System.Windows.Forms.Button getCronScheduleForProcButton;
        private System.Windows.Forms.Label LegalEntityLabel;
        private System.Windows.Forms.TextBox statusFileExtensionTextBox;
        private System.Windows.Forms.Label statusFileExtensionLabel;
        private System.Windows.Forms.CheckBox dataPackageCheckBox;
        private System.Windows.Forms.TextBox legalEntityTextBox;
        private System.Windows.Forms.Button processingErrorsFolderBrowserButton;
        private System.Windows.Forms.TextBox processingErrorsFolderTextBox;
        private System.Windows.Forms.Label processingErrorsFolderLabel;
        private System.Windows.Forms.Label aadApplicationLabel;
        private System.Windows.Forms.ComboBox aadApplicationComboBox;
        private System.Windows.Forms.Panel authMethodPanel;
        private System.Windows.Forms.RadioButton serviceAuthRadioButton;
        private System.Windows.Forms.RadioButton userAuthRadioButton;
        private System.Windows.Forms.GroupBox fileSelectionGroupBox;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton orderDescendingRadioButton;
        private System.Windows.Forms.RadioButton orderAscendingRadioButton;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.Label searchPatternLabel;
        private System.Windows.Forms.GroupBox retryPolicyGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown retriesDelayUpDown;
        private System.Windows.Forms.NumericUpDown retriesCountUpDown;
        private System.Windows.Forms.GroupBox groupBoxExceptions;
        private System.Windows.Forms.CheckBox pauseOnExceptionsCheckBox;
        private System.Windows.Forms.CheckBox pauseIndefinitelyCheckBox;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button addJobButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalUploads;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownStatusCheckInterval;
        private System.Windows.Forms.Label label3;
    }
}