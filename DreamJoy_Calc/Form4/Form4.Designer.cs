
namespace DreamJoy_Calc
{
    partial class Form4
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.CBEmail = new System.Windows.Forms.CheckBox();
            this.CBSMS = new System.Windows.Forms.CheckBox();
            this.CBPopup = new System.Windows.Forms.CheckBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.CBphoneCall = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 38);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(146, 27);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "enter your name";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBEmail
            // 
            this.CBEmail.AutoSize = true;
            this.CBEmail.Location = new System.Drawing.Point(124, 141);
            this.CBEmail.Margin = new System.Windows.Forms.Padding(2);
            this.CBEmail.Name = "CBEmail";
            this.CBEmail.Size = new System.Drawing.Size(68, 24);
            this.CBEmail.TabIndex = 1;
            this.CBEmail.Text = "Email";
            this.CBEmail.UseVisualStyleBackColor = true;
            this.CBEmail.Visible = false;
            // 
            // CBSMS
            // 
            this.CBSMS.AutoSize = true;
            this.CBSMS.Location = new System.Drawing.Point(124, 187);
            this.CBSMS.Margin = new System.Windows.Forms.Padding(2);
            this.CBSMS.Name = "CBSMS";
            this.CBSMS.Size = new System.Drawing.Size(60, 24);
            this.CBSMS.TabIndex = 2;
            this.CBSMS.Text = "SMS";
            this.CBSMS.UseVisualStyleBackColor = true;
            this.CBSMS.Visible = false;
            // 
            // CBPopup
            // 
            this.CBPopup.AutoSize = true;
            this.CBPopup.Location = new System.Drawing.Point(124, 234);
            this.CBPopup.Margin = new System.Windows.Forms.Padding(2);
            this.CBPopup.Name = "CBPopup";
            this.CBPopup.Size = new System.Drawing.Size(73, 24);
            this.CBPopup.TabIndex = 3;
            this.CBPopup.Text = "Popup";
            this.CBPopup.UseVisualStyleBackColor = true;
            this.CBPopup.Visible = false;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(100, 86);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(145, 27);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Location = new System.Drawing.Point(101, 359);
            this.btnSendNotification.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(145, 27);
            this.btnSendNotification.TabIndex = 5;
            this.btnSendNotification.Text = "Send Notification";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Visible = false;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(47, 318);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(251, 27);
            this.textBoxMessage.TabIndex = 6;
            this.textBoxMessage.Text = " enter your message";
            this.textBoxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMessage.Visible = false;
            // 
            // CBphoneCall
            // 
            this.CBphoneCall.AutoSize = true;
            this.CBphoneCall.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CBphoneCall.Location = new System.Drawing.Point(124, 274);
            this.CBphoneCall.Margin = new System.Windows.Forms.Padding(2);
            this.CBphoneCall.Name = "CBphoneCall";
            this.CBphoneCall.Size = new System.Drawing.Size(97, 24);
            this.CBphoneCall.TabIndex = 7;
            this.CBphoneCall.Text = "PhoneCall";
            this.CBphoneCall.UseVisualStyleBackColor = true;
            this.CBphoneCall.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 467);
            this.Controls.Add(this.CBphoneCall);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.CBPopup);
            this.Controls.Add(this.CBSMS);
            this.Controls.Add(this.CBEmail);
            this.Controls.Add(this.textBoxName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Subscibe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox CBEmail;
        private System.Windows.Forms.CheckBox CBSMS;
        private System.Windows.Forms.CheckBox CBPopup;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnSendNotification;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.CheckBox CBphoneCall;
    }
}