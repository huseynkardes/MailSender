using System.Net.Mail;
using System.Net;

namespace RequestMail.Models
{
    public class Mail
    {

        public static void MailSender(string body)
        {
            var fromAddress = new MailAddress("sendmaildeneme@gmail.com");
            var toAddress = new MailAddress("cihadkahraman8@gmail.com");
            const string subject = "Yeni Talep";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("sendmaildeneme@gmail.com", "vwowpwopixwzytoh")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }

}
