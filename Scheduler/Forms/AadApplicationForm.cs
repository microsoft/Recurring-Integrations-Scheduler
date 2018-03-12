/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Text;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class AadApplicationForm : Form
    {
        public AadApplicationForm()
        {
            InitializeComponent();
        }

        public AadApplication AadApplication { get; set; }

        private void DataJobForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(AuthenticationType));

            if (AadApplication != null)
            {
                Text = Resources.Edit_Azure_AD_application;
                textBox1.Text = AadApplication.Name;
                textBox2.Text = AadApplication.ClientId;
                textBox3.Text = AadApplication.Secret;
                comboBox1.SelectedItem = AadApplication.AuthenticationType;
            }
            else
            {
                Text = Resources.Add_Azure_AD_application;
            }
        }

        private bool InputIsValid()
        {
            var message = new StringBuilder();

            if (string.IsNullOrEmpty(textBox1.Text))
                message.AppendLine(Resources.Friendly_name_is_required);
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                message.AppendLine(Resources.Client_Id_is_required);
            }
            else
            {
                var isValid = Guid.TryParse(textBox2.Text, out var guidOutput);
                if (!isValid)
                    message.AppendLine(Resources.Client_Id_is_invalid);
            }
            if (((AuthenticationType) comboBox1.SelectedItem == AuthenticationType.Service) &&
                string.IsNullOrEmpty(textBox3.Text))
                message.AppendLine(Resources.Client_secret_is_required);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Validation_error, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            return message.Length == 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
                AadApplication = new AadApplication
                {
                    Name = textBox1.Text,
                    ClientId = textBox2.Text,
                    Secret = textBox3.Text,
                    AuthenticationType = (AuthenticationType) comboBox1.SelectedItem
                };
            else
                DialogResult = DialogResult.None;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = (AuthenticationType) comboBox1.SelectedItem == AuthenticationType.Service;
        }
    }
}