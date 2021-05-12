using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class ValidateConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.validateGroupBox = new System.Windows.Forms.GroupBox();
            this.aadClientLabel = new System.Windows.Forms.Label();
            this.aadApplicationComboBox = new System.Windows.Forms.ComboBox();
            this.authMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.userAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.validateButton = new System.Windows.Forms.Button();
            this.tenantTextBox = new System.Windows.Forms.TextBox();
            this.authEndPointTextBox = new System.Windows.Forms.TextBox();
            this.aosURLTextBox = new System.Windows.Forms.TextBox();
            this.axInstanceNameTextBox = new System.Windows.Forms.TextBox();
            this.tenantLabel = new System.Windows.Forms.Label();
            this.authEndpointLabel = new System.Windows.Forms.Label();
            this.aosURLLabel = new System.Windows.Forms.Label();
            this.axInstanceNameLabel = new System.Windows.Forms.Label();
            this.validateGroupBox.SuspendLayout();
            this.authMethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(609, 271);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(204, 33);
            this.userComboBox.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(465, 274);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(134, 25);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Choose user";
            // 
            // validateGroupBox
            // 
            this.validateGroupBox.Controls.Add(this.aadClientLabel);
            this.validateGroupBox.Controls.Add(this.aadApplicationComboBox);
            this.validateGroupBox.Controls.Add(this.authMethodGroupBox);
            this.validateGroupBox.Controls.Add(this.messagesTextBox);
            this.validateGroupBox.Controls.Add(this.validateButton);
            this.validateGroupBox.Controls.Add(this.tenantTextBox);
            this.validateGroupBox.Controls.Add(this.authEndPointTextBox);
            this.validateGroupBox.Controls.Add(this.aosURLTextBox);
            this.validateGroupBox.Controls.Add(this.axInstanceNameTextBox);
            this.validateGroupBox.Controls.Add(this.tenantLabel);
            this.validateGroupBox.Controls.Add(this.authEndpointLabel);
            this.validateGroupBox.Controls.Add(this.aosURLLabel);
            this.validateGroupBox.Controls.Add(this.axInstanceNameLabel);
            this.validateGroupBox.Controls.Add(this.userLabel);
            this.validateGroupBox.Controls.Add(this.userComboBox);
            this.validateGroupBox.Location = new System.Drawing.Point(20, 21);
            this.validateGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.validateGroupBox.Name = "validateGroupBox";
            this.validateGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.validateGroupBox.Size = new System.Drawing.Size(1028, 573);
            this.validateGroupBox.TabIndex = 2;
            this.validateGroupBox.TabStop = false;
            // 
            // aadClientLabel
            // 
            this.aadClientLabel.AutoSize = true;
            this.aadClientLabel.Location = new System.Drawing.Point(296, 316);
            this.aadClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aadClientLabel.Name = "aadClientLabel";
            this.aadClientLabel.Size = new System.Drawing.Size(305, 25);
            this.aadClientLabel.TabIndex = 16;
            this.aadClientLabel.Text = "Choose Azure App registration";
            // 
            // aadApplicationComboBox
            // 
            this.aadApplicationComboBox.FormattingEnabled = true;
            this.aadApplicationComboBox.Location = new System.Drawing.Point(609, 312);
            this.aadApplicationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.aadApplicationComboBox.Name = "aadApplicationComboBox";
            this.aadApplicationComboBox.Size = new System.Drawing.Size(204, 33);
            this.aadApplicationComboBox.TabIndex = 15;
            // 
            // authMethodGroupBox
            // 
            this.authMethodGroupBox.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodGroupBox.Controls.Add(this.userAuthRadioButton);
            this.authMethodGroupBox.Location = new System.Drawing.Point(11, 229);
            this.authMethodGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.authMethodGroupBox.Name = "authMethodGroupBox";
            this.authMethodGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.authMethodGroupBox.Size = new System.Drawing.Size(268, 131);
            this.authMethodGroupBox.TabIndex = 14;
            this.authMethodGroupBox.TabStop = false;
            this.authMethodGroupBox.Text = "Authentication method";
            // 
            // serviceAuthRadioButton
            // 
            this.serviceAuthRadioButton.AutoSize = true;
            this.serviceAuthRadioButton.Location = new System.Drawing.Point(11, 84);
            this.serviceAuthRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.serviceAuthRadioButton.Name = "serviceAuthRadioButton";
            this.serviceAuthRadioButton.Size = new System.Drawing.Size(256, 29);
            this.serviceAuthRadioButton.TabIndex = 1;
            this.serviceAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Service_authentication;
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(11, 42);
            this.userAuthRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(229, 29);
            this.userAuthRadioButton.TabIndex = 0;
            this.userAuthRadioButton.TabStop = true;
            this.userAuthRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.User_authentication;
            this.userAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Location = new System.Drawing.Point(11, 371);
            this.messagesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesTextBox.Size = new System.Drawing.Size(1005, 191);
            this.messagesTextBox.TabIndex = 13;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(824, 310);
            this.validateButton.Margin = new System.Windows.Forms.Padding(4);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(195, 40);
            this.validateButton.TabIndex = 12;
            this.validateButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Validate;
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // tenantTextBox
            // 
            this.tenantTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.tenantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenantTextBox.Location = new System.Drawing.Point(271, 177);
            this.tenantTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tenantTextBox.Name = "tenantTextBox";
            this.tenantTextBox.Size = new System.Drawing.Size(748, 24);
            this.tenantTextBox.TabIndex = 11;
            // 
            // authEndPointTextBox
            // 
            this.authEndPointTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.authEndPointTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authEndPointTextBox.Location = new System.Drawing.Point(271, 131);
            this.authEndPointTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.authEndPointTextBox.Name = "authEndPointTextBox";
            this.authEndPointTextBox.Size = new System.Drawing.Size(748, 24);
            this.authEndPointTextBox.TabIndex = 9;
            // 
            // aosURLTextBox
            // 
            this.aosURLTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aosURLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aosURLTextBox.Location = new System.Drawing.Point(271, 83);
            this.aosURLTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aosURLTextBox.Name = "aosURLTextBox";
            this.aosURLTextBox.Size = new System.Drawing.Size(748, 24);
            this.aosURLTextBox.TabIndex = 8;
            // 
            // axInstanceNameTextBox
            // 
            this.axInstanceNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.axInstanceNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.axInstanceNameTextBox.Location = new System.Drawing.Point(271, 34);
            this.axInstanceNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.axInstanceNameTextBox.Name = "axInstanceNameTextBox";
            this.axInstanceNameTextBox.Size = new System.Drawing.Size(748, 24);
            this.axInstanceNameTextBox.TabIndex = 7;
            // 
            // tenantLabel
            // 
            this.tenantLabel.AutoSize = true;
            this.tenantLabel.Location = new System.Drawing.Point(147, 177);
            this.tenantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenantLabel.Name = "tenantLabel";
            this.tenantLabel.Size = new System.Drawing.Size(114, 25);
            this.tenantLabel.TabIndex = 6;
            this.tenantLabel.Text = "Tenant Id :";
            // 
            // authEndpointLabel
            // 
            this.authEndpointLabel.AutoSize = true;
            this.authEndpointLabel.Location = new System.Drawing.Point(13, 131);
            this.authEndpointLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authEndpointLabel.Name = "authEndpointLabel";
            this.authEndpointLabel.Size = new System.Drawing.Size(250, 25);
            this.authEndpointLabel.TabIndex = 4;
            this.authEndpointLabel.Text = "Authentication endpoint :";
            // 
            // aosURLLabel
            // 
            this.aosURLLabel.AutoSize = true;
            this.aosURLLabel.Location = new System.Drawing.Point(145, 83);
            this.aosURLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aosURLLabel.Name = "aosURLLabel";
            this.aosURLLabel.Size = new System.Drawing.Size(116, 25);
            this.aosURLLabel.TabIndex = 3;
            this.aosURLLabel.Text = "AOS URL :";
            // 
            // axInstanceNameLabel
            // 
            this.axInstanceNameLabel.AutoSize = true;
            this.axInstanceNameLabel.Location = new System.Drawing.Point(99, 34);
            this.axInstanceNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.axInstanceNameLabel.Name = "axInstanceNameLabel";
            this.axInstanceNameLabel.Size = new System.Drawing.Size(164, 25);
            this.axInstanceNameLabel.TabIndex = 2;
            this.axInstanceNameLabel.Text = "Instance name :";
            // 
            // ValidateConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1065, 612);
            this.Controls.Add(this.validateGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 649);
            this.Name = "ValidateConnection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Validate instance settings";
            this.Load += new System.EventHandler(this.ValidateConnection_Load);
            this.validateGroupBox.ResumeLayout(false);
            this.validateGroupBox.PerformLayout();
            this.authMethodGroupBox.ResumeLayout(false);
            this.authMethodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.GroupBox validateGroupBox;
        private System.Windows.Forms.Label axInstanceNameLabel;
        private System.Windows.Forms.Label aosURLLabel;
        private System.Windows.Forms.Label authEndpointLabel;
        private System.Windows.Forms.TextBox tenantTextBox;
        private System.Windows.Forms.TextBox authEndPointTextBox;
        private System.Windows.Forms.TextBox aosURLTextBox;
        private System.Windows.Forms.TextBox axInstanceNameTextBox;
        private System.Windows.Forms.Label tenantLabel;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label aadClientLabel;
        private System.Windows.Forms.ComboBox aadApplicationComboBox;
        private System.Windows.Forms.GroupBox authMethodGroupBox;
        private System.Windows.Forms.RadioButton serviceAuthRadioButton;
        private System.Windows.Forms.RadioButton userAuthRadioButton;
    }
}