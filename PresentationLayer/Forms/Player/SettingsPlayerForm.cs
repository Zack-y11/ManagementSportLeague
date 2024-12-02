using BusinessLayer.Services;
using CommonLayer.Models;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.LoginF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace PresentationLayer.Forms.Player
{
    public partial class SettingsPlayerForm : Form
    {
        private readonly IServiceProvider _serviceProvider;  
        private readonly IUserService _userService;
        public SettingsPlayerForm(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;  
            _userService = userService;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            // Clear authenticated user information
            AuthenticatedUser.Name = null;
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
