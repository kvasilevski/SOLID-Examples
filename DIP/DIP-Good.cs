namespace Domain.DIP.Good
{
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }

    public class Notification
    {
        private IMessenger _messenger;

        public Notification(IMessenger pMessenger)
        {
            _messenger = pMessenger;
        }
        public void DoNotify()
        {
            _messenger.SendMessage();
        }
    }
}
