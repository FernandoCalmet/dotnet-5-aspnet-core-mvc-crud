using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace aspnet_core_mvc_crud.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email, email));
                message.From = new MailAddress("khanakat.software@gmail.com", "MyApp Email Sender");
                message.Subject = subject;
                message.Body = htmlMessage;
                message.IsBodyHtml = true;

                using(var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.Port = 587;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("khanakat.software@gmail.com", "@MyPassw0rd");
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }

            return Task.CompletedTask;
        }
    }
}
