using BusinessLayer.Services;
using CommonLayer.Models;
using FluentValidation.Results;
using PresentationLayer.Validations;
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

    public partial class TeamsForm : Form
    {
        private readonly ITeamService _teamService;
        bool isUpdating = false;
        public TeamsForm(
            ITeamService teamService
            )
        {
            InitializeComponent();
            _teamService = teamService;
            LoadData();
            this.activeTeamsDataGrip.Columns["ManagerId"].Visible = false;
        }
        public void LoadData()
        {
            activeTeamsDataGrip.DataSource = _teamService.GetTeams();
            coachComboBox.DataSource = _teamService.GetManagers();
            coachComboBox.DisplayMember = "Name";
            coachComboBox.ValueMember = "UserId";
        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdating)
                {
                    Team team = new Team
                    {
                        ManagerId = (int)coachComboBox.SelectedValue,
                        TeamName = teamNameTextBox.Text,
                        Wins = int.Parse(winsTextBox.Text),
                        Loses = int.Parse(loosesTextBox.Text),
                        Points = int.Parse(pointsTextBox.Text),
                        TeamId = (int)activeTeamsDataGrip.CurrentRow.Cells["TeamId"].Value
                    };
                    TeamValidation teamValidations = new TeamValidation();
                    ValidationResult result = teamValidations.Validate(team);
                    if (!result.IsValid)
                    {
                        DisplayValidatorTeam(result);
                        MessageBox.Show("The team has not been created.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _teamService.UpdateTeam(team);
                        isUpdating = false;
                        MessageBox.Show("Team created successfully");
                        ClearData();
                    }
                }
                else
                {
                    var team = new Team
                    {
                        ManagerId = int.Parse(coachComboBox.SelectedValue.ToString()),
                        TeamName = teamNameTextBox.Text,
                        Wins = 0,
                        Loses = 0,
                        Points = 0
                    };
                    TeamValidation teamValidations = new TeamValidation();
                    ValidationResult result = teamValidations.Validate(team);
                    if (!result.IsValid)
                    {
                        DisplayValidatorTeam(result);
                        MessageBox.Show("The team has not been created.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _teamService.AddTeam(team);
                        MessageBox.Show("Team created successfully");
                        ClearData();
                    }

                }
                LoadData();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("One of the provided values ​​is null:   " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Non valid operation: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred" + ex.Message);
            }

        }

        private void editTeamBtn_Click(object sender, EventArgs e)
        {
            if (activeTeamsDataGrip.SelectedRows.Count > 0)
            {
                teamNameTextBox.Text = activeTeamsDataGrip.CurrentRow.Cells["TeamName"].Value.ToString();
                coachComboBox.SelectedValue = activeTeamsDataGrip.SelectedRows[0].Cells["ManagerId"].Value;
                winsTextBox.Text = activeTeamsDataGrip.SelectedRows[0].Cells["Wins"].Value.ToString();
                loosesTextBox.Text = activeTeamsDataGrip.SelectedRows[0].Cells["Loses"].Value.ToString();
                pointsTextBox.Text = activeTeamsDataGrip.SelectedRows[0].Cells["Points"].Value.ToString();
                isUpdating = true;
            }
            else
            {
                MessageBox.Show("Select a category to edit");
            }
        }

        private void deleteTeamBtn_Click(object sender, EventArgs e)
        {
            if (activeTeamsDataGrip.SelectedRows.Count < 1)
            {
                MessageBox.Show("You must select a row to delete", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var delete = new DialogResult();
                delete = MessageBox.Show("Are you sure you want to delete this Team?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(activeTeamsDataGrip.CurrentRow.Cells["Id"].Value);
                    _teamService.DeleteTeam(id);
                    LoadData();
                }
            }
        }
        private void DisplayValidatorTeam(ValidationResult result)
        {
            teamErrorProvider.Clear();
            foreach (var failure in result.Errors)
            {
                switch (failure.PropertyName)
                {
                    case "ManagerId":
                        teamErrorProvider.SetError(coachComboBox, failure.ErrorMessage);
                        break;
                    case "TeamName":
                        teamErrorProvider.SetError(teamNameTextBox, failure.ErrorMessage);
                        break;
                    case "Wins":
                        teamErrorProvider.SetError(winsTextBox, failure.ErrorMessage);
                        break;
                    case "Loses":
                        teamErrorProvider.SetError(loosesTextBox, failure.ErrorMessage);
                        break;
                    case "Points":
                        teamErrorProvider.SetError(pointsTextBox, failure.ErrorMessage);
                        break;
                }
            }
        }
        public void ClearData()
        {
            teamNameTextBox.Text = string.Empty;
            coachComboBox.SelectedIndex = -1;
            winsTextBox.Text = string.Empty;
            loosesTextBox.Text = string.Empty;
            pointsTextBox.Text = string.Empty;
        }

        private void searchTeamTextBox_TextChanged(object sender, EventArgs e)
        {
            activeTeamsDataGrip.DataSource = _teamService.SearchTeam(searchTeamTextBox.Text);
            if(searchTeamTextBox.Text == "")
            {
                LoadData();
            }
        }
    }
}
