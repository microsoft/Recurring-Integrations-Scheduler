/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using Quartz;
using RecurringIntegrationsScheduler.Common.Contracts;
using RecurringIntegrationsScheduler.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class MainForm : Form
    {
        private bool _privateScheduler;
        private bool _scheduleChanged;
        private JobKey _selectedJobKey;
        public MainForm()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
        }

        private void RefreshGrid()
        {
            try
            {
                if (Scheduler.Instance.GetScheduler() == null)
                    return;

                Cursor = Cursors.WaitCursor;

                var jobsTable = Scheduler.Instance.GetJobs();
                if (jobsTable == null) return;

                var jobsBindingSource = new BindingSource { DataSource = jobsTable };

                jobsDataGridView.AutoGenerateColumns = false;

                var primaryKey = new DataColumn[2];
                primaryKey[0] = jobsTable.Columns["JobName"];
                primaryKey[1] = jobsTable.Columns["JobGroup"];
                jobsTable.PrimaryKey = primaryKey;

                jobsDataGridView.DataSource = jobsTable;
                jobsDataGridView.DataSource = jobsBindingSource;
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, Resources.Unexpected_error);
            }
            finally
            {
                Cursor = Cursors.Default;
                saveScheduleButton.Enabled = jobsDataGridView.RowCount > 0;
                contextMenuStrip1.Enabled = jobsDataGridView.RowCount > 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var bHandled = false;

            if (keyData == Keys.F5)
            {
                RefreshGrid();
                bHandled = true;
            }
            return bHandled;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (Parameters form = new Parameters())
            {
                form.ShowDialog();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            using (AboutBox form = new AboutBox())
            {
                form.ShowDialog();
            }
        }

        private void JobsDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            deleteJobButton.Enabled = true;
            editJobButton.Enabled = true;
            pauseResumeDropDownButton.Enabled = true;
            instanceFilter.Enabled = true;
            jobNameFilter.Enabled = true;
        }

        private void DeleteJobButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = jobsDataGridView.Rows[jobsDataGridView.SelectedCells[0].RowIndex];
                var jobKey = new JobKey(Convert.ToString(selectedRow.Cells["JobName"].Value),
                                        Convert.ToString(selectedRow.Cells["JobGroup"].Value));

                if (Scheduler.Instance.GetScheduler().DeleteJob(jobKey).Result)
                {
                    _scheduleChanged = true;
                }
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void PauseJobButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = jobsDataGridView.Rows[jobsDataGridView.SelectedCells[0].RowIndex];
                var jobKey = new JobKey(Convert.ToString(selectedRow.Cells["JobName"].Value),
                                        Convert.ToString(selectedRow.Cells["JobGroup"].Value));

                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }
                scheduler.PauseJob(jobKey);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void ResumeJobButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = jobsDataGridView.Rows[jobsDataGridView.SelectedCells[0].RowIndex];
                var jobKey = new JobKey(Convert.ToString(selectedRow.Cells["JobName"].Value),
                                        Convert.ToString(selectedRow.Cells["JobGroup"].Value));

                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }
                scheduler.ResumeJob(jobKey);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void ConnectToServerButton_Click(object sender, EventArgs e)
        {
            using (var form = new Connect())
            {
                form.ShowDialog();
                if (!form.Cancelled)
                {
                    try
                    {
                        Scheduler.Instance.Connect(form.Server, form.Port, form.Scheduler);

                        if (Scheduler.Instance.GetScheduler() != null)
                        {
                            toolStripConnectionStatus.Text =
                                string.Format(Resources.Connected_to,
                                              Scheduler.Instance.Address);
                            connectToServerButton.Enabled = false;
                            privateSchedulerButton.Enabled = false;
                            addDownloadJobMenuItem.Enabled = true;
                            addUploadJobMenuItem.Enabled = true;
                            addImportJobMenuItem.Enabled = true;
                            addExportJobMenuItem.Enabled = true;
                            refreshButton.Enabled = true;

                            RefreshGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            string.Format(
                                        Resources.Unable_to_connect_to_scheduler,
                                        form.Scheduler,
                                        form.Server,
                                        form.Port)
                                        );
                    }
                }
            }
        }

        private void SaveStandaloneSchedule()
        {
            try
            {
                var standaloneSchedulePath = Path.Combine(Directory.GetCurrentDirectory(),
                                                "Standalone_schedule.xml");
                var file = new FileInfo(standaloneSchedulePath);

                Scheduler.Instance.BackupToFile(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void SaveScheduleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = Resources.Recurring_Integrations_Schedule_xml;
                    dialog.FileName = "Schedule";
                    dialog.DefaultExt = "xml";
                    dialog.AddExtension = true;

                    var defaultPath = Path.Combine(
                                                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                                                    "RecurringIntegrationsScheduler");
                    if (Directory.Exists(defaultPath))
                    {
                        dialog.InitialDirectory = defaultPath;
                        dialog.RestoreDirectory = true;
                    }

                    dialog.ShowDialog();
                    if (string.IsNullOrEmpty(dialog.FileName)) return;

                    var file = new FileInfo(dialog.FileName);
                    if (file.Exists)
                    {
                        File.Move(file.FullName,
                            file.FullName.Replace(".xml", "-Backup-" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".xml"));
                    }

                    Scheduler.Instance.BackupToFile(file);
                    _scheduleChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void PrivateSchedulerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Scheduler.Instance.Connect();
                if (Scheduler.Instance.GetScheduler() != null)
                {
                    Scheduler.Instance.GetScheduler().Start().Wait();
                    toolStripConnectionStatus.Text = Resources.Connected_to_standalone_scheduler;
                    connectToServerButton.Enabled = false;
                    privateSchedulerButton.Enabled = false;
                    addDownloadJobMenuItem.Enabled = true;
                    addUploadJobMenuItem.Enabled = true;
                    addImportJobMenuItem.Enabled = true;
                    addExportJobMenuItem.Enabled = true;
                    refreshButton.Enabled = true;

                    RefreshGrid();
                    _privateScheduler = true;
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message, Resources.Unable_to_create_standalone_scheduler);
            }
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_privateScheduler)
            {
                SaveStandaloneSchedule();

                var executing = Scheduler.Instance.GetScheduler().GetCurrentlyExecutingJobs().Result;
                if (executing.Count > 0)
                {
                    var result =
                        MessageBox.Show(
                            Resources.Jobs_are_still_running_Are_you_sure_You_want_to_exit_Jobs_will_be_terminated,
                            Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                    Scheduler.Instance.GetScheduler().Shutdown().Wait();
                }
                else
                {
                    Scheduler.Instance.GetScheduler().Shutdown().Wait();
                }
            }
            else
            {
                if (!_scheduleChanged) return;

                var result = MessageBox.Show(
                    string.Format(Resources.You_have_changed_the_schedule, Environment.NewLine), Resources.Warning,
                    MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                    SaveScheduleButton_Click(null, null);
            }
        }

        private void EditJob()
        {
            try
            {
                var jobName = jobsDataGridView.SelectedRows[0].Cells["JobName"].Value.ToString();
                var jobGroup = jobsDataGridView.SelectedRows[0].Cells["JobGroup"].Value.ToString();
                var jobKey = new JobKey(jobName, jobGroup);

                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }

                var jobDetail = scheduler.GetJobDetail(jobKey).Result;
                var jobTrigger = scheduler.GetTriggersOfJob(jobKey).Result.First();
                switch (jobDetail.JobType.FullName)
                {
                    case SettingsConstants.DownloadJob:
                        using (DownloadJob downloadForm = new DownloadJob
                        {
                            JobDetail = jobDetail,
                            Trigger = jobTrigger
                        })
                        {
                            downloadForm.ShowDialog();

                            if (!downloadForm.Cancelled && (downloadForm.JobDetail != null) &&
                                (downloadForm.Trigger != null))
                            {
                                scheduler.ScheduleJob(
                                    downloadForm.JobDetail, new HashSet<ITrigger> { downloadForm.Trigger }, true);

                                RefreshGrid();
                            }
                        }
                        break;

                    case SettingsConstants.ExportJob:
                        using (ExportJob exportForm = new ExportJob
                        {
                            JobDetail = jobDetail,
                            Trigger = jobTrigger
                        })
                        {
                            exportForm.ShowDialog();

                            if (!exportForm.Cancelled && (exportForm.JobDetail != null) &&
                                (exportForm.Trigger != null))
                            {
                                scheduler.ScheduleJob(
                                    exportForm.JobDetail, new HashSet<ITrigger> { exportForm.Trigger }, true);

                                RefreshGrid();
                            }
                        }
                        break;

                    case SettingsConstants.UploadJob:
                        //find related processing job
                        var processingJobName = jobDetail.Key.Name + "-Processing monitor";
                        var processingJobKey = new JobKey(processingJobName, jobDetail.Key.Group);
                        var processingJobDetail = scheduler.GetJobDetail(processingJobKey).Result;
                        ITrigger processingJobTrigger = null;

                        if (processingJobDetail != null)
                        {
                            processingJobTrigger = scheduler.GetTriggersOfJob(processingJobKey).Result.First();
                        }

                        using (UploadJob uploadForm = new UploadJob
                        {
                            UploadJobDetail = jobDetail,
                            UploadTrigger = jobTrigger
                        })
                        {
                            if ((processingJobDetail != null) && (processingJobTrigger != null))
                            {
                                uploadForm.ProcessingJobDetail = processingJobDetail;
                                uploadForm.ProcessingTrigger = processingJobTrigger;
                            }

                            uploadForm.ShowDialog();
                            if (!uploadForm.Cancelled && (uploadForm.UploadJobDetail != null) &&
                                (uploadForm.UploadTrigger != null))
                            {
                                scheduler.ScheduleJob(
                                    uploadForm.UploadJobDetail, new HashSet<ITrigger> { uploadForm.UploadTrigger }, true);

                                if ((uploadForm.ProcessingJobDetail != null) && (uploadForm.ProcessingTrigger != null))
                                {
                                    scheduler.ScheduleJob(
                                        uploadForm.ProcessingJobDetail, new HashSet<ITrigger> { uploadForm.ProcessingTrigger }, true);
                                }

                                RefreshGrid();
                            }
                        }
                        break;

                    case SettingsConstants.ImportJob:
                        //find related execution job
                        var executionJobName = jobDetail.Key.Name + "-Execution monitor";
                        var executionJobKey = new JobKey(executionJobName, jobDetail.Key.Group);
                        var executionJobDetail = scheduler.GetJobDetail(executionJobKey).Result;
                        ITrigger executionJobTrigger = null;

                        if (executionJobDetail != null)
                        {
                            executionJobTrigger = scheduler.GetTriggersOfJob(executionJobKey).Result.First();
                        }

                        using (ImportJob importForm = new ImportJob
                        {
                            ImportJobDetail = jobDetail,
                            ImportTrigger = jobTrigger
                        })
                        {
                            if ((executionJobDetail != null) && (executionJobTrigger != null))
                            {
                                importForm.ExecutionJobDetail = executionJobDetail;
                                importForm.ExecutionTrigger = executionJobTrigger;
                            }

                            importForm.ShowDialog();
                            if (!importForm.Cancelled && (importForm.ImportJobDetail != null) &&
                                (importForm.ImportTrigger != null))
                            {
                                scheduler.ScheduleJob(
                                    importForm.ImportJobDetail, new HashSet<ITrigger> { importForm.ImportTrigger }, true);

                                if ((importForm.ExecutionJobDetail != null) && (importForm.ExecutionTrigger != null))
                                {
                                    scheduler.ScheduleJob(
                                        importForm.ExecutionJobDetail, new HashSet<ITrigger> { importForm.ExecutionTrigger }, true);
                                }

                                RefreshGrid();
                            }
                        }
                        break;

                    case SettingsConstants.ProcessingJob:
                        MessageBox.Show(Resources.Processing_monitoring_job_is_not_supported);
                        break;
                    default:
                        MessageBox.Show(Resources.This_type_of_job_is_not_supported_for_direct_editing);
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void JobsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditJob();
        }

        private void EditJobButton_Click(object sender, EventArgs e)
        {
            EditJob();
        }

        private void JobsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (jobsDataGridView.Rows[e.RowIndex].Cells[@"JobType"].Value.ToString())
            {
                case @"Download":
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#9ABD97"); //dark sea green
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#475657");//davy's grey
                    break;
                case @"Upload":
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#E8D8CD");//bone
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#475657");//davy's grey
                    break;
                case @"ProcessingMonitor":
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#BAADA4");//silver pink
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#475657");//davy's grey
                    break;
                case @"Import":
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#F1F7ED");//isabelline
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#475657");//davy's grey
                    break;
                case @"Export":
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#A6D8D4");//pale robin egg blue
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#475657");//davy's grey
                    break;
                case @"ExecutionMonitor":
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#B0B4AD");//silver chalice
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#475657");//davy's grey
                    break;
                default:
                    e.CellStyle.BackColor = ColorTranslator.FromHtml("#EDEDED");
                    e.CellStyle.SelectionBackColor = ColorTranslator.FromHtml("#475657");//davy's grey
                    return;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void JobsDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hitTestInfo = jobsDataGridView.HitTest(e.X, e.Y);
                if (hitTestInfo.ColumnIndex != -1 && hitTestInfo.RowIndex != -1)
                {
                    jobsDataGridView.CurrentCell = jobsDataGridView[hitTestInfo.ColumnIndex, hitTestInfo.RowIndex];
                    jobsDataGridView.ContextMenuStrip.Opening += (s, i) =>
                    {
                        if (jobsDataGridView.CurrentCell == null)
                            i.Cancel = true;
                        else
                        {
                            i.Cancel = false;
                            SetContextMenuItems(hitTestInfo.RowIndex);
                            contextMenuStrip1.Show(jobsDataGridView, new Point(e.X, e.Y));
                        }
                    };
                }
            }
        }

        private void SetContextMenuItems(int rowIndex)
        {
            try
            {
                var jobName = jobsDataGridView.Rows[rowIndex].Cells["JobName"].Value.ToString();
                var jobGroup = jobsDataGridView.Rows[rowIndex].Cells["JobGroup"].Value.ToString();
                _selectedJobKey = new JobKey(jobName, jobGroup);

                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }

                var jobDetail = scheduler.GetJobDetail(_selectedJobKey).Result;

                switch (jobDetail.JobType.FullName)
                {
                    case SettingsConstants.DownloadJob:
                    case SettingsConstants.ExportJob:
                        openFailedProcessingFolderToolStripMenuItem.Visible = false;
                        openFailedUploadsFolderToolStripMenuItem.Visible = false;
                        openInputFolderToolStripMenuItem.Visible = false;
                        openSuccessfulProcessingFolderToolStripMenuItem.Visible = false;
                        openSuccessfulUploadsFolderToolStripMenuItem.Visible = false;
                        openSuccessfulDownloadsFolderToolStripMenuItem.Visible = true;
                        break;
                    case SettingsConstants.UploadJob:
                    case SettingsConstants.ImportJob:
                        openFailedProcessingFolderToolStripMenuItem.Visible = false;
                        openSuccessfulDownloadsFolderToolStripMenuItem.Visible = false;
                        openSuccessfulProcessingFolderToolStripMenuItem.Visible = false;
                        openFailedUploadsFolderToolStripMenuItem.Visible = true;
                        openInputFolderToolStripMenuItem.Visible = true;
                        openSuccessfulUploadsFolderToolStripMenuItem.Visible = true;
                        break;
                    case SettingsConstants.ProcessingJob:
                    case SettingsConstants.ExecutionJob:
                        openFailedUploadsFolderToolStripMenuItem.Visible = false;
                        openInputFolderToolStripMenuItem.Visible = false;
                        openSuccessfulDownloadsFolderToolStripMenuItem.Visible = false;
                        openFailedProcessingFolderToolStripMenuItem.Visible = true;
                        openSuccessfulProcessingFolderToolStripMenuItem.Visible = true;
                        openSuccessfulUploadsFolderToolStripMenuItem.Visible = true;
                        break;
                    default:
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void PauseJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = jobsDataGridView.Rows[jobsDataGridView.SelectedCells[0].RowIndex];
                var jobKey = new JobKey(Convert.ToString(selectedRow.Cells["JobName"].Value),
                                        Convert.ToString(selectedRow.Cells["JobGroup"].Value));

                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }
                scheduler.PauseJob(jobKey);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void PauseAllJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }
                scheduler.PauseAll();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void ResumeJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = jobsDataGridView.Rows[jobsDataGridView.SelectedCells[0].RowIndex];
                var jobKey = new JobKey(Convert.ToString(selectedRow.Cells["JobName"].Value),
                                        Convert.ToString(selectedRow.Cells["JobGroup"].Value));

                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }
                scheduler.ResumeJob(jobKey);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void ResumeAllJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var scheduler = Scheduler.Instance.GetScheduler();
                if (scheduler == null)
                {
                    MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                    return;
                }
                scheduler.ResumeAll();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void InstanceFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void JobNameFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var bd = (BindingSource)jobsDataGridView.DataSource;
            var dt = (DataTable)bd.DataSource;
            dt.DefaultView.RowFilter = string.Empty;
            if (instanceFilter.Text != string.Empty && jobNameFilter.Text == string.Empty)
            {
                dt.DefaultView.RowFilter = $"Instance like '%{instanceFilter.Text}%'";
            }
            else if (instanceFilter.Text == string.Empty && jobNameFilter.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = $"JobName like '%{jobNameFilter.Text}%'";
            }
            else if (instanceFilter.Text != string.Empty && jobNameFilter.Text != string.Empty)
            {
                dt.DefaultView.RowFilter = $"Instance like '%{instanceFilter.Text}%' and JobName like '%{jobNameFilter.Text}%'";
            }
            jobsDataGridView.Refresh();
            if (jobsDataGridView.RowCount == 0)
            {
                deleteJobButton.Enabled = false;
                editJobButton.Enabled = false;
                pauseResumeDropDownButton.Enabled = false;
            }
        }

        private void OpenSuccessfulDownloadsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scheduler = Scheduler.Instance.GetScheduler();
            var jobDetail = scheduler.GetJobDetail(_selectedJobKey).Result;
            var path = jobDetail.JobDataMap[SettingsConstants.DownloadSuccessDir]?.ToString();
            if (!String.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Unexpected_error);
                }
            }
            else
            {
                MessageBox.Show(Resources.Path_doesnot_exist_or_is_unaccessible, Resources.Unexpected_error);
            }
        }

        private void OpenFailedProcessingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scheduler = Scheduler.Instance.GetScheduler();
            var jobDetail = scheduler.GetJobDetail(_selectedJobKey).Result;
            var path = jobDetail.JobDataMap[SettingsConstants.ProcessingErrorsDir]?.ToString();
            if (!String.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Unexpected_error);
                }
            }
            else
            {
                MessageBox.Show(Resources.Path_doesnot_exist_or_is_unaccessible, Resources.Unexpected_error);
            }
        }

        private void OpenSuccessfulProcessingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scheduler = Scheduler.Instance.GetScheduler();
            var jobDetail = scheduler.GetJobDetail(_selectedJobKey).Result;
            var path = jobDetail.JobDataMap[SettingsConstants.ProcessingSuccessDir]?.ToString();
            if (!String.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Unexpected_error);
                }
            }
            else
            {
                MessageBox.Show(Resources.Path_doesnot_exist_or_is_unaccessible, Resources.Unexpected_error);
            }
        }

        private void OpenFailedUploadsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scheduler = Scheduler.Instance.GetScheduler();
            var jobDetail = scheduler.GetJobDetail(_selectedJobKey).Result;
            var path = jobDetail.JobDataMap[SettingsConstants.UploadErrorsDir]?.ToString();
            if (!String.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Unexpected_error);
                }
            }
            else
            {
                MessageBox.Show(Resources.Path_doesnot_exist_or_is_unaccessible, Resources.Unexpected_error);
            }
        }

        private void OpenSuccessfulUploadsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scheduler = Scheduler.Instance.GetScheduler();
            var jobDetail = scheduler.GetJobDetail(_selectedJobKey).Result;
            var path = jobDetail.JobDataMap[SettingsConstants.UploadSuccessDir]?.ToString();
            if (!String.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Unexpected_error);
                }
            }
            else
            {
                MessageBox.Show(Resources.Path_doesnot_exist_or_is_unaccessible, Resources.Unexpected_error);
            }
        }

        private void OpenInputFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scheduler = Scheduler.Instance.GetScheduler();
            var jobDetail = scheduler.GetJobDetail(_selectedJobKey).Result;
            var path = jobDetail.JobDataMap[SettingsConstants.InputDir]?.ToString();
            if (!String.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                try
                {
                    Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.Unexpected_error);
                }
            }
            else
            {
                MessageBox.Show(Resources.Path_doesnot_exist_or_is_unaccessible, Resources.Unexpected_error);
            }
        }

        private void AddUploadJobMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (UploadJob form = new UploadJob())
                {
                    form.ShowDialog();
                    if (form.Cancelled || (form.UploadJobDetail == null) || (form.UploadTrigger == null)) return;

                    var scheduler = Scheduler.Instance.GetScheduler();
                    if (scheduler == null)
                    {
                        MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                        return;
                    }

                    scheduler.ScheduleJob(
                        form.UploadJobDetail, new HashSet<ITrigger> { form.UploadTrigger }, true);

                    if ((form.ProcessingJobDetail != null) && (form.ProcessingTrigger != null))
                    {
                        scheduler.ScheduleJob(
                            form.ProcessingJobDetail, new HashSet<ITrigger> { form.ProcessingTrigger }, true);
                    }
                    _scheduleChanged = true;
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void AddExportJobMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExportJob form = new ExportJob())
                {
                    form.ShowDialog();

                    if (!form.Cancelled && (form.JobDetail != null) && (form.Trigger != null))
                    {
                        Scheduler.Instance.GetScheduler()
                            .ScheduleJob(form.JobDetail, new HashSet<ITrigger> { form.Trigger }, true);

                        _scheduleChanged = true;
                        RefreshGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void AddImportJobMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (ImportJob form = new ImportJob())
                {
                    form.ShowDialog();
                    if (form.Cancelled || (form.ImportJobDetail == null) || (form.ImportTrigger == null)) return;

                    var scheduler = Scheduler.Instance.GetScheduler();
                    if (scheduler == null)
                    {
                        MessageBox.Show(Resources.No_active_scheduler, Resources.Missing_scheduler);
                        return;
                    }

                    scheduler.ScheduleJob(
                        form.ImportJobDetail, new HashSet<ITrigger> { form.ImportTrigger }, true);

                    if ((form.ExecutionJobDetail != null) && (form.ExecutionTrigger != null))
                    {
                        scheduler.ScheduleJob(
                            form.ExecutionJobDetail, new HashSet<ITrigger> { form.ExecutionTrigger }, true);
                    }
                    _scheduleChanged = true;
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }

        private void AddDownloadJobMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (DownloadJob form = new DownloadJob())
                {
                    form.ShowDialog();

                    if (!form.Cancelled && (form.JobDetail != null) && (form.Trigger != null))
                    {
                        Scheduler.Instance.GetScheduler()
                            .ScheduleJob(form.JobDetail, new HashSet<ITrigger> { form.Trigger }, true);

                        _scheduleChanged = true;
                        RefreshGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.Unexpected_error);
            }
        }
    }
}