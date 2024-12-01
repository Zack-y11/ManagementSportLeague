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
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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
                    int id = Convert.ToInt32(activeTeamsDataGrip.CurrentRow.Cells["TeamId"].Value);
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
            if (searchTeamTextBox.Text == "")
            {
                LoadData();
            }
        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {
            GeneratePDFAsync();
        }
        private async Task GeneratePDFAsync()
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var teamList = new List<Team>();

                foreach (DataGridViewRow row in activeTeamsDataGrip.Rows)
                {
                    if (row.IsNewRow) continue;

                    var team = new Team
                    {
                        TeamName = row.Cells["TeamName"].Value?.ToString() ?? string.Empty,
                        Wins = int.TryParse(row.Cells["Wins"].Value?.ToString(), out int wins) ? wins : 0,
                        Loses = int.TryParse(row.Cells["Loses"].Value?.ToString(), out int loses) ? loses : 0,
                        Points = int.TryParse(row.Cells["Points"].Value?.ToString(), out int points) ? points : 0,
                        Manager = row.Cells["Manager"].Value?.ToString() ?? string.Empty,
                    };

                    teamList.Add(team);
                }

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4.Landscape());
                        page.Margin(1, Unit.Centimetre);

                        page.Header().Height(60)
                            .Background(Colors.Blue.Darken3)
                            .Padding(15)
                            .Row(row =>
                            {
                                row.RelativeItem().Text("Teams Performance Report")
                                    .Bold()
                                    .FontColor(Colors.White)
                                    .FontSize(20);

                                row.RelativeItem().AlignRight()
                                    .Text(DateTime.Now.ToString("MMMM dd, yyyy"))
                                    .FontColor(Colors.Grey.Lighten3)
                                    .FontSize(12);
                            });

                        page.Content().PaddingVertical(1, Unit.Centimetre)
                            .Column(column =>
                            {
                                column.Item().PaddingBottom(1, Unit.Centimetre)
                                    .Background(Colors.Grey.Lighten4)
                                    .Padding(15)
                                    .Row(row =>
                                    {
                                        row.RelativeItem().Text($"Total Teams: {teamList.Count}")
                                            .Bold().FontSize(12);
                                        row.RelativeItem().Text($"Season Report")
                                            .FontSize(12);
                                    });

                                column.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.ConstantColumn(150);    // Team Name
                                        columns.ConstantColumn(80);     // Wins
                                        columns.ConstantColumn(80);     // Loses
                                        columns.ConstantColumn(80);     // Points
                                        columns.RelativeColumn();       // Manager
                                    });

                                    table.Header(header =>
                                    {
                                        header.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(8)
                                            .Text("Team Name")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(10);

                                        header.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(8)
                                            .Text("Wins")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(10);

                                        header.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(8)
                                            .Text("Loses")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(10);

                                        header.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(8)
                                            .Text("Points")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(10);

                                        header.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(8)
                                            .Text("Manager")
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(10);
                                    });

                                    foreach (var (team, index) in teamList.Select((t, i) => (t, i)))
                                    {
                                        var backgroundColor = index % 2 == 0 ? Colors.White : Colors.Grey.Lighten4;

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .Text(team.TeamName)
                                            .Bold()
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(team.Wins.ToString())
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(team.Loses.ToString())
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(team.Points.ToString())
                                            .FontColor(Colors.Blue.Medium)
                                            .Bold()
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .Text(team.Manager)
                                            .FontSize(9);
                                    }
                                });

                                column.Item().PaddingTop(1, Unit.Centimetre)
                                    .AlignRight()
                                    .Text(text =>
                                    {
                                        text.Span("Generated by ").FontSize(8);
                                        text.Span("Sports League Management System").Bold().FontSize(8);
                                        text.Span($" • Page 1 of 1").FontSize(8);
                                    });
                            });
                    });
                });

                await Task.Run(() => document.GeneratePdfAndShow());
                MessageBox.Show("PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                PDFBtn.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}
