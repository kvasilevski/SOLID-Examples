using System.Net.Mail;

namespace Domain.SRP
{
    public interface IEmailService {
        bool SendEmail(User user);
    }

    public class EmailService : IEmailService
    {
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
