/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Text;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class DataJobForm : Form
    {
        public DataJobForm()
        {
            InitializeComponent();
        }

        public DataJob DataJob { get; set; }

        private void DataJobForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(DataJobType));

            if (DataJob != null)
            {
                Text = Resources.Edit_data_job;
                textBox1.Text = DataJob.Name;
                textBox2.Text = DataJob.ActivityId;
                textBox3.Text = DataJob.EntityName;
                comboBox1.SelectedItem = DataJob.Type;
            }
            else
            {
                Text = Resources.Add_data_job;
            }
        }

        private bool InputIsValid()
        {
            var message = new StringBuilder();

            if (string.IsNullOrEmpty(textBox1.Text))
                message.AppendLine(Resources.Friendly_name_is_required);
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                message.AppendLine(Resources.Activity_Id_is_required);
            }
            else
            {
                var isValid = Guid.TryParse(textBox2.Text, out var guidOutput);
                if (!isValid)
                    message.AppendLine(Resources.Activity_Id_is_invalid);
            }

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Validation_error, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            return message.Length == 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
                DataJob = new DataJob
                {
                    Name = textBox1.Text,
                    ActivityId = textBox2.Text,
                    EntityName = textBox3.Text,
                    Type = (DataJobType) comboBox1.SelectedItem
                };
            else
                DialogResult = DialogResult.None;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = (DataJobType) comboBox1.SelectedItem == DataJobType.Upload;
        }
    }
}