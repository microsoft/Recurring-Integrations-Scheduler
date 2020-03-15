/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Quartz;
using Quartz.Impl.Triggers;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class ImportJobV3 : Form
    {
        private const int CpNocloseButton = 0x200;

        public ImportJobV3()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        public bool Cancelled { get; private set; }
        public IJobDetail ImportJobDetail { get; set; }
        public ITrigger ImportTrigger { get; set; }
        public IJobDetail ExecutionJobDetail { get; set; }
        public ITrigger ExecutionTrigger { get; set; }

        private void ImportJobForm_Load(object sender, EventArgs e)
        {
            Cancelled = false;
            //Few changes based on form mode (create or edit)
            Text = ImportJobDetail == null
                ? Resources.Add_import_job
                : string.Format(Resources.Edit_job_0, ImportJobDetail.Key.Name);
            addToolStripButton.Text = ImportJobDetail == null ? Resources.Add_to_schedule : Resources.Edit_job;
            jobName.Enabled = ImportJobDetail == null;

            jobGroupComboBox.DataSource = Properties.Settings.Default.JobGroups;
            jobGroupComboBox.ValueMember = null;
            jobGroupComboBox.DisplayMember = "Name";

            jobGroupComboBox.Enabled = ImportJobDetail == null;

            instanceComboBox.DataSource = Properties.Settings.Default.Instances;
            instanceComboBox.ValueMember = null;
            instanceComboBox.DisplayMember = "Name";

            var applications = Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User);
            var applicationsBindingList = new BindingList<AadApplication>(applications.ToList());
            appRegistrationComboBox.DataSource = applicationsBindingList;
            appRegistrationComboBox.ValueMember = null;
            appRegistrationComboBox.DisplayMember = "Name";

            userComboBox.DataSource = Properties.Settings.Default.Users;
            userComboBox.ValueMember = null;
            userComboBox.DisplayMember = "Login";

            orderByComboBox.DataSource = Enum.GetValues(typeof(OrderByOptions));

            importJobStartAtDateTimePicker.Value = DateTime.Now;
            monitoringJobStartAtDateTimePicker.Value = DateTime.Now;

            inputFolderTextBox.Text = Properties.Settings.Default.UploadInputFolder;
            uploadSuccessFolderTextBox.Text = Properties.Settings.Default.UploadSuccessFolder;
            uploadErrorsFolderTextBox.Text = Properties.Settings.Default.UploadErrorsFolder;
            processingSuccessFolderTextBox.Text = Properties.Settings.Default.ProcessingSuccessFolder;
            processingErrorsFolderTextBox.Text = Properties.Settings.Default.ProcessingErrorsFolder;

            importFromPackageTextBox.Text = PackageApiActions.ImportFromPackageActionPath;
            getAzureWriteUrlTextBox.Text = PackageApiActions.GetAzureWriteUrlActionPath;
            getExecutionSummaryStatusTextBox.Text = PackageApiActions.GetExecutionSummaryStatusActionPath;
            getExecutionSummaryPageUrlTextBox.Text = PackageApiActions.GetExecutionSummaryPageUrlActionPath;
            getImportTargetErrorKeysFileUrlTextBox.Text = PackageApiActions.GetImportTargetErrorKeysFileUrlPath;
            generateImportTargetErrorKeysFileTextBox.Text = PackageApiActions.GenerateImportTargetErrorKeysFilePath;
            getExecutionErrorsTextBox.Text = PackageApiActions.GetExecutionErrorsPath;

            if (ImportJobDetail != null)
            {
                jobName.Text = ImportJobDetail.Key.Name;

                var jobGroup =
                    ((IEnumerable<JobGroup>) jobGroupComboBox.DataSource).FirstOrDefault(
                        x => x.Name == ImportJobDetail.Key.Group);
                jobGroupComboBox.SelectedItem = jobGroup;

                jobDescription.Text = ImportJobDetail.Description;

                useStandardSubfolder.Checked = false;
                inputFolderTextBox.Text = ImportJobDetail.JobDataMap[SettingsConstants.InputDir]?.ToString() ??
                                          string.Empty;
                uploadSuccessFolderTextBox.Text =
                    ImportJobDetail.JobDataMap[SettingsConstants.UploadSuccessDir]?.ToString() ?? string.Empty;

                uploadErrorsFolderTextBox.Text =
                    ImportJobDetail.JobDataMap[SettingsConstants.UploadErrorsDir]?.ToString() ?? string.Empty;

                packageTemplateTextBox.Text =
                    ImportJobDetail.JobDataMap[SettingsConstants.PackageTemplate]?.ToString() ?? string.Empty;

                legalEntityTextBox.Text = ImportJobDetail.JobDataMap[SettingsConstants.Company]?.ToString() ??
                                          string.Empty;
                statusFileExtensionTextBox.Text =
                    ImportJobDetail.JobDataMap[SettingsConstants.StatusFileExtension]?.ToString() ?? ".Status";

                dataProject.Text = ImportJobDetail.JobDataMap[SettingsConstants.DataProject]?.ToString() ??
                                          string.Empty;

                overwriteDataProjectCheckBox.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.OverwriteDataProject] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.OverwriteDataProject].ToString());

                executeImportCheckBox.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.ExecuteImport] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.ExecuteImport].ToString());

                delayBetweenFilesNumericUpDown.Value = Math.Round(Convert.ToDecimal(ImportJobDetail.JobDataMap[SettingsConstants.DelayBetweenFiles]));

                serviceAuthRadioButton.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.UseServiceAuthentication] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.UseServiceAuthentication].ToString());
                if (!serviceAuthRadioButton.Checked)
                {
                    User axUser = null;
                    if (ImportJobDetail.JobDataMap[SettingsConstants.UserName] != null)
                        axUser =
                            ((IEnumerable<User>) userComboBox.DataSource).FirstOrDefault(
                                x => x.Login == ImportJobDetail.JobDataMap[SettingsConstants.UserName].ToString());
                    if (axUser == null)
                    {
                        var userName = ImportJobDetail.JobDataMap[SettingsConstants.UserName];
                        if (userName != null)
                            axUser = new User
                            {
                                Login = userName.ToString(),
                                Password = ImportJobDetail.JobDataMap[SettingsConstants.UserPassword].ToString()
                            };
                        var disabledUser = new Users {axUser};
                        userComboBox.DataSource = disabledUser;
                        userComboBox.Enabled = false;
                    }
                    userComboBox.SelectedItem = axUser;
                }
                var application =
                    ((IEnumerable<AadApplication>) appRegistrationComboBox.DataSource).FirstOrDefault(app =>
                            app.ClientId == ImportJobDetail.JobDataMap[SettingsConstants.AadClientId].ToString());
                if (application == null)
                    if (ImportJobDetail.JobDataMap[SettingsConstants.AadClientSecret] == null)
                    {
                        application = new AadApplication
                        {
                            ClientId = ImportJobDetail.JobDataMap[SettingsConstants.AadClientId].ToString(),
                            Name = Resources.IMPORTED_CHANGE_THIS,
                            AuthenticationType = AuthenticationType.User
                        };
                        Properties.Settings.Default.AadApplications.Add(application);
                        applications =
                            Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User);
                        applicationsBindingList = new BindingList<AadApplication>(applications.ToList());
                        appRegistrationComboBox.DataSource = applicationsBindingList;
                        appRegistrationComboBox.ValueMember = null;
                        appRegistrationComboBox.DisplayMember = "Name";
                    }
                    else
                    {
                        application = new AadApplication
                        {
                            ClientId = ImportJobDetail.JobDataMap[SettingsConstants.AadClientId].ToString(),
                            Secret = ImportJobDetail.JobDataMap[SettingsConstants.AadClientSecret].ToString(),
                            Name = Resources.IMPORTED,
                            AuthenticationType = AuthenticationType.Service
                        };
                        var disabledApplication = new AadApplications {application};
                        appRegistrationComboBox.DataSource = disabledApplication;
                        appRegistrationComboBox.Enabled = false;
                        authMethodPanel.Enabled = false;
                    }
                appRegistrationComboBox.SelectedItem = application;

                var axInstance = ((IEnumerable<Instance>) instanceComboBox.DataSource).FirstOrDefault(x =>
                    (x.AosUri == ImportJobDetail.JobDataMap[SettingsConstants.AosUri].ToString()) &&
                    (x.AadTenant == ImportJobDetail.JobDataMap[SettingsConstants.AadTenant].ToString()) &&
                    (x.AzureAuthEndpoint == ImportJobDetail.JobDataMap[SettingsConstants.AzureAuthEndpoint].ToString()));
                if (axInstance == null)
                {
                    axInstance = new Instance
                    {
                        AosUri = ImportJobDetail.JobDataMap[SettingsConstants.AosUri].ToString(),
                        AadTenant = ImportJobDetail.JobDataMap[SettingsConstants.AadTenant].ToString(),
                        AzureAuthEndpoint = ImportJobDetail.JobDataMap[SettingsConstants.AzureAuthEndpoint].ToString(),
                        Name = Resources.IMPORTED_CHANGE_THIS
                    };
                    Properties.Settings.Default.Instances.Add(axInstance);
                }
                instanceComboBox.SelectedItem = axInstance;

                searchPatternTextBox.Text = ImportJobDetail.JobDataMap[SettingsConstants.SearchPattern]?.ToString() ??
                                            "*.*";
                orderByComboBox.DataSource = Enum.GetValues(typeof(OrderByOptions));
                var selectedOrderBy = OrderByOptions.FileName;
                if (ImportJobDetail.JobDataMap[SettingsConstants.OrderBy] != null)
                    selectedOrderBy =
                        (OrderByOptions)
                        Enum.Parse(typeof(OrderByOptions),
                            ImportJobDetail.JobDataMap[SettingsConstants.OrderBy].ToString());
                orderByComboBox.SelectedItem = selectedOrderBy;

                orderDescendingRadioButton.Checked = (ImportJobDetail.JobDataMap[SettingsConstants.ReverseOrder] != null) &&
                                                     Convert.ToBoolean(
                                                         ImportJobDetail.JobDataMap[SettingsConstants.ReverseOrder]
                                                             .ToString());
                inputFilesArePackagesCheckBox.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.InputFilesArePackages] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.InputFilesArePackages].ToString());

                pauseIndefinitelyCheckBox.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.IndefinitePause] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.IndefinitePause].ToString());

                if (ImportTrigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl) ImportTrigger;
                    importJobSimpleTriggerRadioButton.Checked = true;
                    importJobHoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    importJobMinutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                }
                else if (ImportTrigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl) ImportTrigger;
                    importJobCronTriggerRadioButton.Checked = true;
                    importJobCronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }
                if(ImportJobDetail.JobDataMap[SettingsConstants.RetryCount] != null)
                {
                    retriesCountUpDown.Value = Convert.ToDecimal(ImportJobDetail.JobDataMap[SettingsConstants.RetryCount]);
                }
                if(ImportJobDetail.JobDataMap[SettingsConstants.RetryDelay] != null)
                {
                    retriesDelayUpDown.Value = Convert.ToDecimal(ImportJobDetail.JobDataMap[SettingsConstants.RetryDelay]);
                }
                pauseOnExceptionsCheckBox.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.PauseJobOnException] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.PauseJobOnException].ToString());

                importFromPackageTextBox.Text = ImportJobDetail.JobDataMap[SettingsConstants.ImportFromPackageActionPath]?.ToString() ?? PackageApiActions.ImportFromPackageActionPath;
                getAzureWriteUrlTextBox.Text = ImportJobDetail.JobDataMap[SettingsConstants.GetAzureWriteUrlActionPath]?.ToString() ?? PackageApiActions.GetAzureWriteUrlActionPath;

                multicompanyCheckBox.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.MultiCompanyImport] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.MultiCompanyImport].ToString());

                getLegalEntityFromFilenameRadioButton.Checked = (ImportJobDetail.JobDataMap[SettingsConstants.GetLegalEntityFromFilename] != null) &&
                                                     Convert.ToBoolean(
                                                         ImportJobDetail.JobDataMap[SettingsConstants.GetLegalEntityFromFilename]
                                                             .ToString());
                filenameSeparatorTextBox.Text = ImportJobDetail.JobDataMap[SettingsConstants.FilenameSeparator]?.ToString() ?? string.Empty;

                if (ImportJobDetail.JobDataMap[SettingsConstants.LegalEntityTokenPosition] != null)
                {
                    legalEntityTokenPositionNumericUpDown.Value = Convert.ToDecimal(ImportJobDetail.JobDataMap[SettingsConstants.LegalEntityTokenPosition]);
                }

                verboseLoggingCheckBox.Checked =
                    (ImportJobDetail.JobDataMap[SettingsConstants.LogVerbose] != null) &&
                    Convert.ToBoolean(ImportJobDetail.JobDataMap[SettingsConstants.LogVerbose].ToString());

                Properties.Settings.Default.Save();
            }
            if ((ExecutionJobDetail != null) && (ExecutionTrigger != null))
            {
                useMonitoringJobCheckBox.Checked = true;
                processingSuccessFolderTextBox.Text =
                    ExecutionJobDetail.JobDataMap[SettingsConstants.ProcessingSuccessDir]?.ToString() ?? string.Empty;
                processingErrorsFolderTextBox.Text =
                    ExecutionJobDetail.JobDataMap[SettingsConstants.ProcessingErrorsDir]?.ToString() ?? string.Empty;

                if (ExecutionTrigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl)ExecutionTrigger;
                    monitoringJobSimpleTriggerRadioButton.Checked = true;
                    monitoringJobHoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    monitoringJobMinutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                }
                else if (ExecutionTrigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl)ExecutionTrigger;
                    monitoringJobCronTriggerRadioButton.Checked = true;
                    monitoringJobCronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }

                getExecutionSummaryStatusTextBox.Text = ExecutionJobDetail.JobDataMap[SettingsConstants.GetExecutionSummaryStatusActionPath]?.ToString() ?? PackageApiActions.GetExecutionSummaryStatusActionPath;
                getExecutionSummaryPageUrlTextBox.Text = ExecutionJobDetail.JobDataMap[SettingsConstants.GetExecutionSummaryPageUrlActionPath]?.ToString() ?? PackageApiActions.GetExecutionSummaryPageUrlActionPath;
                getImportTargetErrorKeysFileUrlTextBox.Text = ExecutionJobDetail.JobDataMap[SettingsConstants.GetImportTargetErrorKeysFileUrlPath]?.ToString() ?? PackageApiActions.GetImportTargetErrorKeysFileUrlPath;
                generateImportTargetErrorKeysFileTextBox.Text = ExecutionJobDetail.JobDataMap[SettingsConstants.GenerateImportTargetErrorKeysFilePath]?.ToString() ?? PackageApiActions.GenerateImportTargetErrorKeysFilePath;
                getExecutionErrorsTextBox.Text = ExecutionJobDetail.JobDataMap[SettingsConstants.GetExecutionErrorsPath]?.ToString() ?? PackageApiActions.GetExecutionErrorsPath;

                downloadErrorKeysFileCheckBox.Checked =
                    (ExecutionJobDetail.JobDataMap[SettingsConstants.GetImportTargetErrorKeysFile] != null) &&
                    Convert.ToBoolean(ExecutionJobDetail.JobDataMap[SettingsConstants.GetImportTargetErrorKeysFile].ToString());
                
                getExecutionErrorsCheckBox.Checked =
                    (ExecutionJobDetail.JobDataMap[SettingsConstants.GetExecutionErrors] != null) &&
                    Convert.ToBoolean(ExecutionJobDetail.JobDataMap[SettingsConstants.GetExecutionErrors].ToString());

                statusCheckDelayNumericUpDown.Value = Math.Round(Convert.ToDecimal(ExecutionJobDetail.JobDataMap[SettingsConstants.DelayBetweenStatusCheck]));
            }
        }

        private bool ValidateJobSettings()
        {
            if (importJobCronTriggerRadioButton.Checked)
            {
                var date = GetScheduleForCron(importJobCronExpressionTextBox.Text, DateTimeOffset.Now);
                if (date == DateTimeOffset.MinValue)
                    return false;
            }

            if (useMonitoringJobCheckBox.Checked && monitoringJobCronTriggerRadioButton.Checked)
            {
                var date = GetScheduleForCron(monitoringJobCronExpressionTextBox.Text, DateTimeOffset.Now);
                if (date == DateTimeOffset.MinValue)
                    return false;
            }

            var message = new StringBuilder();

            if (string.IsNullOrEmpty(jobName.Text))
                message.AppendLine(Resources.Job_name_is_missing);

            if ((jobGroupComboBox.SelectedItem == null) || string.IsNullOrEmpty(jobGroupComboBox.Text))
                message.AppendLine(Resources.Job_group_is_not_selected);

            if (string.IsNullOrEmpty(topFolderTextBox.Text) && useStandardSubfolder.Checked)
                message.AppendLine(Resources.Top_uploads_folder_is_not_selected);

            if (string.IsNullOrEmpty(inputFolderTextBox.Text))
                message.AppendLine(Resources.Input_folder_is_not_selected);

            if (string.IsNullOrEmpty(uploadSuccessFolderTextBox.Text))
                message.AppendLine(Resources.Upload_success_folder_is_not_selected);

            if (string.IsNullOrEmpty(uploadErrorsFolderTextBox.Text))
                message.AppendLine(Resources.Upload_errors_folder_is_not_selected);

            if (string.IsNullOrEmpty(processingSuccessFolderTextBox.Text) && useMonitoringJobCheckBox.Checked)
                message.AppendLine(Resources.Processing_success_folder_is_not_selected);

            if (string.IsNullOrEmpty(processingErrorsFolderTextBox.Text) && useMonitoringJobCheckBox.Checked)
                message.AppendLine(Resources.Processing_errors_folder_is_not_selected);

            if (!multicompanyCheckBox.Checked && string.IsNullOrEmpty(legalEntityTextBox.Text))
                message.AppendLine(Resources.Legal_entity_is_missing);

            if (string.IsNullOrEmpty(dataProject.Text))
                message.AppendLine(Resources.Data_project_is_missing);

            if ((instanceComboBox.SelectedItem == null) || string.IsNullOrEmpty(instanceComboBox.Text))
                message.AppendLine(Resources.Dynamics_instance_is_not_selected);

            if (userAuthRadioButton.Checked &&
                ((userComboBox.SelectedItem == null) || string.IsNullOrEmpty(userComboBox.Text)))
                message.AppendLine(Resources.User_is_not_selected);

            if ((appRegistrationComboBox.SelectedItem == null) || string.IsNullOrEmpty(appRegistrationComboBox.Text))
                message.AppendLine(Resources.AAD_client_application_is_not_selected);

            if (string.IsNullOrEmpty(statusFileExtensionTextBox.Text) && useMonitoringJobCheckBox.Checked)
                message.AppendLine(Resources.Status_file_extension_is_not_specified);

            if (!inputFilesArePackagesCheckBox.Checked && string.IsNullOrEmpty(packageTemplateTextBox.Text))
                message.AppendLine(Resources.Package_template_is_missing);

            if (multicompanyCheckBox.Checked && getLegalEntityFromFilenameRadioButton.Checked)
            {
                if (string.IsNullOrEmpty(filenameSeparatorTextBox.Text))
                {
                    message.AppendLine(Resources.Filename_separator_is_missing);
                }
            }

            if (string.IsNullOrEmpty(getAzureWriteUrlTextBox.Text))
                message.AppendLine(Resources.URL_for_GetAzureWriteUrl_action_is_missing);

            if (string.IsNullOrEmpty(importFromPackageTextBox.Text))
                message.AppendLine(Resources.URL_for_ImportFromPackage_action_is_missing);

            if (string.IsNullOrEmpty(getExecutionSummaryStatusTextBox.Text))
                message.AppendLine(Resources.URL_for_GetExecutionSummaryStatus_action_is_missing);

            if (string.IsNullOrEmpty(getExecutionSummaryPageUrlTextBox.Text))
                message.AppendLine(Resources.URL_for_GetExecutionSummaryPageUrl_action_is_missing);

            if (string.IsNullOrEmpty(getImportTargetErrorKeysFileUrlTextBox.Text))
                message.AppendLine(Resources.URL_for_GetImportTargetErrorKeysFileUrl_action_is_missing);

            if (string.IsNullOrEmpty(generateImportTargetErrorKeysFileTextBox.Text))
                message.AppendLine(Resources.URL_for_GenerateImportTargetErrorKeysFile_action_is_missing);

            if (string.IsNullOrEmpty(getExecutionErrorsTextBox.Text))
                message.AppendLine(Resources.URL_for_GetExecutionErrors_action_is_missing);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Job_configuration_is_not_valid);

            return message.Length == 0;
        }

        private IJobDetail GetImportJobDetail()
        {
            var detail = JobBuilder
                .Create()
                .OfType(Type.GetType("RecurringIntegrationsScheduler.Job.Import,RecurringIntegrationsScheduler.Job.Import", true))
                .WithDescription(jobDescription.Text)
                .WithIdentity(new JobKey(jobName.Text, jobGroupComboBox.Text))
                .UsingJobData(GetImportJobDataMap())
                .Build();

            return detail;
        }

        private IJobDetail GetMonitorJobDetail()
        {
            var detail = JobBuilder
                .Create()
                .OfType(
                    Type.GetType(
                        "RecurringIntegrationsScheduler.Job.ExecutionMonitor,RecurringIntegrationsScheduler.Job.ExecutionMonitor",
                        true))
                .WithDescription(string.Format(Resources.Execution_monitor_job_for_import_job_0_1, jobName.Text,
                    jobGroupComboBox.Text))
                .WithIdentity(new JobKey($"{jobName.Text}-Execution monitor", jobGroupComboBox.Text))
                .UsingJobData(GetExecutionJobDataMap())
                .Build();

            return detail;
        }

        private ITrigger GetExecutionTrigger(IJobDetail jobDetail)
        {
            var builder =
                TriggerBuilder
                    .Create()
                    .ForJob(jobDetail)
                    .WithDescription(string.Format(Resources.Trigger_for_job_0_1, jobDetail.Key.Name,
                        jobDetail.Key.Group))
                    .WithIdentity(
                        new TriggerKey(
                            string.Format(Resources.Trigger_for_job_0_1, jobDetail.Key.Name, jobDetail.Key.Group),
                            jobDetail.Key.Group));

            if (monitoringJobSimpleTriggerRadioButton.Checked)
            {
                var minutes = monitoringJobHoursDateTimePicker.Value.Hour * 60;
                minutes += monitoringJobMinutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartNow()
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(monitoringJobCronExpressionTextBox.Text))
                    .StartAt(monitoringJobStartAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
        }

        private ITrigger GetImportTrigger(IJobDetail jobDetail)
        {
            var builder =
                TriggerBuilder
                    .Create()
                    .ForJob(jobDetail)
                    .WithDescription(string.Format(Resources.Trigger_for_job_0_1, jobDetail.Key.Name,
                        jobDetail.Key.Group))
                    .WithIdentity(
                        new TriggerKey(
                            string.Format(Resources.Trigger_for_job_0_1, jobDetail.Key.Name, jobDetail.Key.Group),
                            jobDetail.Key.Group));

            if (importJobSimpleTriggerRadioButton.Checked)
            {
                var minutes = importJobHoursDateTimePicker.Value.Hour * 60;
                minutes += importJobMinutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartNow()
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(importJobCronExpressionTextBox.Text))
                    .StartAt(importJobStartAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
        }

        private JobDataMap GetImportJobDataMap()
        {
            var instance = (Instance)instanceComboBox.SelectedItem;
            var user = (User)userComboBox.SelectedItem;
            var application = (AadApplication)appRegistrationComboBox.SelectedItem;

            var map = new JobDataMap
            {
                {SettingsConstants.InputDir, inputFolderTextBox.Text},
                {SettingsConstants.UploadSuccessDir, uploadSuccessFolderTextBox.Text},
                {SettingsConstants.UploadErrorsDir, uploadErrorsFolderTextBox.Text},
                {SettingsConstants.Company, legalEntityTextBox.Text},
                {SettingsConstants.StatusFileExtension, statusFileExtensionTextBox.Text},
                {SettingsConstants.AadTenant, instance.AadTenant},
                {SettingsConstants.AzureAuthEndpoint, instance.AzureAuthEndpoint},
                {SettingsConstants.AosUri, instance.AosUri},
                {SettingsConstants.AadClientId, application.ClientId},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked.ToString()},
                {SettingsConstants.ExecutionJobPresent, useMonitoringJobCheckBox.Checked.ToString()},
                {SettingsConstants.SearchPattern, searchPatternTextBox.Text},
                {SettingsConstants.OrderBy, orderByComboBox.SelectedItem.ToString()},
                {SettingsConstants.ReverseOrder, orderDescendingRadioButton.Checked.ToString()},
                {SettingsConstants.ExecuteImport, executeImportCheckBox.Checked.ToString()},
                {SettingsConstants.OverwriteDataProject, overwriteDataProjectCheckBox.Checked.ToString()},
                {SettingsConstants.DataProject, dataProject.Text},
                {SettingsConstants.PackageTemplate, packageTemplateTextBox.Text},
                {SettingsConstants.RetryCount, retriesCountUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.RetryDelay, retriesDelayUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.PauseJobOnException, pauseOnExceptionsCheckBox.Checked.ToString()},
                {SettingsConstants.GetAzureWriteUrlActionPath, getAzureWriteUrlTextBox.Text},
                {SettingsConstants.ImportFromPackageActionPath, importFromPackageTextBox.Text},
                {SettingsConstants.IndefinitePause, pauseIndefinitelyCheckBox.Checked.ToString()},
                {SettingsConstants.DelayBetweenFiles, delayBetweenFilesNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.MultiCompanyImport, multicompanyCheckBox.Checked.ToString()},
                {SettingsConstants.GetLegalEntityFromSubfolder, getLegalEntityFromSubfoldersRadioButton.Checked.ToString()},
                {SettingsConstants.GetLegalEntityFromFilename, getLegalEntityFromFilenameRadioButton.Checked.ToString()},
                {SettingsConstants.FilenameSeparator, filenameSeparatorTextBox.Text},
                {SettingsConstants.LegalEntityTokenPosition, legalEntityTokenPositionNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.InputFilesArePackages, inputFilesArePackagesCheckBox.Checked.ToString()},
                {SettingsConstants.LogVerbose, verboseLoggingCheckBox.Checked.ToString()}
            };
            if (serviceAuthRadioButton.Checked)
            {
                map.Add(SettingsConstants.AadClientSecret, application.Secret);
            }
            else
            {
                map.Add(SettingsConstants.UserName, user.Login);
                map.Add(SettingsConstants.UserPassword, user.Password);
            }
            return map;
        }

        private JobDataMap GetExecutionJobDataMap()
        {
            var instance = (Instance)instanceComboBox.SelectedItem;
            var user = (User)userComboBox.SelectedItem;
            var application = (AadApplication)appRegistrationComboBox.SelectedItem;

            var map = new JobDataMap
            {
                {SettingsConstants.UploadSuccessDir, uploadSuccessFolderTextBox.Text},
                {SettingsConstants.ProcessingSuccessDir, processingSuccessFolderTextBox.Text},
                {SettingsConstants.ProcessingErrorsDir, processingErrorsFolderTextBox.Text},
                {SettingsConstants.StatusFileExtension, statusFileExtensionTextBox.Text},
                {SettingsConstants.AadTenant, instance.AadTenant},
                {SettingsConstants.AzureAuthEndpoint, instance.AzureAuthEndpoint},
                {SettingsConstants.AosUri, instance.AosUri},
                {SettingsConstants.AadClientId, application.ClientId},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked.ToString()},
                {SettingsConstants.RetryCount, retriesCountUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.RetryDelay, retriesDelayUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.PauseJobOnException, pauseOnExceptionsCheckBox.Checked.ToString()},
                {SettingsConstants.GetExecutionSummaryStatusActionPath, getExecutionSummaryStatusTextBox.Text},
                {SettingsConstants.GetExecutionSummaryPageUrlActionPath, getExecutionSummaryPageUrlTextBox.Text},
                {SettingsConstants.IndefinitePause, pauseIndefinitelyCheckBox.Checked.ToString()},
                {SettingsConstants.GetImportTargetErrorKeysFile, downloadErrorKeysFileCheckBox.Checked.ToString()},
                {SettingsConstants.GetImportTargetErrorKeysFileUrlPath, getImportTargetErrorKeysFileUrlTextBox.Text},
                {SettingsConstants.GenerateImportTargetErrorKeysFilePath, generateImportTargetErrorKeysFileTextBox.Text},
                {SettingsConstants.PackageTemplate, packageTemplateTextBox.Text},
                {SettingsConstants.DelayBetweenStatusCheck, statusCheckDelayNumericUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.GetExecutionErrors, getExecutionErrorsCheckBox.Checked.ToString()},
                {SettingsConstants.GetExecutionErrorsPath, getExecutionErrorsTextBox.Text},
                {SettingsConstants.LogVerbose, verboseLoggingCheckBox.Checked.ToString()}
            };
            if (serviceAuthRadioButton.Checked)
            {
                map.Add(SettingsConstants.AadClientSecret, application.Secret);
            }
            else
            {
                map.Add(SettingsConstants.UserName, user.Login);
                map.Add(SettingsConstants.UserPassword, user.Password);
            }
            return map;
        }

        private static DateTimeOffset? GetScheduleForCron(string cronexpression, DateTimeOffset date)
        {
            try
            {
                var cron = new CronExpression(cronexpression);
                return cron.GetNextValidTimeAfter(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Cron_expression_is_invalid);
                return DateTimeOffset.MinValue;
            }
        }

        private void TopUploadFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                topFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void UploadErrorsFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                uploadErrorsFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void UseStandardSubfolder_CheckedChanged(object sender, EventArgs e)
        {
            if (useStandardSubfolder.Checked)
            {
                topFolderTextBox.Enabled = true;
                topFolderBrowserButton.Enabled = true;

                inputFolderTextBox.Enabled = false;
                inputFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.UploadInputFolder);
                inputFolderBrowserButton.Enabled = false;

                uploadSuccessFolderTextBox.Enabled = false;
                uploadSuccessFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.UploadSuccessFolder);
                uploadSuccessFolderBrowserButton.Enabled = false;

                uploadErrorsFolderTextBox.Enabled = false;
                uploadErrorsFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.UploadErrorsFolder);
                uploadErrorsFolderBrowserButton.Enabled = false;

                processingSuccessFolderTextBox.Enabled = false;
                processingSuccessFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.ProcessingSuccessFolder);
                processingSuccessFolderBrowserButton.Enabled = false;

                processingErrorsFolderTextBox.Enabled = false;
                processingErrorsFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.ProcessingErrorsFolder);
                processingErrorsFolderBrowserButton.Enabled = false;
            }
            else
            {
                topFolderTextBox.Enabled = false;
                topFolderBrowserButton.Enabled = false;

                inputFolderTextBox.Enabled = true;
                inputFolderBrowserButton.Enabled = true;

                uploadSuccessFolderTextBox.Enabled = true;
                uploadSuccessFolderBrowserButton.Enabled = true;

                uploadErrorsFolderTextBox.Enabled = true;
                uploadErrorsFolderBrowserButton.Enabled = true;

                processingSuccessFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked;
                processingSuccessFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked;

                processingErrorsFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked;
                processingErrorsFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked;

                if (string.IsNullOrEmpty(topFolderTextBox.Text))
                {
                    inputFolderTextBox.Text = string.Empty;
                    uploadSuccessFolderTextBox.Text = string.Empty;
                    uploadErrorsFolderTextBox.Text = string.Empty;
                    processingSuccessFolderTextBox.Text = string.Empty;
                    processingErrorsFolderTextBox.Text = string.Empty;
                }
            }
        }

        private void CronmakerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start("http://www.cronmaker.com");
        }

        private void ImportJobCronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            simpleTriggerImportJobGroupBox.Enabled = !importJobCronTriggerRadioButton.Checked;
            cronTriggerImportJobGroupBox.Enabled = importJobCronTriggerRadioButton.Checked;
        }

        private void CronDocsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start(
                "https://www.quartz-scheduler.net/documentation/quartz-3.x/tutorial/crontrigger.html");
        }

        private void GetCronScheduleForUploadButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(importJobCronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = GetScheduleForCron(importJobCronExpressionTextBox.Text, time);
                    if (date == DateTimeOffset.MinValue)
                        return;
                    if (date == null) continue;
                    scheduleTimes.Add(date.Value);
                    time = date.Value;
                }
            calculatedRunsImportTextBox.Text = string.Empty;
            foreach (var date in scheduleTimes)
                calculatedRunsImportTextBox.Text = calculatedRunsImportTextBox.Text + $@"{date.ToLocalTime():yyyy-MM-dd HH:mm:ss}" + Environment.NewLine;
        }

        private void TopUploadFolder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (useStandardSubfolder.Checked)
                {
                    inputFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.UploadInputFolder);
                    uploadSuccessFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.UploadSuccessFolder);
                    uploadErrorsFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.UploadErrorsFolder);
                    processingSuccessFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.ProcessingSuccessFolder);
                    processingErrorsFolderTextBox.Text = Path.Combine(topFolderTextBox.Text, Properties.Settings.Default.ProcessingErrorsFolder);
                    openFileDialog.InitialDirectory = topFolderTextBox.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Check_if_path + Environment.NewLine + ex.Message, Resources.Warning);
            }
        }

        private void MoreExamplesButton_Click(object sender, EventArgs e)
        {
            var form = new CronExamples();
            form.ShowDialog();
        }

        private void UseMonitoringJobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            monitoringJobGroupBox.Enabled = useMonitoringJobCheckBox.Checked;
            
            processingSuccessFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingSuccessFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingErrorsFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingErrorsFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
        }

        private void InputFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                inputFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void UploadSuccessFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                uploadSuccessFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void ProcessingSuccessFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                processingSuccessFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void MonitoringJobCronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            simpleTriggerMonitoringJobGroupBox.Enabled = !monitoringJobCronTriggerRadioButton.Checked;
            cronTriggerMonitoringJobGroupBox.Enabled = monitoringJobCronTriggerRadioButton.Checked;
        }

        private void GetCronScheduleForProcButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(monitoringJobCronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = GetScheduleForCron(monitoringJobCronExpressionTextBox.Text, time);
                    if (date == DateTimeOffset.MinValue)
                        return;
                    if (date == null) continue;
                    scheduleTimes.Add(date.Value);
                    time = date.Value;
                }
            calculatedRunsImportTextBox.Text = string.Empty;
            foreach (var date in scheduleTimes)
                calculatedRunsImportTextBox.Text = calculatedRunsImportTextBox.Text + $@"{date.ToLocalTime():yyyy-MM-dd HH:mm:ss}" +
                                             Environment.NewLine;
        }

        private void StatusFileExtensionTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(statusFileExtensionTextBox.Text))
            {
                if (statusFileExtensionTextBox.Text.Substring(0, 1) != ".")
                    statusFileExtensionTextBox.Text = $@".{statusFileExtensionTextBox.Text}";
            }
            else
            {
                statusFileExtensionTextBox.Text = @".Status";
            }
        }

        private void ProcessingErrorsFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                processingErrorsFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void ServiceAuthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var applications = serviceAuthRadioButton.Checked
                ? Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.Service)
                : Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User);
            var applicationsBindingList = new BindingList<AadApplication>(applications.ToList());
            appRegistrationComboBox.DataSource = applicationsBindingList;
            appRegistrationComboBox.ValueMember = null;
            appRegistrationComboBox.DisplayMember = "Name";

            userComboBox.Enabled = !serviceAuthRadioButton.Checked;
        }

        private void PackageTemplateFileBrowserButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                packageTemplateTextBox.Text = openFileDialog.FileName;
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            if (ImportJobDetail == null)
            {
                var jobKey = new JobKey(jobName.Text, jobGroupComboBox.Text);
                if (Scheduler.Instance.GetScheduler().CheckExists(jobKey).Result)
                    if (
                        MessageBox.Show(
                            string.Format(Resources.Job_0_in_group_1_already_exists, jobKey.Name, jobKey.Group),
                            Resources.Job_already_exists, MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
            }

            if (!ValidateJobSettings()) return;
            ImportJobDetail = GetImportJobDetail();
            ImportTrigger = GetImportTrigger(ImportJobDetail);
            if (useMonitoringJobCheckBox.Checked)
            {
                ExecutionJobDetail = GetMonitorJobDetail();
                ExecutionTrigger = GetExecutionTrigger(ExecutionJobDetail);
            }
            Close();
        }

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void GetCronScheduleForMonitoringButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(monitoringJobCronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = GetScheduleForCron(monitoringJobCronExpressionTextBox.Text, time);
                    if (date == DateTimeOffset.MinValue)
                        return;
                    if (date == null) continue;
                    scheduleTimes.Add(date.Value);
                    time = date.Value;
                }
            calculatedRunsMonitoringTextBox.Text = string.Empty;
            foreach (var date in scheduleTimes)
                calculatedRunsMonitoringTextBox.Text = calculatedRunsMonitoringTextBox.Text + $@"{date.ToLocalTime():yyyy-MM-dd HH:mm:ss}" + Environment.NewLine;
        }

        private void MoreExamplesMonitoringButton_Click(object sender, EventArgs e)
        {
            var form = new CronExamples();
            form.ShowDialog();
        }

        private void GetLegalEntityFromFilenameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            getLegalEntityFromFilenameDetailsGroupBox.Enabled = getLegalEntityFromFilenameRadioButton.Checked;
        }

        private void LegalEntityTextBox_TextChanged(object sender, EventArgs e)
        {
            multicompanyCheckBox.Checked = legalEntityTextBox.Text.Length == 0;
        }

        private void MulticompanyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            multiCompanyGetMethodPanel.Enabled = multicompanyCheckBox.Checked;
            legalEntityTextBox.Enabled = !multicompanyCheckBox.Checked;
            if(multicompanyCheckBox.Checked)
            {
                legalEntityTextBox.Text = string.Empty;
            }
        }

        private void InputFilesArePackagesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            packageTemplateFileBrowserButton.Enabled = !inputFilesArePackagesCheckBox.Checked;
            packageTemplateTextBox.Enabled = !inputFilesArePackagesCheckBox.Checked;
            searchPatternTextBox.Enabled = !inputFilesArePackagesCheckBox.Checked;
            if(inputFilesArePackagesCheckBox.Checked)
            {
                searchPatternTextBox.Text = "*.zip";
            }
        }

        private void FilenameSeparatorTextBox_TextChanged(object sender, EventArgs e)
        {
            separatorExampleButton.Enabled = !string.IsNullOrEmpty(filenameSeparatorTextBox.Text);
            
            if(!string.IsNullOrEmpty(filenameSeparatorTextBox.Text))
            {
                var invalidCharacter = new Regex("[" + Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars())) + "]");
                if (invalidCharacter.IsMatch(filenameSeparatorTextBox.Text))
                {
                    MessageBox.Show($"{filenameSeparatorTextBox.Text} is invalid character in filename", "Invalid separator");
                    filenameSeparatorTextBox.Text = string.Empty;
                };
            }
        }

        private void SeparatorExampleTextBox_TextChanged(object sender, EventArgs e)
        {
            separatorExampleLegalEntityTextBox.Text = string.Empty;
        }

        private void SeparatorExampleButton_Click(object sender, EventArgs e)
        {
            String[] separator = { filenameSeparatorTextBox.Text };
            var tokenList = separatorExampleTextBox.Text.Split(separator, 10, StringSplitOptions.RemoveEmptyEntries);
            separatorExampleLegalEntityTextBox.Text = tokenList[(int)legalEntityTokenPositionNumericUpDown.Value - 1];
        }

        private void StatusFileExtensionTextBox_Leave_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(statusFileExtensionTextBox.Text))
            {
                if (statusFileExtensionTextBox.Text.Substring(0, 1) != ".")
                    statusFileExtensionTextBox.Text = $@".{statusFileExtensionTextBox.Text}";
            }
            else
            {
                statusFileExtensionTextBox.Text = @".Status";
            }
        }

        private void importJobCronExpressionTextBox_Leave(object sender, EventArgs e)
        {
            var importJobCronExpressionText = this.importJobCronExpressionTextBox.Text;
            this.importJobCronExpressionTextBox.Text = importJobCronExpressionText.Trim();
        }
    }
}