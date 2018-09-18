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
    public partial class DownloadJob : Form
    {
        private const int CpNocloseButton = 0x200;

        public DownloadJob()
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
        public IJobDetail JobDetail { get; set; }
        public ITrigger Trigger { get; set; }

        private void DownloadJobForm_Load(object sender, EventArgs e)
        {
            Cancelled = false;
            //Few changes based on form mode (create or edit)
            Text = JobDetail == null
                ? Resources.Add_download_job
                : string.Format(Resources.Edit_job_0, JobDetail.Key.Name);
            addJobButton.Text = JobDetail == null ? Resources.Add_to_schedule : Resources.Edit_job;
            jobName.Enabled = JobDetail == null;

            jobGroupComboBox.DataSource = Properties.Settings.Default.JobGroups;
            jobGroupComboBox.ValueMember = null;
            jobGroupComboBox.DisplayMember = "Name";

            jobGroupComboBox.Enabled = JobDetail == null;

            instanceComboBox.DataSource = Properties.Settings.Default.Instances;
            instanceComboBox.ValueMember = null;
            instanceComboBox.DisplayMember = "Name";

            var dataJobs = Properties.Settings.Default.DataJobs.Where(x => x.Type == DataJobType.Download);
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

            startAtDateTimePicker.Value = DateTime.Now;

            errorsFolder.Text = Properties.Settings.Default.DownloadErrorsFolder;

            if ((JobDetail != null) && (Trigger != null))
            {
                jobName.Text = JobDetail.Key.Name;

                var jobGroup =
                    ((IEnumerable<JobGroup>) jobGroupComboBox.DataSource).FirstOrDefault(
                        x => x.Name == JobDetail.Key.Group);
                jobGroupComboBox.SelectedItem = jobGroup;

                jobDescription.Text = JobDetail.Description;

                downloadFolder.Text = JobDetail.JobDataMap[SettingsConstants.DownloadSuccessDir]?.ToString() ??
                                      string.Empty;
                errorsFolder.Text = JobDetail.JobDataMap[SettingsConstants.DownloadErrorsDir]?.ToString() ??
                                    string.Empty;
                useStandardSubfolder.Checked = false;

                unzipCheckBox.Checked = (JobDetail.JobDataMap[SettingsConstants.UnzipPackage] != null) &&
                                        Convert.ToBoolean(
                                            JobDetail.JobDataMap[SettingsConstants.UnzipPackage].ToString());
                addTimestampCheckBox.Checked = (JobDetail.JobDataMap[SettingsConstants.AddTimestamp] != null) &&
                                               Convert.ToBoolean(
                                                   JobDetail.JobDataMap[SettingsConstants.AddTimestamp].ToString());
                deletePackageCheckBox.Checked = (JobDetail.JobDataMap[SettingsConstants.DeletePackage] != null) &&
                                                Convert.ToBoolean(
                                                    JobDetail.JobDataMap[SettingsConstants.DeletePackage].ToString());
                serviceAuthRadioButton.Checked = (JobDetail.JobDataMap[SettingsConstants.UseServiceAuthentication] !=
                                                  null) &&
                                                 Convert.ToBoolean(
                                                     JobDetail.JobDataMap[SettingsConstants.UseServiceAuthentication]
                                                         .ToString());

                if (!serviceAuthRadioButton.Checked)
                {
                    User axUser = null;
                    if (JobDetail.JobDataMap[SettingsConstants.UserName] != null)
                        axUser =
                            ((IEnumerable<User>) userComboBox.DataSource).FirstOrDefault(
                                x => x.Login == JobDetail.JobDataMap[SettingsConstants.UserName].ToString());
                    if (axUser == null)
                    {
                        var userName = JobDetail.JobDataMap[SettingsConstants.UserName];
                        if (userName != null)
                            axUser = new User
                            {
                                Login = userName.ToString(),
                                Password = JobDetail.JobDataMap[SettingsConstants.UserPassword].ToString()
                            };
                        var disabledUser = new Users {axUser};
                        userComboBox.DataSource = disabledUser;
                        userComboBox.Enabled = false;
                    }
                    userComboBox.SelectedItem = axUser;
                }
                var application =
                    ((IEnumerable<AadApplication>) aadApplicationComboBox.DataSource).FirstOrDefault(app =>
                            app.ClientId == JobDetail.JobDataMap[SettingsConstants.AadClientId].ToString());
                if (application == null)
                    if (JobDetail.JobDataMap[SettingsConstants.AadClientSecret] == null)
                    {
                        application = new AadApplication
                        {
                            ClientId = JobDetail.JobDataMap[SettingsConstants.AadClientId].ToString(),
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
                            ClientId = JobDetail.JobDataMap[SettingsConstants.AadClientId].ToString(),
                            Secret = JobDetail.JobDataMap[SettingsConstants.AadClientSecret].ToString(),
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
                        dj => dj.ActivityId == JobDetail.JobDataMap[SettingsConstants.ActivityId].ToString());
                if (dataJob == null)
                {
                    dataJob = new DataJob
                    {
                        ActivityId = JobDetail.JobDataMap[SettingsConstants.ActivityId].ToString(),
                        Type = DataJobType.Download,
                        Name = Resources.IMPORTED_CHANGE_THIS
                    };
                    Properties.Settings.Default.DataJobs.Add(dataJob);
                    dataJobs = Properties.Settings.Default.DataJobs.Where(x => x.Type == DataJobType.Download);
                    dataJobsBindingList = new BindingList<DataJob>(dataJobs.ToList());
                    dataJobComboBox.DataSource = dataJobsBindingList;
                    dataJobComboBox.ValueMember = null;
                    dataJobComboBox.DisplayMember = "Name";
                }
                dataJobComboBox.SelectedItem = dataJob;

                var axInstance = ((IEnumerable<Instance>) instanceComboBox.DataSource).FirstOrDefault(x =>
                    (x.AosUri == JobDetail.JobDataMap[SettingsConstants.AosUri].ToString()) &&
                    (x.AadTenant == JobDetail.JobDataMap[SettingsConstants.AadTenant].ToString()) &&
                    (x.AzureAuthEndpoint == JobDetail.JobDataMap[SettingsConstants.AzureAuthEndpoint].ToString()));
                if (axInstance == null)
                {
                    axInstance = new Instance
                    {
                        AosUri = JobDetail.JobDataMap[SettingsConstants.AosUri].ToString(),
                        AadTenant = JobDetail.JobDataMap[SettingsConstants.AadTenant].ToString(),
                        AzureAuthEndpoint = JobDetail.JobDataMap[SettingsConstants.AzureAuthEndpoint].ToString(),
                        Name = Resources.IMPORTED_CHANGE_THIS
                    };
                    Properties.Settings.Default.Instances.Add(axInstance);
                }
                instanceComboBox.SelectedItem = axInstance;

                pauseIndefinitelyCheckBox.Checked =
                    (JobDetail.JobDataMap[SettingsConstants.IndefinitePause] != null) &&
                    Convert.ToBoolean(JobDetail.JobDataMap[SettingsConstants.IndefinitePause].ToString());

                if (Trigger.GetType() == typeof(SimpleTriggerImpl))
                {
                    var localTrigger = (SimpleTriggerImpl) Trigger;
                    simpleTriggerRadioButton.Checked = true;
                    hoursDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                    minutesDateTimePicker.Value = DateTime.Now.Date + localTrigger.RepeatInterval;
                }
                else if (Trigger.GetType() == typeof(CronTriggerImpl))
                {
                    var localTrigger = (CronTriggerImpl) Trigger;
                    cronTriggerRadioButton.Checked = true;
                    cronExpressionTextBox.Text = localTrigger.CronExpressionString;
                }
                if(JobDetail.JobDataMap[SettingsConstants.RetryCount] != null)
                {
                    retriesCountUpDown.Value = Convert.ToDecimal(JobDetail.JobDataMap[SettingsConstants.RetryCount]);
                }
                if(JobDetail.JobDataMap[SettingsConstants.RetryDelay] != null)
                {
                    retriesDelayUpDown.Value = Convert.ToDecimal(JobDetail.JobDataMap[SettingsConstants.RetryDelay]);
                }
                pauseOnExceptionsCheckBox.Checked =
                    (JobDetail.JobDataMap[SettingsConstants.PauseJobOnException] != null) &&
                    Convert.ToBoolean(JobDetail.JobDataMap[SettingsConstants.PauseJobOnException].ToString());

                Properties.Settings.Default.Save();
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

        private void CronmakerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cronmakerLinkLabel.LinkVisited = true;
            Process.Start("http://www.cronmaker.com");
        }

        private void CronTriggerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            hoursDateTimePicker.Enabled = !cronTriggerRadioButton.Checked;
            minutesDateTimePicker.Enabled = !cronTriggerRadioButton.Checked;
            startAtDateTimePicker.Enabled = !cronTriggerRadioButton.Checked;
            cronExpressionTextBox.Enabled = cronTriggerRadioButton.Checked;
            calculateNextRunsButton.Enabled = cronTriggerRadioButton.Checked;
        }

        private void AddJobButton_Click(object sender, EventArgs e)
        {
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

        private bool ValidateJobSettings()
        {
            if (cronTriggerRadioButton.Checked)
            {
                var date = GetScheduleForCron(cronExpressionTextBox.Text, DateTimeOffset.Now);
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

            if ((aadApplicationComboBox.SelectedItem == null) || string.IsNullOrEmpty(aadApplicationComboBox.Text))
                message.AppendLine(Resources.AAD_client_application_is_not_selected);

            if ((dataJobComboBox.SelectedItem == null) || string.IsNullOrEmpty(dataJobComboBox.Text))
                message.AppendLine(Resources.Data_job_is_not_selected);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Job_configuration_is_not_valid);

            return message.Length == 0;
        }

        private IJobDetail GetJobDetail()
        {
            var detail = JobBuilder
                .Create()
                .OfType(Type.GetType("RecurringIntegrationsScheduler.Job.Download,RecurringIntegrationsScheduler.Job.Download", true))
                .WithDescription(jobDescription.Text)
                .WithIdentity(new JobKey(jobName.Text, jobGroupComboBox.Text))
                .UsingJobData(GetJobDataMap())
                .Build();

            return detail;
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
                var minutes = hoursDateTimePicker.Value.Hour*60;
                minutes = minutes + minutesDateTimePicker.Value.Minute;

                return builder.WithSimpleSchedule(x => x
                        .WithIntervalInMinutes(minutes)
                        .RepeatForever())
                    .StartNow()
                    .Build();
            }
            return
                builder.WithSchedule(CronScheduleBuilder.CronSchedule(cronExpressionTextBox.Text))
                    .StartAt(startAtDateTimePicker.Value.ToUniversalTime())
                    .Build();
        }

        private JobDataMap GetJobDataMap()
        {
            var dataJob = (DataJob) dataJobComboBox.SelectedItem;
            var instance = (Instance) instanceComboBox.SelectedItem;
            var user = (User) userComboBox.SelectedItem;
            var application = (AadApplication) aadApplicationComboBox.SelectedItem;

            var map = new JobDataMap
            {
                {SettingsConstants.DownloadSuccessDir, downloadFolder.Text},
                {SettingsConstants.DownloadErrorsDir, errorsFolder.Text},
                {SettingsConstants.AadTenant, instance.AadTenant},
                {SettingsConstants.AzureAuthEndpoint, instance.AzureAuthEndpoint},
                {SettingsConstants.AosUri, instance.AosUri},
                {SettingsConstants.ActivityId, dataJob.ActivityId},
                {SettingsConstants.UseServiceAuthentication, serviceAuthRadioButton.Checked.ToString()},
                {SettingsConstants.AadClientId, application.ClientId},
                {SettingsConstants.UnzipPackage, unzipCheckBox.Checked.ToString()},
                {SettingsConstants.AddTimestamp, addTimestampCheckBox.Checked.ToString()},
                {SettingsConstants.DeletePackage, deletePackageCheckBox.Checked.ToString()},
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

        private void CalculateNextRunsButton_Click(object sender, EventArgs e)
        {
            var scheduleTimes = new List<DateTimeOffset>();

            var time = DateTimeOffset.Now;

            if (!string.IsNullOrEmpty(cronExpressionTextBox.Text))
                for (var i = 0; i <= 99; i++)
                {
                    var date = GetScheduleForCron(cronExpressionTextBox.Text, time);
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