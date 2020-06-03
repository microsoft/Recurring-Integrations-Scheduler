using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class ImportJobV3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportJobV3));
            this.foldersGroupBox = new System.Windows.Forms.GroupBox();
            this.topFolderLabel = new System.Windows.Forms.Label();
            this.topFolderTextBox = new System.Windows.Forms.TextBox();
            this.topFolderBrowserButton = new System.Windows.Forms.Button();
            this.useStandardSubfolder = new System.Windows.Forms.CheckBox();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.inputFolderTextBox = new System.Windows.Forms.TextBox();
            this.inputFolderBrowserButton = new System.Windows.Forms.Button();
            this.uploadSuccessFolderLabel = new System.Windows.Forms.Label();
            this.uploadSuccessFolderTextBox = new System.Windows.Forms.TextBox();
            this.uploadSuccessFolderBrowserButton = new System.Windows.Forms.Button();
            this.uploadErrorsFolderLabel = new System.Windows.Forms.Label();
            this.uploadErrorsFolderTextBox = new System.Windows.Forms.TextBox();
            this.uploadErrorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.processingSuccessFolderLabel = new System.Windows.Forms.Label();
            this.processingSuccessFolderTextBox = new System.Windows.Forms.TextBox();
            this.processingSuccessFolderBrowserButton = new System.Windows.Forms.Button();
            this.processingErrorsFolderLabel = new System.Windows.Forms.Label();
            this.processingErrorsFolderTextBox = new System.Windows.Forms.TextBox();
            this.processingErrorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.legalEntityTextBox = new System.Windows.Forms.TextBox();
            this.legalEntityLabel = new System.Windows.Forms.Label();
            this.jobDescription = new System.Windows.Forms.TextBox();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.jobGroupComboBox = new System.Windows.Forms.ComboBox();
            this.jobGroupLabel = new System.Windows.Forms.Label();
            this.jobName = new System.Windows.Forms.TextBox();
            this.jobNameLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.axDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.instanceLabel = new System.Windows.Forms.Label();
            this.instanceComboBox = new System.Windows.Forms.ComboBox();
            this.authMethodPanel = new System.Windows.Forms.Panel();
            this.userAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.serviceAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.appRegistrationLabel = new System.Windows.Forms.Label();
            this.appRegistrationComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.importJobRunEveryLabel = new System.Windows.Forms.Label();
            this.moreExamplesImportButton = new System.Windows.Forms.Button();
            this.calculatedRunsImportTextBox = new System.Windows.Forms.TextBox();
            this.getCronScheduleForImportJobButton = new System.Windows.Forms.Button();
            this.cronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.importJobTriggerTypePanel = new System.Windows.Forms.Panel();
            this.importJobSimpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.importJobCronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.buildCronLabel = new System.Windows.Forms.Label();
            this.cronTriggerInfoTextBox = new System.Windows.Forms.TextBox();
            this.cronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.importJobCronExpressionLabel = new System.Windows.Forms.Label();
            this.importJobCronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.importJobMinutesLabel = new System.Windows.Forms.Label();
            this.importJobHoursLabel = new System.Windows.Forms.Label();
            this.importJobStartAtLabel = new System.Windows.Forms.Label();
            this.importJobStartAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importJobMinutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importJobHoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pauseIndefinitelyCheckBox = new System.Windows.Forms.CheckBox();
            this.downloadFolderLabel = new System.Windows.Forms.Label();
            this.monitoringJobGroupBox = new System.Windows.Forms.GroupBox();
            this.statusCheckDelayLabel = new System.Windows.Forms.Label();
            this.statusCheckDelayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.downloadErrorKeysFileCheckBox = new System.Windows.Forms.CheckBox();
            this.statusFileExtensionLabel = new System.Windows.Forms.Label();
            this.statusFileExtensionTextBox = new System.Windows.Forms.TextBox();
            this.getExecutionErrorsCheckBox = new System.Windows.Forms.CheckBox();
            this.procJobTriggerTypePanel = new System.Windows.Forms.Panel();
            this.monitoringJobSimpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.monitoringJobCronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.simpleTriggerMonitoringJobGroupBox = new System.Windows.Forms.GroupBox();
            this.monitoringJobRunEveryLabel = new System.Windows.Forms.Label();
            this.monitoringJobHoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monitoringJobHoursLabel = new System.Windows.Forms.Label();
            this.monitoringJobAndOrLabel = new System.Windows.Forms.Label();
            this.monitoringJobMinutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monitoringJobMinutesLabel = new System.Windows.Forms.Label();
            this.monitoringJobStartAtLabel = new System.Windows.Forms.Label();
            this.monitoringJobStartAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cronTriggerMonitoringJobGroupBox = new System.Windows.Forms.GroupBox();
            this.monitoringJobCronExpressionLabel = new System.Windows.Forms.Label();
            this.monitoringJobCronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.monitoringCronTextBox = new System.Windows.Forms.TextBox();
            this.monitoringJobBuildCronLabel = new System.Windows.Forms.Label();
            this.monitoringJobCronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.monitoringJobCronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.getCronScheduleForMonitoringButton = new System.Windows.Forms.Button();
            this.calculatedRunsMonitoringTextBox = new System.Windows.Forms.TextBox();
            this.moreExamplesMonitoringButton = new System.Windows.Forms.Button();
            this.fileSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.inputFilesArePackagesCheckBox = new System.Windows.Forms.CheckBox();
            this.packageTemplateLabel = new System.Windows.Forms.Label();
            this.packageTemplateTextBox = new System.Windows.Forms.TextBox();
            this.packageTemplateFileBrowserButton = new System.Windows.Forms.Button();
            this.searchPatternLabel = new System.Windows.Forms.Label();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderByPanel = new System.Windows.Forms.Panel();
            this.orderAscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.orderDescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.importDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataProjectLabel = new System.Windows.Forms.Label();
            this.dataProject = new System.Windows.Forms.TextBox();
            this.overwriteDataProjectCheckBox = new System.Windows.Forms.CheckBox();
            this.executeImportCheckBox = new System.Windows.Forms.CheckBox();
            this.delayBetweenFilesLabel = new System.Windows.Forms.Label();
            this.delayBetweenFilesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.retryPolicyGroupBox = new System.Windows.Forms.GroupBox();
            this.retriesLabel = new System.Windows.Forms.Label();
            this.retriesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.delayLabel = new System.Windows.Forms.Label();
            this.retriesDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBoxExceptions = new System.Windows.Forms.GroupBox();
            this.pauseOnExceptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.jobTabControl = new System.Windows.Forms.TabControl();
            this.importJobOverviewTabPage = new System.Windows.Forms.TabPage();
            this.jobIdentificationGroupBox = new System.Windows.Forms.GroupBox();
            this.jobControlGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.verboseLoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.importJobDetailsTabPage = new System.Windows.Forms.TabPage();
            this.targetCompanyGroupBox = new System.Windows.Forms.GroupBox();
            this.multicompanyCheckBox = new System.Windows.Forms.CheckBox();
            this.multiCompanyGetMethodPanel = new System.Windows.Forms.Panel();
            this.getLegalEntityFromSubfoldersRadioButton = new System.Windows.Forms.RadioButton();
            this.getLegalEntityFromSubfoldersTextBox = new System.Windows.Forms.TextBox();
            this.getLegalEntityFromFilenameRadioButton = new System.Windows.Forms.RadioButton();
            this.getLegalEntityFromFilenameTextBox = new System.Windows.Forms.TextBox();
            this.getLegalEntityFromFilenameDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.filenameSeparatorLabel = new System.Windows.Forms.Label();
            this.filenameSeparatorTextBox = new System.Windows.Forms.TextBox();
            this.legalEntityTokenPositionLabel = new System.Windows.Forms.Label();
            this.legalEntityTokenPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.separatorExmpleLabel = new System.Windows.Forms.Label();
            this.separatorExampleTextBox = new System.Windows.Forms.TextBox();
            this.separatorExampleLegalEntityTextBox = new System.Windows.Forms.TextBox();
            this.separatorExampleButton = new System.Windows.Forms.Button();
            this.importJobRecurrenceTabPage = new System.Windows.Forms.TabPage();
            this.simpleTriggerImportJobGroupBox = new System.Windows.Forms.GroupBox();
            this.importJobAndOrLabel = new System.Windows.Forms.Label();
            this.cronTriggerImportJobGroupBox = new System.Windows.Forms.GroupBox();
            this.monitoringJobTabPage = new System.Windows.Forms.TabPage();
            this.useMonitoringJobCheckBox = new System.Windows.Forms.CheckBox();
            this.connectionTabPage = new System.Windows.Forms.TabPage();
            this.customOdataTabPage = new System.Windows.Forms.TabPage();
            this.customODataGroupBox = new System.Windows.Forms.GroupBox();
            this.GetAzureWriteUrlLabel = new System.Windows.Forms.Label();
            this.getAzureWriteUrlTextBox = new System.Windows.Forms.TextBox();
            this.ImportFromPackageLabel = new System.Windows.Forms.Label();
            this.importFromPackageTextBox = new System.Windows.Forms.TextBox();
            this.GetExecutionSummaryStatusLabel = new System.Windows.Forms.Label();
            this.getExecutionSummaryStatusTextBox = new System.Windows.Forms.TextBox();
            this.GetExecutionSummaryPageUrlLabel = new System.Windows.Forms.Label();
            this.getExecutionSummaryPageUrlTextBox = new System.Windows.Forms.TextBox();
            this.GetImportTargetErrorKeysFileUrlLabel = new System.Windows.Forms.Label();
            this.getImportTargetErrorKeysFileUrlTextBox = new System.Windows.Forms.TextBox();
            this.GenerateImportTargetErrorKeysFileLabel = new System.Windows.Forms.Label();
            this.generateImportTargetErrorKeysFileTextBox = new System.Windows.Forms.TextBox();
            this.getExecutionErrorsLabel = new System.Windows.Forms.Label();
            this.getExecutionErrorsTextBox = new System.Windows.Forms.TextBox();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.foldersGroupBox.SuspendLayout();
            this.axDetailsGroupBox.SuspendLayout();
            this.authMethodPanel.SuspendLayout();
            this.importJobTriggerTypePanel.SuspendLayout();
            this.monitoringJobGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCheckDelayNumericUpDown)).BeginInit();
            this.procJobTriggerTypePanel.SuspendLayout();
            this.simpleTriggerMonitoringJobGroupBox.SuspendLayout();
            this.cronTriggerMonitoringJobGroupBox.SuspendLayout();
            this.fileSelectionGroupBox.SuspendLayout();
            this.orderByPanel.SuspendLayout();
            this.importDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenFilesNumericUpDown)).BeginInit();
            this.retryPolicyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).BeginInit();
            this.groupBoxExceptions.SuspendLayout();
            this.jobTabControl.SuspendLayout();
            this.importJobOverviewTabPage.SuspendLayout();
            this.jobIdentificationGroupBox.SuspendLayout();
            this.jobControlGroupBox.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.importJobDetailsTabPage.SuspendLayout();
            this.targetCompanyGroupBox.SuspendLayout();
            this.multiCompanyGetMethodPanel.SuspendLayout();
            this.getLegalEntityFromFilenameDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legalEntityTokenPositionNumericUpDown)).BeginInit();
            this.importJobRecurrenceTabPage.SuspendLayout();
            this.simpleTriggerImportJobGroupBox.SuspendLayout();
            this.cronTriggerImportJobGroupBox.SuspendLayout();
            this.monitoringJobTabPage.SuspendLayout();
            this.connectionTabPage.SuspendLayout();
            this.customOdataTabPage.SuspendLayout();
            this.customODataGroupBox.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // foldersGroupBox
            // 
            this.foldersGroupBox.Controls.Add(this.topFolderLabel);
            this.foldersGroupBox.Controls.Add(this.topFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.topFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.useStandardSubfolder);
            this.foldersGroupBox.Controls.Add(this.inputFolderLabel);
            this.foldersGroupBox.Controls.Add(this.inputFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.inputFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.uploadSuccessFolderLabel);
            this.foldersGroupBox.Controls.Add(this.uploadSuccessFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.uploadSuccessFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.uploadErrorsFolderLabel);
            this.foldersGroupBox.Controls.Add(this.uploadErrorsFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.uploadErrorsFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.processingSuccessFolderLabel);
            this.foldersGroupBox.Controls.Add(this.processingSuccessFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.processingSuccessFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.processingErrorsFolderLabel);
            this.foldersGroupBox.Controls.Add(this.processingErrorsFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.processingErrorsFolderBrowserButton);
            this.foldersGroupBox.Location = new System.Drawing.Point(409, 7);
            this.foldersGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.foldersGroupBox.Name = "foldersGroupBox";
            this.foldersGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.foldersGroupBox.Size = new System.Drawing.Size(409, 561);
            this.foldersGroupBox.TabIndex = 0;
            this.foldersGroupBox.TabStop = false;
            this.foldersGroupBox.Text = "Folders";
            // 
            // topFolderLabel
            // 
            this.topFolderLabel.AutoSize = true;
            this.topFolderLabel.Location = new System.Drawing.Point(6, 63);
            this.topFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topFolderLabel.Name = "topFolderLabel";
            this.topFolderLabel.Size = new System.Drawing.Size(100, 25);
            this.topFolderLabel.TabIndex = 0;
            this.topFolderLabel.Text = "Top folder";
            // 
            // topFolderTextBox
            // 
            this.topFolderTextBox.Location = new System.Drawing.Point(9, 96);
            this.topFolderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.topFolderTextBox.Name = "topFolderTextBox";
            this.topFolderTextBox.Size = new System.Drawing.Size(340, 29);
            this.topFolderTextBox.TabIndex = 1;
            this.topFolderTextBox.TextChanged += new System.EventHandler(this.TopUploadFolder_TextChanged);
            // 
            // topFolderBrowserButton
            // 
            this.topFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.topFolderBrowserButton.Location = new System.Drawing.Point(358, 90);
            this.topFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.topFolderBrowserButton.Name = "topFolderBrowserButton";
            this.topFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.topFolderBrowserButton.TabIndex = 0;
            this.topFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.topFolderBrowserButton.UseVisualStyleBackColor = true;
            this.topFolderBrowserButton.Click += new System.EventHandler(this.TopUploadFolderBrowserButton_Click);
            // 
            // useStandardSubfolder
            // 
            this.useStandardSubfolder.AutoSize = true;
            this.useStandardSubfolder.Checked = true;
            this.useStandardSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useStandardSubfolder.Location = new System.Drawing.Point(9, 137);
            this.useStandardSubfolder.Margin = new System.Windows.Forms.Padding(6);
            this.useStandardSubfolder.Name = "useStandardSubfolder";
            this.useStandardSubfolder.Size = new System.Drawing.Size(295, 29);
            this.useStandardSubfolder.TabIndex = 0;
            this.useStandardSubfolder.Text = "Use default subfolders names";
            this.useStandardSubfolder.UseVisualStyleBackColor = true;
            this.useStandardSubfolder.CheckedChanged += new System.EventHandler(this.UseStandardSubfolder_CheckedChanged);
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(6, 175);
            this.inputFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(108, 25);
            this.inputFolderLabel.TabIndex = 0;
            this.inputFolderLabel.Text = "Input folder";
            // 
            // inputFolderTextBox
            // 
            this.inputFolderTextBox.Enabled = false;
            this.inputFolderTextBox.Location = new System.Drawing.Point(9, 209);
            this.inputFolderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.inputFolderTextBox.Name = "inputFolderTextBox";
            this.inputFolderTextBox.Size = new System.Drawing.Size(340, 29);
            this.inputFolderTextBox.TabIndex = 2;
            // 
            // inputFolderBrowserButton
            // 
            this.inputFolderBrowserButton.Enabled = false;
            this.inputFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.inputFolderBrowserButton.Location = new System.Drawing.Point(358, 201);
            this.inputFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.inputFolderBrowserButton.Name = "inputFolderBrowserButton";
            this.inputFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.inputFolderBrowserButton.TabIndex = 0;
            this.inputFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.inputFolderBrowserButton.UseVisualStyleBackColor = true;
            this.inputFolderBrowserButton.Click += new System.EventHandler(this.InputFolderButton_Click);
            // 
            // uploadSuccessFolderLabel
            // 
            this.uploadSuccessFolderLabel.AutoSize = true;
            this.uploadSuccessFolderLabel.Location = new System.Drawing.Point(6, 249);
            this.uploadSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uploadSuccessFolderLabel.Name = "uploadSuccessFolderLabel";
            this.uploadSuccessFolderLabel.Size = new System.Drawing.Size(204, 25);
            this.uploadSuccessFolderLabel.TabIndex = 0;
            this.uploadSuccessFolderLabel.Text = "Upload success folder";
            // 
            // uploadSuccessFolderTextBox
            // 
            this.uploadSuccessFolderTextBox.Enabled = false;
            this.uploadSuccessFolderTextBox.Location = new System.Drawing.Point(9, 282);
            this.uploadSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.uploadSuccessFolderTextBox.Name = "uploadSuccessFolderTextBox";
            this.uploadSuccessFolderTextBox.Size = new System.Drawing.Size(340, 29);
            this.uploadSuccessFolderTextBox.TabIndex = 3;
            // 
            // uploadSuccessFolderBrowserButton
            // 
            this.uploadSuccessFolderBrowserButton.Enabled = false;
            this.uploadSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadSuccessFolderBrowserButton.Location = new System.Drawing.Point(358, 277);
            this.uploadSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadSuccessFolderBrowserButton.Name = "uploadSuccessFolderBrowserButton";
            this.uploadSuccessFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.uploadSuccessFolderBrowserButton.TabIndex = 0;
            this.uploadSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadSuccessFolderBrowserButton.Click += new System.EventHandler(this.UploadSuccessFolderButton_Click);
            // 
            // uploadErrorsFolderLabel
            // 
            this.uploadErrorsFolderLabel.AutoSize = true;
            this.uploadErrorsFolderLabel.Location = new System.Drawing.Point(6, 321);
            this.uploadErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uploadErrorsFolderLabel.Name = "uploadErrorsFolderLabel";
            this.uploadErrorsFolderLabel.Size = new System.Drawing.Size(182, 25);
            this.uploadErrorsFolderLabel.TabIndex = 0;
            this.uploadErrorsFolderLabel.Text = "Upload errors folder";
            // 
            // uploadErrorsFolderTextBox
            // 
            this.uploadErrorsFolderTextBox.Enabled = false;
            this.uploadErrorsFolderTextBox.Location = new System.Drawing.Point(9, 354);
            this.uploadErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.uploadErrorsFolderTextBox.Name = "uploadErrorsFolderTextBox";
            this.uploadErrorsFolderTextBox.Size = new System.Drawing.Size(340, 29);
            this.uploadErrorsFolderTextBox.TabIndex = 4;
            // 
            // uploadErrorsFolderBrowserButton
            // 
            this.uploadErrorsFolderBrowserButton.Enabled = false;
            this.uploadErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadErrorsFolderBrowserButton.Location = new System.Drawing.Point(358, 349);
            this.uploadErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadErrorsFolderBrowserButton.Name = "uploadErrorsFolderBrowserButton";
            this.uploadErrorsFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.uploadErrorsFolderBrowserButton.TabIndex = 0;
            this.uploadErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadErrorsFolderBrowserButton.Click += new System.EventHandler(this.UploadErrorsFolderBrowserButton_Click);
            // 
            // processingSuccessFolderLabel
            // 
            this.processingSuccessFolderLabel.AutoSize = true;
            this.processingSuccessFolderLabel.Location = new System.Drawing.Point(6, 397);
            this.processingSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.processingSuccessFolderLabel.Name = "processingSuccessFolderLabel";
            this.processingSuccessFolderLabel.Size = new System.Drawing.Size(239, 25);
            this.processingSuccessFolderLabel.TabIndex = 0;
            this.processingSuccessFolderLabel.Text = "Processing success folder";
            // 
            // processingSuccessFolderTextBox
            // 
            this.processingSuccessFolderTextBox.Enabled = false;
            this.processingSuccessFolderTextBox.Location = new System.Drawing.Point(9, 428);
            this.processingSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.processingSuccessFolderTextBox.Name = "processingSuccessFolderTextBox";
            this.processingSuccessFolderTextBox.Size = new System.Drawing.Size(340, 29);
            this.processingSuccessFolderTextBox.TabIndex = 5;
            // 
            // processingSuccessFolderBrowserButton
            // 
            this.processingSuccessFolderBrowserButton.Enabled = false;
            this.processingSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingSuccessFolderBrowserButton.Location = new System.Drawing.Point(358, 423);
            this.processingSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingSuccessFolderBrowserButton.Name = "processingSuccessFolderBrowserButton";
            this.processingSuccessFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.processingSuccessFolderBrowserButton.TabIndex = 0;
            this.processingSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingSuccessFolderBrowserButton.Click += new System.EventHandler(this.ProcessingSuccessFolderButton_Click);
            // 
            // processingErrorsFolderLabel
            // 
            this.processingErrorsFolderLabel.AutoSize = true;
            this.processingErrorsFolderLabel.Location = new System.Drawing.Point(6, 469);
            this.processingErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.processingErrorsFolderLabel.Name = "processingErrorsFolderLabel";
            this.processingErrorsFolderLabel.Size = new System.Drawing.Size(217, 25);
            this.processingErrorsFolderLabel.TabIndex = 0;
            this.processingErrorsFolderLabel.Text = "Processing errors folder";
            // 
            // processingErrorsFolderTextBox
            // 
            this.processingErrorsFolderTextBox.Enabled = false;
            this.processingErrorsFolderTextBox.Location = new System.Drawing.Point(9, 500);
            this.processingErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.processingErrorsFolderTextBox.Name = "processingErrorsFolderTextBox";
            this.processingErrorsFolderTextBox.Size = new System.Drawing.Size(340, 29);
            this.processingErrorsFolderTextBox.TabIndex = 6;
            // 
            // processingErrorsFolderBrowserButton
            // 
            this.processingErrorsFolderBrowserButton.Enabled = false;
            this.processingErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingErrorsFolderBrowserButton.Location = new System.Drawing.Point(358, 495);
            this.processingErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingErrorsFolderBrowserButton.Name = "processingErrorsFolderBrowserButton";
            this.processingErrorsFolderBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.processingErrorsFolderBrowserButton.TabIndex = 0;
            this.processingErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingErrorsFolderBrowserButton.Click += new System.EventHandler(this.ProcessingErrorsFolderBrowserButton_Click);
            // 
            // legalEntityTextBox
            // 
            this.legalEntityTextBox.Location = new System.Drawing.Point(226, 55);
            this.legalEntityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.legalEntityTextBox.Name = "legalEntityTextBox";
            this.legalEntityTextBox.Size = new System.Drawing.Size(175, 29);
            this.legalEntityTextBox.TabIndex = 8;
            this.legalEntityTextBox.TextChanged += new System.EventHandler(this.LegalEntityTextBox_TextChanged);
            // 
            // legalEntityLabel
            // 
            this.legalEntityLabel.AutoSize = true;
            this.legalEntityLabel.Location = new System.Drawing.Point(9, 61);
            this.legalEntityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.legalEntityLabel.Name = "legalEntityLabel";
            this.legalEntityLabel.Size = new System.Drawing.Size(206, 25);
            this.legalEntityLabel.TabIndex = 0;
            this.legalEntityLabel.Text = "Single target company";
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
            this.jobDescriptionLabel.TabIndex = 0;
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
            this.jobGroupLabel.TabIndex = 0;
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
            // axDetailsGroupBox
            // 
            this.axDetailsGroupBox.Controls.Add(this.instanceLabel);
            this.axDetailsGroupBox.Controls.Add(this.instanceComboBox);
            this.axDetailsGroupBox.Controls.Add(this.authMethodPanel);
            this.axDetailsGroupBox.Controls.Add(this.appRegistrationLabel);
            this.axDetailsGroupBox.Controls.Add(this.appRegistrationComboBox);
            this.axDetailsGroupBox.Controls.Add(this.userLabel);
            this.axDetailsGroupBox.Controls.Add(this.userComboBox);
            this.axDetailsGroupBox.Location = new System.Drawing.Point(7, 7);
            this.axDetailsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.axDetailsGroupBox.Name = "axDetailsGroupBox";
            this.axDetailsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.axDetailsGroupBox.Size = new System.Drawing.Size(484, 242);
            this.axDetailsGroupBox.TabIndex = 0;
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
            this.instanceLabel.TabIndex = 0;
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
            this.instanceComboBox.TabIndex = 0;
            // 
            // authMethodPanel
            // 
            this.authMethodPanel.Controls.Add(this.userAuthRadioButton);
            this.authMethodPanel.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodPanel.Location = new System.Drawing.Point(13, 83);
            this.authMethodPanel.Margin = new System.Windows.Forms.Padding(6);
            this.authMethodPanel.Name = "authMethodPanel";
            this.authMethodPanel.Size = new System.Drawing.Size(464, 46);
            this.authMethodPanel.TabIndex = 0;
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(6, 6);
            this.userAuthRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(204, 29);
            this.userAuthRadioButton.TabIndex = 0;
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
            this.serviceAuthRadioButton.TabIndex = 1;
            this.serviceAuthRadioButton.Text = "Service authentication";
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // appRegistrationLabel
            // 
            this.appRegistrationLabel.AutoSize = true;
            this.appRegistrationLabel.Location = new System.Drawing.Point(17, 146);
            this.appRegistrationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.appRegistrationLabel.Name = "appRegistrationLabel";
            this.appRegistrationLabel.Size = new System.Drawing.Size(202, 25);
            this.appRegistrationLabel.TabIndex = 0;
            this.appRegistrationLabel.Text = "Azure app registration";
            // 
            // appRegistrationComboBox
            // 
            this.appRegistrationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appRegistrationComboBox.FormattingEnabled = true;
            this.appRegistrationComboBox.Location = new System.Drawing.Point(226, 140);
            this.appRegistrationComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.appRegistrationComboBox.Name = "appRegistrationComboBox";
            this.appRegistrationComboBox.Size = new System.Drawing.Size(248, 32);
            this.appRegistrationComboBox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(165, 190);
            this.userLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 25);
            this.userLabel.TabIndex = 0;
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
            this.userComboBox.TabIndex = 2;
            // 
            // importJobRunEveryLabel
            // 
            this.importJobRunEveryLabel.AutoSize = true;
            this.importJobRunEveryLabel.Location = new System.Drawing.Point(6, 26);
            this.importJobRunEveryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.importJobRunEveryLabel.Name = "importJobRunEveryLabel";
            this.importJobRunEveryLabel.Size = new System.Drawing.Size(146, 25);
            this.importJobRunEveryLabel.TabIndex = 0;
            this.importJobRunEveryLabel.Text = "Run job every...";
            // 
            // moreExamplesImportButton
            // 
            this.moreExamplesImportButton.Location = new System.Drawing.Point(290, 517);
            this.moreExamplesImportButton.Margin = new System.Windows.Forms.Padding(6);
            this.moreExamplesImportButton.Name = "moreExamplesImportButton";
            this.moreExamplesImportButton.Size = new System.Drawing.Size(121, 102);
            this.moreExamplesImportButton.TabIndex = 2;
            this.moreExamplesImportButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesImportButton.UseVisualStyleBackColor = true;
            this.moreExamplesImportButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
            // 
            // calculatedRunsImportTextBox
            // 
            this.calculatedRunsImportTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsImportTextBox.Location = new System.Drawing.Point(17, 517);
            this.calculatedRunsImportTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.calculatedRunsImportTextBox.Multiline = true;
            this.calculatedRunsImportTextBox.Name = "calculatedRunsImportTextBox";
            this.calculatedRunsImportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsImportTextBox.Size = new System.Drawing.Size(263, 98);
            this.calculatedRunsImportTextBox.TabIndex = 0;
            this.calculatedRunsImportTextBox.TabStop = false;
            // 
            // getCronScheduleForImportJobButton
            // 
            this.getCronScheduleForImportJobButton.Location = new System.Drawing.Point(17, 443);
            this.getCronScheduleForImportJobButton.Margin = new System.Windows.Forms.Padding(6);
            this.getCronScheduleForImportJobButton.Name = "getCronScheduleForImportJobButton";
            this.getCronScheduleForImportJobButton.Size = new System.Drawing.Size(193, 66);
            this.getCronScheduleForImportJobButton.TabIndex = 1;
            this.getCronScheduleForImportJobButton.Text = "Calculate next 100 runs of cron trigger";
            this.getCronScheduleForImportJobButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForImportJobButton.Click += new System.EventHandler(this.GetCronScheduleForUploadButton_Click);
            // 
            // cronDocsLinkLabel
            // 
            this.cronDocsLinkLabel.AutoSize = true;
            this.cronDocsLinkLabel.Location = new System.Drawing.Point(11, 406);
            this.cronDocsLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cronDocsLinkLabel.Name = "cronDocsLinkLabel";
            this.cronDocsLinkLabel.Size = new System.Drawing.Size(316, 25);
            this.cronDocsLinkLabel.TabIndex = 0;
            this.cronDocsLinkLabel.TabStop = true;
            this.cronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.cronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // importJobTriggerTypePanel
            // 
            this.importJobTriggerTypePanel.Controls.Add(this.importJobSimpleTriggerRadioButton);
            this.importJobTriggerTypePanel.Controls.Add(this.importJobCronTriggerRadioButton);
            this.importJobTriggerTypePanel.Location = new System.Drawing.Point(9, 9);
            this.importJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(6);
            this.importJobTriggerTypePanel.Name = "importJobTriggerTypePanel";
            this.importJobTriggerTypePanel.Size = new System.Drawing.Size(838, 46);
            this.importJobTriggerTypePanel.TabIndex = 0;
            // 
            // importJobSimpleTriggerRadioButton
            // 
            this.importJobSimpleTriggerRadioButton.AutoSize = true;
            this.importJobSimpleTriggerRadioButton.Checked = true;
            this.importJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(11, 6);
            this.importJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.importJobSimpleTriggerRadioButton.Name = "importJobSimpleTriggerRadioButton";
            this.importJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(156, 29);
            this.importJobSimpleTriggerRadioButton.TabIndex = 0;
            this.importJobSimpleTriggerRadioButton.TabStop = true;
            this.importJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.importJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // importJobCronTriggerRadioButton
            // 
            this.importJobCronTriggerRadioButton.AutoSize = true;
            this.importJobCronTriggerRadioButton.Location = new System.Drawing.Point(425, 6);
            this.importJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.importJobCronTriggerRadioButton.Name = "importJobCronTriggerRadioButton";
            this.importJobCronTriggerRadioButton.Size = new System.Drawing.Size(139, 29);
            this.importJobCronTriggerRadioButton.TabIndex = 1;
            this.importJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.importJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.importJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.ImportJobCronTriggerRadioButton_CheckedChanged);
            // 
            // buildCronLabel
            // 
            this.buildCronLabel.AutoSize = true;
            this.buildCronLabel.Location = new System.Drawing.Point(11, 371);
            this.buildCronLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buildCronLabel.Name = "buildCronLabel";
            this.buildCronLabel.Size = new System.Drawing.Size(219, 25);
            this.buildCronLabel.TabIndex = 0;
            this.buildCronLabel.Text = "Build cron expression at";
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
            this.cronTriggerInfoTextBox.TabIndex = 0;
            this.cronTriggerInfoTextBox.TabStop = false;
            this.cronTriggerInfoTextBox.Text = resources.GetString("cronTriggerInfoTextBox.Text");
            // 
            // cronmakerLinkLabel
            // 
            this.cronmakerLinkLabel.AutoSize = true;
            this.cronmakerLinkLabel.Location = new System.Drawing.Point(231, 371);
            this.cronmakerLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cronmakerLinkLabel.Name = "cronmakerLinkLabel";
            this.cronmakerLinkLabel.Size = new System.Drawing.Size(146, 25);
            this.cronmakerLinkLabel.TabIndex = 0;
            this.cronmakerLinkLabel.TabStop = true;
            this.cronmakerLinkLabel.Text = "cronmaker.com";
            this.cronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // importJobCronExpressionLabel
            // 
            this.importJobCronExpressionLabel.AutoSize = true;
            this.importJobCronExpressionLabel.Location = new System.Drawing.Point(11, 26);
            this.importJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.importJobCronExpressionLabel.Name = "importJobCronExpressionLabel";
            this.importJobCronExpressionLabel.Size = new System.Drawing.Size(155, 25);
            this.importJobCronExpressionLabel.TabIndex = 0;
            this.importJobCronExpressionLabel.Text = "Cron expression";
            // 
            // importJobCronExpressionTextBox
            // 
            this.importJobCronExpressionTextBox.Location = new System.Drawing.Point(17, 54);
            this.importJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.importJobCronExpressionTextBox.Name = "importJobCronExpressionTextBox";
            this.importJobCronExpressionTextBox.Size = new System.Drawing.Size(391, 29);
            this.importJobCronExpressionTextBox.TabIndex = 0;
            this.importJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // importJobMinutesLabel
            // 
            this.importJobMinutesLabel.AutoSize = true;
            this.importJobMinutesLabel.Location = new System.Drawing.Point(240, 66);
            this.importJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.importJobMinutesLabel.Name = "importJobMinutesLabel";
            this.importJobMinutesLabel.Size = new System.Drawing.Size(94, 25);
            this.importJobMinutesLabel.TabIndex = 0;
            this.importJobMinutesLabel.Text = "minute(s)";
            this.importJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // importJobHoursLabel
            // 
            this.importJobHoursLabel.AutoSize = true;
            this.importJobHoursLabel.Location = new System.Drawing.Point(240, 26);
            this.importJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.importJobHoursLabel.Name = "importJobHoursLabel";
            this.importJobHoursLabel.Size = new System.Drawing.Size(75, 25);
            this.importJobHoursLabel.TabIndex = 0;
            this.importJobHoursLabel.Text = "hour(s)";
            this.importJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // importJobStartAtLabel
            // 
            this.importJobStartAtLabel.AutoSize = true;
            this.importJobStartAtLabel.Location = new System.Drawing.Point(51, 105);
            this.importJobStartAtLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.importJobStartAtLabel.Name = "importJobStartAtLabel";
            this.importJobStartAtLabel.Size = new System.Drawing.Size(96, 25);
            this.importJobStartAtLabel.TabIndex = 0;
            this.importJobStartAtLabel.Text = "starting at";
            this.importJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // importJobStartAtDateTimePicker
            // 
            this.importJobStartAtDateTimePicker.CustomFormat = "HH:mm:ss";
            this.importJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.importJobStartAtDateTimePicker.Location = new System.Drawing.Point(160, 100);
            this.importJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.importJobStartAtDateTimePicker.Name = "importJobStartAtDateTimePicker";
            this.importJobStartAtDateTimePicker.ShowUpDown = true;
            this.importJobStartAtDateTimePicker.Size = new System.Drawing.Size(130, 29);
            this.importJobStartAtDateTimePicker.TabIndex = 2;
            this.importJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // importJobMinutesDateTimePicker
            // 
            this.importJobMinutesDateTimePicker.CustomFormat = "mm";
            this.importJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.importJobMinutesDateTimePicker.Location = new System.Drawing.Point(160, 59);
            this.importJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.importJobMinutesDateTimePicker.Name = "importJobMinutesDateTimePicker";
            this.importJobMinutesDateTimePicker.ShowUpDown = true;
            this.importJobMinutesDateTimePicker.Size = new System.Drawing.Size(76, 29);
            this.importJobMinutesDateTimePicker.TabIndex = 1;
            this.importJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 1, 0, 0);
            // 
            // importJobHoursDateTimePicker
            // 
            this.importJobHoursDateTimePicker.CustomFormat = "HH";
            this.importJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.importJobHoursDateTimePicker.Location = new System.Drawing.Point(160, 18);
            this.importJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.importJobHoursDateTimePicker.Name = "importJobHoursDateTimePicker";
            this.importJobHoursDateTimePicker.ShowUpDown = true;
            this.importJobHoursDateTimePicker.Size = new System.Drawing.Size(76, 29);
            this.importJobHoursDateTimePicker.TabIndex = 0;
            this.importJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // pauseIndefinitelyCheckBox
            // 
            this.pauseIndefinitelyCheckBox.AutoSize = true;
            this.pauseIndefinitelyCheckBox.Location = new System.Drawing.Point(13, 345);
            this.pauseIndefinitelyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.pauseIndefinitelyCheckBox.Name = "pauseIndefinitelyCheckBox";
            this.pauseIndefinitelyCheckBox.Size = new System.Drawing.Size(357, 29);
            this.pauseIndefinitelyCheckBox.TabIndex = 2;
            this.pauseIndefinitelyCheckBox.Text = "Don\'t execute the job. Always pause.";
            this.pauseIndefinitelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // downloadFolderLabel
            // 
            this.downloadFolderLabel.AutoSize = true;
            this.downloadFolderLabel.Location = new System.Drawing.Point(9, 157);
            this.downloadFolderLabel.Name = "downloadFolderLabel";
            this.downloadFolderLabel.Size = new System.Drawing.Size(90, 13);
            this.downloadFolderLabel.TabIndex = 0;
            this.downloadFolderLabel.Text = "Top upload folder";
            // 
            // monitoringJobGroupBox
            // 
            this.monitoringJobGroupBox.Controls.Add(this.statusCheckDelayLabel);
            this.monitoringJobGroupBox.Controls.Add(this.statusCheckDelayNumericUpDown);
            this.monitoringJobGroupBox.Controls.Add(this.downloadErrorKeysFileCheckBox);
            this.monitoringJobGroupBox.Controls.Add(this.statusFileExtensionLabel);
            this.monitoringJobGroupBox.Controls.Add(this.statusFileExtensionTextBox);
            this.monitoringJobGroupBox.Controls.Add(this.getExecutionErrorsCheckBox);
            this.monitoringJobGroupBox.Controls.Add(this.procJobTriggerTypePanel);
            this.monitoringJobGroupBox.Controls.Add(this.simpleTriggerMonitoringJobGroupBox);
            this.monitoringJobGroupBox.Controls.Add(this.cronTriggerMonitoringJobGroupBox);
            this.monitoringJobGroupBox.Enabled = false;
            this.monitoringJobGroupBox.Location = new System.Drawing.Point(9, 52);
            this.monitoringJobGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringJobGroupBox.Name = "monitoringJobGroupBox";
            this.monitoringJobGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.monitoringJobGroupBox.Size = new System.Drawing.Size(860, 853);
            this.monitoringJobGroupBox.TabIndex = 0;
            this.monitoringJobGroupBox.TabStop = false;
            // 
            // statusCheckDelayLabel
            // 
            this.statusCheckDelayLabel.AutoSize = true;
            this.statusCheckDelayLabel.Location = new System.Drawing.Point(11, 33);
            this.statusCheckDelayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusCheckDelayLabel.Name = "statusCheckDelayLabel";
            this.statusCheckDelayLabel.Size = new System.Drawing.Size(305, 25);
            this.statusCheckDelayLabel.TabIndex = 0;
            this.statusCheckDelayLabel.Text = "Delay between status check (sec)";
            // 
            // statusCheckDelayNumericUpDown
            // 
            this.statusCheckDelayNumericUpDown.Location = new System.Drawing.Point(325, 31);
            this.statusCheckDelayNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.statusCheckDelayNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.statusCheckDelayNumericUpDown.Name = "statusCheckDelayNumericUpDown";
            this.statusCheckDelayNumericUpDown.Size = new System.Drawing.Size(84, 29);
            this.statusCheckDelayNumericUpDown.TabIndex = 0;
            this.statusCheckDelayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // downloadErrorKeysFileCheckBox
            // 
            this.downloadErrorKeysFileCheckBox.AutoSize = true;
            this.downloadErrorKeysFileCheckBox.Location = new System.Drawing.Point(433, 33);
            this.downloadErrorKeysFileCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.downloadErrorKeysFileCheckBox.Name = "downloadErrorKeysFileCheckBox";
            this.downloadErrorKeysFileCheckBox.Size = new System.Drawing.Size(313, 29);
            this.downloadErrorKeysFileCheckBox.TabIndex = 0;
            this.downloadErrorKeysFileCheckBox.Text = "Download import errors keys file";
            this.downloadErrorKeysFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusFileExtensionLabel
            // 
            this.statusFileExtensionLabel.AutoSize = true;
            this.statusFileExtensionLabel.Location = new System.Drawing.Point(13, 85);
            this.statusFileExtensionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.statusFileExtensionLabel.Name = "statusFileExtensionLabel";
            this.statusFileExtensionLabel.Size = new System.Drawing.Size(186, 25);
            this.statusFileExtensionLabel.TabIndex = 6;
            this.statusFileExtensionLabel.Text = "Status file extension";
            // 
            // statusFileExtensionTextBox
            // 
            this.statusFileExtensionTextBox.Location = new System.Drawing.Point(209, 79);
            this.statusFileExtensionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.statusFileExtensionTextBox.Name = "statusFileExtensionTextBox";
            this.statusFileExtensionTextBox.Size = new System.Drawing.Size(101, 29);
            this.statusFileExtensionTextBox.TabIndex = 7;
            this.statusFileExtensionTextBox.Text = ".Status";
            this.statusFileExtensionTextBox.Leave += new System.EventHandler(this.StatusFileExtensionTextBox_Leave);
            // 
            // getExecutionErrorsCheckBox
            // 
            this.getExecutionErrorsCheckBox.AutoSize = true;
            this.getExecutionErrorsCheckBox.Location = new System.Drawing.Point(433, 83);
            this.getExecutionErrorsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.getExecutionErrorsCheckBox.Name = "getExecutionErrorsCheckBox";
            this.getExecutionErrorsCheckBox.Size = new System.Drawing.Size(373, 29);
            this.getExecutionErrorsCheckBox.TabIndex = 8;
            this.getExecutionErrorsCheckBox.Text = "Retrieve execution errors in json format";
            this.getExecutionErrorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // procJobTriggerTypePanel
            // 
            this.procJobTriggerTypePanel.Controls.Add(this.monitoringJobSimpleTriggerRadioButton);
            this.procJobTriggerTypePanel.Controls.Add(this.monitoringJobCronTriggerRadioButton);
            this.procJobTriggerTypePanel.Location = new System.Drawing.Point(11, 148);
            this.procJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(6);
            this.procJobTriggerTypePanel.Name = "procJobTriggerTypePanel";
            this.procJobTriggerTypePanel.Size = new System.Drawing.Size(838, 46);
            this.procJobTriggerTypePanel.TabIndex = 0;
            // 
            // monitoringJobSimpleTriggerRadioButton
            // 
            this.monitoringJobSimpleTriggerRadioButton.AutoSize = true;
            this.monitoringJobSimpleTriggerRadioButton.Checked = true;
            this.monitoringJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(7, 6);
            this.monitoringJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringJobSimpleTriggerRadioButton.Name = "monitoringJobSimpleTriggerRadioButton";
            this.monitoringJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(156, 29);
            this.monitoringJobSimpleTriggerRadioButton.TabIndex = 0;
            this.monitoringJobSimpleTriggerRadioButton.TabStop = true;
            this.monitoringJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.monitoringJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // monitoringJobCronTriggerRadioButton
            // 
            this.monitoringJobCronTriggerRadioButton.AutoSize = true;
            this.monitoringJobCronTriggerRadioButton.Location = new System.Drawing.Point(425, 6);
            this.monitoringJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringJobCronTriggerRadioButton.Name = "monitoringJobCronTriggerRadioButton";
            this.monitoringJobCronTriggerRadioButton.Size = new System.Drawing.Size(139, 29);
            this.monitoringJobCronTriggerRadioButton.TabIndex = 0;
            this.monitoringJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.monitoringJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.monitoringJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.MonitoringJobCronTriggerRadioButton_CheckedChanged);
            // 
            // simpleTriggerMonitoringJobGroupBox
            // 
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobRunEveryLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobHoursDateTimePicker);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobHoursLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobAndOrLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobMinutesDateTimePicker);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobMinutesLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobStartAtLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobStartAtDateTimePicker);
            this.simpleTriggerMonitoringJobGroupBox.Location = new System.Drawing.Point(11, 201);
            this.simpleTriggerMonitoringJobGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.simpleTriggerMonitoringJobGroupBox.Name = "simpleTriggerMonitoringJobGroupBox";
            this.simpleTriggerMonitoringJobGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.simpleTriggerMonitoringJobGroupBox.Size = new System.Drawing.Size(403, 155);
            this.simpleTriggerMonitoringJobGroupBox.TabIndex = 1;
            this.simpleTriggerMonitoringJobGroupBox.TabStop = false;
            // 
            // monitoringJobRunEveryLabel
            // 
            this.monitoringJobRunEveryLabel.AutoSize = true;
            this.monitoringJobRunEveryLabel.Location = new System.Drawing.Point(18, 26);
            this.monitoringJobRunEveryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monitoringJobRunEveryLabel.Name = "monitoringJobRunEveryLabel";
            this.monitoringJobRunEveryLabel.Size = new System.Drawing.Size(146, 25);
            this.monitoringJobRunEveryLabel.TabIndex = 0;
            this.monitoringJobRunEveryLabel.Text = "Run job every...";
            this.monitoringJobRunEveryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // monitoringJobHoursDateTimePicker
            // 
            this.monitoringJobHoursDateTimePicker.CustomFormat = "HH";
            this.monitoringJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monitoringJobHoursDateTimePicker.Location = new System.Drawing.Point(169, 20);
            this.monitoringJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringJobHoursDateTimePicker.Name = "monitoringJobHoursDateTimePicker";
            this.monitoringJobHoursDateTimePicker.ShowUpDown = true;
            this.monitoringJobHoursDateTimePicker.Size = new System.Drawing.Size(76, 29);
            this.monitoringJobHoursDateTimePicker.TabIndex = 0;
            this.monitoringJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // monitoringJobHoursLabel
            // 
            this.monitoringJobHoursLabel.AutoSize = true;
            this.monitoringJobHoursLabel.Location = new System.Drawing.Point(249, 26);
            this.monitoringJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monitoringJobHoursLabel.Name = "monitoringJobHoursLabel";
            this.monitoringJobHoursLabel.Size = new System.Drawing.Size(75, 25);
            this.monitoringJobHoursLabel.TabIndex = 1;
            this.monitoringJobHoursLabel.Text = "hour(s)";
            this.monitoringJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // monitoringJobAndOrLabel
            // 
            this.monitoringJobAndOrLabel.AutoSize = true;
            this.monitoringJobAndOrLabel.Location = new System.Drawing.Point(95, 63);
            this.monitoringJobAndOrLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monitoringJobAndOrLabel.Name = "monitoringJobAndOrLabel";
            this.monitoringJobAndOrLabel.Size = new System.Drawing.Size(68, 25);
            this.monitoringJobAndOrLabel.TabIndex = 2;
            this.monitoringJobAndOrLabel.Text = "and/or";
            this.monitoringJobAndOrLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // monitoringJobMinutesDateTimePicker
            // 
            this.monitoringJobMinutesDateTimePicker.CustomFormat = "mm";
            this.monitoringJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monitoringJobMinutesDateTimePicker.Location = new System.Drawing.Point(169, 63);
            this.monitoringJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringJobMinutesDateTimePicker.Name = "monitoringJobMinutesDateTimePicker";
            this.monitoringJobMinutesDateTimePicker.ShowUpDown = true;
            this.monitoringJobMinutesDateTimePicker.Size = new System.Drawing.Size(76, 29);
            this.monitoringJobMinutesDateTimePicker.TabIndex = 0;
            this.monitoringJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 30, 0, 0);
            // 
            // monitoringJobMinutesLabel
            // 
            this.monitoringJobMinutesLabel.AutoSize = true;
            this.monitoringJobMinutesLabel.Location = new System.Drawing.Point(249, 66);
            this.monitoringJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.monitoringJobMinutesLabel.Name = "monitoringJobMinutesLabel";
            this.monitoringJobMinutesLabel.Size = new System.Drawing.Size(94, 25);
            this.monitoringJobMinutesLabel.TabIndex = 0;
            this.monitoringJobMinutesLabel.Text = "minute(s)";
            this.monitoringJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // monitoringJobStartAtLabel
            // 
            this.monitoringJobStartAtLabel.AutoSize = true;
            this.monitoringJobStartAtLabel.Location = new System.Drawing.Point(68, 103);
            this.monitoringJobStartAtLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monitoringJobStartAtLabel.Name = "monitoringJobStartAtLabel";
            this.monitoringJobStartAtLabel.Size = new System.Drawing.Size(96, 25);
            this.monitoringJobStartAtLabel.TabIndex = 0;
            this.monitoringJobStartAtLabel.Text = "starting at";
            this.monitoringJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // monitoringJobStartAtDateTimePicker
            // 
            this.monitoringJobStartAtDateTimePicker.CustomFormat = "HH:mm:ss";
            this.monitoringJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monitoringJobStartAtDateTimePicker.Location = new System.Drawing.Point(169, 103);
            this.monitoringJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringJobStartAtDateTimePicker.Name = "monitoringJobStartAtDateTimePicker";
            this.monitoringJobStartAtDateTimePicker.ShowUpDown = true;
            this.monitoringJobStartAtDateTimePicker.Size = new System.Drawing.Size(130, 29);
            this.monitoringJobStartAtDateTimePicker.TabIndex = 0;
            this.monitoringJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // cronTriggerMonitoringJobGroupBox
            // 
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobCronExpressionLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobCronExpressionTextBox);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringCronTextBox);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobBuildCronLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobCronmakerLinkLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobCronDocsLinkLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.getCronScheduleForMonitoringButton);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.calculatedRunsMonitoringTextBox);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.moreExamplesMonitoringButton);
            this.cronTriggerMonitoringJobGroupBox.Enabled = false;
            this.cronTriggerMonitoringJobGroupBox.Location = new System.Drawing.Point(420, 201);
            this.cronTriggerMonitoringJobGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.cronTriggerMonitoringJobGroupBox.Name = "cronTriggerMonitoringJobGroupBox";
            this.cronTriggerMonitoringJobGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.cronTriggerMonitoringJobGroupBox.Size = new System.Drawing.Size(429, 639);
            this.cronTriggerMonitoringJobGroupBox.TabIndex = 2;
            this.cronTriggerMonitoringJobGroupBox.TabStop = false;
            // 
            // monitoringJobCronExpressionLabel
            // 
            this.monitoringJobCronExpressionLabel.AutoSize = true;
            this.monitoringJobCronExpressionLabel.Location = new System.Drawing.Point(11, 26);
            this.monitoringJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monitoringJobCronExpressionLabel.Name = "monitoringJobCronExpressionLabel";
            this.monitoringJobCronExpressionLabel.Size = new System.Drawing.Size(155, 25);
            this.monitoringJobCronExpressionLabel.TabIndex = 0;
            this.monitoringJobCronExpressionLabel.Text = "Cron expression";
            // 
            // monitoringJobCronExpressionTextBox
            // 
            this.monitoringJobCronExpressionTextBox.Location = new System.Drawing.Point(17, 59);
            this.monitoringJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringJobCronExpressionTextBox.Name = "monitoringJobCronExpressionTextBox";
            this.monitoringJobCronExpressionTextBox.Size = new System.Drawing.Size(391, 29);
            this.monitoringJobCronExpressionTextBox.TabIndex = 0;
            this.monitoringJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // monitoringCronTextBox
            // 
            this.monitoringCronTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.monitoringCronTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monitoringCronTextBox.Location = new System.Drawing.Point(17, 103);
            this.monitoringCronTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.monitoringCronTextBox.Multiline = true;
            this.monitoringCronTextBox.Name = "monitoringCronTextBox";
            this.monitoringCronTextBox.Size = new System.Drawing.Size(394, 271);
            this.monitoringCronTextBox.TabIndex = 0;
            this.monitoringCronTextBox.TabStop = false;
            this.monitoringCronTextBox.Text = resources.GetString("monitoringCronTextBox.Text");
            // 
            // monitoringJobBuildCronLabel
            // 
            this.monitoringJobBuildCronLabel.AutoSize = true;
            this.monitoringJobBuildCronLabel.Location = new System.Drawing.Point(11, 380);
            this.monitoringJobBuildCronLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monitoringJobBuildCronLabel.Name = "monitoringJobBuildCronLabel";
            this.monitoringJobBuildCronLabel.Size = new System.Drawing.Size(219, 25);
            this.monitoringJobBuildCronLabel.TabIndex = 0;
            this.monitoringJobBuildCronLabel.Text = "Build cron expression at";
            // 
            // monitoringJobCronmakerLinkLabel
            // 
            this.monitoringJobCronmakerLinkLabel.AutoSize = true;
            this.monitoringJobCronmakerLinkLabel.Location = new System.Drawing.Point(240, 380);
            this.monitoringJobCronmakerLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monitoringJobCronmakerLinkLabel.Name = "monitoringJobCronmakerLinkLabel";
            this.monitoringJobCronmakerLinkLabel.Size = new System.Drawing.Size(146, 25);
            this.monitoringJobCronmakerLinkLabel.TabIndex = 0;
            this.monitoringJobCronmakerLinkLabel.TabStop = true;
            this.monitoringJobCronmakerLinkLabel.Text = "cronmaker.com";
            this.monitoringJobCronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // monitoringJobCronDocsLinkLabel
            // 
            this.monitoringJobCronDocsLinkLabel.AutoSize = true;
            this.monitoringJobCronDocsLinkLabel.Location = new System.Drawing.Point(11, 414);
            this.monitoringJobCronDocsLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monitoringJobCronDocsLinkLabel.Name = "monitoringJobCronDocsLinkLabel";
            this.monitoringJobCronDocsLinkLabel.Size = new System.Drawing.Size(316, 25);
            this.monitoringJobCronDocsLinkLabel.TabIndex = 0;
            this.monitoringJobCronDocsLinkLabel.TabStop = true;
            this.monitoringJobCronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.monitoringJobCronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // getCronScheduleForMonitoringButton
            // 
            this.getCronScheduleForMonitoringButton.Location = new System.Drawing.Point(17, 452);
            this.getCronScheduleForMonitoringButton.Margin = new System.Windows.Forms.Padding(6);
            this.getCronScheduleForMonitoringButton.Name = "getCronScheduleForMonitoringButton";
            this.getCronScheduleForMonitoringButton.Size = new System.Drawing.Size(193, 66);
            this.getCronScheduleForMonitoringButton.TabIndex = 4;
            this.getCronScheduleForMonitoringButton.Text = "Get cron schedule for monitoring job ";
            this.getCronScheduleForMonitoringButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForMonitoringButton.Click += new System.EventHandler(this.GetCronScheduleForMonitoringButton_Click);
            // 
            // calculatedRunsMonitoringTextBox
            // 
            this.calculatedRunsMonitoringTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsMonitoringTextBox.Location = new System.Drawing.Point(17, 526);
            this.calculatedRunsMonitoringTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.calculatedRunsMonitoringTextBox.Multiline = true;
            this.calculatedRunsMonitoringTextBox.Name = "calculatedRunsMonitoringTextBox";
            this.calculatedRunsMonitoringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsMonitoringTextBox.Size = new System.Drawing.Size(263, 98);
            this.calculatedRunsMonitoringTextBox.TabIndex = 3;
            this.calculatedRunsMonitoringTextBox.TabStop = false;
            // 
            // moreExamplesMonitoringButton
            // 
            this.moreExamplesMonitoringButton.Location = new System.Drawing.Point(290, 526);
            this.moreExamplesMonitoringButton.Margin = new System.Windows.Forms.Padding(6);
            this.moreExamplesMonitoringButton.Name = "moreExamplesMonitoringButton";
            this.moreExamplesMonitoringButton.Size = new System.Drawing.Size(121, 102);
            this.moreExamplesMonitoringButton.TabIndex = 5;
            this.moreExamplesMonitoringButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesMonitoringButton.UseVisualStyleBackColor = true;
            this.moreExamplesMonitoringButton.Click += new System.EventHandler(this.MoreExamplesMonitoringButton_Click);
            // 
            // fileSelectionGroupBox
            // 
            this.fileSelectionGroupBox.Controls.Add(this.inputFilesArePackagesCheckBox);
            this.fileSelectionGroupBox.Controls.Add(this.packageTemplateLabel);
            this.fileSelectionGroupBox.Controls.Add(this.packageTemplateTextBox);
            this.fileSelectionGroupBox.Controls.Add(this.packageTemplateFileBrowserButton);
            this.fileSelectionGroupBox.Controls.Add(this.searchPatternLabel);
            this.fileSelectionGroupBox.Controls.Add(this.searchPatternTextBox);
            this.fileSelectionGroupBox.Controls.Add(this.orderByLabel);
            this.fileSelectionGroupBox.Controls.Add(this.orderByComboBox);
            this.fileSelectionGroupBox.Controls.Add(this.orderLabel);
            this.fileSelectionGroupBox.Controls.Add(this.orderByPanel);
            this.fileSelectionGroupBox.Location = new System.Drawing.Point(431, 7);
            this.fileSelectionGroupBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fileSelectionGroupBox.Name = "fileSelectionGroupBox";
            this.fileSelectionGroupBox.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fileSelectionGroupBox.Size = new System.Drawing.Size(453, 343);
            this.fileSelectionGroupBox.TabIndex = 0;
            this.fileSelectionGroupBox.TabStop = false;
            this.fileSelectionGroupBox.Text = "Input files";
            // 
            // inputFilesArePackagesCheckBox
            // 
            this.inputFilesArePackagesCheckBox.AutoSize = true;
            this.inputFilesArePackagesCheckBox.Checked = true;
            this.inputFilesArePackagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputFilesArePackagesCheckBox.Location = new System.Drawing.Point(9, 35);
            this.inputFilesArePackagesCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.inputFilesArePackagesCheckBox.Name = "inputFilesArePackagesCheckBox";
            this.inputFilesArePackagesCheckBox.Size = new System.Drawing.Size(312, 29);
            this.inputFilesArePackagesCheckBox.TabIndex = 2;
            this.inputFilesArePackagesCheckBox.Text = "Input files are packages already";
            this.inputFilesArePackagesCheckBox.UseVisualStyleBackColor = true;
            this.inputFilesArePackagesCheckBox.CheckedChanged += new System.EventHandler(this.InputFilesArePackagesCheckBox_CheckedChanged);
            // 
            // packageTemplateLabel
            // 
            this.packageTemplateLabel.AutoSize = true;
            this.packageTemplateLabel.Location = new System.Drawing.Point(6, 83);
            this.packageTemplateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.packageTemplateLabel.Name = "packageTemplateLabel";
            this.packageTemplateLabel.Size = new System.Drawing.Size(197, 25);
            this.packageTemplateLabel.TabIndex = 0;
            this.packageTemplateLabel.Text = "Package template file";
            // 
            // packageTemplateTextBox
            // 
            this.packageTemplateTextBox.Enabled = false;
            this.packageTemplateTextBox.Location = new System.Drawing.Point(9, 114);
            this.packageTemplateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.packageTemplateTextBox.Name = "packageTemplateTextBox";
            this.packageTemplateTextBox.Size = new System.Drawing.Size(380, 29);
            this.packageTemplateTextBox.TabIndex = 6;
            // 
            // packageTemplateFileBrowserButton
            // 
            this.packageTemplateFileBrowserButton.Enabled = false;
            this.packageTemplateFileBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.packageTemplateFileBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.packageTemplateFileBrowserButton.Location = new System.Drawing.Point(398, 109);
            this.packageTemplateFileBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.packageTemplateFileBrowserButton.Name = "packageTemplateFileBrowserButton";
            this.packageTemplateFileBrowserButton.Size = new System.Drawing.Size(44, 48);
            this.packageTemplateFileBrowserButton.TabIndex = 7;
            this.packageTemplateFileBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.packageTemplateFileBrowserButton.UseVisualStyleBackColor = true;
            this.packageTemplateFileBrowserButton.Click += new System.EventHandler(this.PackageTemplateFileBrowserButton_Click);
            // 
            // searchPatternLabel
            // 
            this.searchPatternLabel.AutoSize = true;
            this.searchPatternLabel.Location = new System.Drawing.Point(13, 203);
            this.searchPatternLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchPatternLabel.Name = "searchPatternLabel";
            this.searchPatternLabel.Size = new System.Drawing.Size(253, 25);
            this.searchPatternLabel.TabIndex = 0;
            this.searchPatternLabel.Text = "Search pattern for input files";
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Enabled = false;
            this.searchPatternTextBox.Location = new System.Drawing.Point(268, 198);
            this.searchPatternTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(171, 29);
            this.searchPatternTextBox.TabIndex = 0;
            this.searchPatternTextBox.Text = "*.zip";
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(13, 244);
            this.orderByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(88, 25);
            this.orderByLabel.TabIndex = 0;
            this.orderByLabel.Text = "Order by";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(110, 240);
            this.orderByComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(329, 32);
            this.orderByComboBox.TabIndex = 1;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(13, 297);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(88, 25);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Direction";
            // 
            // orderByPanel
            // 
            this.orderByPanel.Controls.Add(this.orderAscendingRadioButton);
            this.orderByPanel.Controls.Add(this.orderDescendingRadioButton);
            this.orderByPanel.Location = new System.Drawing.Point(110, 288);
            this.orderByPanel.Margin = new System.Windows.Forms.Padding(0);
            this.orderByPanel.Name = "orderByPanel";
            this.orderByPanel.Size = new System.Drawing.Size(332, 42);
            this.orderByPanel.TabIndex = 0;
            // 
            // orderAscendingRadioButton
            // 
            this.orderAscendingRadioButton.AutoSize = true;
            this.orderAscendingRadioButton.Checked = true;
            this.orderAscendingRadioButton.Location = new System.Drawing.Point(13, 6);
            this.orderAscendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderAscendingRadioButton.Name = "orderAscendingRadioButton";
            this.orderAscendingRadioButton.Size = new System.Drawing.Size(130, 29);
            this.orderAscendingRadioButton.TabIndex = 0;
            this.orderAscendingRadioButton.TabStop = true;
            this.orderAscendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Ascending;
            this.orderAscendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderDescendingRadioButton
            // 
            this.orderDescendingRadioButton.AutoSize = true;
            this.orderDescendingRadioButton.Location = new System.Drawing.Point(158, 6);
            this.orderDescendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderDescendingRadioButton.Name = "orderDescendingRadioButton";
            this.orderDescendingRadioButton.Size = new System.Drawing.Size(141, 29);
            this.orderDescendingRadioButton.TabIndex = 1;
            this.orderDescendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Descending;
            this.orderDescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // importDetailsGroupBox
            // 
            this.importDetailsGroupBox.Controls.Add(this.dataProjectLabel);
            this.importDetailsGroupBox.Controls.Add(this.dataProject);
            this.importDetailsGroupBox.Controls.Add(this.overwriteDataProjectCheckBox);
            this.importDetailsGroupBox.Controls.Add(this.executeImportCheckBox);
            this.importDetailsGroupBox.Controls.Add(this.delayBetweenFilesLabel);
            this.importDetailsGroupBox.Controls.Add(this.delayBetweenFilesNumericUpDown);
            this.importDetailsGroupBox.Location = new System.Drawing.Point(7, 7);
            this.importDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importDetailsGroupBox.Name = "importDetailsGroupBox";
            this.importDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importDetailsGroupBox.Size = new System.Drawing.Size(416, 268);
            this.importDetailsGroupBox.TabIndex = 0;
            this.importDetailsGroupBox.TabStop = false;
            this.importDetailsGroupBox.Text = "Import details";
            // 
            // dataProjectLabel
            // 
            this.dataProjectLabel.AutoSize = true;
            this.dataProjectLabel.Location = new System.Drawing.Point(7, 37);
            this.dataProjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataProjectLabel.Name = "dataProjectLabel";
            this.dataProjectLabel.Size = new System.Drawing.Size(281, 25);
            this.dataProjectLabel.TabIndex = 0;
            this.dataProjectLabel.Text = "Data project name in Dynamics";
            // 
            // dataProject
            // 
            this.dataProject.Location = new System.Drawing.Point(13, 72);
            this.dataProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataProject.Name = "dataProject";
            this.dataProject.Size = new System.Drawing.Size(387, 29);
            this.dataProject.TabIndex = 1;
            // 
            // overwriteDataProjectCheckBox
            // 
            this.overwriteDataProjectCheckBox.AutoSize = true;
            this.overwriteDataProjectCheckBox.Checked = true;
            this.overwriteDataProjectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteDataProjectCheckBox.Location = new System.Drawing.Point(13, 120);
            this.overwriteDataProjectCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.overwriteDataProjectCheckBox.Name = "overwriteDataProjectCheckBox";
            this.overwriteDataProjectCheckBox.Size = new System.Drawing.Size(309, 29);
            this.overwriteDataProjectCheckBox.TabIndex = 2;
            this.overwriteDataProjectCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Overwrite_data_project_definition;
            this.overwriteDataProjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // executeImportCheckBox
            // 
            this.executeImportCheckBox.AutoSize = true;
            this.executeImportCheckBox.Checked = true;
            this.executeImportCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.executeImportCheckBox.Location = new System.Drawing.Point(13, 162);
            this.executeImportCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.executeImportCheckBox.Name = "executeImportCheckBox";
            this.executeImportCheckBox.Size = new System.Drawing.Size(167, 29);
            this.executeImportCheckBox.TabIndex = 3;
            this.executeImportCheckBox.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Execute_import;
            this.executeImportCheckBox.UseVisualStyleBackColor = true;
            // 
            // delayBetweenFilesLabel
            // 
            this.delayBetweenFilesLabel.AutoSize = true;
            this.delayBetweenFilesLabel.Location = new System.Drawing.Point(7, 218);
            this.delayBetweenFilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delayBetweenFilesLabel.Name = "delayBetweenFilesLabel";
            this.delayBetweenFilesLabel.Size = new System.Drawing.Size(309, 25);
            this.delayBetweenFilesLabel.TabIndex = 0;
            this.delayBetweenFilesLabel.Text = "Delay between files uploads (sec.)";
            // 
            // delayBetweenFilesNumericUpDown
            // 
            this.delayBetweenFilesNumericUpDown.Location = new System.Drawing.Point(325, 214);
            this.delayBetweenFilesNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.delayBetweenFilesNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.delayBetweenFilesNumericUpDown.Name = "delayBetweenFilesNumericUpDown";
            this.delayBetweenFilesNumericUpDown.Size = new System.Drawing.Size(79, 29);
            this.delayBetweenFilesNumericUpDown.TabIndex = 4;
            this.delayBetweenFilesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Package files|*.zip";
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
            this.retryPolicyGroupBox.TabIndex = 1;
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
            this.retriesCountUpDown.Location = new System.Drawing.Point(182, 33);
            this.retriesCountUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.retriesCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.retriesCountUpDown.Name = "retriesCountUpDown";
            this.retriesCountUpDown.Size = new System.Drawing.Size(88, 29);
            this.retriesCountUpDown.TabIndex = 1;
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
            this.delayLabel.TabIndex = 0;
            this.delayLabel.Text = "Delay (seconds)";
            // 
            // retriesDelayUpDown
            // 
            this.retriesDelayUpDown.Location = new System.Drawing.Point(182, 78);
            this.retriesDelayUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.retriesDelayUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.retriesDelayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.retriesDelayUpDown.Name = "retriesDelayUpDown";
            this.retriesDelayUpDown.Size = new System.Drawing.Size(88, 29);
            this.retriesDelayUpDown.TabIndex = 2;
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
            this.groupBoxExceptions.TabIndex = 0;
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
            this.jobTabControl.Controls.Add(this.importJobOverviewTabPage);
            this.jobTabControl.Controls.Add(this.importJobDetailsTabPage);
            this.jobTabControl.Controls.Add(this.importJobRecurrenceTabPage);
            this.jobTabControl.Controls.Add(this.monitoringJobTabPage);
            this.jobTabControl.Controls.Add(this.connectionTabPage);
            this.jobTabControl.Controls.Add(this.customOdataTabPage);
            this.jobTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobTabControl.Location = new System.Drawing.Point(0, 0);
            this.jobTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.jobTabControl.Name = "jobTabControl";
            this.jobTabControl.SelectedIndex = 0;
            this.jobTabControl.Size = new System.Drawing.Size(1294, 940);
            this.jobTabControl.TabIndex = 0;
            // 
            // importJobOverviewTabPage
            // 
            this.importJobOverviewTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.importJobOverviewTabPage.Controls.Add(this.jobIdentificationGroupBox);
            this.importJobOverviewTabPage.Controls.Add(this.jobControlGroupBox);
            this.importJobOverviewTabPage.Controls.Add(this.foldersGroupBox);
            this.importJobOverviewTabPage.Location = new System.Drawing.Point(4, 33);
            this.importJobOverviewTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.importJobOverviewTabPage.Name = "importJobOverviewTabPage";
            this.importJobOverviewTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.importJobOverviewTabPage.Size = new System.Drawing.Size(1286, 903);
            this.importJobOverviewTabPage.TabIndex = 0;
            this.importJobOverviewTabPage.Text = "Import job overview";
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
            this.jobIdentificationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobIdentificationGroupBox.Name = "jobIdentificationGroupBox";
            this.jobIdentificationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.jobIdentificationGroupBox.Size = new System.Drawing.Size(392, 375);
            this.jobIdentificationGroupBox.TabIndex = 0;
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
            this.jobControlGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobControlGroupBox.Name = "jobControlGroupBox";
            this.jobControlGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.jobControlGroupBox.Size = new System.Drawing.Size(392, 382);
            this.jobControlGroupBox.TabIndex = 0;
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
            this.groupBoxLogging.TabIndex = 1;
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
            // importJobDetailsTabPage
            // 
            this.importJobDetailsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.importJobDetailsTabPage.Controls.Add(this.importDetailsGroupBox);
            this.importJobDetailsTabPage.Controls.Add(this.fileSelectionGroupBox);
            this.importJobDetailsTabPage.Controls.Add(this.targetCompanyGroupBox);
            this.importJobDetailsTabPage.Location = new System.Drawing.Point(4, 33);
            this.importJobDetailsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.importJobDetailsTabPage.Name = "importJobDetailsTabPage";
            this.importJobDetailsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.importJobDetailsTabPage.Size = new System.Drawing.Size(1286, 903);
            this.importJobDetailsTabPage.TabIndex = 0;
            this.importJobDetailsTabPage.Text = "Import job details";
            // 
            // targetCompanyGroupBox
            // 
            this.targetCompanyGroupBox.Controls.Add(this.legalEntityLabel);
            this.targetCompanyGroupBox.Controls.Add(this.legalEntityTextBox);
            this.targetCompanyGroupBox.Controls.Add(this.multicompanyCheckBox);
            this.targetCompanyGroupBox.Controls.Add(this.multiCompanyGetMethodPanel);
            this.targetCompanyGroupBox.Location = new System.Drawing.Point(7, 284);
            this.targetCompanyGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.targetCompanyGroupBox.Name = "targetCompanyGroupBox";
            this.targetCompanyGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.targetCompanyGroupBox.Size = new System.Drawing.Size(416, 618);
            this.targetCompanyGroupBox.TabIndex = 2;
            this.targetCompanyGroupBox.TabStop = false;
            this.targetCompanyGroupBox.Text = "Target company";
            // 
            // multicompanyCheckBox
            // 
            this.multicompanyCheckBox.AutoSize = true;
            this.multicompanyCheckBox.Location = new System.Drawing.Point(15, 107);
            this.multicompanyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.multicompanyCheckBox.Name = "multicompanyCheckBox";
            this.multicompanyCheckBox.Size = new System.Drawing.Size(341, 29);
            this.multicompanyCheckBox.TabIndex = 9;
            this.multicompanyCheckBox.Text = "Multiple target legal entities method";
            this.multicompanyCheckBox.UseVisualStyleBackColor = true;
            this.multicompanyCheckBox.CheckedChanged += new System.EventHandler(this.MulticompanyCheckBox_CheckedChanged);
            // 
            // multiCompanyGetMethodPanel
            // 
            this.multiCompanyGetMethodPanel.Controls.Add(this.getLegalEntityFromSubfoldersRadioButton);
            this.multiCompanyGetMethodPanel.Controls.Add(this.getLegalEntityFromSubfoldersTextBox);
            this.multiCompanyGetMethodPanel.Controls.Add(this.getLegalEntityFromFilenameRadioButton);
            this.multiCompanyGetMethodPanel.Controls.Add(this.getLegalEntityFromFilenameTextBox);
            this.multiCompanyGetMethodPanel.Controls.Add(this.getLegalEntityFromFilenameDetailsGroupBox);
            this.multiCompanyGetMethodPanel.Enabled = false;
            this.multiCompanyGetMethodPanel.Location = new System.Drawing.Point(15, 142);
            this.multiCompanyGetMethodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.multiCompanyGetMethodPanel.Name = "multiCompanyGetMethodPanel";
            this.multiCompanyGetMethodPanel.Size = new System.Drawing.Size(389, 469);
            this.multiCompanyGetMethodPanel.TabIndex = 0;
            // 
            // getLegalEntityFromSubfoldersRadioButton
            // 
            this.getLegalEntityFromSubfoldersRadioButton.AutoSize = true;
            this.getLegalEntityFromSubfoldersRadioButton.Checked = true;
            this.getLegalEntityFromSubfoldersRadioButton.Location = new System.Drawing.Point(4, 4);
            this.getLegalEntityFromSubfoldersRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.getLegalEntityFromSubfoldersRadioButton.Name = "getLegalEntityFromSubfoldersRadioButton";
            this.getLegalEntityFromSubfoldersRadioButton.Size = new System.Drawing.Size(347, 29);
            this.getLegalEntityFromSubfoldersRadioButton.TabIndex = 0;
            this.getLegalEntityFromSubfoldersRadioButton.TabStop = true;
            this.getLegalEntityFromSubfoldersRadioButton.Text = "Get legal entity from subfolder name";
            this.getLegalEntityFromSubfoldersRadioButton.UseVisualStyleBackColor = true;
            // 
            // getLegalEntityFromSubfoldersTextBox
            // 
            this.getLegalEntityFromSubfoldersTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.getLegalEntityFromSubfoldersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getLegalEntityFromSubfoldersTextBox.Location = new System.Drawing.Point(31, 39);
            this.getLegalEntityFromSubfoldersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.getLegalEntityFromSubfoldersTextBox.Multiline = true;
            this.getLegalEntityFromSubfoldersTextBox.Name = "getLegalEntityFromSubfoldersTextBox";
            this.getLegalEntityFromSubfoldersTextBox.Size = new System.Drawing.Size(347, 63);
            this.getLegalEntityFromSubfoldersTextBox.TabIndex = 1;
            this.getLegalEntityFromSubfoldersTextBox.Text = "Names of subfolders of Input folder are legal entities names";
            // 
            // getLegalEntityFromFilenameRadioButton
            // 
            this.getLegalEntityFromFilenameRadioButton.AutoSize = true;
            this.getLegalEntityFromFilenameRadioButton.Location = new System.Drawing.Point(4, 124);
            this.getLegalEntityFromFilenameRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.getLegalEntityFromFilenameRadioButton.Name = "getLegalEntityFromFilenameRadioButton";
            this.getLegalEntityFromFilenameRadioButton.Size = new System.Drawing.Size(338, 29);
            this.getLegalEntityFromFilenameRadioButton.TabIndex = 2;
            this.getLegalEntityFromFilenameRadioButton.Text = "Get legal entity from input file name";
            this.getLegalEntityFromFilenameRadioButton.UseVisualStyleBackColor = true;
            this.getLegalEntityFromFilenameRadioButton.CheckedChanged += new System.EventHandler(this.GetLegalEntityFromFilenameRadioButton_CheckedChanged);
            // 
            // getLegalEntityFromFilenameTextBox
            // 
            this.getLegalEntityFromFilenameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.getLegalEntityFromFilenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getLegalEntityFromFilenameTextBox.Location = new System.Drawing.Point(31, 159);
            this.getLegalEntityFromFilenameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.getLegalEntityFromFilenameTextBox.Multiline = true;
            this.getLegalEntityFromFilenameTextBox.Name = "getLegalEntityFromFilenameTextBox";
            this.getLegalEntityFromFilenameTextBox.Size = new System.Drawing.Size(347, 78);
            this.getLegalEntityFromFilenameTextBox.TabIndex = 3;
            this.getLegalEntityFromFilenameTextBox.Text = "Legal entity is part of input file name. It is necessary to specify separator and" +
    " position of LE token in the file name.";
            // 
            // getLegalEntityFromFilenameDetailsGroupBox
            // 
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.filenameSeparatorLabel);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.filenameSeparatorTextBox);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.legalEntityTokenPositionLabel);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.legalEntityTokenPositionNumericUpDown);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExmpleLabel);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExampleTextBox);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExampleLegalEntityTextBox);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExampleButton);
            this.getLegalEntityFromFilenameDetailsGroupBox.Enabled = false;
            this.getLegalEntityFromFilenameDetailsGroupBox.Location = new System.Drawing.Point(28, 242);
            this.getLegalEntityFromFilenameDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.getLegalEntityFromFilenameDetailsGroupBox.Name = "getLegalEntityFromFilenameDetailsGroupBox";
            this.getLegalEntityFromFilenameDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.getLegalEntityFromFilenameDetailsGroupBox.Size = new System.Drawing.Size(350, 223);
            this.getLegalEntityFromFilenameDetailsGroupBox.TabIndex = 4;
            this.getLegalEntityFromFilenameDetailsGroupBox.TabStop = false;
            // 
            // filenameSeparatorLabel
            // 
            this.filenameSeparatorLabel.AutoSize = true;
            this.filenameSeparatorLabel.Location = new System.Drawing.Point(6, 26);
            this.filenameSeparatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filenameSeparatorLabel.Name = "filenameSeparatorLabel";
            this.filenameSeparatorLabel.Size = new System.Drawing.Size(184, 25);
            this.filenameSeparatorLabel.TabIndex = 3;
            this.filenameSeparatorLabel.Text = "Separator character";
            // 
            // filenameSeparatorTextBox
            // 
            this.filenameSeparatorTextBox.Location = new System.Drawing.Point(196, 20);
            this.filenameSeparatorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filenameSeparatorTextBox.MaxLength = 1;
            this.filenameSeparatorTextBox.Name = "filenameSeparatorTextBox";
            this.filenameSeparatorTextBox.Size = new System.Drawing.Size(33, 29);
            this.filenameSeparatorTextBox.TabIndex = 0;
            this.filenameSeparatorTextBox.Text = "#";
            this.filenameSeparatorTextBox.TextChanged += new System.EventHandler(this.FilenameSeparatorTextBox_TextChanged);
            // 
            // legalEntityTokenPositionLabel
            // 
            this.legalEntityTokenPositionLabel.AutoSize = true;
            this.legalEntityTokenPositionLabel.Location = new System.Drawing.Point(6, 65);
            this.legalEntityTokenPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.legalEntityTokenPositionLabel.Name = "legalEntityTokenPositionLabel";
            this.legalEntityTokenPositionLabel.Size = new System.Drawing.Size(236, 25);
            this.legalEntityTokenPositionLabel.TabIndex = 2;
            this.legalEntityTokenPositionLabel.Text = "Legal entity token position";
            // 
            // legalEntityTokenPositionNumericUpDown
            // 
            this.legalEntityTokenPositionNumericUpDown.Location = new System.Drawing.Point(251, 61);
            this.legalEntityTokenPositionNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.legalEntityTokenPositionNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.legalEntityTokenPositionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.legalEntityTokenPositionNumericUpDown.Name = "legalEntityTokenPositionNumericUpDown";
            this.legalEntityTokenPositionNumericUpDown.Size = new System.Drawing.Size(62, 29);
            this.legalEntityTokenPositionNumericUpDown.TabIndex = 1;
            this.legalEntityTokenPositionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // separatorExmpleLabel
            // 
            this.separatorExmpleLabel.AutoSize = true;
            this.separatorExmpleLabel.Location = new System.Drawing.Point(9, 105);
            this.separatorExmpleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.separatorExmpleLabel.Name = "separatorExmpleLabel";
            this.separatorExmpleLabel.Size = new System.Drawing.Size(88, 25);
            this.separatorExmpleLabel.TabIndex = 4;
            this.separatorExmpleLabel.Text = "Example";
            // 
            // separatorExampleTextBox
            // 
            this.separatorExampleTextBox.Location = new System.Drawing.Point(11, 135);
            this.separatorExampleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.separatorExampleTextBox.Name = "separatorExampleTextBox";
            this.separatorExampleTextBox.Size = new System.Drawing.Size(336, 29);
            this.separatorExampleTextBox.TabIndex = 5;
            this.separatorExampleTextBox.Text = "USMF#Customers-YYYYMMDD.zip";
            this.separatorExampleTextBox.TextChanged += new System.EventHandler(this.SeparatorExampleTextBox_TextChanged);
            // 
            // separatorExampleLegalEntityTextBox
            // 
            this.separatorExampleLegalEntityTextBox.Location = new System.Drawing.Point(11, 183);
            this.separatorExampleLegalEntityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.separatorExampleLegalEntityTextBox.Name = "separatorExampleLegalEntityTextBox";
            this.separatorExampleLegalEntityTextBox.Size = new System.Drawing.Size(160, 29);
            this.separatorExampleLegalEntityTextBox.TabIndex = 6;
            this.separatorExampleLegalEntityTextBox.Text = "USMF";
            // 
            // separatorExampleButton
            // 
            this.separatorExampleButton.Location = new System.Drawing.Point(183, 179);
            this.separatorExampleButton.Margin = new System.Windows.Forms.Padding(6);
            this.separatorExampleButton.Name = "separatorExampleButton";
            this.separatorExampleButton.Size = new System.Drawing.Size(167, 42);
            this.separatorExampleButton.TabIndex = 7;
            this.separatorExampleButton.Text = "Get legal entity";
            this.separatorExampleButton.UseVisualStyleBackColor = true;
            this.separatorExampleButton.Click += new System.EventHandler(this.SeparatorExampleButton_Click);
            // 
            // importJobRecurrenceTabPage
            // 
            this.importJobRecurrenceTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.importJobRecurrenceTabPage.Controls.Add(this.importJobTriggerTypePanel);
            this.importJobRecurrenceTabPage.Controls.Add(this.simpleTriggerImportJobGroupBox);
            this.importJobRecurrenceTabPage.Controls.Add(this.cronTriggerImportJobGroupBox);
            this.importJobRecurrenceTabPage.Location = new System.Drawing.Point(4, 33);
            this.importJobRecurrenceTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.importJobRecurrenceTabPage.Name = "importJobRecurrenceTabPage";
            this.importJobRecurrenceTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.importJobRecurrenceTabPage.Size = new System.Drawing.Size(1286, 903);
            this.importJobRecurrenceTabPage.TabIndex = 0;
            this.importJobRecurrenceTabPage.Text = "Import job recurrence";
            // 
            // simpleTriggerImportJobGroupBox
            // 
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobRunEveryLabel);
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobHoursDateTimePicker);
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobHoursLabel);
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobAndOrLabel);
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobMinutesDateTimePicker);
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobMinutesLabel);
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobStartAtLabel);
            this.simpleTriggerImportJobGroupBox.Controls.Add(this.importJobStartAtDateTimePicker);
            this.simpleTriggerImportJobGroupBox.Location = new System.Drawing.Point(9, 65);
            this.simpleTriggerImportJobGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.simpleTriggerImportJobGroupBox.Name = "simpleTriggerImportJobGroupBox";
            this.simpleTriggerImportJobGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.simpleTriggerImportJobGroupBox.Size = new System.Drawing.Size(403, 155);
            this.simpleTriggerImportJobGroupBox.TabIndex = 0;
            this.simpleTriggerImportJobGroupBox.TabStop = false;
            // 
            // importJobAndOrLabel
            // 
            this.importJobAndOrLabel.AutoSize = true;
            this.importJobAndOrLabel.Location = new System.Drawing.Point(84, 66);
            this.importJobAndOrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.importJobAndOrLabel.Name = "importJobAndOrLabel";
            this.importJobAndOrLabel.Size = new System.Drawing.Size(68, 25);
            this.importJobAndOrLabel.TabIndex = 0;
            this.importJobAndOrLabel.Text = "and/or";
            // 
            // cronTriggerImportJobGroupBox
            // 
            this.cronTriggerImportJobGroupBox.Controls.Add(this.importJobCronExpressionLabel);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.importJobCronExpressionTextBox);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.cronTriggerInfoTextBox);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.buildCronLabel);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.cronmakerLinkLabel);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.cronDocsLinkLabel);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.getCronScheduleForImportJobButton);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.calculatedRunsImportTextBox);
            this.cronTriggerImportJobGroupBox.Controls.Add(this.moreExamplesImportButton);
            this.cronTriggerImportJobGroupBox.Enabled = false;
            this.cronTriggerImportJobGroupBox.Location = new System.Drawing.Point(420, 65);
            this.cronTriggerImportJobGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.cronTriggerImportJobGroupBox.Name = "cronTriggerImportJobGroupBox";
            this.cronTriggerImportJobGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.cronTriggerImportJobGroupBox.Size = new System.Drawing.Size(429, 633);
            this.cronTriggerImportJobGroupBox.TabIndex = 0;
            this.cronTriggerImportJobGroupBox.TabStop = false;
            // 
            // monitoringJobTabPage
            // 
            this.monitoringJobTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.monitoringJobTabPage.Controls.Add(this.useMonitoringJobCheckBox);
            this.monitoringJobTabPage.Controls.Add(this.monitoringJobGroupBox);
            this.monitoringJobTabPage.Location = new System.Drawing.Point(4, 33);
            this.monitoringJobTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.monitoringJobTabPage.Name = "monitoringJobTabPage";
            this.monitoringJobTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.monitoringJobTabPage.Size = new System.Drawing.Size(1286, 903);
            this.monitoringJobTabPage.TabIndex = 0;
            this.monitoringJobTabPage.Text = "Execution monitoring job";
            // 
            // useMonitoringJobCheckBox
            // 
            this.useMonitoringJobCheckBox.AutoSize = true;
            this.useMonitoringJobCheckBox.Location = new System.Drawing.Point(9, 9);
            this.useMonitoringJobCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.useMonitoringJobCheckBox.Name = "useMonitoringJobCheckBox";
            this.useMonitoringJobCheckBox.Size = new System.Drawing.Size(289, 29);
            this.useMonitoringJobCheckBox.TabIndex = 0;
            this.useMonitoringJobCheckBox.Text = "Add execution monitoring job";
            this.useMonitoringJobCheckBox.UseVisualStyleBackColor = true;
            this.useMonitoringJobCheckBox.CheckedChanged += new System.EventHandler(this.UseMonitoringJobCheckBox_CheckedChanged);
            // 
            // connectionTabPage
            // 
            this.connectionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.connectionTabPage.Controls.Add(this.axDetailsGroupBox);
            this.connectionTabPage.Location = new System.Drawing.Point(4, 33);
            this.connectionTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.connectionTabPage.Name = "connectionTabPage";
            this.connectionTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.connectionTabPage.Size = new System.Drawing.Size(1286, 903);
            this.connectionTabPage.TabIndex = 0;
            this.connectionTabPage.Text = "Connection";
            // 
            // customOdataTabPage
            // 
            this.customOdataTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.customOdataTabPage.Controls.Add(this.customODataGroupBox);
            this.customOdataTabPage.Location = new System.Drawing.Point(4, 33);
            this.customOdataTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.customOdataTabPage.Name = "customOdataTabPage";
            this.customOdataTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.customOdataTabPage.Size = new System.Drawing.Size(1286, 903);
            this.customOdataTabPage.TabIndex = 0;
            this.customOdataTabPage.Text = "Custom OData actions";
            // 
            // customODataGroupBox
            // 
            this.customODataGroupBox.Controls.Add(this.GetAzureWriteUrlLabel);
            this.customODataGroupBox.Controls.Add(this.getAzureWriteUrlTextBox);
            this.customODataGroupBox.Controls.Add(this.ImportFromPackageLabel);
            this.customODataGroupBox.Controls.Add(this.importFromPackageTextBox);
            this.customODataGroupBox.Controls.Add(this.GetExecutionSummaryStatusLabel);
            this.customODataGroupBox.Controls.Add(this.getExecutionSummaryStatusTextBox);
            this.customODataGroupBox.Controls.Add(this.GetExecutionSummaryPageUrlLabel);
            this.customODataGroupBox.Controls.Add(this.getExecutionSummaryPageUrlTextBox);
            this.customODataGroupBox.Controls.Add(this.GetImportTargetErrorKeysFileUrlLabel);
            this.customODataGroupBox.Controls.Add(this.getImportTargetErrorKeysFileUrlTextBox);
            this.customODataGroupBox.Controls.Add(this.GenerateImportTargetErrorKeysFileLabel);
            this.customODataGroupBox.Controls.Add(this.generateImportTargetErrorKeysFileTextBox);
            this.customODataGroupBox.Controls.Add(this.getExecutionErrorsLabel);
            this.customODataGroupBox.Controls.Add(this.getExecutionErrorsTextBox);
            this.customODataGroupBox.Location = new System.Drawing.Point(7, 7);
            this.customODataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.customODataGroupBox.Name = "customODataGroupBox";
            this.customODataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.customODataGroupBox.Size = new System.Drawing.Size(1276, 380);
            this.customODataGroupBox.TabIndex = 0;
            this.customODataGroupBox.TabStop = false;
            this.customODataGroupBox.Text = "Custom OData actions relative paths";
            // 
            // GetAzureWriteUrlLabel
            // 
            this.GetAzureWriteUrlLabel.AutoSize = true;
            this.GetAzureWriteUrlLabel.Location = new System.Drawing.Point(158, 44);
            this.GetAzureWriteUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetAzureWriteUrlLabel.Name = "GetAzureWriteUrlLabel";
            this.GetAzureWriteUrlLabel.Size = new System.Drawing.Size(165, 25);
            this.GetAzureWriteUrlLabel.TabIndex = 0;
            this.GetAzureWriteUrlLabel.Text = "GetAzureWriteUrl";
            // 
            // getAzureWriteUrlTextBox
            // 
            this.getAzureWriteUrlTextBox.Location = new System.Drawing.Point(332, 39);
            this.getAzureWriteUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getAzureWriteUrlTextBox.Name = "getAzureWriteUrlTextBox";
            this.getAzureWriteUrlTextBox.Size = new System.Drawing.Size(930, 29);
            this.getAzureWriteUrlTextBox.TabIndex = 0;
            // 
            // ImportFromPackageLabel
            // 
            this.ImportFromPackageLabel.AutoSize = true;
            this.ImportFromPackageLabel.Location = new System.Drawing.Point(134, 92);
            this.ImportFromPackageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImportFromPackageLabel.Name = "ImportFromPackageLabel";
            this.ImportFromPackageLabel.Size = new System.Drawing.Size(188, 25);
            this.ImportFromPackageLabel.TabIndex = 0;
            this.ImportFromPackageLabel.Text = "ImportFromPackage";
            // 
            // importFromPackageTextBox
            // 
            this.importFromPackageTextBox.Location = new System.Drawing.Point(332, 87);
            this.importFromPackageTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importFromPackageTextBox.Name = "importFromPackageTextBox";
            this.importFromPackageTextBox.Size = new System.Drawing.Size(930, 29);
            this.importFromPackageTextBox.TabIndex = 1;
            // 
            // GetExecutionSummaryStatusLabel
            // 
            this.GetExecutionSummaryStatusLabel.AutoSize = true;
            this.GetExecutionSummaryStatusLabel.Location = new System.Drawing.Point(57, 140);
            this.GetExecutionSummaryStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetExecutionSummaryStatusLabel.Name = "GetExecutionSummaryStatusLabel";
            this.GetExecutionSummaryStatusLabel.Size = new System.Drawing.Size(269, 25);
            this.GetExecutionSummaryStatusLabel.TabIndex = 0;
            this.GetExecutionSummaryStatusLabel.Text = "GetExecutionSummaryStatus";
            // 
            // getExecutionSummaryStatusTextBox
            // 
            this.getExecutionSummaryStatusTextBox.Location = new System.Drawing.Point(332, 135);
            this.getExecutionSummaryStatusTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getExecutionSummaryStatusTextBox.Name = "getExecutionSummaryStatusTextBox";
            this.getExecutionSummaryStatusTextBox.Size = new System.Drawing.Size(930, 29);
            this.getExecutionSummaryStatusTextBox.TabIndex = 2;
            // 
            // GetExecutionSummaryPageUrlLabel
            // 
            this.GetExecutionSummaryPageUrlLabel.AutoSize = true;
            this.GetExecutionSummaryPageUrlLabel.Location = new System.Drawing.Point(46, 188);
            this.GetExecutionSummaryPageUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetExecutionSummaryPageUrlLabel.Name = "GetExecutionSummaryPageUrlLabel";
            this.GetExecutionSummaryPageUrlLabel.Size = new System.Drawing.Size(283, 25);
            this.GetExecutionSummaryPageUrlLabel.TabIndex = 0;
            this.GetExecutionSummaryPageUrlLabel.Text = "GetExecutionSummaryPageUrl";
            // 
            // getExecutionSummaryPageUrlTextBox
            // 
            this.getExecutionSummaryPageUrlTextBox.Location = new System.Drawing.Point(332, 183);
            this.getExecutionSummaryPageUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getExecutionSummaryPageUrlTextBox.Name = "getExecutionSummaryPageUrlTextBox";
            this.getExecutionSummaryPageUrlTextBox.Size = new System.Drawing.Size(930, 29);
            this.getExecutionSummaryPageUrlTextBox.TabIndex = 3;
            // 
            // GetImportTargetErrorKeysFileUrlLabel
            // 
            this.GetImportTargetErrorKeysFileUrlLabel.AutoSize = true;
            this.GetImportTargetErrorKeysFileUrlLabel.Location = new System.Drawing.Point(31, 236);
            this.GetImportTargetErrorKeysFileUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GetImportTargetErrorKeysFileUrlLabel.Name = "GetImportTargetErrorKeysFileUrlLabel";
            this.GetImportTargetErrorKeysFileUrlLabel.Size = new System.Drawing.Size(296, 25);
            this.GetImportTargetErrorKeysFileUrlLabel.TabIndex = 0;
            this.GetImportTargetErrorKeysFileUrlLabel.Text = "GetImportTargetErrorKeysFileUrl";
            // 
            // getImportTargetErrorKeysFileUrlTextBox
            // 
            this.getImportTargetErrorKeysFileUrlTextBox.Location = new System.Drawing.Point(332, 231);
            this.getImportTargetErrorKeysFileUrlTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getImportTargetErrorKeysFileUrlTextBox.Name = "getImportTargetErrorKeysFileUrlTextBox";
            this.getImportTargetErrorKeysFileUrlTextBox.Size = new System.Drawing.Size(930, 29);
            this.getImportTargetErrorKeysFileUrlTextBox.TabIndex = 4;
            // 
            // GenerateImportTargetErrorKeysFileLabel
            // 
            this.GenerateImportTargetErrorKeysFileLabel.AutoSize = true;
            this.GenerateImportTargetErrorKeysFileLabel.Location = new System.Drawing.Point(6, 284);
            this.GenerateImportTargetErrorKeysFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenerateImportTargetErrorKeysFileLabel.Name = "GenerateImportTargetErrorKeysFileLabel";
            this.GenerateImportTargetErrorKeysFileLabel.Size = new System.Drawing.Size(322, 25);
            this.GenerateImportTargetErrorKeysFileLabel.TabIndex = 0;
            this.GenerateImportTargetErrorKeysFileLabel.Text = "GenerateImportTargetErrorKeysFile";
            // 
            // generateImportTargetErrorKeysFileTextBox
            // 
            this.generateImportTargetErrorKeysFileTextBox.Location = new System.Drawing.Point(332, 279);
            this.generateImportTargetErrorKeysFileTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generateImportTargetErrorKeysFileTextBox.Name = "generateImportTargetErrorKeysFileTextBox";
            this.generateImportTargetErrorKeysFileTextBox.Size = new System.Drawing.Size(930, 29);
            this.generateImportTargetErrorKeysFileTextBox.TabIndex = 5;
            // 
            // getExecutionErrorsLabel
            // 
            this.getExecutionErrorsLabel.AutoSize = true;
            this.getExecutionErrorsLabel.Location = new System.Drawing.Point(141, 332);
            this.getExecutionErrorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.getExecutionErrorsLabel.Name = "getExecutionErrorsLabel";
            this.getExecutionErrorsLabel.Size = new System.Drawing.Size(181, 25);
            this.getExecutionErrorsLabel.TabIndex = 7;
            this.getExecutionErrorsLabel.Text = "GetExecutionErrors";
            // 
            // getExecutionErrorsTextBox
            // 
            this.getExecutionErrorsTextBox.Location = new System.Drawing.Point(332, 327);
            this.getExecutionErrorsTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getExecutionErrorsTextBox.Name = "getExecutionErrorsTextBox";
            this.getExecutionErrorsTextBox.Size = new System.Drawing.Size(930, 29);
            this.getExecutionErrorsTextBox.TabIndex = 6;
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
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripButton,
            this.addToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 940);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1294, 40);
            this.mainToolStrip.TabIndex = 0;
            // 
            // ImportJobV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1294, 980);
            this.Controls.Add(this.jobTabControl);
            this.Controls.Add(this.mainToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1318, 1044);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1318, 1044);
            this.Name = "ImportJobV3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ImportJobForm_Load);
            this.foldersGroupBox.ResumeLayout(false);
            this.foldersGroupBox.PerformLayout();
            this.axDetailsGroupBox.ResumeLayout(false);
            this.axDetailsGroupBox.PerformLayout();
            this.authMethodPanel.ResumeLayout(false);
            this.authMethodPanel.PerformLayout();
            this.importJobTriggerTypePanel.ResumeLayout(false);
            this.importJobTriggerTypePanel.PerformLayout();
            this.monitoringJobGroupBox.ResumeLayout(false);
            this.monitoringJobGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCheckDelayNumericUpDown)).EndInit();
            this.procJobTriggerTypePanel.ResumeLayout(false);
            this.procJobTriggerTypePanel.PerformLayout();
            this.simpleTriggerMonitoringJobGroupBox.ResumeLayout(false);
            this.simpleTriggerMonitoringJobGroupBox.PerformLayout();
            this.cronTriggerMonitoringJobGroupBox.ResumeLayout(false);
            this.cronTriggerMonitoringJobGroupBox.PerformLayout();
            this.fileSelectionGroupBox.ResumeLayout(false);
            this.fileSelectionGroupBox.PerformLayout();
            this.orderByPanel.ResumeLayout(false);
            this.orderByPanel.PerformLayout();
            this.importDetailsGroupBox.ResumeLayout(false);
            this.importDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenFilesNumericUpDown)).EndInit();
            this.retryPolicyGroupBox.ResumeLayout(false);
            this.retryPolicyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).EndInit();
            this.groupBoxExceptions.ResumeLayout(false);
            this.groupBoxExceptions.PerformLayout();
            this.jobTabControl.ResumeLayout(false);
            this.importJobOverviewTabPage.ResumeLayout(false);
            this.jobIdentificationGroupBox.ResumeLayout(false);
            this.jobIdentificationGroupBox.PerformLayout();
            this.jobControlGroupBox.ResumeLayout(false);
            this.jobControlGroupBox.PerformLayout();
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.importJobDetailsTabPage.ResumeLayout(false);
            this.targetCompanyGroupBox.ResumeLayout(false);
            this.targetCompanyGroupBox.PerformLayout();
            this.multiCompanyGetMethodPanel.ResumeLayout(false);
            this.multiCompanyGetMethodPanel.PerformLayout();
            this.getLegalEntityFromFilenameDetailsGroupBox.ResumeLayout(false);
            this.getLegalEntityFromFilenameDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legalEntityTokenPositionNumericUpDown)).EndInit();
            this.importJobRecurrenceTabPage.ResumeLayout(false);
            this.simpleTriggerImportJobGroupBox.ResumeLayout(false);
            this.simpleTriggerImportJobGroupBox.PerformLayout();
            this.cronTriggerImportJobGroupBox.ResumeLayout(false);
            this.cronTriggerImportJobGroupBox.PerformLayout();
            this.monitoringJobTabPage.ResumeLayout(false);
            this.monitoringJobTabPage.PerformLayout();
            this.connectionTabPage.ResumeLayout(false);
            this.customOdataTabPage.ResumeLayout(false);
            this.customODataGroupBox.ResumeLayout(false);
            this.customODataGroupBox.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox foldersGroupBox;
        private System.Windows.Forms.Button topFolderBrowserButton;
        private System.Windows.Forms.TextBox topFolderTextBox;
        private System.Windows.Forms.Label topFolderLabel;
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
        private System.Windows.Forms.DateTimePicker importJobStartAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker importJobMinutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker importJobHoursDateTimePicker;
        private System.Windows.Forms.Label importJobMinutesLabel;
        private System.Windows.Forms.Label importJobHoursLabel;
        private System.Windows.Forms.Label importJobStartAtLabel;
        private System.Windows.Forms.Label buildCronLabel;
        private System.Windows.Forms.TextBox cronTriggerInfoTextBox;
        private System.Windows.Forms.LinkLabel cronmakerLinkLabel;
        private System.Windows.Forms.Label importJobCronExpressionLabel;
        private System.Windows.Forms.TextBox importJobCronExpressionTextBox;
        private System.Windows.Forms.Panel importJobTriggerTypePanel;
        private System.Windows.Forms.RadioButton importJobCronTriggerRadioButton;
        private System.Windows.Forms.RadioButton importJobSimpleTriggerRadioButton;
        private System.Windows.Forms.LinkLabel cronDocsLinkLabel;
        private System.Windows.Forms.TextBox calculatedRunsImportTextBox;
        private System.Windows.Forms.Button getCronScheduleForImportJobButton;
        private System.Windows.Forms.Button moreExamplesImportButton;
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
        private System.Windows.Forms.GroupBox monitoringJobGroupBox;
        private System.Windows.Forms.Panel procJobTriggerTypePanel;
        private System.Windows.Forms.RadioButton monitoringJobCronTriggerRadioButton;
        private System.Windows.Forms.RadioButton monitoringJobSimpleTriggerRadioButton;
        private System.Windows.Forms.Label monitoringJobCronExpressionLabel;
        private System.Windows.Forms.TextBox monitoringJobCronExpressionTextBox;
        private System.Windows.Forms.Label monitoringJobMinutesLabel;
        private System.Windows.Forms.Label monitoringJobRunEveryLabel;
        private System.Windows.Forms.Label monitoringJobStartAtLabel;
        private System.Windows.Forms.DateTimePicker monitoringJobStartAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker monitoringJobMinutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker monitoringJobHoursDateTimePicker;
        private System.Windows.Forms.Label legalEntityLabel;
        private System.Windows.Forms.TextBox legalEntityTextBox;
        private System.Windows.Forms.Button processingErrorsFolderBrowserButton;
        private System.Windows.Forms.TextBox processingErrorsFolderTextBox;
        private System.Windows.Forms.Label processingErrorsFolderLabel;
        private System.Windows.Forms.Label appRegistrationLabel;
        private System.Windows.Forms.ComboBox appRegistrationComboBox;
        private System.Windows.Forms.Panel authMethodPanel;
        private System.Windows.Forms.RadioButton serviceAuthRadioButton;
        private System.Windows.Forms.RadioButton userAuthRadioButton;
        private System.Windows.Forms.GroupBox fileSelectionGroupBox;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.Panel orderByPanel;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox retryPolicyGroupBox;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Label retriesLabel;
        private System.Windows.Forms.NumericUpDown retriesDelayUpDown;
        private System.Windows.Forms.NumericUpDown retriesCountUpDown;
        private System.Windows.Forms.GroupBox groupBoxExceptions;
        private System.Windows.Forms.CheckBox pauseOnExceptionsCheckBox;
        private System.Windows.Forms.CheckBox pauseIndefinitelyCheckBox;
        private System.Windows.Forms.CheckBox downloadErrorKeysFileCheckBox;
        private System.Windows.Forms.NumericUpDown delayBetweenFilesNumericUpDown;
        private System.Windows.Forms.Label delayBetweenFilesLabel;
        private System.Windows.Forms.NumericUpDown statusCheckDelayNumericUpDown;
        private System.Windows.Forms.Label statusCheckDelayLabel;
        private System.Windows.Forms.TabControl jobTabControl;
        private System.Windows.Forms.TabPage importJobOverviewTabPage;
        private System.Windows.Forms.TabPage importJobDetailsTabPage;
        private System.Windows.Forms.TabPage importJobRecurrenceTabPage;
        private System.Windows.Forms.TabPage monitoringJobTabPage;
        private System.Windows.Forms.TabPage connectionTabPage;
        private System.Windows.Forms.GroupBox jobIdentificationGroupBox;
        private System.Windows.Forms.GroupBox jobControlGroupBox;
        private System.Windows.Forms.LinkLabel monitoringJobCronDocsLinkLabel;
        private System.Windows.Forms.Label monitoringJobBuildCronLabel;
        private System.Windows.Forms.TextBox monitoringCronTextBox;
        private System.Windows.Forms.LinkLabel monitoringJobCronmakerLinkLabel;
        private System.Windows.Forms.Button packageTemplateFileBrowserButton;
        private System.Windows.Forms.TextBox packageTemplateTextBox;
        private System.Windows.Forms.Label packageTemplateLabel;
        private System.Windows.Forms.CheckBox useMonitoringJobCheckBox;
        private System.Windows.Forms.TabPage customOdataTabPage;
        private System.Windows.Forms.GroupBox customODataGroupBox;
        private System.Windows.Forms.Label GenerateImportTargetErrorKeysFileLabel;
        private System.Windows.Forms.TextBox generateImportTargetErrorKeysFileTextBox;
        private System.Windows.Forms.Label GetImportTargetErrorKeysFileUrlLabel;
        private System.Windows.Forms.TextBox getImportTargetErrorKeysFileUrlTextBox;
        private System.Windows.Forms.Label GetExecutionSummaryPageUrlLabel;
        private System.Windows.Forms.TextBox getExecutionSummaryPageUrlTextBox;
        private System.Windows.Forms.Label GetExecutionSummaryStatusLabel;
        private System.Windows.Forms.TextBox getExecutionSummaryStatusTextBox;
        private System.Windows.Forms.Label ImportFromPackageLabel;
        private System.Windows.Forms.TextBox importFromPackageTextBox;
        private System.Windows.Forms.Label GetAzureWriteUrlLabel;
        private System.Windows.Forms.TextBox getAzureWriteUrlTextBox;
        private System.Windows.Forms.Label importJobRunEveryLabel;
        private System.Windows.Forms.Label importJobAndOrLabel;
        private System.Windows.Forms.GroupBox cronTriggerImportJobGroupBox;
        private System.Windows.Forms.GroupBox simpleTriggerImportJobGroupBox;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.GroupBox cronTriggerMonitoringJobGroupBox;
        private System.Windows.Forms.GroupBox simpleTriggerMonitoringJobGroupBox;
        private System.Windows.Forms.Label monitoringJobAndOrLabel;
        private System.Windows.Forms.Label monitoringJobHoursLabel;
        private System.Windows.Forms.Button moreExamplesMonitoringButton;
        private System.Windows.Forms.TextBox calculatedRunsMonitoringTextBox;
        private System.Windows.Forms.Button getCronScheduleForMonitoringButton;
        private System.Windows.Forms.Panel multiCompanyGetMethodPanel;
        private System.Windows.Forms.RadioButton getLegalEntityFromSubfoldersRadioButton;
        private System.Windows.Forms.GroupBox getLegalEntityFromFilenameDetailsGroupBox;
        private System.Windows.Forms.TextBox filenameSeparatorTextBox;
        private System.Windows.Forms.TextBox getLegalEntityFromFilenameTextBox;
        private System.Windows.Forms.RadioButton getLegalEntityFromFilenameRadioButton;
        private System.Windows.Forms.TextBox getLegalEntityFromSubfoldersTextBox;
        private System.Windows.Forms.Label filenameSeparatorLabel;
        private System.Windows.Forms.Label legalEntityTokenPositionLabel;
        private System.Windows.Forms.NumericUpDown legalEntityTokenPositionNumericUpDown;
        private System.Windows.Forms.GroupBox targetCompanyGroupBox;
        private System.Windows.Forms.CheckBox multicompanyCheckBox;
        private System.Windows.Forms.Label statusFileExtensionLabel;
        private System.Windows.Forms.TextBox statusFileExtensionTextBox;
        private System.Windows.Forms.CheckBox inputFilesArePackagesCheckBox;
        private System.Windows.Forms.Button separatorExampleButton;
        private System.Windows.Forms.TextBox separatorExampleLegalEntityTextBox;
        private System.Windows.Forms.TextBox separatorExampleTextBox;
        private System.Windows.Forms.Label separatorExmpleLabel;
        private System.Windows.Forms.CheckBox getExecutionErrorsCheckBox;
        private System.Windows.Forms.Label getExecutionErrorsLabel;
        private System.Windows.Forms.TextBox getExecutionErrorsTextBox;
        private System.Windows.Forms.GroupBox groupBoxLogging;
        private System.Windows.Forms.CheckBox verboseLoggingCheckBox;
    }
}