using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    public partial class Form4 : Form
    {
        private Subscriber user;
        private List<INotification> notifications = new List<INotification>();
        

        public Form4()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreatingUser();
        }

        private void CreatingUser()
        {
            user = new Subscriber(null, textBoxName.Text);
            CBEmail.Visible = true;
            CBSMS.Visible = true;
            CBPopup.Visible = true;
            CBphoneCall.Visible = true;
            textBoxMessage.Visible = true;
            btnSendNotification.Visible = true;
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            AddCheckedNotificationsToList();
            SendNotification();
        }

        private void AddCheckedNotificationsToList()
        {
            notifications.Clear();

            if (CBEmail.Checked)
            {
                notifications.Add(new Email());
            }
            if (CBSMS.Checked)
            {
                notifications.Add(new SMS());
            }
            if (CBPopup.Checked)
            {
                Popup popup = new Popup();
                notifications.Add(popup);
            }
            if (CBphoneCall.Checked)
            {
                notifications.Add(new PhoneCall());
            }
           
        }

        private void SendNotification()
        {
            foreach (INotification notification in notifications)
            {
                if (notification is IMessageSound)
                {
                    ((IMessageSound)notification).Sound();
                }
                notification.Send(textBoxMessage.Text);
                
            }
        }
    }
}