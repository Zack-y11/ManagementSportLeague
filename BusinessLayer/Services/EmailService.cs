using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _smtpServer;
        private readonly int _port;
        private readonly string _senderEmail;
        private readonly string _password;

        public EmailService(string smtpServer, int port, string senderEmail, string password)
        {
            _smtpServer = smtpServer;
            _port = port;
            _senderEmail = senderEmail;
            _password = password;
        }

        public async Task SendMatchCreatedEmailAsync(string coach1Email, string team1Name, string coach2Email, string team2Name, DateTime matchDate)
        {
            using (var client = new SmtpClient(_smtpServer))
            {
                client.Port = _port;
                client.Credentials = new NetworkCredential(_senderEmail, _password);
                client.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_senderEmail),
                    Subject = "Match Created",
                    Body = $"Hello,\n\n" +
                       $"A new match has been created between {team1Name} and {team2Name} for the {matchDate.ToString("dddd dd, MMMM yyyy")}.\n\n" +
                       $"Best regards,\n" +
                       $"Sports Management System Team",

                    IsBodyHtml = false
                };
                
                mailMessage.To.Add(coach1Email);
                mailMessage.To.Add(coach2Email);

                await client.SendMailAsync(mailMessage);
            }
        }
        public async Task SendWelcomeEmailAsync(string recipientEmail, string userName, string password)
        {
            using (var client = new SmtpClient(_smtpServer))
            {
                client.Port = _port;
                client.Credentials = new NetworkCredential(_senderEmail, _password);
                client.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_senderEmail),
                    Subject = "Welcome to Our Sports Management System",
                    Body = $"Hello {userName},\n\n" +
                       $"Welcome to our system! Your account has been created successfully.\n\n" +
                       $"Your login credentials:\n" +
                       $"Username: {userName}\n" +
                       $"Password: {password}\n\n" +
                       $"For security reasons, we recommend changing your password after your first login.\n\n" +
                       $"Best regards,\n" +
                       $"Sports Management System Team",

                    IsBodyHtml = false
                };
                mailMessage.To.Add(recipientEmail);

                await client.SendMailAsync(mailMessage);
            }
        }
    }
}
