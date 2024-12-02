using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Configuration;
using BusinessLayer.Services;
using CommonLayer.Models;
using PresentationLayer.LoginF;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;



namespace PresentationLayer.Forms
{
    public partial class SettingsForm : Form
    { 
        private readonly IServiceProvider _serviceProvider;  
        private readonly IUserService _userService;
        public SettingsForm(ITeamService teamService, IUserService userService, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userService = userService;
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            // Clear authenticated user information
            AuthenticatedUser.UserId = 0;
            AuthenticatedUser.RoleId = 0;

            // Close the current form
            var parentForm = this.ParentForm;
            if (parentForm != null)
            {
                parentForm.Hide();
                parentForm.Close();
            }

            // Get new instance of LoginForms with proper dependency injection
            var loginForm = _serviceProvider.GetRequiredService<LoginForms>();
            loginForm.Show();
        }
    }
}




