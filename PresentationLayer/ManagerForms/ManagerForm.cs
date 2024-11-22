using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PresentationLayer.ManagerForms
{
    public partial class ManagerForm : Form
    {
        private Form activeChildForm;

        public ManagerForm()
        {
            InitializeComponent();
            SetUpButtons();
        }

        private void ibtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            UpdateWindowButtons();
        }

        private void ibtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ibtnRestaurar.Visible = false;
            ibtnMaximizar.Visible = true;
            UpdateWindowButtons();
        }

        private void UpdateWindowButtons()
        {
            ibtnMaximizar.Visible = (this.WindowState != FormWindowState.Maximized);
            ibtnRestaurar.Visible = (this.WindowState == FormWindowState.Maximized);
        }

        private void SetUpButtons()
        {
            btnDashboard.Click += ButtonClickHandler;
            btnActivities.Click += ButtonClickHandler;
            btnPlayers.Click += ButtonClickHandler;
            btnStats.Click += ButtonClickHandler;
            btnPositionTable.Click += ButtonClickHandler;



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
                case "btndashboard":
                    LoadDashboardContent();
                    break;

                case "btnactivities":
                    LoadActivitiesContent();
                    break;
                default:
                    MessageBox.Show($"Unknown button: {button.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "btnplayers":
                    LoadPlayersContent();
                    break;

                case "btnstats":
                    LoadStatsContent();
                    break;

                case "btnpositiontable":
                    LoadPositionTableContent();
                    break;
            }
        }

        private void LoadActivitiesContent()
        {
            try
            {
                var activitiesForm = new ActivitiesForm();
                OpenChildForm(activitiesForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the activities: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPlayersContent()
        {
            try
            {
                var playersForm = new PlayersForm();
                OpenChildForm(playersForm);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the players: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStatsContent()
        {
            try
            {
                var statsForm = new StatsForm();
                OpenChildForm(statsForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the stats: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPositionTableContent()
        {
            try
            {
                var positionTableForm = new PositionForm();

                OpenChildForm(positionTableForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the position table: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardContent()
        {
            try
            {
                var dashboardForm = new DashboardForm();
                OpenChildForm(dashboardForm);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the dashboard: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelObjetiveSeason_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

