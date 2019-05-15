using System;
using System.Net.Mail;

namespace Domain.SRP
{

    public class UserServiceBad
    {
        public User Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new Exception("Email is not an email");
            }

            var user = new User()
            {
                Email = email,
                Password = password
            };
            //Store user somewhere

            SendEmail(user);

            return user;
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public bool SendEmail(User user)
        {
            MailMessage mail = new MailMessage("myCompany@yourcompany.com", user.Email);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            mail.Subject = "This is a registration email.";
            mail.Body = "This a registration email body";
            client.Send(mail);

            return true;
        }
    }

}
