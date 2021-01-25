using System.Media;
using System.Windows.Forms;

namespace DreamJoy_Calc
{
    internal interface INotification
    {
        void Send(string messageContent);
    }

    public interface IMessageSound
    {
        void Sound();
    }

    internal class Email : INotification
    {
        public void Send(string messageContent)
        {
            MessageBox.Show($"Sending out an email: \n{messageContent}");
        }
    }

    internal class SMS : INotification
    {   
        public void Send(string messageContent)
        {
            MessageBox.Show($"Sending out an SMS: \n{messageContent}");
        }
    }

    internal class Popup : INotification, IMessageSound
    {
        public void Send(string messageContent)
        {
            MessageBox.Show($"popup: \n{messageContent}");
        }

        public void Sound()
        {
            SystemSounds.Beep.Play();
        }
    }

    internal class PhoneCall : INotification
    {
        public void Send(string messageContent)
        {
            MessageBox.Show($"Making a phone call: \n{messageContent}");
        }
    }
}