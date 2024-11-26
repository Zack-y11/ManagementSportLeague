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
        private readonly Color HOVER_BACKGROUND = Color.FromArgb(230, 230, 230);
        private readonly Color ACTIVE_BACKGROUND = Color.FromArgb(0, 123, 255);
        private IconButton currentButton;
        private Form activeForm = null;
        private IconButton hoveredButton = null;
        bool isUpdating = false;
        private readonly ITeamService _teamService;
        private readonly IMatchService _matchService;

        public dashboardAdmin(
            ITeamService teamService,
            IMatchService matchService)
        {
            InitializeComponent();
            _teamService = teamService;
            _matchService = matchService;

            LoadData();
            matchInformation.Columns["HomeTeamId"].Visible = false;
            matchInformation.Columns["AwayTeamId"].Visible = false;
            matchInformation.Columns["StatusId"].Visible = false;


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
                    case "matchesbtn":
                        LoadDashboardContent();
                        break;
                    case "usersbtn":
                        LoadCoachContent();
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
                var form = new MatchesListForm();
                OpenChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Dashboard form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadCoachContent()
        {
            try
            {
                var form = new usersForm();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
        }
        public void LoadData()
        {
            matchInformation.DataSource = _matchService.GetMatches();

            homeTeamComboBox.DataSource = _matchService.GetTeamIdAndName();
            homeTeamComboBox.DisplayMember = "TeamName";
            homeTeamComboBox.ValueMember = "TeamId";

            awayTeamComboBox.DataSource = _matchService.GetTeamIdAndName();
            awayTeamComboBox.DisplayMember = "TeamName";
            awayTeamComboBox.ValueMember = "TeamId";

            statusComboBox.DataSource = _matchService.GetMatchStatuses();
            statusComboBox.DisplayMember = "Status";
            statusComboBox.ValueMember = "StatusId";
        }

        private void addMatchBtn_Click(object sender, EventArgs e)
        {
            if (isUpdating)
            {
                var match = new Match
                {
                    HomeTeamId = Convert.ToInt32(homeTeamComboBox.SelectedValue),
                    AwayTeamId = Convert.ToInt32(awayTeamComboBox.SelectedValue),
                    StatusId = Convert.ToInt32(statusComboBox.SelectedValue),
                    Score = scoreTextBox.Text,
                    MatchDate = matchDateTimePicker.Value,
                    Fouls = int.Parse(foulsTextBox.Text),
                    Corners = int.Parse(cornersTextBox.Text),
                    MatchId = (int)matchInformation.SelectedRows[0].Cells["MatchId"].Value
                };
                _matchService.UpdateMatch(match);
                isUpdating = false;
            }
            else
            {
                var match = new Match
                {
                    HomeTeamId = Convert.ToInt32(homeTeamComboBox.SelectedValue),
                    AwayTeamId = Convert.ToInt32(awayTeamComboBox.SelectedValue),
                    StatusId = Convert.ToInt32(statusComboBox.SelectedValue),
                    Score = scoreTextBox.Text,
                    MatchDate = matchDateTimePicker.Value,
                    Fouls = int.Parse(foulsTextBox.Text),
                    Corners = int.Parse(cornersTextBox.Text)
                };
                _matchService.AddMatch(match);
            }
            LoadData();

        }

        private void editMatchBtn_Click(object sender, EventArgs e)
        {
            if (matchInformation.SelectedRows.Count > 0)
            {
                homeTeamComboBox.SelectedValue = matchInformation.SelectedRows[0].Cells["HomeTeamId"].Value;
                awayTeamComboBox.SelectedValue = matchInformation.SelectedRows[0].Cells["AwayTeamId"].Value;
                matchDateTimePicker.Value = (DateTime)matchInformation.SelectedRows[0].Cells["MatchDate"].Value;
                scoreTextBox.Text = matchInformation.SelectedRows[0].Cells["Score"].Value.ToString();
                foulsTextBox.Text = matchInformation.SelectedRows[0].Cells["Fouls"].Value.ToString();
                cornersTextBox.Text = matchInformation.SelectedRows[0].Cells["Corners"].Value.ToString();
                statusComboBox.SelectedValue = matchInformation.SelectedRows[0].Cells["StatusId"].Value;
                isUpdating = true;
            }
            else
            {
                MessageBox.Show("Please select a match to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMatchBtn_Click(object sender, EventArgs e)
        {
            if(matchInformation.SelectedRows.Count <1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var delete = new DialogResult();
                delete = MessageBox.Show("¿Está seguro de eliminar el partido?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(delete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(matchInformation.SelectedRows[0].Cells["MatchId"].Value);
                    _matchService.DeleteMatch(id);
                    MessageBox.Show("Match Eliminado Correctamente");
                    LoadData();


                }
            }
        }
    }
}