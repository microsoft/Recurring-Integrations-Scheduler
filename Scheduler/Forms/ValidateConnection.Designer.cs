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
            this.userComboBox.Location = new System.Drawing.Point(358, 173);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(185, 24);
            this.userComboBox.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(264, 176);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(88, 17);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = Resources.Choose_user;
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
            this.validateGroupBox.Location = new System.Drawing.Point(13, 13);
            this.validateGroupBox.Name = "validateGroupBox";
            this.validateGroupBox.Size = new System.Drawing.Size(685, 367);
            this.validateGroupBox.TabIndex = 2;
            this.validateGroupBox.TabStop = false;
            // 
            // aadClientLabel
            // 
            this.aadClientLabel.AutoSize = true;
            this.aadClientLabel.Location = new System.Drawing.Point(197, 203);
            this.aadClientLabel.Name = "aadClientLabel";
            this.aadClientLabel.Size = new System.Drawing.Size(155, 17);
            this.aadClientLabel.TabIndex = 16;
            this.aadClientLabel.Text = Resources.Choose_AAD_Client_app;
            // 
            // aadApplicationComboBox
            // 
            this.aadApplicationComboBox.FormattingEnabled = true;
            this.aadApplicationComboBox.Location = new System.Drawing.Point(358, 200);
            this.aadApplicationComboBox.Name = "aadApplicationComboBox";
            this.aadApplicationComboBox.Size = new System.Drawing.Size(185, 24);
            this.aadApplicationComboBox.TabIndex = 15;
            // 
            // authMethodGroupBox
            // 
            this.authMethodGroupBox.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodGroupBox.Controls.Add(this.userAuthRadioButton);
            this.authMethodGroupBox.Location = new System.Drawing.Point(7, 147);
            this.authMethodGroupBox.Name = "authMethodGroupBox";
            this.authMethodGroupBox.Size = new System.Drawing.Size(179, 84);
            this.authMethodGroupBox.TabIndex = 14;
            this.authMethodGroupBox.TabStop = false;
            this.authMethodGroupBox.Text = Resources.Authentication_method;
            // 
            // serviceAuthRadioButton
            // 
            this.serviceAuthRadioButton.AutoSize = true;
            this.serviceAuthRadioButton.Location = new System.Drawing.Point(7, 54);
            this.serviceAuthRadioButton.Name = "serviceAuthRadioButton";
            this.serviceAuthRadioButton.Size = new System.Drawing.Size(169, 21);
            this.serviceAuthRadioButton.TabIndex = 1;
            this.serviceAuthRadioButton.Text = Resources.Service_authentication;
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(7, 27);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(152, 21);
            this.userAuthRadioButton.TabIndex = 0;
            this.userAuthRadioButton.TabStop = true;
            this.userAuthRadioButton.Text = Resources.User_authentication;
            this.userAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Location = new System.Drawing.Point(7, 237);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesTextBox.Size = new System.Drawing.Size(672, 124);
            this.messagesTextBox.TabIndex = 13;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(549, 199);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(130, 25);
            this.validateButton.TabIndex = 12;
            this.validateButton.Text = Resources.Validate;
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // tenantTextBox
            // 
            this.tenantTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.tenantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenantTextBox.Location = new System.Drawing.Point(180, 113);
            this.tenantTextBox.Name = "tenantTextBox";
            this.tenantTextBox.Size = new System.Drawing.Size(499, 15);
            this.tenantTextBox.TabIndex = 11;
            // 
            // authEndPointTextBox
            // 
            this.authEndPointTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.authEndPointTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authEndPointTextBox.Location = new System.Drawing.Point(180, 84);
            this.authEndPointTextBox.Name = "authEndPointTextBox";
            this.authEndPointTextBox.Size = new System.Drawing.Size(499, 15);
            this.authEndPointTextBox.TabIndex = 9;
            // 
            // aosURLTextBox
            // 
            this.aosURLTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aosURLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aosURLTextBox.Location = new System.Drawing.Point(180, 53);
            this.aosURLTextBox.Name = "aosURLTextBox";
            this.aosURLTextBox.Size = new System.Drawing.Size(499, 15);
            this.aosURLTextBox.TabIndex = 8;
            // 
            // axInstanceNameTextBox
            // 
            this.axInstanceNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.axInstanceNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.axInstanceNameTextBox.Location = new System.Drawing.Point(180, 22);
            this.axInstanceNameTextBox.Name = "axInstanceNameTextBox";
            this.axInstanceNameTextBox.Size = new System.Drawing.Size(499, 15);
            this.axInstanceNameTextBox.TabIndex = 7;
            // 
            // tenantLabel
            // 
            this.tenantLabel.AutoSize = true;
            this.tenantLabel.Location = new System.Drawing.Point(98, 113);
            this.tenantLabel.Name = "tenantLabel";
            this.tenantLabel.Size = new System.Drawing.Size(76, 17);
            this.tenantLabel.TabIndex = 6;
            this.tenantLabel.Text = Resources.Tenant_Id;
            // 
            // authEndpointLabel
            // 
            this.authEndpointLabel.AutoSize = true;
            this.authEndpointLabel.Location = new System.Drawing.Point(9, 84);
            this.authEndpointLabel.Name = "authEndpointLabel";
            this.authEndpointLabel.Size = new System.Drawing.Size(165, 17);
            this.authEndpointLabel.TabIndex = 4;
            this.authEndpointLabel.Text = Resources.Authentication_endpoint;
            // 
            // aosURLLabel
            // 
            this.aosURLLabel.AutoSize = true;
            this.aosURLLabel.Location = new System.Drawing.Point(97, 53);
            this.aosURLLabel.Name = "aosURLLabel";
            this.aosURLLabel.Size = new System.Drawing.Size(77, 17);
            this.aosURLLabel.TabIndex = 3;
            this.aosURLLabel.Text = Resources.AOS_URL_;
            // 
            // axInstanceNameLabel
            // 
            this.axInstanceNameLabel.AutoSize = true;
            this.axInstanceNameLabel.Location = new System.Drawing.Point(66, 22);
            this.axInstanceNameLabel.Name = "axInstanceNameLabel";
            this.axInstanceNameLabel.Size = new System.Drawing.Size(108, 17);
            this.axInstanceNameLabel.TabIndex = 2;
            this.axInstanceNameLabel.Text = Resources.Instance_name_;
            // 
            // ValidateConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 392);
            this.Controls.Add(this.validateGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(728, 439);
            this.Name = "ValidateConnection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = Resources.Validate_instance_settings;
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