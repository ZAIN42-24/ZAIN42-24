using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace ELearningProject.Services
{
    public class EmailSenderService : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var webMail = "zackriver.buisness@gmail.com";
            var webMailPassword = "*A01205330792Z#";
            var msg = new MailMessage();

            msg.From = new MailAddress(webMail);
            msg.Subject = subject;
            msg.To.Add(email);
            msg.Body = $"<html><body><p>{htmlMessage}</p></body></html>";
            msg.IsBodyHtml = true;


            var smtpClient = new SmtpClient("smtp.office365.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(webMail,webMailPassword)
            };

            try
            {
                smtpClient.Send(msg);
            }
            catch(SmtpException ex) {
                Console.WriteLine($"SMTP Exception: {ex.Message}");
            }


        }
    }
}
