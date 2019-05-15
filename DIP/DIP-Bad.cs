namespace Domain.DIP.Bad
{
    public class Email
    {
        public void SendEmail()
        {
            // code to send mail
        }
    }

    public class Notification
    {
        private Email _email;

        public Notification()
        {
            _email = new Email();
        }

        public void DoNotify()
        {
            _email.SendEmail();
        }
    }

    //public class SMS
    //{
    //    public void SendSms()
    //    {
    //        // code to send sms
    //    }
    //}
}
