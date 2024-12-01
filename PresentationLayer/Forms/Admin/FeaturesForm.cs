using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FeaturesForm : Form
    {
        public FeaturesForm()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            leagNameTextBox.Text = "Premier League";
            seasonNameComboBox.Items.Add("2021/2022");
            seasonNameComboBox.Items.Add("2020/2021");
            seasonNameComboBox.Items.Add("2019/2020");
            seasonNameComboBox.SelectedIndex = 0;
            matchDurationComboBox.Items.Add("90");
            matchDurationComboBox.SelectedIndex = 0;
            substitutionsComboBox.Items.Add("3");
            substitutionsComboBox.Items.Add("5");
            substitutionsComboBox.SelectedIndex = 0;
            numberTeamComboBox.Items.Add("20");
            numberTeamComboBox.Items.Add("18");
            numberTeamComboBox.SelectedIndex = 0;
            playerComboBox.Items.Add("11");
            playerComboBox.SelectedIndex = 0;
            pointsWinComboBox.Items.Add("3");
            pointsWinComboBox.SelectedIndex = 0;
            drawPoints.Items.Add("1");
            drawPoints.SelectedIndex = 0;
            losePointsComboBox.Items.Add("0");
            losePointsComboBox.SelectedIndex = 0;
        }

        private void settingsLeagueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Simulate saving the selected data
                string selectedLeague = leagNameTextBox.Text;
                string selectedSeason = seasonNameComboBox.SelectedItem.ToString();
                string selectedMatchDuration = matchDurationComboBox.SelectedItem.ToString();
                string selectedSubstitutions = substitutionsComboBox.SelectedItem.ToString();
                string selectedNumberTeam = numberTeamComboBox.SelectedItem.ToString();
                string selectedPlayer = playerComboBox.SelectedItem.ToString();
                string selectedPointsWin = pointsWinComboBox.SelectedItem.ToString();
                string selectedDrawPoints = drawPoints.SelectedItem.ToString();
                string selectedLosePoints = losePointsComboBox.SelectedItem.ToString();

                // Display a message to indicate that the data has been saved
                MessageBox.Show("Data has been saved: \n" +
                                "League: " + selectedLeague + "\n" +
                                "Season: " + selectedSeason + "\n" +
                                "Match Duration: " + selectedMatchDuration + "\n" +
                                "Substitutions: " + selectedSubstitutions + "\n" +
                                "Number of Teams: " + selectedNumberTeam + "\n" +
                                "Number of Players: " + selectedPlayer + "\n" +
                                "Points for Win: " + selectedPointsWin + "\n" +
                                "Points for Draw: " + selectedDrawPoints + "\n" +
                                "Points for Lose: " + selectedLosePoints);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
