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
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class UploadJob : Form
    {
        private const int CpNocloseButton = 0x200;

        public UploadJob()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CpNocloseButton;
                return myCp;
            }
        }

        public bool Cancelled { get; private set; }
        public IJobDetail UploadJobDetail { get; set; }
        public ITrigger UploadTrigger { get; set; }
        public IJobDetail ProcessingJobDetail { get; set; }
        public ITrigger ProcessingTrigger { get; set; }

        private void UploadJobForm_Load(object sender, EventArgs e)
        {
            Cancelled = false;
            //Few changes based on form mode (create or edit)
            Text = UploadJobDetail == null
                ? Resources.Add_upload_job
                : string.Format(Resources.Edit_job_0, UploadJobDetail.Key.Name);
            addJobButton.Text = UploadJobDetail == null ? Resources.Add_to_schedule : Resources.Edit_job;
            jobName.Enabled = UploadJobDetail == null;

            jobGroupComboBox.DataSource = Properties.Settings.Default.JobGroups;
            jobGroupComboBox.ValueMember = null;
            jobGroupComboBox.DisplayMember = "Name";

            jobGroupComboBox.Enabled = UploadJobDetail == null;

            instanceComboBox.DataSource = Properties.Settings.Default.Instances;
            instanceComboBox.ValueMember = null;
            instanceComboBox.DisplayMember = "Name";

            var dataJobs = Properties.Settings.Default.DataJobs.Where(x => x.Type == DataJobType.Upload);
            var dataJobsBindingList = new BindingList<DataJob>(dataJobs.ToList());
            dataJobComboBox.DataSource = dataJobsBindingList;
            dataJobComboBox.ValueMember = null;
            dataJobComboBox.DisplayMember = "Name";

            var applications = Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User);
            var applicationsBindingList = new BindingList<AadApplication>(applications.ToList());
            aadApplicationComboBox.DataSource = applicationsBindingList;
            aadApplicationComboBox.ValueMember = null;
            aadApplicationComboBox.DisplayMember = "Name";

            userComboBox.DataSource = Properties.Settings.Default.Users;
            userComboBox.ValueMember = null;
            userComboBox.DisplayMember = "Login";

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

                var jobGroup =
                    ((IEnumerable<JobGroup>) jobGroupComboBox.DataSource).FirstOrDefault(
                        x => x.Name == UploadJobDetail.Key.Group);
                jobGroupComboBox.SelectedItem = jobGroup;

                jobDescription.Text = UploadJobDetail.Description;

                useStandardSubfolder.Checked = false;
                inputFolderTextBox.Text = UploadJobDetail.JobDataMap[SettingsConstants.InputDir]?.ToString() ??
                                          string.Empty;
                uploadSuccessFolderTextBox.Text =
                    UploadJobDetail.JobDataMap[SettingsConstants.UploadSuccessDir]?.ToString() ?? string.Empty;
                uploadErrorsFolderTextBox.Text =
                    UploadJobDetail.JobDataMap[SettingsConstants.UploadErrorsDir]?.ToString() ?? string.Empty;

                legalEntityTextBox.Text = UploadJobDetail.JobDataMap[SettingsConstants.Company]?.ToString() ??
                                          string.Empty;
                dataPackageCheckBox.Checked = (UploadJobDetail.JobDataMap[SettingsConstants.IsDataPackage] != null) &&
                                              Convert.ToBoolean(
                                                  UploadJobDetail.JobDataMap[SettingsConstants.IsDataPackage].ToString());
                statusFileExtensionTextBox.Text =
                    UploadJobDetail.JobDataMap[SettingsConstants.StatusFileExtension]?.ToString() ?? ".Status";
                serviceAuthRadioButton.Checked =
                    (UploadJobDetail.JobDataMap[SettingsConstants.UseServiceAuthentication] != null) &&
                    Convert.ToBoolean(UploadJobDetail.JobDataMap[SettingsConstants.UseServiceAuthentication].ToString());
                if (!serviceAuthRadioButton.Checked)
                {
                    User axUser = null;
                    if (UploadJobDetail.JobDataMap[SettingsConstants.UserName] != null)
                        axUser =
                            ((IEnumerable<User>) userComboBox.DataSource).FirstOrDefault(
                                x => x.Login == UploadJobDetail.JobDataMap[SettingsConstants.UserName].ToString());
                    if (axUser == null)
                    {
                        var userName = UploadJobDetail.JobDataMap[SettingsConstants.UserName];
                        if (userName != null)
                            axUser = new User
                            {
                                Login = userName.ToString(),
                                Password = UploadJobDetail.JobDataMap[SettingsConstants.UserPassword].ToString()
                            };
                        var disabledUser = new Users {axUser};
                        userComboBox.DataSource = disabledUser;
                        userComboBox.Enabled = false;
                    }
                    userComboBox.SelectedItem = axUser;
                }
                var application =
                    ((IEnumerable<AadApplication>) aadApplicationComboBox.DataSource).FirstOrDefault(app =>
                            app.ClientId == UploadJobDetail.JobDataMap[SettingsConstants.AadClientId].ToString());
                if (application == null)
                    if (UploadJobDetail.JobDataMap[SettingsConstants.AadClientSecret] == null)
                    {
                        application = new AadApplication
                        {
                            ClientId = UploadJobDetail.JobDataMap[SettingsConstants.AadClientId].ToString(),
                            Name = Resources.IMPORTED_CHANGE_THIS,
                            AuthenticationType = AuthenticationType.User
                        };
                        Properties.Settings.Default.AadApplications.Add(application);
                        applications =
                            Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User);
                        applicationsBindingList = new BindingList<AadApplication>(applications.ToList());
                        aadApplicationComboBox.DataSource = applicationsBindingList;
                        aadApplicationComboBox.ValueMember = null;
                        aadApplicationComboBox.DisplayMember = "Name";
                    }
                    else
                    {
                        application = new AadApplication
                        {
                            ClientId = UploadJobDetail.JobDataMap[SettingsConstants.AadClientId].ToString(),
                            Secret = UploadJobDetail.JobDataMap[SettingsConstants.AadClientSecret].ToString(),
                            Name = Resources.IMPORTED,
                            AuthenticationType = AuthenticationType.Service
                        };
                        var disabledApplication = new AadApplications {application};
                        aadApplicationComboBox.DataSource = disabledApplication;
                        aadApplicationComboBox.Enabled = false;
                        authMethodPanel.Enabled = false;
                    }
                aadApplicationComboBox.SelectedItem = application;

                var dataJob =
                    ((IEnumerable<DataJob>) dataJobComboBox.DataSource).FirstOrDefault(
                        dj => dj.ActivityId == UploadJobDetail.JobDataMap[SettingsConstants.ActivityId].ToString());
                if (dataJob == null)
                {
                    dataJob = new DataJob
                    {
                        ActivityId = UploadJobDetail.JobDataMap[SettingsConstants.ActivityId].ToString(),
                        EntityName = UploadJobDetail.JobDataMap[SettingsConstants.EntityName].ToString(),
                        Type = DataJobType.Upload,
                        Name = Resources.IMPORTED_CHANGE_THIS
                    };
                    Properties.Settings.Default.DataJobs.Add(dataJob);
                    dataJobs = Properties.Settings.Default.DataJobs.Where(x => x.Type == DataJobType.Upload);
                    dataJobsBindingList = new BindingList<DataJob>(dataJobs.ToList());
                    dataJobComboBox.DataSource = dataJobsBindingList;
                    dataJobComboBox.ValueMember = null;
                    dataJobComboBox.DisplayMember = "Name";
                }
                dataJobComboBox.SelectedItem = dataJob;

                var axInstance = ((IEnumerable<Instance>) instanceComboBox.DataSource).FirstOrDefault(x =>
                    (x.AosUri == UploadJobDetail.JobDataMap[SettingsConstants.AosUri].ToString()) &&
                    (x.AadTenant == UploadJobDetail.JobDataMap[SettingsConstants.AadTenant].ToString()) &&
                    (x.AzureAuthEndpoint == UploadJobDetail.JobDataMap[SettingsConstants.AzureAuthEndpoint].ToString()));
                if (axInstance == null)
                {
                    axInstance = new Instance
                    {
                        AosUri = UploadJobDetail.JobDataMap[SettingsConstants.AosUri].ToString(),
                        AadTenant = UploadJobDetail.JobDataMap[SettingsConstants.AadTenant].ToString(),
                        AzureAuthEndpoint = UploadJobDetail.JobDataMap[SettingsConstants.AzureAuthEndpoint].ToString(),
                        Name = Resources.IMPORTED_CHANGE_THIS
                    };
                    Properties.Settings.Default.Instances.Add(axInstance);
                }
                instanceComboBox.SelectedItem = axInstance;

                searchPatternTextBox.Text = UploadJobDetail.JobDataMap[SettingsConstants.SearchPattern]?.ToString() ??
                                            "*.*";
                orderByComboBox.DataSource = Enum.GetValues(typeof(OrderByOptions));
                var selectedOrderBy = OrderByOptions.FileName;
                if (UploadJobDetail.JobDataMap[SettingsConstants.OrderBy] != null)
                    selectedOrderBy =
                        (OrderByOptions)
                        Enum.Parse(typeof(OrderByOptions),
                            UploadJobDetail.JobDataMap[SettingsConstants.OrderBy].ToString());
                orderByComboBox.SelectedItem = selectedOrderBy;

                orderDescendingRadioButton.Checked = (UploadJobDetail.JobDataMap[SettingsConstants.ReverseOrder] != null) &&
                                                     Convert.ToBoolean(
                                                         UploadJobDetail.JobDataMap[SettingsConstants.ReverseOrder]
                                                             .ToString());

                pauseIndefinitelyCheckBox.Checked =
                    (UploadJobDetail.JobDataMap[SettingsConstants.IndefinitePause] != null) &&
                    Convert.ToBoolean(UploadJobDetail.JobDataMap[SettingsConstants.IndefinitePause].ToString());

                if (UploadTrigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl) UploadTrigger;
                    upJobSimpleTriggerRadioButton.Checked = true;
                    upJobHoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    upJobMinutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                }
                else if (UploadTrigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl) UploadTrigger;
                    upJobCronTriggerRadioButton.Checked = true;
                    upJobCronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }
                if(UploadJobDetail.JobDataMap[SettingsConstants.RetryCount] != null)
                {
                    retriesCountUpDown.Value = Convert.ToDecimal(UploadJobDetail.JobDataMap[SettingsConstants.RetryCount]);
                }
                if(UploadJobDetail.JobDataMap[SettingsConstants.RetryDelay] != null)
                {
                    retriesDelayUpDown.Value = Convert.ToDecimal(UploadJobDetail.JobDataMap[SettingsConstants.RetryDelay]);
                }
                pauseOnExceptionsCheckBox.Checked =
                    (UploadJobDetail.JobDataMap[SettingsConstants.PauseJobOnException] != null) &&
                    Convert.ToBoolean(UploadJobDetail.JobDataMap[SettingsConstants.PauseJobOnException].ToString());

                Properties.Settings.Default.Save();
            }
            if ((ProcessingJobDetail != null) && (ProcessingTrigger != null))
            {
                useMonitoringJobCheckBox.Checked = true;
                processingSuccessFolderTextBox.Text =
                    ProcessingJobDetail.JobDataMap[SettingsConstants.ProcessingSuccessDir]?.ToString() ?? string.Empty;
                processingErrorsFolderTextBox.Text =
                    ProcessingJobDetail.JobDataMap[SettingsConstants.ProcessingErrorsDir]?.ToString() ?? string.Empty;

                if (ProcessingTrigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl) ProcessingTrigger;
                    procJobSimpleTriggerRadioButton.Checked = true;
                    procJobHoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    procJobMinutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                }
                else if (ProcessingTrigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl) ProcessingTrigger;
                    procJobCronTriggerRadioButton.Checked = true;
                    procJobCronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }
            }
        }

        private void TopUploadFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                topUploadFolderTextBox.Text = folderBrowserDialog.SelectedPath;
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

        private void CronmakerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start("http://www.cronmaker.com");
        }

        private void UpJobCronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            upJobHoursDateTimePicker.Enabled = !upJobCronTriggerRadioButton.Checked;
            upJobMinutesDateTimePicker.Enabled = !upJobCronTriggerRadioButton.Checked;
            upJobStartAtDateTimePicker.Enabled = !upJobCronTriggerRadioButton.Checked;
            upJobCronExpressionTextBox.Enabled = upJobCronTriggerRadioButton.Checked;
            getCronScheduleForUploadButton.Enabled = upJobCronTriggerRadioButton.Checked;
        }

        private void AddJobButton_Click(object sender, EventArgs e)
        {
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
                ProcessingJobDetail = GetMonitorJobDetail();
                ProcessingTrigger = GetProcessingTrigger(ProcessingJobDetail);
            }
            Close();
        }

        private bool ValidateJobSettings()
        {
            if (upJobCronTriggerRadioButton.Checked)
            {
                var date = GetScheduleForCron(upJobCronExpressionTextBox.Text, DateTimeOffset.Now);
                if (date == DateTimeOffset.MinValue)
                    return false;
            }

            if (useMonitoringJobCheckBox.Checked && procJobCronTriggerRadioButton.Checked)
            {
                var date = GetScheduleForCron(procJobCronExpressionTextBox.Text, DateTimeOffset.Now);
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

            if ((aadApplicationComboBox.SelectedItem == null) || string.IsNullOrEmpty(aadApplicationComboBox.Text))
                message.AppendLine(Resources.AAD_client_application_is_not_selected);

            if ((dataJobComboBox.SelectedItem == null) || string.IsNullOrEmpty(dataJobComboBox.Text))
                message.AppendLine(Resources.Data_job_is_not_selected);

            if (string.IsNullOrEmpty(statusFileExtensionTextBox.Text) && useMonitoringJobCheckBox.Checked)
                message.AppendLine(Resources.Status_file_extension_is_not_specified);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Job_configuration_is_not_valid);

            return message.Length == 0;
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

        private IJobDetail GetMonitorJobDetail()
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
                var minutes = procJobHoursDateTimePicker.Value.Hour*60;
                minutes = minutes + procJobMinutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartNow()
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(procJobCronExpressionTextBox.Text))
                    .StartAt(procJobStartAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
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
                var minutes = upJobHoursDateTimePicker.Value.Hour*60;
                minutes = minutes + upJobMinutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartNow()
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(upJobCronExpressionTextBox.Text))
                    .StartAt(upJobStartAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
        }

        private JobDataMap GetUploadJobDataMap()
        {
            var dataJob = (DataJob) dataJobComboBox.SelectedItem;
            var instance = (Instance) instanceComboBox.SelectedItem;
            var user = (User) userComboBox.SelectedItem;
            var application = (AadApplication) aadApplicationComboBox.SelectedItem;

            var map = new JobDataMap
            {
                {SettingsConstants.InputDir, inputFolderTextBox.Text},
                {SettingsConstants.UploadSuccessDir, uploadSuccessFolderTextBox.Text},
                {SettingsConstants.UploadErrorsDir, uploadErrorsFolderTextBox.Text},
                {SettingsConstants.Company, legalEntityTextBox.Text},
                {SettingsConstants.EntityName, dataJob.EntityName},
                {SettingsConstants.IsDataPackage, dataPackageCheckBox.Checked.ToString()},
                {SettingsConstants.StatusFileExtension, statusFileExtensionTextBox.Text},
                {SettingsConstants.AadTenant, instance.AadTenant},
                {SettingsConstants.AzureAuthEndpoint, instance.AzureAuthEndpoint},
                {SettingsConstants.AosUri, instance.AosUri},
                {SettingsConstants.AadClientId, application.ClientId},
                {SettingsConstants.ActivityId, dataJob.ActivityId},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked.ToString()},
                {SettingsConstants.ProcessingJobPresent, useMonitoringJobCheckBox.Checked.ToString()},
                {SettingsConstants.SearchPattern, searchPatternTextBox.Text},
                {SettingsConstants.OrderBy, orderByComboBox.SelectedItem.ToString()},
                {SettingsConstants.ReverseOrder, orderDescendingRadioButton.Checked.ToString()},
                {SettingsConstants.RetryCount, retriesCountUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.RetryDelay, retriesDelayUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.PauseJobOnException, pauseOnExceptionsCheckBox.Checked.ToString()},
                {SettingsConstants.IndefinitePause, pauseIndefinitelyCheckBox.Checked.ToString()}
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
            var instance = (Instance) instanceComboBox.SelectedItem;
            var user = (User) userComboBox.SelectedItem;
            var dataJob = (DataJob) dataJobComboBox.SelectedItem;
            var application = (AadApplication) aadApplicationComboBox.SelectedItem;

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
                {SettingsConstants.ActivityId, dataJob.ActivityId},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked.ToString()},
                {SettingsConstants.RetryCount, retriesCountUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.RetryDelay, retriesDelayUpDown.Value.ToString(CultureInfo.InvariantCulture)},
                {SettingsConstants.PauseJobOnException, pauseOnExceptionsCheckBox.Checked.ToString()},
                {SettingsConstants.IndefinitePause, pauseIndefinitelyCheckBox.Checked.ToString()}
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

        private void CronDocsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start(
                "http://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontrigger.html");
        }

        private void GetCronScheduleForUploadButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(upJobCronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = GetScheduleForCron(upJobCronExpressionTextBox.Text, time);
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

        private void MoreExamplesButton_Click(object sender, EventArgs e)
        {
            var form = new CronExamples();
            form.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void UseMonitoringJobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            processingJobGroupBox.Enabled = useMonitoringJobCheckBox.Checked;
            statusFileExtensionTextBox.Enabled = useMonitoringJobCheckBox.Checked;
            processingSuccessFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingSuccessFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked &&
                                                           !useStandardSubfolder.Checked;
            processingErrorsFolderTextBox.Enabled = useMonitoringJobCheckBox.Checked && !useStandardSubfolder.Checked;
            processingErrorsFolderBrowserButton.Enabled = useMonitoringJobCheckBox.Checked &&
                                                          !useStandardSubfolder.Checked;
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

        private void ProcJobCronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            procJobHoursDateTimePicker.Enabled = !procJobCronTriggerRadioButton.Checked;
            procJobMinutesDateTimePicker.Enabled = !procJobCronTriggerRadioButton.Checked;
            procJobStartAtDateTimePicker.Enabled = !procJobCronTriggerRadioButton.Checked;
            procJobCronExpressionTextBox.Enabled = procJobCronTriggerRadioButton.Checked;
            getCronScheduleForProcButton.Enabled = procJobCronTriggerRadioButton.Checked;
        }

        private void GetCronScheduleForProcButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(procJobCronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = GetScheduleForCron(procJobCronExpressionTextBox.Text, time);
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
            aadApplicationComboBox.DataSource = applicationsBindingList;
            aadApplicationComboBox.ValueMember = null;
            aadApplicationComboBox.DisplayMember = "Name";

            userComboBox.Enabled = !serviceAuthRadioButton.Checked;
        }
    }
}