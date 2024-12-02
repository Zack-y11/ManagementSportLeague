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
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PresentationLayer.Forms.Player
{
    public partial class PlayerTeamForm : Form
    {
        private ITeamService _teamService;
        public PlayerTeamForm(ITeamService teamService)
        {
            InitializeComponent();
            _teamService = teamService;
            LoadData();
        }
        public void LoadData()
        {

            var result = _teamService.GetCoachTeamFromPlayer(AuthenticatedUser.UserId);
            if (result is not null)
            {
                teamDataGrip.DataSource = result;
            }

        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {
            GenerateTeamsReportPDFAsync();
        }
        private async Task GenerateTeamsReportPDFAsync()
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var teamsList = new List<TeamStats>();

                foreach (DataGridViewRow row in teamDataGrip.Rows)
                {
                    if (row.IsNewRow) continue;

                    var team = new TeamStats
                    {
                        TeamName = row.Cells["TeamName"].Value?.ToString() ?? string.Empty,
                        Manager = row.Cells["Manager"].Value?.ToString() ?? string.Empty,
                        Wins = int.TryParse(row.Cells["Wins"].Value?.ToString(), out int wins) ? wins : 0,
                        Loses = int.TryParse(row.Cells["Loses"].Value?.ToString(), out int loses) ? loses : 0,
                        Points = int.TryParse(row.Cells["Points"].Value?.ToString(), out int points) ? points : 0
                    };

                    teamsList.Add(team);
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
                                row.RelativeItem().Text("Team Performance Report")
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
                                        row.RelativeItem().Text($"Total Teams: {teamsList.Count}")
                                            .Bold().FontSize(12);
                                        row.RelativeItem().Text($"League Statistics")
                                            .FontSize(12);
                                    });

                                column.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.ConstantColumn(150);   // Team Name
                                        columns.ConstantColumn(120);   // Manager
                                        columns.ConstantColumn(80);    // Wins
                                        columns.ConstantColumn(80);    // Loses
                                        columns.ConstantColumn(80);    // Points
                                    });

                                    table.Header(header =>
                                    {
                                        string[] headers = { "Team Name", "Manager", "Wins", "Loses", "Points" };
                                        foreach (var headerText in headers)
                                        {
                                            header.Cell().Background(Colors.Blue.Darken3)
                                                .Padding(8)
                                                .Text(headerText)
                                                .Bold()
                                                .FontColor(Colors.White)
                                                .FontSize(10);
                                        }
                                    });

                                    foreach (var (team, index) in teamsList.Select((t, i) => (t, i)))
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
                                            .Text(team.Manager)
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(team.Wins.ToString())
                                            .FontColor(Colors.Green.Darken1)
                                            .Bold()
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(team.Loses.ToString())
                                            .FontColor(Colors.Red.Darken1)
                                            .Bold()
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(team.Points.ToString())
                                            .FontColor(Colors.Blue.Medium)
                                            .Bold()
                                            .FontSize(9);
                                    }
                                });

                                column.Item().PaddingTop(1, Unit.Centimetre)
                                    .Background(Colors.Grey.Lighten4)
                                    .Padding(15)
                                    .Row(row =>
                                    {
                                        row.RelativeItem().Text($"Total Wins: {teamsList.Sum(t => t.Wins)}")
                                            .Bold().FontSize(10);
                                        row.RelativeItem().Text($"Total Losses: {teamsList.Sum(t => t.Loses)}")
                                            .Bold().FontSize(10);
                                        row.RelativeItem().Text($"Average Points: {teamsList.Average(t => t.Points):F1}")
                                            .Bold().FontSize(10);
                                    });

                                column.Item().PaddingTop(1, Unit.Centimetre)
                                    .AlignRight()
                                    .Text(text =>
                                    {
                                        text.Span("Generated by ").FontSize(8);
                                        text.Span("League Management System").Bold().FontSize(8);
                                        text.Span($" • Page 1 of 1").FontSize(8);
                                    });
                            });
                    });
                });

                await Task.Run(() => document.GeneratePdfAndShow());
                MessageBox.Show("Team statistics PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
