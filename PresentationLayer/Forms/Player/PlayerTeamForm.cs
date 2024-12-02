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
            GeneratePDFAsync();
        }
        private async Task GeneratePDFAsync()
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var teamList = new List<Team>();

                foreach (DataGridViewRow row in teamDataGrip.Rows)
                {
                    if (row.IsNewRow) continue;

                    var team = new Team
                    {
                        TeamName = row.Cells["TeamName"].Value?.ToString() ?? string.Empty,
                        Wins = int.TryParse(row.Cells["Wins"].Value?.ToString(), out int wins) ? wins : 0,
                        Loses = int.TryParse(row.Cells["Loses"].Value?.ToString(), out int loses) ? loses : 0,
                        Points = int.TryParse(row.Cells["Points"].Value?.ToString(), out int points) ? points : 0,
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

                        page.Content()
                            .PaddingVertical(1, Unit.Centimetre)
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
                                        columns.RelativeColumn(4);
                                        columns.RelativeColumn(2);
                                        columns.RelativeColumn(2);
                                        columns.RelativeColumn(2);
                                    });

                                    table.Header(header =>
                                    {
                                        string[] headers = { "Team Name", "Wins", "Loses", "Points" };
                                        foreach (var headerText in headers)
                                        {
                                            header.Cell().Background(Colors.Blue.Darken3)
                                                .Padding(12)
                                                .Text(headerText)
                                                .AlignCenter()    // Center the header text
                                                .Bold()
                                                .FontColor(Colors.White)
                                                .FontSize(11);
                                        }
                                    });

                                    foreach (var (team, index) in teamList.Select((t, i) => (t, i)))
                                    {
                                        var backgroundColor = index % 2 == 0 ? Colors.White : Colors.Grey.Lighten4;

                                        // Team Name column (now centered)
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .AlignCenter()    // Center the team name
                                            .Text(team.TeamName)
                                            .Bold()
                                            .FontSize(10);

                                        // Wins column
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .AlignCenter()
                                            .Text(team.Wins.ToString())
                                            .FontColor(Colors.Green.Darken1)
                                            .Bold()
                                            .FontSize(10);

                                        // Loses column
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .AlignCenter()
                                            .Text(team.Loses.ToString())
                                            .FontColor(Colors.Red.Darken1)
                                            .Bold()
                                            .FontSize(10);

                                        // Points column
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(10)
                                            .AlignCenter()
                                            .Text(team.Points.ToString())
                                            .FontColor(Colors.Blue.Medium)
                                            .Bold()
                                            .FontSize(10);
                                    }
                                });

                                column.Item().PaddingTop(1, Unit.Centimetre)
                                    .Background(Colors.Grey.Lighten4)
                                    .Padding(15)
                                    .Row(row =>
                                    {
                                        row.RelativeItem().Text($"Total Wins: {teamList.Sum(t => t.Wins)}")
                                            .Bold().FontSize(10);
                                        row.RelativeItem().Text($"Total Losses: {teamList.Sum(t => t.Loses)}")
                                            .Bold().FontSize(10);
                                        row.RelativeItem().Text($"Average Points: {teamList.Average(t => t.Points):F1}")
                                            .Bold().FontSize(10);
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
