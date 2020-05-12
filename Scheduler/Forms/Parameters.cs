/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using RecurringIntegrationsScheduler.Common.Helpers;
using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.JobGroups = (JobGroups) jobGroupsGrid.DataSource;
            Properties.Settings.Default.Users = (Users) usersDataGrid.DataSource;
            Properties.Settings.Default.Instances = (Instances) instancesGrid.DataSource;
            Properties.Settings.Default.DataJobs = (DataJobs) dataJobsGrid.DataSource;
            Properties.Settings.Default.AadApplications = (AadApplications) applicationsGrid.DataSource;
            Properties.Settings.Default.ProcessingErrorsFolder = processingErrorsFolder.Text;
            Properties.Settings.Default.ProcessingSuccessFolder = processingSuccessFolder.Text;
            Properties.Settings.Default.DownloadErrorsFolder = downloadErrorsFolder.Text;
            Properties.Settings.Default.UploadErrorsFolder = uploadErrorsFolder.Text;
            Properties.Settings.Default.UploadInputFolder = uploadInputFolder.Text;
            Properties.Settings.Default.UploadSuccessFolder = uploadSuccessFolder.Text;
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UpdateSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpdateSettings = false;
                Properties.Settings.Default.Save();
            }
            jobGroupsGrid.DataSource = Properties.Settings.Default.JobGroups;
            dataJobsGrid.DataSource = Properties.Settings.Default.DataJobs;
            instancesGrid.DataSource = Properties.Settings.Default.Instances;
            applicationsGrid.DataSource = Properties.Settings.Default.AadApplications;
            usersDataGrid.DataSource = Properties.Settings.Default.Users;
            processingErrorsFolder.Text = Properties.Settings.Default.ProcessingErrorsFolder;
            processingSuccessFolder.Text = Properties.Settings.Default.ProcessingSuccessFolder;
            downloadErrorsFolder.Text = Properties.Settings.Default.DownloadErrorsFolder;
            uploadErrorsFolder.Text = Properties.Settings.Default.UploadErrorsFolder;
            uploadInputFolder.Text = Properties.Settings.Default.UploadInputFolder;
            uploadSuccessFolder.Text = Properties.Settings.Default.UploadSuccessFolder;
        }

        private void InstancesDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if ((instancesGrid.RowCount != 0) && (instancesGrid.SelectedRows.Count != 0)) return;
            instancesDeleteButton.Enabled = false;
            instancesValidateButton.Enabled = false;
            instancesEditButton.Enabled = false;
        }

        private void InstancesDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            instancesDeleteButton.Enabled = true;
            instancesValidateButton.Enabled = true;
            instancesEditButton.Enabled = true;
        }

        private void AxInstancesAddButton_Click(object sender, EventArgs e)
        {
            var form = new InstanceForm();
            if (form.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.Instances.Add(form.Instance);
        }

        private void AxInstancesDeleteButton_Click(object sender, EventArgs e)
        {
            if (instancesGrid.SelectedRows.Count > 0)
                instancesGrid.Rows.RemoveAt(instancesGrid.SelectedRows[0].Index);
        }

        private void UsersDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if ((usersDataGrid.RowCount != 0) && (usersDataGrid.SelectedRows.Count != 0)) return;
            usersDeleteButton.Enabled = false;
            usersEditButton.Enabled = false;
        }

        private void UsersDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            usersDeleteButton.Enabled = true;
            usersEditButton.Enabled = true;
        }

        private void UsersAddButton_Click(object sender, EventArgs e)
        {
            using UserForm form = new UserForm();
            if (form.ShowDialog() != DialogResult.OK) return;
            var axUser = form.User;
            if (axUser != null)
                axUser.Password = EncryptDecrypt.Encrypt(axUser.Password);
            Properties.Settings.Default.Users.Add(axUser);
        }

        private void UsersDeleteButton_Click(object sender, EventArgs e)
        {
            if (usersDataGrid.SelectedRows.Count > 0)
                usersDataGrid.Rows.RemoveAt(usersDataGrid.SelectedRows[0].Index);
        }

        private void DataJobsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if ((dataJobsGrid.RowCount != 0) && (dataJobsGrid.SelectedRows.Count != 0)) return;
            dataJobsDeleteButton.Enabled = false;
            dataJobsEditButton.Enabled = false;
        }

        private void DataJobsDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            dataJobsDeleteButton.Enabled = true;
            dataJobsEditButton.Enabled = true;
        }

        private void DataJobsAddButton_Click(object sender, EventArgs e)
        {
            using DataJobForm form = new DataJobForm();
            if (form.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.DataJobs.Add(form.DataJob);
        }

        private void DataJobsDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataJobsGrid.SelectedRows.Count > 0)
                dataJobsGrid.Rows.RemoveAt(dataJobsGrid.SelectedRows[0].Index);
        }

        private void JobGroupsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if ((jobGroupsGrid.RowCount != 0) && (jobGroupsGrid.SelectedRows.Count != 0)) return;
            jobGroupsDeleteButton.Enabled = false;
            jobGroupsEditButton.Enabled = false;
        }

        private void JobGroupsDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            jobGroupsDeleteButton.Enabled = true;
            jobGroupsEditButton.Enabled = true;
        }

        private void JobGroupsAddButton_Click(object sender, EventArgs e)
        {
            using JobGroupForm form = new JobGroupForm();
            if (form.ShowDialog() == DialogResult.OK)
                Properties.Settings.Default.JobGroups.Add(form.JobGroup);
        }

        private void JobGroupsDeleteButton_Click(object sender, EventArgs e)
        {
            if (jobGroupsGrid.SelectedRows.Count > 0)
                jobGroupsGrid.Rows.RemoveAt(jobGroupsGrid.SelectedRows[0].Index);
        }

        private void InstancesValidateButton_Click(object sender, EventArgs e)
        {
            using ValidateConnection form = new ValidateConnection { Instance = (Instance)instancesGrid.SelectedRows[0].DataBoundItem };
            form.ShowDialog();
        }

        private void InstancesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (instancesGrid.SelectedRows.Count != 0) return;
            instancesDeleteButton.Enabled = false;
            instancesValidateButton.Enabled = false;
            instancesEditButton.Enabled = false;
        }

        private void ApplicationsAddButton_Click(object sender, EventArgs e)
        {
            using AadApplicationForm form = new AadApplicationForm();
            if (form.ShowDialog() != DialogResult.OK) return;

            var application = form.AadApplication;
            if ((application != null) && (application.Secret != string.Empty))
                application.Secret = EncryptDecrypt.Encrypt(application.Secret);

            Properties.Settings.Default.AadApplications.Add(application);
        }

        private void ApplicationsDeleteButton_Click(object sender, EventArgs e)
        {
            if (applicationsGrid.SelectedRows.Count > 0)
                applicationsGrid.Rows.RemoveAt(applicationsGrid.SelectedRows[0].Index);
        }

        private void ApplicationsGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if ((applicationsGrid.RowCount != 0) && (applicationsGrid.SelectedRows.Count != 0)) return;
            applicationsDeleteButton.Enabled = false;
            applicationsEditButton.Enabled = false;
        }

        private void ApplicationsGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            applicationsDeleteButton.Enabled = true;
            applicationsEditButton.Enabled = true;
        }

        private void InstancesEdit()
        {
            using InstanceForm form = new InstanceForm { Instance = (Instance)instancesGrid.SelectedRows[0].DataBoundItem };
            var index = Properties.Settings.Default.Instances.IndexOf((Instance)instancesGrid.SelectedRows[0].DataBoundItem);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Instances.RemoveAt(index);
                Properties.Settings.Default.Instances.Insert(index, form.Instance);
            }
            instancesGrid.Rows[index].Selected = true;
        }

        private void DataJobsEdit()
        {
            using DataJobForm form = new DataJobForm { DataJob = (DataJob)dataJobsGrid.SelectedRows[0].DataBoundItem };
            var index = Properties.Settings.Default.DataJobs.IndexOf((DataJob)dataJobsGrid.SelectedRows[0].DataBoundItem);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataJobs.RemoveAt(index);
                Properties.Settings.Default.DataJobs.Insert(index, form.DataJob);
            }
            dataJobsGrid.Rows[index].Selected = true;
        }

        private void ApplicationsEdit()
        {
            var application = (AadApplication) applicationsGrid.SelectedRows[0].DataBoundItem;
            try
            {
                if (application.Secret != string.Empty)
                    application.Secret = EncryptDecrypt.Decrypt(application.Secret);
            }
            catch
            {
                application.Secret = string.Empty;
                MessageBox.Show(Resources.Existing_application_secret_could_not_be_decrypted);
            }

            using AadApplicationForm form = new AadApplicationForm { AadApplication = application };
            var index = Properties.Settings.Default.AadApplications.IndexOf((AadApplication)applicationsGrid.SelectedRows[0].DataBoundItem);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AadApplications.RemoveAt(index);
                application = form.AadApplication;

                if ((application != null) && (application.Secret != string.Empty))
                    application.Secret = EncryptDecrypt.Encrypt(application.Secret);

                Properties.Settings.Default.AadApplications.Insert(index, application);
            }
            else
            {
                try
                {
                    application.Secret = EncryptDecrypt.Encrypt(application.Secret);
                }
                catch
                {
                    application.Secret = string.Empty;
                    MessageBox.Show(Resources.Existing_application_secret_could_not_be_encrypted);
                }
            }
            applicationsGrid.Rows[index].Selected = true;
        }

        private void UsersEdit()
        {
            var user = (User) usersDataGrid.SelectedRows[0].DataBoundItem;
            try
            {
                user.Password = EncryptDecrypt.Decrypt(user.Password);
            }
            catch
            {
                user.Password = string.Empty;
                MessageBox.Show(Resources.Existing_password_could_not_be_decrypted);
            }

            using UserForm form = new UserForm { User = user };
            var index = Properties.Settings.Default.Users.IndexOf((User)usersDataGrid.SelectedRows[0].DataBoundItem);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Users.RemoveAt(index);
                user = form.User;
                if (user != null)
                    user.Password = EncryptDecrypt.Encrypt(user.Password);
                Properties.Settings.Default.Users.Insert(index, user);
            }
            else
            {
                try
                {
                    user.Password = EncryptDecrypt.Encrypt(user.Password);
                }
                catch
                {
                    user.Password = string.Empty;
                    MessageBox.Show(Resources.Existing_password_could_not_be_encrypted);
                }
            }
            usersDataGrid.Rows[index].Selected = true;
        }

        private void JobGroupsEdit()
        {
            using JobGroupForm form = new JobGroupForm { JobGroup = (JobGroup)jobGroupsGrid.SelectedRows[0].DataBoundItem };
            var index = Properties.Settings.Default.JobGroups.IndexOf((JobGroup)jobGroupsGrid.SelectedRows[0].DataBoundItem);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.JobGroups.RemoveAt(index);
                Properties.Settings.Default.JobGroups.Insert(index, form.JobGroup);
            }
            jobGroupsGrid.Rows[index].Selected = true;
        }

        private void InstancesEditButton_Click(object sender, EventArgs e)
        {
            InstancesEdit();
        }

        private void DataJobsEditButton_Click(object sender, EventArgs e)
        {
            DataJobsEdit();
        }

        private void ApplicationsEditButton_Click(object sender, EventArgs e)
        {
            ApplicationsEdit();
        }

        private void UsersEditButton_Click(object sender, EventArgs e)
        {
            UsersEdit();
        }

        private void JobGroupsEditButton_Click(object sender, EventArgs e)
        {
            JobGroupsEdit();
        }

        private void InstancesGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InstancesEdit();
        }

        private void DataJobsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataJobsEdit();
        }

        private void ApplicationsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplicationsEdit();
        }

        private void UsersDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UsersEdit();
        }

        private void JobGroupsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            JobGroupsEdit();
        }
    }
}