﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IEmailService
    {
        Task SendWelcomeEmailAsync(string recipientEmail, string userName, string password);
    }
}
