/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using RecurringIntegrationsScheduler.Common.Helpers;
using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class ValidateConnection : Form
    {
        public ValidateConnection()
        {
            InitializeComponent();
        }

        public Instance Instance { get; set; }

        private void ValidateConnection_Load(object sender, EventArgs e)
        {
            axInstanceNameTextBox.Text = Instance.Name;
            aosURLTextBox.Text = Instance.AosUri;
            authEndPointTextBox.Text = Instance.AzureAuthEndpoint;
            tenantTextBox.Text = Instance.AadTenant;

            userComboBox.DataSource = Properties.Settings.Default.Users;
            userComboBox.ValueMember = null;
            userComboBox.DisplayMember = "Login";

            var applications = Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User);
            var applicationsBindingList = new BindingList<AadApplication>(applications.ToList());
            aadApplicationComboBox.DataSource = applicationsBindingList;
            aadApplicationComboBox.ValueMember = null;
            aadApplicationComboBox.DisplayMember = Resources.Name;
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            messagesTextBox.Text = string.Empty;
            User user = null;

            if (userAuthRadioButton.Checked)
            {
                user = (User) userComboBox.SelectedItem;
                if (user == null)
                {
                    messagesTextBox.Text = Resources.Select_user_first;
                    return;
                }
            }

            var application = (AadApplication) aadApplicationComboBox.SelectedItem;
            if (application == null)
            {
                messagesTextBox.Text = Resources.Select_AAD_client_first;
                return;
            }

            var settings = new Common.JobSettings.Settings();

            Guid.TryParse(application.ClientId, out Guid aadClientGuid);
            settings.AadClientId = aadClientGuid;
            settings.AadClientSecret = EncryptDecrypt.Decrypt(application.Secret);

            if (Instance != null)
            {
                settings.AadTenant = Instance.AadTenant;
                settings.AosUri = Instance.AosUri.TrimEnd('/'); ;
                settings.AzureAuthEndpoint = Instance.AzureAuthEndpoint;
            }
            if (user != null)
            {
                settings.UserName = user.Login;
                settings.UserPassword = EncryptDecrypt.Decrypt(user.Password);
            }
            settings.UseServiceAuthentication = serviceAuthRadioButton.Checked;

            var httpClientHelper = new HttpClientHelper(settings);

            try
            {
                var response = Task.Run(async () =>
                {
                    var result = await httpClientHelper.GetRequestAsync(new Uri(settings.AosUri));
                    return result;
                });
                response.Wait();

                if (response.Result.StatusCode == HttpStatusCode.OK)
                    messagesTextBox.Text = response.Result.ReasonPhrase;
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                    messagesTextBox.Text = messagesTextBox.Text + Environment.NewLine + ex.Message;
                var inner = ex;
                while (inner.InnerException != null)
                {
                    var innerMessage = inner.InnerException?.Message;
                    if (!string.IsNullOrEmpty(innerMessage))
                        messagesTextBox.Text = messagesTextBox.Text + Environment.NewLine + innerMessage;
                    inner = inner.InnerException;
                }
            }
        }

        private void ServiceAuthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            aadApplicationComboBox.Text = "";
            var applications = serviceAuthRadioButton.Checked
                ? Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.Service)
                : Properties.Settings.Default.AadApplications.Where(x => x.AuthenticationType == AuthenticationType.User);
            var applicationsBindingList = new BindingList<AadApplication>(applications.ToList());
            aadApplicationComboBox.DataSource = applicationsBindingList;
            aadApplicationComboBox.ValueMember = null;
            aadApplicationComboBox.DisplayMember = Resources.Name;

            userComboBox.Enabled = !serviceAuthRadioButton.Checked;
        }
    }
}