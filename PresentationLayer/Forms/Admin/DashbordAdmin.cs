using BusinessLayer.Services;
using CommonLayer.Models;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class dashboardAdmin : Form

    {
        private readonly Color DEFAULT_BACKGROUND = Color.Transparent;
        private readonly Color HEADER_COLOR = Color.FromArgb(0, 123, 252);
        private IconButton currentButton;
        private Form activeForm = null;
        private IconButton hoveredButton = null;
        bool isUpdating = false;
        private readonly ITeamService _teamService;
        private readonly IMatchService _matchService;
        private readonly IUserService _userService;

        public dashboardAdmin(
            ITeamService teamService,
            IMatchService matchService,
            IUserService userService)
        {
            InitializeComponent();
            _teamService = teamService;
            _matchService = matchService;
            _userService = userService;


            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BringToFront();
            headerPanel.BackColor = HEADER_COLOR;
            LoadDashboardContent();
            SetupButton();
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                contentPanel.SuspendLayout();

                // First handle the active form if it exists
                if (activeForm != null)
                {
                    activeForm.Hide();
                    activeForm.Close();
                    activeForm.Dispose();
                }

                // Clear all controls at once
                contentPanel.Controls.Clear();

                // Set up the new form
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Add new form and show it
                contentPanel.Controls.Add(childForm);
                contentPanel.Tag = childForm;
                childForm.Show();

                contentPanel.ResumeLayout(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupButton()
        {
            if (matchesBtn != null) ConfigureButton(matchesBtn);
            if (usersBtn != null) ConfigureButton(usersBtn);
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
            button.Click += Button_Click;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = (IconButton)sender;
            if (button != currentButton)
            {
                currentButton.BackColor = DEFAULT_BACKGROUND;
                currentButton.ForeColor = Color.Black;
                currentButton.IconColor = Color.Black;

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

                    currentButton.BackColor = DEFAULT_BACKGROUND;
                    currentButton.ForeColor = Color.Black;
                    currentButton.IconColor = Color.Black;
                }

                currentButton = button;
                button.BackColor = HEADER_COLOR;
                button.ForeColor = Color.White;
                button.IconColor = Color.White;

                switch (button.Name.ToLower())
                {
                    case "matchesbtn":
                        LoadDashboardContent();
                        break;

                    case "usersbtn":
                        LoadUserContent();
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
                var form = new MatchesListForm(_matchService);
                OpenChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Dashboard form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadUserContent()
        {
            try
            {
                var form = new usersForm(_userService);
                OpenChildForm(form);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Coach form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void resetBtn_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            UpdateWindowButtons();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            UpdateWindowButtons();
        }



        private void UpdateWindowButtons()
        {
            maximizeBtn.Visible = (this.WindowState != FormWindowState.Maximized);
            resetBtn.Visible = (this.WindowState == FormWindowState.Maximized);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to exit?",
        "Exit Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (activeForm != null)
                {
                    activeForm.Hide();
                    activeForm.Close();
                    activeForm.Dispose();
                    activeForm = null;
                }

                
                this.Close();
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

         
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Close();
                activeForm.Dispose();
            }

            contentPanel?.Controls.Clear();

         
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }
    }

 }
