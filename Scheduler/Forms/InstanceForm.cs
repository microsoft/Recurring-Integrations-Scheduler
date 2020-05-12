/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Text;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class InstanceForm : Form
    {
        public InstanceForm()
        {
            InitializeComponent();
        }

        public Instance Instance { get; set; }

        private void InstanceForm_Load(object sender, EventArgs e)
        {
            if (Instance != null)
            {
                Text = Resources.Edit_instance;
                textBox1.Text = Instance.Name;
                textBox2.Text = Instance.AosUri;
                textBox3.Text = Instance.AzureAuthEndpoint;
                textBox4.Text = Instance.AadTenant;
                checkBox1.Checked = Instance.UseADAL;
            }
            else
            {
                Text = Resources.Add_instance;
                textBox3.Text = @"https://login.microsoftonline.com";
            }
        }

        private bool InputIsValid()
        {
            var message = new StringBuilder();

            if (string.IsNullOrEmpty(textBox1.Text))
                message.AppendLine(Resources.Friendly_name_is_required);
            if (string.IsNullOrEmpty(textBox2.Text))
                message.AppendLine(Resources.AOS_URL_is_required);
            else if (!CheckUrl(textBox2.Text))
                message.AppendLine(Resources.AOS_URL_is_invalid);
            if (string.IsNullOrEmpty(textBox3.Text))
                message.AppendLine(Resources.Authentication_endpoint_is_required);
            else if (!CheckUrl(textBox3.Text))
                message.AppendLine(Resources.Authentication_endpoint_URL_is_invalid);
            if (string.IsNullOrEmpty(textBox4.Text))
                message.AppendLine(Resources.Tenant_Id_is_required);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Validation_error, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            return message.Length == 0;
        }

        private static bool CheckUrl(string url)
        {
            var result = Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
             && ((uriResult.Scheme == Uri.UriSchemeHttp) || (uriResult.Scheme == Uri.UriSchemeHttps));
            return result;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
                Instance = new Instance
                {
                    Name = textBox1.Text,
                    AosUri = textBox2.Text.TrimEnd('/'),
                    AzureAuthEndpoint = textBox3.Text.TrimEnd('/'),
                    AadTenant = textBox4.Text,
                    UseADAL = checkBox1.Checked
                };
            else
                DialogResult = DialogResult.None;
        }
    }
}