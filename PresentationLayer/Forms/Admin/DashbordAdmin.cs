using BusinessLayer.Services;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class dashboardAdmin : Form

    {
        private readonly Color DEFAULT_BACKGROUND = Color.Transparent;
        private readonly Color HOVER_BACKGROUND = Color.FromArgb(230, 230, 230);
        private readonly Color ACTIVE_BACKGROUND = Color.FromArgb(0, 123, 255);
        private IconButton currentButton;
        private Form activeForm = null;
        private IconButton hoveredButton = null;
        private readonly ITeamService _teamService;

        public dashboardAdmin(ITeamService teamService)
        {
            InitializeComponent();
        _teamService = teamService;

            headerPanel.Dock = DockStyle.Top;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BringToFront();

            SetupButton();
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm.Dispose();
                }

                activeForm = childForm;

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
                MessageBox.Show($"Error opening form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupButton()
        {
            if (dashboardBtn != null) ConfigureButton(dashboardBtn);
            if (teamsBtn != null) ConfigureButton(teamsBtn);
            if (featuresBtn != null) ConfigureButton(featuresBtn);
            if (settingsBtn != null) ConfigureButton(settingsBtn);
            if (statisticsBtn != null) ConfigureButton(statisticsBtn);
        }

        private void ConfigureButton(IconButton button)
        {
            button.MouseEnter -= Button_MouseEnter;
            button.MouseLeave -= Button_MouseLeave;
            button.Click -= Button_Click;

            
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = DEFAULT_BACKGROUND;
            button.IconColor = Color.Black;

          
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;
            button.Click += Button_Click;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = (IconButton)sender;
            if (button != currentButton)
            {
                hoveredButton = button;
                button.BackColor = HOVER_BACKGROUND;
                button.IconColor = Color.Black;

                if (currentButton == null)
                {
                    headerPanel.BackColor = HOVER_BACKGROUND;
                }
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = (IconButton)sender;
            if (button != currentButton)
            {
                hoveredButton = null;
                button.BackColor = DEFAULT_BACKGROUND;
                button.IconColor = Color.Black;

                if (currentButton == null)
                {
                    headerPanel.BackColor = DEFAULT_BACKGROUND;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (IconButton)sender;

                if (currentButton != null)
                {
                    // Reset previous button
                    currentButton.BackColor = DEFAULT_BACKGROUND;
                    currentButton.ForeColor = Color.Black;
                    currentButton.IconColor = Color.Black;
                }

                // Set current button
                currentButton = button;

                // Update button appearance
                button.BackColor = ACTIVE_BACKGROUND;
                button.ForeColor = Color.White;
                button.IconColor = Color.White;

                // Update header panel color
                headerPanel.BackColor = ACTIVE_BACKGROUND;
                headerPanel.Refresh();

                // Load the appropriate form
                switch (button.Name.ToLower())
                {
                    case "dashboardbtn":
                        LoadDashboardContent();
                        break;
                    case "teamsbtn":
                        LoadTeamsContent();
                        break;
                    case "featuresbtn":
                        LoadFeaturesContent();
                        break;
                    case "statisticsbtn":
                        LoadStatisticsContent();
                        break;
                    case "settingsbtn":
                        LoadSettingsContent();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in button click: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardContent()
        {
            try
            {
                var form = new DashboardForm();
                OpenChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Dashboard form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadTeamsContent()
        {

            try
            {
                var form = new TeamsForm(_teamService);
                OpenChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Teams form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFeaturesContent()
        {

            try
            {
                var form = new FeaturesForm();
                OpenChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Features form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatisticsContent()
        {
            try
            {
                var form = new StatisticsForm();
                OpenChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Statistics form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSettingsContent()
        {
            try
            {
                var form = new SettingsForm();
                OpenChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Settings form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
        }

    
    }
}