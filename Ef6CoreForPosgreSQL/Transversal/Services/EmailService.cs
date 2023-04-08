using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Ef6CoreForPosgreSQL.Transversal.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmail(string email, string subject, string message)
        {
            using (var client = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = _configuration["Email:Email"],
                    Password = _configuration["Email:Password"]
                    //UserName = "developbottago@gmail.com",
                    //Password =  "e1d9u888"
                    //UserName = "ie@grupodifare.com",
                    //Password = "fibonacci7369"
                };
                client.UseDefaultCredentials = false;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = credential;
                client.Host = _configuration["Email:Host"];
                client.Port = int.Parse(_configuration["Email:Port"]);
                // client.Host = "smtp.gmail.com";
                //client.Port =  587;
                client.EnableSsl = bool.Parse(_configuration["Email:SSL"]);
                //client.Host = "correo.grupodifare.com";
                //client.Port = 25;
                //client.EnableSsl = false;

                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(email));
                    emailMessage.From = new MailAddress(credential.UserName);
                    emailMessage.Subject = subject;
                    emailMessage.Body = message;
                    try
                    {
                        client.Send(emailMessage);
                    }
                    catch
                    {

                    }

                }
            }
            await Task.CompletedTask;
        }


    }

}
