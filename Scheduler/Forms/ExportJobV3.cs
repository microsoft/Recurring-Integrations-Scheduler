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
    public partial class ExportJobV3 : Form
    {
        private const int CpNocloseButton = 0x200;

        public ExportJobV3()
        {
            InitializeComponent();
        }

        public bool Cancelled { get; private set; }

        public IJobDetail JobDetail { get; set; }

        public ITrigger Trigger { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void ExportJobForm_Load(object sender, EventArgs e)
        {
            Cancelled = false;
            //Few changes based on form mode (create or edit)
            Text = JobDetail == null
                ? Resources.Add_export_job
                : string.Format(Resources.Edit_job_0, JobDetail.Key.Name);
            addToolStripButton.Text = JobDetail == null ? Resources.Add_to_schedule : Resources.Edit_job;
            jobName.Enabled = JobDetail == null;

            jobGroupComboBox.DataSource = Properties.Settings.Default.JobGroups;
            jobGroupComboBox.ValueMember = null;
            jobGroupComboBox.DisplayMember = "Name";

            jobGroupComboBox.Enabled = JobDetail == null;

            instanceComboBox.DataSource = Properties.Settings.Default.Instances;
            instanceComboBox.ValueMember = null;
            instanceComboBox.DisplayMember = "Name";

            appRegistrationComboBox.DataSource = Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User).ToList();
            appRegistrationComboBox.ValueMember = null;
            appRegistrationComboBox.DisplayMember = "Name";

            userComboBox.DataSource = Properties.Settings.Default.Users;
            userComboBox.ValueMember = null;
            userComboBox.DisplayMember = "Login";

            startAtDateTimePicker.Value = DateTime.Now;

            errorsFolder.Text = Properties.Settings.Default.DownloadErrorsFolder;

            exportToPackageTextBox.Text = PackageApiActions.ExportToPackageActionPath;
            getExecutionSummaryStatusTextBox.Text = PackageApiActions.GetExecutionSummaryStatusActionPath;
            getExportedPackageUrlTextBox.Text = PackageApiActions.GetExportedPackageUrlActionPath;

            if ((JobDetail != null) && (Trigger != null))
            {
                jobName.Text = JobDetail.Key.Name;

                var jobGroup = ((IEnumerable<JobGroup>)jobGroupComboBox.DataSource).FirstOrDefault(x => x.Name == JobDetail.Key.Group);
                jobGroupComboBox.SelectedItem = jobGroup;

                jobDescription.Text = JobDetail.Description;

                downloadFolder.Text = JobDetail.JobDataMap.GetString(SettingsConstants.DownloadSuccessDir);
                errorsFolder.Text = JobDetail.JobDataMap.GetString(SettingsConstants.DownloadErrorsDir);
                useStandardSubfolder.Checked = false;

                unzipCheckBox.Checked = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.UnzipPackage);
                addTimestampCheckBox.Checked = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.AddTimestamp);
                deletePackageCheckBox.Checked = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.DeletePackage);
                serviceAuthRadioButton.Checked = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.UseServiceAuthentication);

                dataProject.Text = JobDetail.JobDataMap.GetString(SettingsConstants.DataProject);
                legalEntity.Text = JobDetail.JobDataMap.GetString(SettingsConstants.Company);
                delayBetweenStatusCheckNumericUpDown.Value = JobDetail.JobDataMap.GetInt(SettingsConstants.DelayBetweenStatusCheck);
                delayBetweenAttemptsNumericUpDown.Value = JobDetail.JobDataMap.GetInt(SettingsConstants.DelayBetweenFiles);

                if (!serviceAuthRadioButton.Checked)
                {
                    User axUser = null;
                    if (!JobDetail.JobDataMap.GetString(SettingsConstants.UserName).IsNullOrWhiteSpace())
                    {
                        axUser = ((IEnumerable<User>)userComboBox.DataSource).FirstOrDefault(x => x.Login == JobDetail.JobDataMap.GetString(SettingsConstants.UserName));
                    }
                    if (axUser == null)
                    {
                        axUser = new User
                        {
                            Login = JobDetail.JobDataMap.GetString(SettingsConstants.UserName),
                            Password = JobDetail.JobDataMap.GetString(SettingsConstants.UserPassword)
                        };
                        Properties.Settings.Default.Users.Add(axUser);
                        userComboBox.DataSource = Properties.Settings.Default.Users;
                    }
                    userComboBox.SelectedItem = axUser;
                }
                var application = ((IEnumerable<AadApplication>)appRegistrationComboBox.DataSource).FirstOrDefault(app => app.ClientId == JobDetail.JobDataMap.GetString(SettingsConstants.AadClientId));
                if (application == null)
                {
                    if (!serviceAuthRadioButton.Checked)
                    {
                        application = new AadApplication
                        {
                            ClientId = JobDetail.JobDataMap.GetString(SettingsConstants.AadClientId) ?? Guid.Empty.ToString(),
                            Name = $"{Resources.IMPORTED_CHANGE_THIS} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}",
                            AuthenticationType = AuthenticationType.User
                        };
                    }
                    else
                    {
                        application = new AadApplication
                        {
                            ClientId = JobDetail.JobDataMap.GetString(SettingsConstants.AadClientId) ?? Guid.Empty.ToString(),
                            Secret = JobDetail.JobDataMap.GetString(SettingsConstants.AadClientSecret) ?? String.Empty,
                            Name = $"{Resources.IMPORTED_CHANGE_THIS} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}",
                            AuthenticationType = AuthenticationType.Service
                        };
                    }
                    Properties.Settings.Default.AadApplications.Add(application);
                    appRegistrationComboBox.DataSource = Properties.Settings.Default.AadApplications;
                }
                appRegistrationComboBox.SelectedItem = application;

                var axInstance = ((IEnumerable<Instance>)instanceComboBox.DataSource).FirstOrDefault(x =>
                   (x.AosUri == JobDetail.JobDataMap.GetString(SettingsConstants.AosUri)) &&
                   (x.AadTenant == JobDetail.JobDataMap.GetString(SettingsConstants.AadTenant)) &&
                   (x.AzureAuthEndpoint == JobDetail.JobDataMap.GetString(SettingsConstants.AzureAuthEndpoint)));
                if (axInstance == null)
                {
                    axInstance = new Instance
                    {
                        AosUri = JobDetail.JobDataMap.GetString(SettingsConstants.AosUri),
                        AadTenant = JobDetail.JobDataMap.GetString(SettingsConstants.AadTenant),
                        AzureAuthEndpoint = JobDetail.JobDataMap.GetString(SettingsConstants.AzureAuthEndpoint),
                        UseADAL = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.UseADAL),
                        Name = $"{Resources.IMPORTED_CHANGE_THIS} {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}"
                    };
                    Properties.Settings.Default.Instances.Add(axInstance);
                    instanceComboBox.DataSource = Properties.Settings.Default.Instances;
                }
                instanceComboBox.SelectedItem = axInstance;

                pauseIndefinitelyCheckBox.Checked = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.IndefinitePause);

                if (Trigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl)Trigger;
                    simpleTriggerRadioButton.Checked = true;
                    hoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    minutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    startAtDateTimePicker.Value = localTrigger.StartTimeUtc.UtcDateTime.ToLocalTime();
                }
                else if (Trigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl)Trigger;
                    cronTriggerRadioButton.Checked = true;
                    cronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }

                retriesCountUpDown.Value = JobDetail.JobDataMap.GetInt(SettingsConstants.RetryCount);
                retriesDelayUpDown.Value = JobDetail.JobDataMap.GetInt(SettingsConstants.RetryDelay);

                pauseOnExceptionsCheckBox.Checked = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.PauseJobOnException);

                exportToPackageTextBox.Text = JobDetail.JobDataMap.GetString(SettingsConstants.ExportToPackageActionPath) ?? PackageApiActions.ExportToPackageActionPath;
                getExecutionSummaryStatusTextBox.Text = JobDetail.JobDataMap.GetString(SettingsConstants.GetExecutionSummaryStatusActionPath) ?? PackageApiActions.GetExecutionSummaryStatusActionPath;
                getExportedPackageUrlTextBox.Text = JobDetail.JobDataMap.GetString(SettingsConstants.GetExportedPackageUrlActionPath) ?? PackageApiActions.GetExportedPackageUrlActionPath;

                verboseLoggingCheckBox.Checked = JobDetail.JobDataMap.GetBooleanValue(SettingsConstants.LogVerbose);

                Properties.Settings.Default.Save();
            }
            FormsHelper.SetDropDownsWidth(this);
        }

        private IJobDetail GetJobDetail()
        {
            var detail = JobBuilder
                .Create()
                .OfType(Type.GetType("RecurringIntegrationsScheduler.Job.Export,RecurringIntegrationsScheduler.Job.Export", true))
                .WithDescription(jobDescription.Text)
                .WithIdentity(new JobKey(jobName.Text, jobGroupComboBox.Text))
                .UsingJobData(GetJobDataMap())
                .Build();

            return detail;
        }

        private JobDataMap GetJobDataMap()
        {
            var instance = (Instance)instanceComboBox.SelectedItem;
            var user = (User)userComboBox.SelectedItem;
            var application = (AadApplication)appRegistrationComboBox.SelectedItem;

            var map = new JobDataMap
            {
                {SettingsConstants.DownloadSuccessDir, downloadFolder.Text},
                {SettingsConstants.DownloadErrorsDir, errorsFolder.Text},
                {SettingsConstants.AadTenant, instance.AadTenant},
                {SettingsConstants.AzureAuthEndpoint, instance.AzureAuthEndpoint},
                {SettingsConstants.AosUri, instance.AosUri},
                {SettingsConstants.UseADAL, instance.UseADAL},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked},
                {SettingsConstants.AadClientId, application.ClientId},
                {SettingsConstants.UnzipPackage, unzipCheckBox.Checked},
                {SettingsConstants.AddTimestamp, addTimestampCheckBox.Checked},
                {SettingsConstants.DeletePackage, deletePackageCheckBox.Checked},
                {SettingsConstants.DataProject, dataProject.Text},
                {SettingsConstants.Company, legalEntity.Text},
                {SettingsConstants.DelayBetweenFiles, delayBetweenAttemptsNumericUpDown.Value},
                {SettingsConstants.DelayBetweenStatusCheck, delayBetweenStatusCheckNumericUpDown.Value},
                {SettingsConstants.RetryCount, retriesCountUpDown.Value},
                {SettingsConstants.RetryDelay, retriesDelayUpDown.Value},
                {SettingsConstants.PauseJobOnException, pauseOnExceptionsCheckBox.Checked},
                {SettingsConstants.ExportToPackageActionPath, exportToPackageTextBox.Text},
                {SettingsConstants.GetExecutionSummaryStatusActionPath, getExecutionSummaryStatusTextBox.Text},
                {SettingsConstants.GetExportedPackageUrlActionPath, getExportedPackageUrlTextBox.Text},
                {SettingsConstants.IndefinitePause, pauseIndefinitelyCheckBox.Checked},
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

        private ITrigger GetTrigger(IJobDetail jobDetail)
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

            if (simpleTriggerRadioButton.Checked)
            {
                var minutes = hoursDateTimePicker.Value.Hour * 60;
                minutes += minutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartAt(startAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(cronExpressionTextBox.Text))
                    .StartNow()
                    .Build();
        }

        private bool ValidateJobSettings()
        {
            if (cronTriggerRadioButton.Checked)
            {
                var date = FormsHelper.GetScheduleForCron(cronExpressionTextBox.Text, DateTimeOffset.Now);
                if (date == DateTimeOffset.MinValue)
                    return false;
            }
            var message = new StringBuilder();

            if (string.IsNullOrEmpty(jobName.Text))
                message.AppendLine(Resources.Job_name_is_missing);

            if (string.IsNullOrEmpty(jobGroupComboBox.Text))
                message.AppendLine(Resources.Job_group_is_not_selected);

            if (string.IsNullOrEmpty(downloadFolder.Text))
                message.AppendLine(Resources.Download_folder_is_not_selected);

            if (string.IsNullOrEmpty(errorsFolder.Text))
                message.AppendLine(Resources.Download_errors_folder_is_not_selected);

            if ((instanceComboBox.SelectedItem == null) || string.IsNullOrEmpty(instanceComboBox.Text))
                message.AppendLine(Resources.Dynamics_instance_is_not_selected);

            if (userAuthRadioButton.Checked &&
                ((userComboBox.SelectedItem == null) || string.IsNullOrEmpty(userComboBox.Text)))
                message.AppendLine(Resources.User_is_not_selected);

            if ((appRegistrationComboBox.SelectedItem == null) || string.IsNullOrEmpty(appRegistrationComboBox.Text))
                message.AppendLine(Resources.AAD_client_application_is_not_selected);

            if (string.IsNullOrEmpty(dataProject.Text))
                message.AppendLine(Resources.Data_project_is_missing);

            if (string.IsNullOrEmpty(legalEntity.Text))
                message.AppendLine(Resources.Legal_entity_is_missing);

            if (string.IsNullOrEmpty(exportToPackageTextBox.Text))
                message.AppendLine(Resources.URL_for_ExportToPackage_action_is_missing);

            if (string.IsNullOrEmpty(getExecutionSummaryStatusTextBox.Text))
                message.AppendLine(Resources.URL_for_GetExecutionSummaryStatus_action_is_missing);

            if (string.IsNullOrEmpty(getExportedPackageUrlTextBox.Text))
                message.AppendLine(Resources.URL_for_GetExportedPackageUrl_action_is_missing);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Job_configuration_is_not_valid);

            return message.Length == 0;
        }

        #region FormEvents

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            FormsHelper.TrimTextBoxes(this);

            if (JobDetail == null)
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
            JobDetail = GetJobDetail();
            Trigger = GetTrigger(JobDetail);
            Close();
        }

        private void CalculateNextRunsButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();
            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(cronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = FormsHelper.GetScheduleForCron(cronExpressionTextBox.Text, time);
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

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            Close();
        }

        private void CronDocsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start("https://www.quartz-scheduler.net/documentation/quartz-3.x/tutorial/crontrigger.html");
        }

        private void CronmakerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start("http://www.cronmaker.com");
        }

        private void CronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            simpleTriggerJobGroupBox.Enabled = !cronTriggerRadioButton.Checked;
            cronTriggerGroupBox.Enabled = cronTriggerRadioButton.Checked;
        }

        private void DownloadFolder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (useStandardSubfolder.Checked)
                    errorsFolder.Text = Path.Combine(downloadFolder.Text, Properties.Settings.Default.DownloadErrorsFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Check_if_path + Environment.NewLine + ex.Message, Resources.Warning);
            }
        }

        private void DownloadFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                downloadFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void ErrorsFolderBrowserButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                errorsFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void MoreExamplesButton_Click(object sender, EventArgs e)
        {
            var form = new CronExamples();
            form.ShowDialog();
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

        private void UnzipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            addTimestampCheckBox.Enabled = unzipCheckBox.Checked;
            deletePackageCheckBox.Enabled = unzipCheckBox.Checked;
            if (!unzipCheckBox.Checked)
            {
                addTimestampCheckBox.Checked = unzipCheckBox.Checked;
                deletePackageCheckBox.Checked = unzipCheckBox.Checked;
            }
        }

        private void UseStandardSubfolder_CheckedChanged(object sender, EventArgs e)
        {
            if (useStandardSubfolder.Checked)
            {
                errorsFolder.Enabled = false;
                errorsFolder.Text = Path.Combine(downloadFolder.Text, Properties.Settings.Default.DownloadErrorsFolder);
                errorsFolderBrowserButton.Enabled = false;
            }
            else
            {
                errorsFolder.Enabled = true;
                errorsFolderBrowserButton.Enabled = true;
            }
        }

        #endregion
    }
}