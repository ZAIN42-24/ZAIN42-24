using System.Net.Mail;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace ELearningProject.Services
{
    public class EmailSenderService : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var webMail = "";
            var webMailPassword = "";
            var msg = new MailMessage();

            msg.From = new MailAddress(webMail);
            msg.Subject = subject;
            msg.To.Add(email);
            //msg.Body = $"<html><body>" +
            //    $"<p>{htmlMessage}</p>" +
            //    $"</body></html>";

            msg.Body = $"";


        }
    }
}
