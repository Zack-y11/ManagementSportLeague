using BusinessLayer.Services;
using CommonLayer.Enums;
using CommonLayer.Models;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.LoginF
{
    public partial class LoginForms : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public LoginForms(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;
        }

        private void SignInButtom_Click(object sender, EventArgs e)
        {
            var user = _userService.Login(emailTextBox.Text, passwordTextBox.Text);
            if (user != null)
            {
                AuthenticatedUser.Name = user.Name;
                AuthenticatedUser.RoleId = user.RoleId;

                if (AuthenticatedUser.RoleId == (int)Roles.Admin)
                {
                    _serviceProvider.GetRequiredService<dashboardAdmin>().ShowDialog();
                    this.Hide();
                } else if (AuthenticatedUser.RoleId == (int)Roles.Manager)
                {
                    // manager o coach

                } else if (AuthenticatedUser.RoleId == (int)Roles.Player)
                {
                    // player

                }
            }else
            {
                
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
