using BusinessLayer.Services;
using CommonLayer.Models;
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
    public partial class MatchesListForm : Form
    {
        private IMatchService _matchService;
        bool isUpdating = false;

        public MatchesListForm(IMatchService matchService)
        {
            InitializeComponent();
            _matchService = matchService;
            LoadData();
            matchInformation.Columns["HomeTeamId"].Visible = false;
            matchInformation.Columns["AwayTeamId"].Visible = false;
            matchInformation.Columns["StatusId"].Visible = false;

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
            if (matchInformation.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var delete = new DialogResult();
                delete = MessageBox.Show("¿Está seguro de eliminar el partido?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
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
