/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Text;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class JobGroupForm : Form
    {
        public JobGroupForm()
        {
            InitializeComponent();
        }

        public JobGroup JobGroup { get; set; }

        private void JobGroupForm_Load(object sender, EventArgs e)
        {
            if (JobGroup != null)
            {
                Text = Resources.Edit_job_group;
                textBox1.Text = JobGroup.Name;
            }
            else
            {
                Text = Resources.Add_job_group;
            }
        }

        private bool InputIsValid()
        {
            var message = new StringBuilder();

            if (string.IsNullOrEmpty(textBox1.Text))
                message.AppendLine(Resources.Job_group_name_is_required);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Validation_error, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            return message.Length == 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
                JobGroup = new JobGroup
                {
                    Name = textBox1.Text
                };
            else
                DialogResult = DialogResult.None;
        }
    }
}