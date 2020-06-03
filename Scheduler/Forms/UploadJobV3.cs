/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Quartz;
using Quartz.Impl.Triggers;
using Quartz.Util;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class UploadJobV3 : Form
    {
        private const int CpNocloseButton = 0x200;

        public UploadJobV3()
        {
            InitializeComponent();
        }

        public bool Cancelled { get; private set; }

        public IJobDetail ProcessingJobDetail { get; set; }

        public ITrigger ProcessingTrigger { get; set; }

        public IJobDetail UploadJobDetail { get; set; }

        public ITrigger UploadTrigger { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void UploadJobForm_Load(object sender, EventArgs e)
        {
            Cancelled = false;
            //Few changes based on form mode (create or edit)
            Text = UploadJobDetail == null
                ? Resources.Add_upload_job
                : string.Format(Resources.Edit_job_0, UploadJobDetail.Key.Name);
            addToolStripButton.Text = UploadJobDetail == null ? Resources.Add_to_schedule : Resources.Edit_job;
            jobName.Enabled = UploadJobDetail == null;

            jobGroupComboBox.DataSource = Properties.Settings.Default.JobGroups;
            jobGroupComboBox.ValueMember = null;
            jobGroupComboBox.DisplayMember = "Name";

            jobGroupComboBox.Enabled = UploadJobDetail == null;

            instanceComboBox.DataSource = Properties.Settings.Default.Instances;
            instanceComboBox.ValueMember = null;
            instanceComboBox.DisplayMember = "Name";

            appRegistrationComboBox.DataSource = Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User).ToList();
            appRegistrationComboBox.ValueMember = null;
            appRegistrationComboBox.DisplayMember = "Name";

            userComboBox.DataSource = Properties.Settings.Default.Users;
            userComboBox.ValueMember = null;
            userComboBox.DisplayMember = "Login";

            dataJobComboBox.DataSource = Properties.Settings.Default.DataJobs.Where(x => x.Type == DataJobType.Upload).ToList();
            dataJobComboBox.ValueMember = null;
            dataJobComboBox.DisplayMember = "Name";

            orderByComboBox.DataSource = Enum.GetValues(typeof(OrderByOptions));

            upJobStartAtDateTimePicker.Value = DateTime.Now;
            procJobStartAtDateTimePicker.Value = DateTime.Now;

            inputFolderTextBox.Text = Properties.Settings.Default.UploadInputFolder;
            uploadSuccessFolderTextBox.Text = Properties.Settings.Default.UploadSuccessFolder;
            uploadErrorsFolderTextBox.Text = Properties.Settings.Default.UploadErrorsFolder;
            processingSuccessFolderTextBox.Text = Properties.Settings.Default.ProcessingSuccessFolder;
            processingErrorsFolderTextBox.Text = Properties.Settings.Default.ProcessingErrorsFolder;

            if ((UploadJobDetail != null) && (UploadTrigger != null))
            {
                jobName.Text = UploadJobDetail.Key.Name;

                var jobGroup = ((IEnumerable<JobGroup>)jobGroupComboBox.DataSource).FirstOrDefault(x => x.Name == UploadJobDetail.Key.Group);
                jobGroupComboBox.SelectedItem = jobGroup;

                jobDescription.Text = UploadJobDetail.Description;

                useStandardSubfolder.Checked = false;
                inputFolderTextBox.Text = UploadJobDetail.JobDataMap.GetString(SettingsConstants.InputDir);
                uploadSuccessFolderTextBox.Text = UploadJobDetail.JobDataMap.GetString(SettingsConstants.UploadSuccessDir);
                uploadErrorsFolderTextBox.Text = UploadJobDetail.JobDataMap.GetString(SettingsConstants.UploadErrorsDir);
                legalEntityTextBox.Text = UploadJobDetail.JobDataMap.GetString(SettingsConstants.Company);
                isDataPackageCheckBox.Checked = UploadJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.IsDataPackage);
                statusFileExtensionTextBox.Text = UploadJobDetail.JobDataMap.GetString(SettingsConstants.StatusFileExtension) ?? ".Status";
                numericUpDownIntervalUploads.Value = UploadJobDetail.JobDataMap.GetInt(SettingsConstants.DelayBetweenFiles);
                serviceAuthRadioButton.Checked = UploadJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.UseServiceAuthentication);
                if (!serviceAuthRadioButton.Checked)
                {
                    User axUser = null;
                    if (!UploadJobDetail.JobDataMap.GetString(SettingsConstants.UserName).IsNullOrWhiteSpace())
                    {
                        axUser = ((IEnumerable<User>)userComboBox.DataSource).FirstOrDefault(x => x.Login == UploadJobDetail.JobDataMap.GetString(SettingsConstants.UserName));
                    }
                    if (axUser == null)
                    {
                        axUser = new User
                        {
                            Login = UploadJobDetail.JobDataMap.GetString(SettingsConstants.UserName),
                            Password = UploadJobDetail.JobDataMap.GetString(SettingsConstants.UserPassword)
                        };
                        Properties.Settings.Default.Users.Add(axUser);
                        userComboBox.DataSource = Properties.Settings.Default.Users;
                    }
                    userComboBox.SelectedItem = axUser;
                }
                var application = ((IEnumerable<AadApplication>)appRegistrationComboBox.DataSource).FirstOrDefault(app => app.ClientId == UploadJobDetail.JobDataMap.GetString(SettingsConstants.AadClientId));
                if (application == null)
                {
                    if (!serviceAuthRadioButton.Checked)
                    {
                        application = new AadApplication
                        {
                            ClientId = UploadJobDetail.JobDataMap.GetString(SettingsConstants.AadClientId) ?? Guid.Empty.ToString(),
                            Name = $"{Resources.IMPORTED_CHANGE_THIS} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}",
                            AuthenticationType = AuthenticationType.User
                        };
                    }
                    else
                    {
                        application = new AadApplication
                        {
                            ClientId = UploadJobDetail.JobDataMap.GetString(SettingsConstants.AadClientId) ?? Guid.Empty.ToString(),
                            Secret = UploadJobDetail.JobDataMap.GetString(SettingsConstants.AadClientSecret) ?? String.Empty,
                            Name = $"{Resources.IMPORTED_CHANGE_THIS} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}",
                            AuthenticationType = AuthenticationType.Service
                        };
                    }
                    Properties.Settings.Default.AadApplications.Add(application);
                    appRegistrationComboBox.DataSource = Properties.Settings.Default.AadApplications;
                }
                appRegistrationComboBox.SelectedItem = application;

                var dataJob = ((IEnumerable<DataJob>)dataJobComboBox.DataSource).FirstOrDefault(dj => dj.ActivityId == UploadJobDetail.JobDataMap.GetString(SettingsConstants.ActivityId));
                if (dataJob == null)
                {
                    dataJob = new DataJob
                    {
                        ActivityId = UploadJobDetail.JobDataMap.GetString(SettingsConstants.ActivityId),
                        EntityName = UploadJobDetail.JobDataMap.GetString(SettingsConstants.EntityName),
                        Type = DataJobType.Upload,
                        Name = $"{Resources.IMPORTED_CHANGE_THIS} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}"
                    };
                    Properties.Settings.Default.DataJobs.Add(dataJob);
                    dataJobComboBox.DataSource = Properties.Settings.Default.DataJobs.Where(x => x.Type == DataJobType.Upload).ToList();
                }
                dataJobComboBox.SelectedItem = dataJob;

                var axInstance = ((IEnumerable<Instance>)instanceComboBox.DataSource).FirstOrDefault(x =>
                   (x.AosUri == UploadJobDetail.JobDataMap.GetString(SettingsConstants.AosUri)) &&
                   (x.AadTenant == UploadJobDetail.JobDataMap.GetString(SettingsConstants.AadTenant)) &&
                   (x.AzureAuthEndpoint == UploadJobDetail.JobDataMap.GetString(SettingsConstants.AzureAuthEndpoint)));
                if (axInstance == null)
                {
                    axInstance = new Instance
                    {
                        AosUri = UploadJobDetail.JobDataMap.GetString(SettingsConstants.AosUri),
                        AadTenant = UploadJobDetail.JobDataMap.GetString(SettingsConstants.AadTenant),
                        AzureAuthEndpoint = UploadJobDetail.JobDataMap.GetString(SettingsConstants.AzureAuthEndpoint),
                        UseADAL = UploadJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.UseADAL),
                        Name = $"{Resources.IMPORTED_CHANGE_THIS} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}"
                    };
                    Properties.Settings.Default.Instances.Add(axInstance);
                    instanceComboBox.DataSource = Properties.Settings.Default.Instances;
                }
                instanceComboBox.SelectedItem = axInstance;

                searchPatternTextBox.Text = UploadJobDetail.JobDataMap.GetString(SettingsConstants.SearchPattern) ?? "*.*";
                orderByComboBox.DataSource = Enum.GetValues(typeof(OrderByOptions));
                var selectedOrderBy = OrderByOptions.FileName;
                if (!UploadJobDetail.JobDataMap.GetString(SettingsConstants.OrderBy).IsNullOrWhiteSpace())
                {
                    selectedOrderBy = (OrderByOptions)Enum.Parse(typeof(OrderByOptions), UploadJobDetail.JobDataMap.GetString(SettingsConstants.OrderBy));
                }
                orderByComboBox.SelectedItem = selectedOrderBy;

                orderDescendingRadioButton.Checked = UploadJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.ReverseOrder);

                pauseIndefinitelyCheckBox.Checked = UploadJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.IndefinitePause);

                if (UploadTrigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl)UploadTrigger;
                    upJobSimpleTriggerRadioButton.Checked = true;
                    upJobHoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    upJobMinutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    upJobStartAtDateTimePicker.Value = localTrigger.StartTimeUtc.UtcDateTime.ToLocalTime();
                }
                else if (UploadTrigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl)UploadTrigger;
                    upJobCronTriggerRadioButton.Checked = true;
                    upJobCronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }

                retriesCountUpDown.Value = UploadJobDetail.JobDataMap.GetInt(SettingsConstants.RetryCount);
                retriesDelayUpDown.Value = UploadJobDetail.JobDataMap.GetInt(SettingsConstants.RetryDelay);

                pauseOnExceptionsCheckBox.Checked = UploadJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.PauseJobOnException);
                verboseLoggingCheckBox.Checked = UploadJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.LogVerbose);

                Properties.Settings.Default.Save();
            }
            if ((ProcessingJobDetail != null) && (ProcessingTrigger != null))
            {
                useMonitoringJobCheckBox.Checked = true;
                processingSuccessFolderTextBox.Text = ProcessingJobDetail.JobDataMap.GetString(SettingsConstants.ProcessingSuccessDir);
                processingErrorsFolderTextBox.Text = ProcessingJobDetail.JobDataMap.GetString(SettingsConstants.ProcessingErrorsDir);
                delayBetweenStatusCheckNumericUpDown.Value = ProcessingJobDetail.JobDataMap.GetInt(SettingsConstants.DelayBetweenStatusCheck);

                getExecutionErrorsCheckBox.Checked = ProcessingJobDetail.JobDataMap.GetBooleanValue(SettingsConstants.GetExecutionErrors);

                if (ProcessingTrigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl)ProcessingTrigger;
                    procJobSimpleTriggerRadioButton.Checked = true;
                    procJobHoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    procJobMinutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    procJobStartAtDateTimePicker.Value = localTrigger.StartTimeUtc.UtcDateTime.ToLocalTime();
                }
                else if (ProcessingTrigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl)ProcessingTrigger;
                    procJobCronTriggerRadioButton.Checked = true;
                    procJobCronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }
            }
            FormsHelper.SetDropDownsWidth(this);
        }
        
        private IJobDetail GetUploadJobDetail()
        {
            var detail = JobBuilder
                .Create()
                .OfType(Type.GetType("RecurringIntegrationsScheduler.Job.Upload,RecurringIntegrationsScheduler.Job.Upload", true))
                .WithDescription(jobDescription.Text)
                .WithIdentity(new JobKey(jobName.Text, jobGroupComboBox.Text))
                .UsingJobData(GetUploadJobDataMap())
                .Build();

            return detail;
        }
       
        private IJobDetail GetProcessingJobDetail()
        {
            var detail = JobBuilder
                .Create()
                .OfType(
                    Type.GetType(
                        "RecurringIntegrationsScheduler.Job.ProcessingMonitor,RecurringIntegrationsScheduler.Job.ProcessingMonitor",
                        true))
                .WithDescription(string.Format(Resources.Processing_monitor_job_for_upload_job_0_1, jobName.Text,
                    jobGroupComboBox.Text))
                .WithIdentity(new JobKey($"{jobName.Text}-Processing monitor", jobGroupComboBox.Text))
                .UsingJobData(GetProcessingJobDataMap())
                .Build();

            return detail;
        }

        private JobDataMap GetUploadJobDataMap()
        {
            var dataJob = (DataJob)dataJobComboBox.SelectedItem;
            var instance = (Instance)instanceComboBox.SelectedItem;
            var user = (User)userComboBox.SelectedItem;
            var application = (AadApplication)appRegistrationComboBox.SelectedItem;

            var map = new JobDataMap
            {
                {SettingsConstants.InputDir, inputFolderTextBox.Text},
                {SettingsConstants.UploadSuccessDir, uploadSuccessFolderTextBox.Text},
                {SettingsConstants.UploadErrorsDir, uploadErrorsFolderTextBox.Text},
                {SettingsConstants.Company, legalEntityTextBox.Text},
                {SettingsConstants.EntityName, dataJob.EntityName},
                {SettingsConstants.IsDataPackage, isDataPackageCheckBox.Checked},
                {SettingsConstants.StatusFileExtension, statusFileExtensionTextBox.Text},
                {SettingsConstants.AadTenant, instance.AadTenant},
                {SettingsConstants.AzureAuthEndpoint, instance.AzureAuthEndpoint},
                {SettingsConstants.AosUri, instance.AosUri},
                {SettingsConstants.UseADAL, instance.UseADAL},
                {SettingsConstants.AadClientId, application.ClientId},
                {SettingsConstants.ActivityId, dataJob.ActivityId},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked},
                {SettingsConstants.ProcessingJobPresent, useMonitoringJobCheckBox.Checked},
                {SettingsConstants.SearchPattern, searchPatternTextBox.Text},
                {SettingsConstants.OrderBy, orderByComboBox.SelectedItem.ToString()},
                {SettingsConstants.ReverseOrder, orderDescendingRadioButton.Checked},
                {SettingsConstants.RetryCount, retriesCountUpDown.Value},
                {SettingsConstants.RetryDelay, retriesDelayUpDown.Value},
                {SettingsConstants.PauseJobOnException, pauseOnExceptionsCheckBox.Checked},
                {SettingsConstants.IndefinitePause, pauseIndefinitelyCheckBox.Checked},
                {SettingsConstants.DelayBetweenFiles, numericUpDownIntervalUploads.Value},
                {SettingsConstants.LogVerbose, verboseLoggingCheckBox.Checked}
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
        
        private JobDataMap GetProcessingJobDataMap()
        {
            var instance = (Instance)instanceComboBox.SelectedItem;
            var user = (User)userComboBox.SelectedItem;
            var dataJob = (DataJob)dataJobComboBox.SelectedItem;
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
                {SettingsConstants.UseADAL, instance.UseADAL},
                {SettingsConstants.AadClientId, application.ClientId},
                {SettingsConstants.ActivityId, dataJob.ActivityId},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked},
                {SettingsConstants.RetryCount, retriesCountUpDown.Value},
                {SettingsConstants.RetryDelay, retriesDelayUpDown.Value},
                {SettingsConstants.PauseJobOnException, pauseOnExceptionsCheckBox.Checked},
                {SettingsConstants.IndefinitePause, pauseIndefinitelyCheckBox.Checked},
                {SettingsConstants.DelayBetweenStatusCheck, delayBetweenStatusCheckNumericUpDown.Value},
                {SettingsConstants.GetExecutionErrors, getExecutionErrorsCheckBox.Checked},
                {SettingsConstants.LogVerbose, verboseLoggingCheckBox.Checked}
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
        
        private ITrigger GetUploadTrigger(IJobDetail jobDetail)
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

            if (upJobSimpleTriggerRadioButton.Checked)
            {
                var minutes = upJobHoursDateTimePicker.Value.Hour * 60;
                minutes += upJobMinutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartAt(upJobStartAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(upJobCronExpressionTextBox.Text))
                    .StartNow()
                    .Build();
        }
        
        private ITrigger GetProcessingTrigger(IJobDetail jobDetail)
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

            if (procJobSimpleTriggerRadioButton.Checked)
            {
                var minutes = procJobHoursDateTimePicker.Value.Hour * 60;
                minutes += procJobMinutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartAt(procJobStartAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(procJobCronExpressionTextBox.Text))
                    .StartNow()
                    .Build();
        }

        private bool ValidateJobSettings()
        {
            if (upJobCronTriggerRadioButton.Checked)
            {
                var date = FormsHelper.GetScheduleForCron(upJobCronExpressionTextBox.Text, DateTimeOffset.Now);
                if (date == DateTimeOffset.MinValue)
                    return false;
            }

            if (useMonitoringJobCheckBox.Checked && procJobCronTriggerRadioButton.Checked)
            {
                var date = FormsHelper.GetScheduleForCron(procJobCronExpressionTextBox.Text, DateTimeOffset.Now);
                if (date == DateTimeOffset.MinValue)
                    return false;
            }

            var message = new StringBuilder();

            if (string.IsNullOrEmpty(jobName.Text))
                message.AppendLine(Resources.Job_name_is_missing);

            if ((jobGroupComboBox.SelectedItem == null) || string.IsNullOrEmpty(jobGroupComboBox.Text))
                message.AppendLine(Resources.Job_group_is_not_selected);

            if (string.IsNullOrEmpty(topUploadFolderTextBox.Text) && useStandardSubfolder.Checked)
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

            if ((instanceComboBox.SelectedItem == null) || string.IsNullOrEmpty(instanceComboBox.Text))
                message.AppendLine(Resources.Dynamics_instance_is_not_selected);

            if (userAuthRadioButton.Checked &&
                ((userComboBox.SelectedItem == null) || string.IsNullOrEmpty(userComboBox.Text)))
                message.AppendLine(Resources.User_is_not_selected);

            if ((appRegistrationComboBox.SelectedItem == null) || string.IsNullOrEmpty(appRegistrationComboBox.Text))
                message.AppendLine(Resources.AAD_client_application_is_not_selected);

            if ((dataJobComboBox.SelectedItem == null) || string.IsNullOrEmpty(dataJobComboBox.Text))
                message.AppendLine(Resources.Data_job_is_not_selected);

            if (string.IsNullOrEmpty(statusFileExtensionTextBox.Text) && useMonitoringJobCheckBox.Checked)
                message.AppendLine(Resources.Status_file_extension_is_not_specified);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Job_configuration_is_not_valid);

            return message.Length == 0;
        }
        
        #region Form events

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            FormsHelper.TrimTextBoxes(this);

            if (UploadJobDetail == null)
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
            UploadJobDetail = GetUploadJobDetail();
            UploadTrigger = GetUploadTrigger(UploadJobDetail);
            if (useMonitoringJobCheckBox.Checked)
            {
                ProcessingJobDetail = GetProcessingJobDetail();
                ProcessingTrigger = GetProcessingTrigger(ProcessingJobDetail);
            }
            Close();
        }

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void CronDocsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start(
                "https://www.quartz-scheduler.net/documentation/quartz-3.x/tutorial/crontrigger.html");
        }

        private void CronmakerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start("http://www.cronmaker.com");
        }

        private void GetCronScheduleForProcButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(procJobCronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = FormsHelper.GetScheduleForCron(procJobCronExpressionTextBox.Text, time);
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

        private void GetCronScheduleForUploadButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(upJobCronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = FormsHelper.GetScheduleForCron(upJobCronExpressionTextBox.Text, time);
                    if (date == DateTimeOffset.MinValue)
                        return;
                    if (date == null) continue;
                    scheduleTimes.Add(date.Value);
                    time = date.Value;
                }
            calculatedRunsTextBox.Text = string.Empty;
            foreach (var date in scheduleTimes)
                calculatedRunsTextBox.Text = calculatedRunsTextBox.Text + $@"{date.ToLocalTime():yyyy-MM-dd HH:mm:ss}" +
                                             Environment.NewLine;
        }

        private void InputFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                inputFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void IsDataPackageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isDataPackageCheckBox.Checked)
            {
                searchPatternTextBox.Text = "*.zip";
                searchPatternTextBox.Enabled = false;
            }
            else
            {
                searchPatternTextBox.Text = "*.*";
                searchPatternTextBox.Enabled = true;
            }
        }

        private void MoreExamplesButton_Click(object sender, EventArgs e)
        {
            var form = new CronExamples();
            form.ShowDialog();
        }

        private void ProcessingErrorsFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                processingErrorsFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void ProcessingSuccessFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                processingSuccessFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void ProcJobCronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            simpleTriggerMonitoringJobGroupBox.Enabled = !procJobCronTriggerRadioButton.Checked;
            cronTriggerMonitoringJobGroupBox.Enabled = procJobCronTriggerRadioButton.Checked;
        }

        private void ServiceAuthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (serviceAuthRadioButton.Checked)
            {
                appRegistrationComboBox.DataSource = Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.Service).ToList();
            }
            else
            {
                appRegistrationComboBox.DataSource = Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User).ToList();
            }

            userComboBox.Enabled = !serviceAuthRadioButton.Checked;
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

        private void TopUploadFolder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (useStandardSubfolder.Checked)
                {
                    inputFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                        Properties.Settings.Default.UploadInputFolder);
                    uploadSuccessFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                        Properties.Settings.Default.UploadSuccessFolder);
                    uploadErrorsFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                        Properties.Settings.Default.UploadErrorsFolder);
                    processingSuccessFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                        Properties.Settings.Default.ProcessingSuccessFolder);
                    processingErrorsFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                        Properties.Settings.Default.ProcessingErrorsFolder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Check_if_path + Environment.NewLine + ex.Message, Resources.Warning);
            }
        }

        private void TopUploadFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                topUploadFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void UpJobCronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            simpleTriggerUploadJobGroupBox.Enabled = !upJobCronTriggerRadioButton.Checked;
            cronTriggerUploadJobGroupBox.Enabled = upJobCronTriggerRadioButton.Checked;
        }

        private void UploadErrorsFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                uploadErrorsFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void UploadSuccessFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                uploadSuccessFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void UseMonitoringJobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            processingJobGroupBox.Enabled = useMonitoringJobCheckBox.Checked;

            processingSuccessFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingSuccessFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingErrorsFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingErrorsFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
        }

        private void UseStandardSubfolder_CheckedChanged(object sender, EventArgs e)
        {
            if (useStandardSubfolder.Checked)
            {
                topUploadFolderTextBox.Enabled = true;
                topUploadFolderBrowserButton.Enabled = true;

                inputFolderTextBox.Enabled = false;
                inputFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                    Properties.Settings.Default.UploadInputFolder);
                inputFolderBrowserButton.Enabled = false;

                uploadSuccessFolderTextBox.Enabled = false;
                uploadSuccessFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                    Properties.Settings.Default.UploadSuccessFolder);
                uploadSuccessFolderBrowserButton.Enabled = false;

                uploadErrorsFolderTextBox.Enabled = false;
                uploadErrorsFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                    Properties.Settings.Default.UploadErrorsFolder);
                uploadErrorsFolderBrowserButton.Enabled = false;

                processingSuccessFolderTextBox.Enabled = false;
                processingSuccessFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                    Properties.Settings.Default.ProcessingSuccessFolder);
                processingSuccessFolderBrowserButton.Enabled = false;

                processingErrorsFolderTextBox.Enabled = false;
                processingErrorsFolderTextBox.Text = Path.Combine(topUploadFolderTextBox.Text,
                    Properties.Settings.Default.ProcessingErrorsFolder);
                processingErrorsFolderBrowserButton.Enabled = false;
            }
            else
            {
                topUploadFolderTextBox.Enabled = false;
                topUploadFolderBrowserButton.Enabled = false;

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

                if (string.IsNullOrEmpty(topUploadFolderTextBox.Text))
                {
                    inputFolderTextBox.Text = "";
                    uploadSuccessFolderTextBox.Text = "";
                    uploadErrorsFolderTextBox.Text = "";
                    processingSuccessFolderTextBox.Text = "";
                    processingErrorsFolderTextBox.Text = "";
                }
            }
        }
        
        #endregion
    }
}