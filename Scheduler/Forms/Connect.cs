/* Copyright (c) Microsoft Corporation. All rights reserved.
   Licensed under the MIT License. */

using System;
using System.Windows.Forms;

namespace RecurringIntegrationsScheduler.Forms
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        public string Server { get; private set; }
        public int Port { get; private set; }
        public string Scheduler { get; private set; }
        public bool Cancelled { get; private set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Cancelled = false;
            Server = serverTextBox.Text;
            Port = int.Parse(portTextBox.Text);
            Scheduler = schedulerTextBox.Text;
            Close();
        }

        private void ServerConnectForm_Load(object sender, EventArgs e)
        {
            Cancelled = true;
        }
    }
}