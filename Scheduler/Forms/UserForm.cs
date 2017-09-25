/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using RecurringIntegrationsScheduler.Properties;
using RecurringIntegrationsScheduler.Settings;
using System;
using System.Text;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        public User User { get; set; }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (User != null)
            {
                Text = Resources.Edit_user;
                textBox1.Text = User.Login;
                textBox2.Text = User.Password;
            }
            else
            {
                Text = Resources.Add_user;
            }
        }

        private bool InputIsValid()
        {
            var message = new StringBuilder();

            if (string.IsNullOrEmpty(textBox1.Text))
                message.AppendLine(Resources.User_login_is_required);
            if (string.IsNullOrEmpty(textBox2.Text))
                message.AppendLine(Resources.User_password_is_required);

            if (message.Length > 0)
                MessageBox.Show(message.ToString(), Resources.Validation_error, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            return message.Length == 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (InputIsValid())
                User = new User
                {
                    Login = textBox1.Text,
                    Password = textBox2.Text
                };
            else
                DialogResult = DialogResult.None;
        }
    }
}