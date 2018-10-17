using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class ImportJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportJob));
            this.jobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.PackageTemplateFileBrowserButton = new System.Windows.Forms.Button();
            this.packageTemplateTextBox = new System.Windows.Forms.TextBox();
            this.PackageTemplateLabel = new System.Windows.Forms.Label();
            this.processingErrorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.processingErrorsFolderTextBox = new System.Windows.Forms.TextBox();
            this.processingErrorsFolderLabel = new System.Windows.Forms.Label();
            this.statusFileExtensionTextBox = new System.Windows.Forms.TextBox();
            this.statusFileExtensionLabel = new System.Windows.Forms.Label();
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
            this.importDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.executeImportCheckBox = new System.Windows.Forms.CheckBox();
            this.overwriteDataProjectCheckBox = new System.Windows.Forms.CheckBox();
            this.dataProject = new System.Windows.Forms.TextBox();
            this.dataProjectLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.retryPolicyGroupBox = new System.Windows.Forms.GroupBox();
            this.retriesDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.retriesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxExceptions = new System.Windows.Forms.GroupBox();
            this.pauseOnExceptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.addJobButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customActionsButton = new System.Windows.Forms.Button();
            this.jobDetailsGroupBox.SuspendLayout();
            this.axDetailsGroupBox.SuspendLayout();
            this.authMethodPanel.SuspendLayout();
            this.recurrenceGroupBox.SuspendLayout();
            this.upJobTriggerTypePanel.SuspendLayout();
            this.processingJobGroupBox.SuspendLayout();
            this.procJobTriggerTypePanel.SuspendLayout();
            this.fileSelectionGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.importDetailsGroupBox.SuspendLayout();
            this.retryPolicyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).BeginInit();
            this.groupBoxExceptions.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Controls.Add(this.PackageTemplateFileBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.packageTemplateTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.PackageTemplateLabel);
            this.jobDetailsGroupBox.Controls.Add(this.processingErrorsFolderBrowserButton);
            this.jobDetailsGroupBox.Controls.Add(this.processingErrorsFolderTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.processingErrorsFolderLabel);
            this.jobDetailsGroupBox.Controls.Add(this.statusFileExtensionTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.statusFileExtensionLabel);
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
            this.jobDetailsGroupBox.Location = new System.Drawing.Point(20, 20);
            this.jobDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobDetailsGroupBox.Name = "jobDetailsGroupBox";
            this.jobDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(344, 738);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job details";
            // 
            // PackageTemplateFileBrowserButton
            // 
            this.PackageTemplateFileBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PackageTemplateFileBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.PackageTemplateFileBrowserButton.Location = new System.Drawing.Point(300, 622);
            this.PackageTemplateFileBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.PackageTemplateFileBrowserButton.Name = "PackageTemplateFileBrowserButton";
            this.PackageTemplateFileBrowserButton.Size = new System.Drawing.Size(36, 40);
            this.PackageTemplateFileBrowserButton.TabIndex = 29;
            this.PackageTemplateFileBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PackageTemplateFileBrowserButton.UseVisualStyleBackColor = true;
            this.PackageTemplateFileBrowserButton.Click += new System.EventHandler(this.PackageTemplateFileBrowserButton_Click);
            // 
            // packageTemplateTextBox
            // 
            this.packageTemplateTextBox.Location = new System.Drawing.Point(16, 628);
            this.packageTemplateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.packageTemplateTextBox.Name = "packageTemplateTextBox";
            this.packageTemplateTextBox.Size = new System.Drawing.Size(278, 26);
            this.packageTemplateTextBox.TabIndex = 28;
            // 
            // PackageTemplateLabel
            // 
            this.PackageTemplateLabel.AutoSize = true;
            this.PackageTemplateLabel.Location = new System.Drawing.Point(12, 602);
            this.PackageTemplateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PackageTemplateLabel.Name = "PackageTemplateLabel";
            this.PackageTemplateLabel.Size = new System.Drawing.Size(137, 20);
            this.PackageTemplateLabel.TabIndex = 10;
            this.PackageTemplateLabel.Text = "Package template";
            // 
            // processingErrorsFolderBrowserButton
            // 
            this.processingErrorsFolderBrowserButton.Enabled = false;
            this.processingErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingErrorsFolderBrowserButton.Location = new System.Drawing.Point(300, 566);
            this.processingErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingErrorsFolderBrowserButton.Name = "processingErrorsFolderBrowserButton";
            this.processingErrorsFolderBrowserButton.Size = new System.Drawing.Size(36, 40);
            this.processingErrorsFolderBrowserButton.TabIndex = 27;
            this.processingErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingErrorsFolderBrowserButton.Click += new System.EventHandler(this.ProcessingErrorsFolderBrowserButton_Click);
            // 
            // processingErrorsFolderTextBox
            // 
            this.processingErrorsFolderTextBox.Enabled = false;
            this.processingErrorsFolderTextBox.Location = new System.Drawing.Point(16, 572);
            this.processingErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingErrorsFolderTextBox.Name = "processingErrorsFolderTextBox";
            this.processingErrorsFolderTextBox.Size = new System.Drawing.Size(278, 26);
            this.processingErrorsFolderTextBox.TabIndex = 26;
            // 
            // processingErrorsFolderLabel
            // 
            this.processingErrorsFolderLabel.AutoSize = true;
            this.processingErrorsFolderLabel.Location = new System.Drawing.Point(12, 545);
            this.processingErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processingErrorsFolderLabel.Name = "processingErrorsFolderLabel";
            this.processingErrorsFolderLabel.Size = new System.Drawing.Size(176, 20);
            this.processingErrorsFolderLabel.TabIndex = 9;
            this.processingErrorsFolderLabel.Text = "Processing errors folder";
            // 
            // statusFileExtensionTextBox
            // 
            this.statusFileExtensionTextBox.Enabled = false;
            this.statusFileExtensionTextBox.Location = new System.Drawing.Point(218, 702);
            this.statusFileExtensionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusFileExtensionTextBox.Name = "statusFileExtensionTextBox";
            this.statusFileExtensionTextBox.Size = new System.Drawing.Size(120, 26);
            this.statusFileExtensionTextBox.TabIndex = 31;
            this.statusFileExtensionTextBox.Text = ".Status";
            this.statusFileExtensionTextBox.Leave += new System.EventHandler(this.StatusFileExtensionTextBox_Leave);
            // 
            // statusFileExtensionLabel
            // 
            this.statusFileExtensionLabel.AutoSize = true;
            this.statusFileExtensionLabel.Location = new System.Drawing.Point(57, 708);
            this.statusFileExtensionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusFileExtensionLabel.Name = "statusFileExtensionLabel";
            this.statusFileExtensionLabel.Size = new System.Drawing.Size(152, 20);
            this.statusFileExtensionLabel.TabIndex = 12;
            this.statusFileExtensionLabel.Text = "Status file extension";
            // 
            // legalEntityTextBox
            // 
            this.legalEntityTextBox.Location = new System.Drawing.Point(218, 666);
            this.legalEntityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.legalEntityTextBox.Name = "legalEntityTextBox";
            this.legalEntityTextBox.Size = new System.Drawing.Size(120, 26);
            this.legalEntityTextBox.TabIndex = 30;
            // 
            // LegalEntityLabel
            // 
            this.LegalEntityLabel.AutoSize = true;
            this.LegalEntityLabel.Location = new System.Drawing.Point(118, 669);
            this.LegalEntityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LegalEntityLabel.Name = "LegalEntityLabel";
            this.LegalEntityLabel.Size = new System.Drawing.Size(90, 20);
            this.LegalEntityLabel.TabIndex = 11;
            this.LegalEntityLabel.Text = "Legal entity";
            // 
            // inputFolderBrowserButton
            // 
            this.inputFolderBrowserButton.Enabled = false;
            this.inputFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.inputFolderBrowserButton.Location = new System.Drawing.Point(300, 322);
            this.inputFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.inputFolderBrowserButton.Name = "inputFolderBrowserButton";
            this.inputFolderBrowserButton.Size = new System.Drawing.Size(36, 40);
            this.inputFolderBrowserButton.TabIndex = 19;
            this.inputFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.inputFolderBrowserButton.UseVisualStyleBackColor = true;
            this.inputFolderBrowserButton.Click += new System.EventHandler(this.InputFolderButton_Click);
            // 
            // inputFolderTextBox
            // 
            this.inputFolderTextBox.Enabled = false;
            this.inputFolderTextBox.Location = new System.Drawing.Point(16, 328);
            this.inputFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputFolderTextBox.Name = "inputFolderTextBox";
            this.inputFolderTextBox.Size = new System.Drawing.Size(278, 26);
            this.inputFolderTextBox.TabIndex = 18;
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(12, 300);
            this.inputFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(116, 20);
            this.inputFolderLabel.TabIndex = 5;
            this.inputFolderLabel.Text = "Input subfolder";
            // 
            // processingSuccessFolderBrowserButton
            // 
            this.processingSuccessFolderBrowserButton.Enabled = false;
            this.processingSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingSuccessFolderBrowserButton.Location = new System.Drawing.Point(300, 505);
            this.processingSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingSuccessFolderBrowserButton.Name = "processingSuccessFolderBrowserButton";
            this.processingSuccessFolderBrowserButton.Size = new System.Drawing.Size(36, 40);
            this.processingSuccessFolderBrowserButton.TabIndex = 25;
            this.processingSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingSuccessFolderBrowserButton.Click += new System.EventHandler(this.ProcessingSuccessFolderButton_Click);
            // 
            // processingSuccessFolderTextBox
            // 
            this.processingSuccessFolderTextBox.Enabled = false;
            this.processingSuccessFolderTextBox.Location = new System.Drawing.Point(16, 511);
            this.processingSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingSuccessFolderTextBox.Name = "processingSuccessFolderTextBox";
            this.processingSuccessFolderTextBox.Size = new System.Drawing.Size(278, 26);
            this.processingSuccessFolderTextBox.TabIndex = 24;
            // 
            // processingSuccessFolderLabel
            // 
            this.processingSuccessFolderLabel.AutoSize = true;
            this.processingSuccessFolderLabel.Location = new System.Drawing.Point(12, 485);
            this.processingSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processingSuccessFolderLabel.Name = "processingSuccessFolderLabel";
            this.processingSuccessFolderLabel.Size = new System.Drawing.Size(193, 20);
            this.processingSuccessFolderLabel.TabIndex = 8;
            this.processingSuccessFolderLabel.Text = "Processing success folder";
            // 
            // uploadSuccessFolderBrowserButton
            // 
            this.uploadSuccessFolderBrowserButton.Enabled = false;
            this.uploadSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadSuccessFolderBrowserButton.Location = new System.Drawing.Point(300, 382);
            this.uploadSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadSuccessFolderBrowserButton.Name = "uploadSuccessFolderBrowserButton";
            this.uploadSuccessFolderBrowserButton.Size = new System.Drawing.Size(36, 40);
            this.uploadSuccessFolderBrowserButton.TabIndex = 21;
            this.uploadSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadSuccessFolderBrowserButton.Click += new System.EventHandler(this.UploadSuccessFolderButton_Click);
            // 
            // uploadSuccessFolderTextBox
            // 
            this.uploadSuccessFolderTextBox.Enabled = false;
            this.uploadSuccessFolderTextBox.Location = new System.Drawing.Point(16, 389);
            this.uploadSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadSuccessFolderTextBox.Name = "uploadSuccessFolderTextBox";
            this.uploadSuccessFolderTextBox.Size = new System.Drawing.Size(278, 26);
            this.uploadSuccessFolderTextBox.TabIndex = 20;
            // 
            // uploadSuccessFolderLabel
            // 
            this.uploadSuccessFolderLabel.AutoSize = true;
            this.uploadSuccessFolderLabel.Location = new System.Drawing.Point(12, 362);
            this.uploadSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uploadSuccessFolderLabel.Name = "uploadSuccessFolderLabel";
            this.uploadSuccessFolderLabel.Size = new System.Drawing.Size(166, 20);
            this.uploadSuccessFolderLabel.TabIndex = 6;
            this.uploadSuccessFolderLabel.Text = "Upload success folder";
            // 
            // useStandardSubfolder
            // 
            this.useStandardSubfolder.AutoSize = true;
            this.useStandardSubfolder.Checked = true;
            this.useStandardSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useStandardSubfolder.Location = new System.Drawing.Point(16, 268);
            this.useStandardSubfolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useStandardSubfolder.Name = "useStandardSubfolder";
            this.useStandardSubfolder.Size = new System.Drawing.Size(247, 24);
            this.useStandardSubfolder.TabIndex = 4;
            this.useStandardSubfolder.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Use_default_subfolders_names;
            this.useStandardSubfolder.UseVisualStyleBackColor = true;
            this.useStandardSubfolder.CheckedChanged += new System.EventHandler(this.UseStandardSubfolder_CheckedChanged);
            // 
            // uploadErrorsFolderBrowserButton
            // 
            this.uploadErrorsFolderBrowserButton.Enabled = false;
            this.uploadErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadErrorsFolderBrowserButton.Location = new System.Drawing.Point(300, 445);
            this.uploadErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadErrorsFolderBrowserButton.Name = "uploadErrorsFolderBrowserButton";
            this.uploadErrorsFolderBrowserButton.Size = new System.Drawing.Size(36, 40);
            this.uploadErrorsFolderBrowserButton.TabIndex = 23;
            this.uploadErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadErrorsFolderBrowserButton.Click += new System.EventHandler(this.UploadErrorsFolderBrowserButton_Click);
            // 
            // uploadErrorsFolderTextBox
            // 
            this.uploadErrorsFolderTextBox.Enabled = false;
            this.uploadErrorsFolderTextBox.Location = new System.Drawing.Point(16, 449);
            this.uploadErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadErrorsFolderTextBox.Name = "uploadErrorsFolderTextBox";
            this.uploadErrorsFolderTextBox.Size = new System.Drawing.Size(278, 26);
            this.uploadErrorsFolderTextBox.TabIndex = 22;
            // 
            // uploadErrorsFolderLabel
            // 
            this.uploadErrorsFolderLabel.AutoSize = true;
            this.uploadErrorsFolderLabel.Location = new System.Drawing.Point(12, 422);
            this.uploadErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uploadErrorsFolderLabel.Name = "uploadErrorsFolderLabel";
            this.uploadErrorsFolderLabel.Size = new System.Drawing.Size(149, 20);
            this.uploadErrorsFolderLabel.TabIndex = 7;
            this.uploadErrorsFolderLabel.Text = "Upload errors folder";
            // 
            // topUploadFolderBrowserButton
            // 
            this.topUploadFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topUploadFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.topUploadFolderBrowserButton.Location = new System.Drawing.Point(300, 228);
            this.topUploadFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.topUploadFolderBrowserButton.Name = "topUploadFolderBrowserButton";
            this.topUploadFolderBrowserButton.Size = new System.Drawing.Size(36, 40);
            this.topUploadFolderBrowserButton.TabIndex = 17;
            this.topUploadFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.topUploadFolderBrowserButton.UseVisualStyleBackColor = true;
            this.topUploadFolderBrowserButton.Click += new System.EventHandler(this.TopUploadFolderBrowserButton_Click);
            // 
            // topUploadFolderTextBox
            // 
            this.topUploadFolderTextBox.Location = new System.Drawing.Point(16, 234);
            this.topUploadFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topUploadFolderTextBox.Name = "topUploadFolderTextBox";
            this.topUploadFolderTextBox.Size = new System.Drawing.Size(278, 26);
            this.topUploadFolderTextBox.TabIndex = 16;
            this.topUploadFolderTextBox.TextChanged += new System.EventHandler(this.TopUploadFolder_TextChanged);
            // 
            // topUploadFolderLabel
            // 
            this.topUploadFolderLabel.AutoSize = true;
            this.topUploadFolderLabel.Location = new System.Drawing.Point(12, 206);
            this.topUploadFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topUploadFolderLabel.Name = "topUploadFolderLabel";
            this.topUploadFolderLabel.Size = new System.Drawing.Size(132, 20);
            this.topUploadFolderLabel.TabIndex = 3;
            this.topUploadFolderLabel.Text = "Top upload folder";
            // 
            // jobDescription
            // 
            this.jobDescription.Location = new System.Drawing.Point(18, 145);
            this.jobDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobDescription.Multiline = true;
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.Size = new System.Drawing.Size(314, 53);
            this.jobDescription.TabIndex = 15;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(12, 118);
            this.jobDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.jobDescriptionLabel.TabIndex = 2;
            this.jobDescriptionLabel.Text = "Description";
            // 
            // jobGroupComboBox
            // 
            this.jobGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobGroupComboBox.FormattingEnabled = true;
            this.jobGroupComboBox.Location = new System.Drawing.Point(75, 75);
            this.jobGroupComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobGroupComboBox.Name = "jobGroupComboBox";
            this.jobGroupComboBox.Size = new System.Drawing.Size(258, 28);
            this.jobGroupComboBox.Sorted = true;
            this.jobGroupComboBox.TabIndex = 14;
            // 
            // jobGroupLabel
            // 
            this.jobGroupLabel.AutoSize = true;
            this.jobGroupLabel.Location = new System.Drawing.Point(12, 80);
            this.jobGroupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobGroupLabel.Name = "jobGroupLabel";
            this.jobGroupLabel.Size = new System.Drawing.Size(54, 20);
            this.jobGroupLabel.TabIndex = 1;
            this.jobGroupLabel.Text = "Group";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(75, 26);
            this.jobName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(258, 26);
            this.jobName.TabIndex = 13;
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Location = new System.Drawing.Point(12, 31);
            this.jobNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(51, 20);
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
            this.axDetailsGroupBox.Location = new System.Drawing.Point(375, 325);
            this.axDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axDetailsGroupBox.Name = "axDetailsGroupBox";
            this.axDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axDetailsGroupBox.Size = new System.Drawing.Size(345, 202);
            this.axDetailsGroupBox.TabIndex = 3;
            this.axDetailsGroupBox.TabStop = false;
            this.axDetailsGroupBox.Text = "Dynamics details";
            // 
            // aadApplicationLabel
            // 
            this.aadApplicationLabel.AutoSize = true;
            this.aadApplicationLabel.Location = new System.Drawing.Point(18, 122);
            this.aadApplicationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aadApplicationLabel.Name = "aadApplicationLabel";
            this.aadApplicationLabel.Size = new System.Drawing.Size(123, 20);
            this.aadApplicationLabel.TabIndex = 1;
            this.aadApplicationLabel.Text = "AAD application";
            // 
            // aadApplicationComboBox
            // 
            this.aadApplicationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aadApplicationComboBox.FormattingEnabled = true;
            this.aadApplicationComboBox.Location = new System.Drawing.Point(154, 118);
            this.aadApplicationComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aadApplicationComboBox.Name = "aadApplicationComboBox";
            this.aadApplicationComboBox.Size = new System.Drawing.Size(180, 28);
            this.aadApplicationComboBox.TabIndex = 4;
            // 
            // authMethodPanel
            // 
            this.authMethodPanel.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodPanel.Controls.Add(this.userAuthRadioButton);
            this.authMethodPanel.Location = new System.Drawing.Point(10, 69);
            this.authMethodPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authMethodPanel.Name = "authMethodPanel";
            this.authMethodPanel.Size = new System.Drawing.Size(322, 38);
            this.authMethodPanel.TabIndex = 30;
            // 
            // serviceAuthRadioButton
            // 
            this.serviceAuthRadioButton.AutoSize = true;
            this.serviceAuthRadioButton.Location = new System.Drawing.Point(177, 5);
            this.serviceAuthRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceAuthRadioButton.Name = "serviceAuthRadioButton";
            this.serviceAuthRadioButton.Size = new System.Drawing.Size(122, 24);
            this.serviceAuthRadioButton.TabIndex = 1;
            this.serviceAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Service_auth;
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(4, 5);
            this.userAuthRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(104, 24);
            this.userAuthRadioButton.TabIndex = 0;
            this.userAuthRadioButton.TabStop = true;
            this.userAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.User_auth;
            this.userAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(98, 162);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(43, 20);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "User";
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(154, 158);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(180, 28);
            this.userComboBox.TabIndex = 5;
            // 
            // instanceLabel
            // 
            this.instanceLabel.AutoSize = true;
            this.instanceLabel.Location = new System.Drawing.Point(28, 34);
            this.instanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instanceLabel.Name = "instanceLabel";
            this.instanceLabel.Size = new System.Drawing.Size(71, 20);
            this.instanceLabel.TabIndex = 0;
            this.instanceLabel.Text = "Instance";
            // 
            // instanceComboBox
            // 
            this.instanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceComboBox.FormattingEnabled = true;
            this.instanceComboBox.Location = new System.Drawing.Point(114, 29);
            this.instanceComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instanceComboBox.Name = "instanceComboBox";
            this.instanceComboBox.Size = new System.Drawing.Size(218, 28);
            this.instanceComboBox.TabIndex = 3;
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
            this.recurrenceGroupBox.Location = new System.Drawing.Point(729, 20);
            this.recurrenceGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recurrenceGroupBox.Name = "recurrenceGroupBox";
            this.recurrenceGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recurrenceGroupBox.Size = new System.Drawing.Size(345, 689);
            this.recurrenceGroupBox.TabIndex = 6;
            this.recurrenceGroupBox.TabStop = false;
            this.recurrenceGroupBox.Text = "Recurrence";
            // 
            // pauseIndefinitelyCheckBox
            // 
            this.pauseIndefinitelyCheckBox.AutoSize = true;
            this.pauseIndefinitelyCheckBox.Location = new System.Drawing.Point(15, 29);
            this.pauseIndefinitelyCheckBox.Name = "pauseIndefinitelyCheckBox";
            this.pauseIndefinitelyCheckBox.Size = new System.Drawing.Size(183, 24);
            this.pauseIndefinitelyCheckBox.TabIndex = 0;
            this.pauseIndefinitelyCheckBox.Text = "Pause job indefinitely";
            this.pauseIndefinitelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // getCronScheduleForProcButton
            // 
            this.getCronScheduleForProcButton.Enabled = false;
            this.getCronScheduleForProcButton.Location = new System.Drawing.Point(178, 517);
            this.getCronScheduleForProcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getCronScheduleForProcButton.Name = "getCronScheduleForProcButton";
            this.getCronScheduleForProcButton.Size = new System.Drawing.Size(158, 55);
            this.getCronScheduleForProcButton.TabIndex = 13;
            this.getCronScheduleForProcButton.Text = "Get cron schedule for monitoring job ";
            this.getCronScheduleForProcButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForProcButton.Click += new System.EventHandler(this.GetCronScheduleForProcButton_Click);
            // 
            // moreExamplesButton
            // 
            this.moreExamplesButton.Location = new System.Drawing.Point(237, 578);
            this.moreExamplesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moreExamplesButton.Name = "moreExamplesButton";
            this.moreExamplesButton.Size = new System.Drawing.Size(99, 85);
            this.moreExamplesButton.TabIndex = 15;
            this.moreExamplesButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesButton.UseVisualStyleBackColor = true;
            this.moreExamplesButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
            // 
            // calculatedRunsTextBox
            // 
            this.calculatedRunsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsTextBox.Location = new System.Drawing.Point(14, 578);
            this.calculatedRunsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculatedRunsTextBox.Multiline = true;
            this.calculatedRunsTextBox.Name = "calculatedRunsTextBox";
            this.calculatedRunsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsTextBox.Size = new System.Drawing.Size(216, 82);
            this.calculatedRunsTextBox.TabIndex = 14;
            this.calculatedRunsTextBox.TabStop = false;
            // 
            // getCronScheduleForUploadButton
            // 
            this.getCronScheduleForUploadButton.Enabled = false;
            this.getCronScheduleForUploadButton.Location = new System.Drawing.Point(14, 517);
            this.getCronScheduleForUploadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getCronScheduleForUploadButton.Name = "getCronScheduleForUploadButton";
            this.getCronScheduleForUploadButton.Size = new System.Drawing.Size(158, 55);
            this.getCronScheduleForUploadButton.TabIndex = 12;
            this.getCronScheduleForUploadButton.Text = "Get cron schedule for import job ";
            this.getCronScheduleForUploadButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForUploadButton.Click += new System.EventHandler(this.GetCronScheduleForUploadButton_Click);
            // 
            // cronDocsLinkLabel
            // 
            this.cronDocsLinkLabel.AutoSize = true;
            this.cronDocsLinkLabel.Location = new System.Drawing.Point(9, 486);
            this.cronDocsLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cronDocsLinkLabel.Name = "cronDocsLinkLabel";
            this.cronDocsLinkLabel.Size = new System.Drawing.Size(259, 20);
            this.cronDocsLinkLabel.TabIndex = 11;
            this.cronDocsLinkLabel.TabStop = true;
            this.cronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.cronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // upJobTriggerTypePanel
            // 
            this.upJobTriggerTypePanel.Controls.Add(this.upJobCronTriggerRadioButton);
            this.upJobTriggerTypePanel.Controls.Add(this.upJobSimpleTriggerRadioButton);
            this.upJobTriggerTypePanel.Location = new System.Drawing.Point(14, 114);
            this.upJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upJobTriggerTypePanel.Name = "upJobTriggerTypePanel";
            this.upJobTriggerTypePanel.Size = new System.Drawing.Size(312, 38);
            this.upJobTriggerTypePanel.TabIndex = 29;
            // 
            // upJobCronTriggerRadioButton
            // 
            this.upJobCronTriggerRadioButton.AutoSize = true;
            this.upJobCronTriggerRadioButton.Location = new System.Drawing.Point(177, 5);
            this.upJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upJobCronTriggerRadioButton.Name = "upJobCronTriggerRadioButton";
            this.upJobCronTriggerRadioButton.Size = new System.Drawing.Size(117, 24);
            this.upJobCronTriggerRadioButton.TabIndex = 1;
            this.upJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.upJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.upJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.UpJobCronTriggerRadioButton_CheckedChanged);
            // 
            // upJobSimpleTriggerRadioButton
            // 
            this.upJobSimpleTriggerRadioButton.AutoSize = true;
            this.upJobSimpleTriggerRadioButton.Checked = true;
            this.upJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(4, 5);
            this.upJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upJobSimpleTriggerRadioButton.Name = "upJobSimpleTriggerRadioButton";
            this.upJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(131, 24);
            this.upJobSimpleTriggerRadioButton.TabIndex = 0;
            this.upJobSimpleTriggerRadioButton.TabStop = true;
            this.upJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.upJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // buildCronLabel
            // 
            this.buildCronLabel.AutoSize = true;
            this.buildCronLabel.Location = new System.Drawing.Point(9, 457);
            this.buildCronLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buildCronLabel.Name = "buildCronLabel";
            this.buildCronLabel.Size = new System.Drawing.Size(177, 20);
            this.buildCronLabel.TabIndex = 5;
            this.buildCronLabel.Text = "Build cron expression at";
            // 
            // cronTriggerInfoTextBox
            // 
            this.cronTriggerInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cronTriggerInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cronTriggerInfoTextBox.Location = new System.Drawing.Point(14, 226);
            this.cronTriggerInfoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cronTriggerInfoTextBox.Multiline = true;
            this.cronTriggerInfoTextBox.Name = "cronTriggerInfoTextBox";
            this.cronTriggerInfoTextBox.Size = new System.Drawing.Size(322, 226);
            this.cronTriggerInfoTextBox.TabIndex = 4;
            this.cronTriggerInfoTextBox.TabStop = false;
            this.cronTriggerInfoTextBox.Text = resources.GetString("cronTriggerInfoTextBox.Text");
            // 
            // cronmakerLinkLabel
            // 
            this.cronmakerLinkLabel.AutoSize = true;
            this.cronmakerLinkLabel.Location = new System.Drawing.Point(189, 457);
            this.cronmakerLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cronmakerLinkLabel.Name = "cronmakerLinkLabel";
            this.cronmakerLinkLabel.Size = new System.Drawing.Size(118, 20);
            this.cronmakerLinkLabel.TabIndex = 10;
            this.cronmakerLinkLabel.TabStop = true;
            this.cronmakerLinkLabel.Text = "cronmaker.com";
            this.cronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // upJobCronExpressionLabel
            // 
            this.upJobCronExpressionLabel.AutoSize = true;
            this.upJobCronExpressionLabel.Location = new System.Drawing.Point(9, 163);
            this.upJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upJobCronExpressionLabel.Name = "upJobCronExpressionLabel";
            this.upJobCronExpressionLabel.Size = new System.Drawing.Size(123, 20);
            this.upJobCronExpressionLabel.TabIndex = 3;
            this.upJobCronExpressionLabel.Text = "Cron expression";
            // 
            // upJobCronExpressionTextBox
            // 
            this.upJobCronExpressionTextBox.Enabled = false;
            this.upJobCronExpressionTextBox.Location = new System.Drawing.Point(14, 186);
            this.upJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upJobCronExpressionTextBox.Name = "upJobCronExpressionTextBox";
            this.upJobCronExpressionTextBox.Size = new System.Drawing.Size(320, 26);
            this.upJobCronExpressionTextBox.TabIndex = 9;
            this.upJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // upJobMinutesLabel
            // 
            this.upJobMinutesLabel.AutoSize = true;
            this.upJobMinutesLabel.Location = new System.Drawing.Point(96, 78);
            this.upJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.upJobMinutesLabel.Name = "upJobMinutesLabel";
            this.upJobMinutesLabel.Size = new System.Drawing.Size(26, 20);
            this.upJobMinutesLabel.TabIndex = 1;
            this.upJobMinutesLabel.Text = "M:";
            this.upJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobHoursLabel
            // 
            this.upJobHoursLabel.AutoSize = true;
            this.upJobHoursLabel.Location = new System.Drawing.Point(9, 78);
            this.upJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.upJobHoursLabel.Name = "upJobHoursLabel";
            this.upJobHoursLabel.Size = new System.Drawing.Size(25, 20);
            this.upJobHoursLabel.TabIndex = 0;
            this.upJobHoursLabel.Text = "H:";
            this.upJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobStartAtLabel
            // 
            this.upJobStartAtLabel.AutoSize = true;
            this.upJobStartAtLabel.Location = new System.Drawing.Point(189, 78);
            this.upJobStartAtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upJobStartAtLabel.Name = "upJobStartAtLabel";
            this.upJobStartAtLabel.Size = new System.Drawing.Size(59, 20);
            this.upJobStartAtLabel.TabIndex = 2;
            this.upJobStartAtLabel.Text = "start at";
            this.upJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobStartAtDateTimePicker
            // 
            this.upJobStartAtDateTimePicker.CustomFormat = "HH:mm";
            this.upJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobStartAtDateTimePicker.Location = new System.Drawing.Point(248, 74);
            this.upJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upJobStartAtDateTimePicker.Name = "upJobStartAtDateTimePicker";
            this.upJobStartAtDateTimePicker.ShowUpDown = true;
            this.upJobStartAtDateTimePicker.Size = new System.Drawing.Size(76, 26);
            this.upJobStartAtDateTimePicker.TabIndex = 8;
            this.upJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // upJobMinutesDateTimePicker
            // 
            this.upJobMinutesDateTimePicker.CustomFormat = "mm";
            this.upJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobMinutesDateTimePicker.Location = new System.Drawing.Point(124, 74);
            this.upJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upJobMinutesDateTimePicker.Name = "upJobMinutesDateTimePicker";
            this.upJobMinutesDateTimePicker.ShowUpDown = true;
            this.upJobMinutesDateTimePicker.Size = new System.Drawing.Size(50, 26);
            this.upJobMinutesDateTimePicker.TabIndex = 7;
            this.upJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 1, 0, 0);
            // 
            // upJobHoursDateTimePicker
            // 
            this.upJobHoursDateTimePicker.CustomFormat = "HH";
            this.upJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobHoursDateTimePicker.Location = new System.Drawing.Point(36, 74);
            this.upJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upJobHoursDateTimePicker.Name = "upJobHoursDateTimePicker";
            this.upJobHoursDateTimePicker.ShowUpDown = true;
            this.upJobHoursDateTimePicker.Size = new System.Drawing.Size(50, 26);
            this.upJobHoursDateTimePicker.TabIndex = 6;
            this.upJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // downloadFolderLabel
            // 
            this.downloadFolderLabel.AutoSize = true;
            this.downloadFolderLabel.Location = new System.Drawing.Point(9, 157);
            this.downloadFolderLabel.Name = "downloadFolderLabel";
            this.downloadFolderLabel.Size = new System.Drawing.Size(90, 13);
            this.downloadFolderLabel.TabIndex = 8;
            this.downloadFolderLabel.Text = "Top upload folder";
            // 
            // processingJobGroupBox
            // 
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
            this.processingJobGroupBox.Location = new System.Drawing.Point(375, 565);
            this.processingJobGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingJobGroupBox.Name = "processingJobGroupBox";
            this.processingJobGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingJobGroupBox.Size = new System.Drawing.Size(345, 194);
            this.processingJobGroupBox.TabIndex = 5;
            this.processingJobGroupBox.TabStop = false;
            this.processingJobGroupBox.Text = "Execution monitoring job";
            // 
            // procJobTriggerTypePanel
            // 
            this.procJobTriggerTypePanel.Controls.Add(this.procJobCronTriggerRadioButton);
            this.procJobTriggerTypePanel.Controls.Add(this.procJobSimpleTriggerRadioButton);
            this.procJobTriggerTypePanel.Location = new System.Drawing.Point(14, 74);
            this.procJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procJobTriggerTypePanel.Name = "procJobTriggerTypePanel";
            this.procJobTriggerTypePanel.Size = new System.Drawing.Size(312, 38);
            this.procJobTriggerTypePanel.TabIndex = 38;
            // 
            // procJobCronTriggerRadioButton
            // 
            this.procJobCronTriggerRadioButton.AutoSize = true;
            this.procJobCronTriggerRadioButton.Location = new System.Drawing.Point(177, 2);
            this.procJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procJobCronTriggerRadioButton.Name = "procJobCronTriggerRadioButton";
            this.procJobCronTriggerRadioButton.Size = new System.Drawing.Size(117, 24);
            this.procJobCronTriggerRadioButton.TabIndex = 1;
            this.procJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.procJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.procJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.ProcJobCronTriggerRadioButton_CheckedChanged);
            // 
            // procJobSimpleTriggerRadioButton
            // 
            this.procJobSimpleTriggerRadioButton.AutoSize = true;
            this.procJobSimpleTriggerRadioButton.Checked = true;
            this.procJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(4, 5);
            this.procJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procJobSimpleTriggerRadioButton.Name = "procJobSimpleTriggerRadioButton";
            this.procJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(131, 24);
            this.procJobSimpleTriggerRadioButton.TabIndex = 0;
            this.procJobSimpleTriggerRadioButton.TabStop = true;
            this.procJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.procJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // procJobCronExpressionLabel
            // 
            this.procJobCronExpressionLabel.AutoSize = true;
            this.procJobCronExpressionLabel.Location = new System.Drawing.Point(9, 122);
            this.procJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.procJobCronExpressionLabel.Name = "procJobCronExpressionLabel";
            this.procJobCronExpressionLabel.Size = new System.Drawing.Size(123, 20);
            this.procJobCronExpressionLabel.TabIndex = 3;
            this.procJobCronExpressionLabel.Text = "Cron expression";
            // 
            // procJobCronExpressionTextBox
            // 
            this.procJobCronExpressionTextBox.Enabled = false;
            this.procJobCronExpressionTextBox.Location = new System.Drawing.Point(14, 146);
            this.procJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procJobCronExpressionTextBox.Name = "procJobCronExpressionTextBox";
            this.procJobCronExpressionTextBox.Size = new System.Drawing.Size(320, 26);
            this.procJobCronExpressionTextBox.TabIndex = 7;
            this.procJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // procJobMinutesLabel
            // 
            this.procJobMinutesLabel.AutoSize = true;
            this.procJobMinutesLabel.Location = new System.Drawing.Point(96, 38);
            this.procJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.procJobMinutesLabel.Name = "procJobMinutesLabel";
            this.procJobMinutesLabel.Size = new System.Drawing.Size(26, 20);
            this.procJobMinutesLabel.TabIndex = 1;
            this.procJobMinutesLabel.Text = "M:";
            this.procJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobHoursLabel
            // 
            this.procJobHoursLabel.AutoSize = true;
            this.procJobHoursLabel.Location = new System.Drawing.Point(9, 38);
            this.procJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.procJobHoursLabel.Name = "procJobHoursLabel";
            this.procJobHoursLabel.Size = new System.Drawing.Size(25, 20);
            this.procJobHoursLabel.TabIndex = 0;
            this.procJobHoursLabel.Text = "H:";
            this.procJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobStartAtLabel
            // 
            this.procJobStartAtLabel.AutoSize = true;
            this.procJobStartAtLabel.Location = new System.Drawing.Point(189, 38);
            this.procJobStartAtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.procJobStartAtLabel.Name = "procJobStartAtLabel";
            this.procJobStartAtLabel.Size = new System.Drawing.Size(59, 20);
            this.procJobStartAtLabel.TabIndex = 2;
            this.procJobStartAtLabel.Text = "start at";
            this.procJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobStartAtDateTimePicker
            // 
            this.procJobStartAtDateTimePicker.CustomFormat = "HH:mm";
            this.procJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobStartAtDateTimePicker.Location = new System.Drawing.Point(248, 34);
            this.procJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procJobStartAtDateTimePicker.Name = "procJobStartAtDateTimePicker";
            this.procJobStartAtDateTimePicker.ShowUpDown = true;
            this.procJobStartAtDateTimePicker.Size = new System.Drawing.Size(76, 26);
            this.procJobStartAtDateTimePicker.TabIndex = 6;
            this.procJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // procJobMinutesDateTimePicker
            // 
            this.procJobMinutesDateTimePicker.CustomFormat = "mm";
            this.procJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobMinutesDateTimePicker.Location = new System.Drawing.Point(124, 34);
            this.procJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procJobMinutesDateTimePicker.Name = "procJobMinutesDateTimePicker";
            this.procJobMinutesDateTimePicker.ShowUpDown = true;
            this.procJobMinutesDateTimePicker.Size = new System.Drawing.Size(50, 26);
            this.procJobMinutesDateTimePicker.TabIndex = 5;
            this.procJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 30, 0, 0);
            // 
            // procJobHoursDateTimePicker
            // 
            this.procJobHoursDateTimePicker.CustomFormat = "HH";
            this.procJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobHoursDateTimePicker.Location = new System.Drawing.Point(36, 34);
            this.procJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.procJobHoursDateTimePicker.Name = "procJobHoursDateTimePicker";
            this.procJobHoursDateTimePicker.ShowUpDown = true;
            this.procJobHoursDateTimePicker.Size = new System.Drawing.Size(50, 26);
            this.procJobHoursDateTimePicker.TabIndex = 4;
            this.procJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // useMonitoringJobCheckBox
            // 
            this.useMonitoringJobCheckBox.AutoSize = true;
            this.useMonitoringJobCheckBox.Location = new System.Drawing.Point(374, 535);
            this.useMonitoringJobCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useMonitoringJobCheckBox.Name = "useMonitoringJobCheckBox";
            this.useMonitoringJobCheckBox.Size = new System.Drawing.Size(167, 24);
            this.useMonitoringJobCheckBox.TabIndex = 4;
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
            this.fileSelectionGroupBox.Location = new System.Drawing.Point(375, 171);
            this.fileSelectionGroupBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileSelectionGroupBox.Name = "fileSelectionGroupBox";
            this.fileSelectionGroupBox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileSelectionGroupBox.Size = new System.Drawing.Size(344, 149);
            this.fileSelectionGroupBox.TabIndex = 2;
            this.fileSelectionGroupBox.TabStop = false;
            this.fileSelectionGroupBox.Text = "Files filter and order";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(87, 62);
            this.orderByComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(250, 28);
            this.orderByComboBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderDescendingRadioButton);
            this.panel1.Controls.Add(this.orderAscendingRadioButton);
            this.panel1.Location = new System.Drawing.Point(64, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 35);
            this.panel1.TabIndex = 4;
            // 
            // orderDescendingRadioButton
            // 
            this.orderDescendingRadioButton.AutoSize = true;
            this.orderDescendingRadioButton.Location = new System.Drawing.Point(152, 5);
            this.orderDescendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderDescendingRadioButton.Name = "orderDescendingRadioButton";
            this.orderDescendingRadioButton.Size = new System.Drawing.Size(119, 24);
            this.orderDescendingRadioButton.TabIndex = 1;
            this.orderDescendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Descending;
            this.orderDescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderAscendingRadioButton
            // 
            this.orderAscendingRadioButton.AutoSize = true;
            this.orderAscendingRadioButton.Checked = true;
            this.orderAscendingRadioButton.Location = new System.Drawing.Point(6, 5);
            this.orderAscendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderAscendingRadioButton.Name = "orderAscendingRadioButton";
            this.orderAscendingRadioButton.Size = new System.Drawing.Size(109, 24);
            this.orderAscendingRadioButton.TabIndex = 0;
            this.orderAscendingRadioButton.TabStop = true;
            this.orderAscendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Ascending;
            this.orderAscendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Location = new System.Drawing.Point(128, 28);
            this.searchPatternTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(210, 26);
            this.searchPatternTextBox.TabIndex = 3;
            this.searchPatternTextBox.Text = "*.zip";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(8, 102);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(49, 20);
            this.orderLabel.TabIndex = 2;
            this.orderLabel.Text = "Order";
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(8, 66);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(69, 20);
            this.orderByLabel.TabIndex = 1;
            this.orderByLabel.Text = "Order by";
            // 
            // searchPatternLabel
            // 
            this.searchPatternLabel.AutoSize = true;
            this.searchPatternLabel.Location = new System.Drawing.Point(8, 31);
            this.searchPatternLabel.Name = "searchPatternLabel";
            this.searchPatternLabel.Size = new System.Drawing.Size(115, 20);
            this.searchPatternLabel.TabIndex = 0;
            this.searchPatternLabel.Text = "Search pattern";
            // 
            // importDetailsGroupBox
            // 
            this.importDetailsGroupBox.Controls.Add(this.executeImportCheckBox);
            this.importDetailsGroupBox.Controls.Add(this.overwriteDataProjectCheckBox);
            this.importDetailsGroupBox.Controls.Add(this.dataProject);
            this.importDetailsGroupBox.Controls.Add(this.dataProjectLabel);
            this.importDetailsGroupBox.Location = new System.Drawing.Point(374, 29);
            this.importDetailsGroupBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.importDetailsGroupBox.Name = "importDetailsGroupBox";
            this.importDetailsGroupBox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.importDetailsGroupBox.Size = new System.Drawing.Size(344, 129);
            this.importDetailsGroupBox.TabIndex = 1;
            this.importDetailsGroupBox.TabStop = false;
            this.importDetailsGroupBox.Text = "Import details";
            // 
            // executeImportCheckBox
            // 
            this.executeImportCheckBox.AutoSize = true;
            this.executeImportCheckBox.Checked = true;
            this.executeImportCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.executeImportCheckBox.Location = new System.Drawing.Point(10, 100);
            this.executeImportCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.executeImportCheckBox.Name = "executeImportCheckBox";
            this.executeImportCheckBox.Size = new System.Drawing.Size(141, 24);
            this.executeImportCheckBox.TabIndex = 3;
            this.executeImportCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Execute_import;
            this.executeImportCheckBox.UseVisualStyleBackColor = true;
            // 
            // overwriteDataProjectCheckBox
            // 
            this.overwriteDataProjectCheckBox.AutoSize = true;
            this.overwriteDataProjectCheckBox.Checked = true;
            this.overwriteDataProjectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteDataProjectCheckBox.Location = new System.Drawing.Point(10, 65);
            this.overwriteDataProjectCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.overwriteDataProjectCheckBox.Name = "overwriteDataProjectCheckBox";
            this.overwriteDataProjectCheckBox.Size = new System.Drawing.Size(257, 24);
            this.overwriteDataProjectCheckBox.TabIndex = 2;
            this.overwriteDataProjectCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Overwrite_data_project_definition;
            this.overwriteDataProjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataProject
            // 
            this.dataProject.Location = new System.Drawing.Point(128, 28);
            this.dataProject.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataProject.Name = "dataProject";
            this.dataProject.Size = new System.Drawing.Size(210, 26);
            this.dataProject.TabIndex = 1;
            // 
            // dataProjectLabel
            // 
            this.dataProjectLabel.AutoSize = true;
            this.dataProjectLabel.Location = new System.Drawing.Point(8, 31);
            this.dataProjectLabel.Name = "dataProjectLabel";
            this.dataProjectLabel.Size = new System.Drawing.Size(96, 20);
            this.dataProjectLabel.TabIndex = 0;
            this.dataProjectLabel.Text = "Data project";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Package files|*.zip";
            // 
            // retryPolicyGroupBox
            // 
            this.retryPolicyGroupBox.Controls.Add(this.retriesDelayUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.label2);
            this.retryPolicyGroupBox.Controls.Add(this.retriesCountUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.label1);
            this.retryPolicyGroupBox.Location = new System.Drawing.Point(729, 735);
            this.retryPolicyGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.retryPolicyGroupBox.Name = "retryPolicyGroupBox";
            this.retryPolicyGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.retryPolicyGroupBox.Size = new System.Drawing.Size(346, 103);
            this.retryPolicyGroupBox.TabIndex = 8;
            this.retryPolicyGroupBox.TabStop = false;
            this.retryPolicyGroupBox.Text = "Retry policy";
            // 
            // retriesDelayUpDown
            // 
            this.retriesDelayUpDown.Location = new System.Drawing.Point(148, 65);
            this.retriesDelayUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.retriesDelayUpDown.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.retriesDelayUpDown.Name = "retriesDelayUpDown";
            this.retriesDelayUpDown.Size = new System.Drawing.Size(99, 26);
            this.retriesDelayUpDown.TabIndex = 10;
            this.retriesDelayUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delay (seconds)";
            // 
            // retriesCountUpDown
            // 
            this.retriesCountUpDown.Location = new System.Drawing.Point(148, 28);
            this.retriesCountUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.retriesCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.retriesCountUpDown.Name = "retriesCountUpDown";
            this.retriesCountUpDown.Size = new System.Drawing.Size(99, 26);
            this.retriesCountUpDown.TabIndex = 9;
            this.retriesCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of retries";
            // 
            // groupBoxExceptions
            // 
            this.groupBoxExceptions.Controls.Add(this.pauseOnExceptionsCheckBox);
            this.groupBoxExceptions.Location = new System.Drawing.Point(375, 766);
            this.groupBoxExceptions.Name = "groupBoxExceptions";
            this.groupBoxExceptions.Size = new System.Drawing.Size(345, 72);
            this.groupBoxExceptions.TabIndex = 9;
            this.groupBoxExceptions.TabStop = false;
            this.groupBoxExceptions.Text = "Exceptions";
            // 
            // pauseOnExceptionsCheckBox
            // 
            this.pauseOnExceptionsCheckBox.AutoSize = true;
            this.pauseOnExceptionsCheckBox.Checked = true;
            this.pauseOnExceptionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pauseOnExceptionsCheckBox.Location = new System.Drawing.Point(14, 26);
            this.pauseOnExceptionsCheckBox.Name = "pauseOnExceptionsCheckBox";
            this.pauseOnExceptionsCheckBox.Size = new System.Drawing.Size(270, 24);
            this.pauseOnExceptionsCheckBox.TabIndex = 0;
            this.pauseOnExceptionsCheckBox.Text = "Pause job when exception occurs";
            this.pauseOnExceptionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.addJobButton);
            this.groupBoxButtons.Controls.Add(this.cancelButton);
            this.groupBoxButtons.Controls.Add(this.customActionsButton);
            this.groupBoxButtons.Location = new System.Drawing.Point(20, 844);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(1055, 71);
            this.groupBoxButtons.TabIndex = 10;
            this.groupBoxButtons.TabStop = false;
            // 
            // addJobButton
            // 
            this.addJobButton.Location = new System.Drawing.Point(709, 25);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(162, 34);
            this.addJobButton.TabIndex = 2;
            this.addJobButton.Text = "Add to schedule";
            this.addJobButton.UseVisualStyleBackColor = true;
            this.addJobButton.Click += new System.EventHandler(this.AddJobButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(887, 25);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(162, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // customActionsButton
            // 
            this.customActionsButton.Location = new System.Drawing.Point(6, 25);
            this.customActionsButton.Name = "customActionsButton";
            this.customActionsButton.Size = new System.Drawing.Size(288, 34);
            this.customActionsButton.TabIndex = 0;
            this.customActionsButton.Text = "Custom Odata actions";
            this.customActionsButton.UseVisualStyleBackColor = true;
            this.customActionsButton.Click += new System.EventHandler(this.CustomActionsButton_Click);
            // 
            // ImportJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1082, 927);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxExceptions);
            this.Controls.Add(this.importDetailsGroupBox);
            this.Controls.Add(this.fileSelectionGroupBox);
            this.Controls.Add(this.processingJobGroupBox);
            this.Controls.Add(this.recurrenceGroupBox);
            this.Controls.Add(this.axDetailsGroupBox);
            this.Controls.Add(this.jobDetailsGroupBox);
            this.Controls.Add(this.useMonitoringJobCheckBox);
            this.Controls.Add(this.retryPolicyGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1094, 916);
            this.Name = "ImportJob";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ImportJobForm_Load);
            this.jobDetailsGroupBox.ResumeLayout(false);
            this.jobDetailsGroupBox.PerformLayout();
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
            this.importDetailsGroupBox.ResumeLayout(false);
            this.importDetailsGroupBox.PerformLayout();
            this.retryPolicyGroupBox.ResumeLayout(false);
            this.retryPolicyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).EndInit();
            this.groupBoxExceptions.ResumeLayout(false);
            this.groupBoxExceptions.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox importDetailsGroupBox;
        private System.Windows.Forms.TextBox dataProject;
        private System.Windows.Forms.Label dataProjectLabel;
        private System.Windows.Forms.CheckBox executeImportCheckBox;
        private System.Windows.Forms.CheckBox overwriteDataProjectCheckBox;
        private System.Windows.Forms.Button PackageTemplateFileBrowserButton;
        private System.Windows.Forms.TextBox packageTemplateTextBox;
        private System.Windows.Forms.Label PackageTemplateLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
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
        private System.Windows.Forms.Button customActionsButton;
    }
}