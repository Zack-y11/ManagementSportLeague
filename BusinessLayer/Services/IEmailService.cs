using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IEmailService
    {
        Task SendWelcomeEmailAsync(string recipientEmail, string userName, string password);
        Task SendMatchCreatedEmailAsync(string coach1Email, string team1Name, string coach2Email, string team2Name, DateTime matchDate);
    }
}
