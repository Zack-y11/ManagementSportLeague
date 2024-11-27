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
        public PlayerDashboardForm()
        {
            InitializeComponent();
            SetUpButtons();
        }


        private void SetUpButtons()
        {
            dashboardBtn.Click += ButtonClickHandler;
            calendarBtn.Click += ButtonClickHandler;
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
                case "calendarbtn":
                    LoadCalendarContent();
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
                var playerInfoForm = new PlayerInfoForm();
                OpenChildForm(playerInfoForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the activities: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCalendarContent()
        {
            try
            {
                var activitiesForm = new CalendarForm();
                OpenChildForm(activitiesForm);
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
                var playerTeamForm = new PlayerTeamForm();
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
                var positionForm = new PositionForm();
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
                var setitngsForm = new SettingsForm();
                OpenChildForm(setitngsForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the activities: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }

}
