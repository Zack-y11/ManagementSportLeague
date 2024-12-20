﻿using BusinessLayer.Services;
using PresentationLayer.ManagerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Player
{
    public partial class PlayerDashboardForm : Form
    {
        private Form activeChildForm;
        private readonly ITeamService _teamService;
        private readonly IPlayerService _playerService;
        private readonly IUserService _userService;        
        private readonly IServiceProvider _serviceProvider; 
        public PlayerDashboardForm(ITeamService teamService, IPlayerService playerService, IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            SetUpButtons();
            _teamService = teamService;
            _playerService = playerService;
            _userService = userService;          
            _serviceProvider = serviceProvider;
            LoadDashboardContent();
        }


        private void SetUpButtons()
        {
            dashboardBtn.Click += ButtonClickHandler;
            playerTeamBtn.Click += ButtonClickHandler;
            positionTableBtn.Click += ButtonClickHandler;
            settingsPlayerBtn.Click += ButtonClickHandler;

        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (activeChildForm != null)
                {
                    activeChildForm.Close();
                    activeChildForm.Dispose();
                }

                activeChildForm = childForm;

                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(childForm);
                contentPanel.Tag = childForm;

                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the form: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClickHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name.ToLower())
            {

                case "dashboardbtn":
                    LoadDashboardContent();
                    break;
                case "playerteambtn":
                    LoadPlayerTeamContent();
                    break;
                default:
                    MessageBox.Show($"Unknown button: {button.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "positiontablebtn":
                    LoadPositionContent();
                    break;
                case "settingsplayerbtn":
                    LoadSettingsContent();
                    break;

            }
        }
        private void LoadDashboardContent()
        {
            try
            {
                var playerInfoForm = new PlayerInfoForm(_playerService);
                OpenChildForm(playerInfoForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the activities: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadPlayerTeamContent()
        {
            try
            {
                var playerTeamForm = new PlayerTeamForm(_teamService);
                OpenChildForm(playerTeamForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the activities: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPositionContent()
        {
            try
            {
                var positionForm = new PositionForm(_teamService);
                OpenChildForm(positionForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the activities: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSettingsContent()
        {
            try
            {
                var settingsPlayerForm = new SettingsPlayerForm(_userService, _serviceProvider);
                OpenChildForm(settingsPlayerForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the activities: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UpdateWindowButtons()
        {
            maximizeBtn.Visible = (this.WindowState != FormWindowState.Maximized);
            resetBtn.Visible = (this.WindowState == FormWindowState.Maximized);
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            UpdateWindowButtons();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            UpdateWindowButtons();
        }
    }

}
