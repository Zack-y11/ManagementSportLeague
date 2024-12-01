using BusinessLayer.Services;
using CommonLayer.Models;
using Microsoft.Extensions.Logging.Console;
using PresentationLayer.Reports.Categories;
using System;
using System.CodeDom;
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
using QuestContainer = QuestPDF.Infrastructure.IContainer;


namespace PresentationLayer.ManagerForms
{
    public partial class DashboardForm : Form
    {   private readonly PerfomanceStats _perfomanceStats;  
        private readonly IMatchService _matchService;
        bool isUpdating = false;
        private int _userId;
        private readonly ITeamService _teamService;
        public DashboardForm(IMatchService matchService, ITeamService teamService, int userId)
        {
            InitializeComponent();
            _userId = userId;
            _matchService = matchService;
            _teamService = teamService;
            LoadData();
        }

        private void LoadData()
        {
            NextMatchDto nextMatch = _matchService.GetNextMatch(_userId);
            int victories = _teamService.GetTeamVictoriesCount(_userId);
            int playersCount = _teamService.GetTeamPlayersCount(_userId);
            var standings = _teamService.GetTeamStandings();

            teamsStandingDGV.DataSource = standings.ToList();
            teamsStandingDGV.Columns["Position"].HeaderText = "Pos";
            teamsStandingDGV.Columns["TeamName"].HeaderText = "Team";
            teamsStandingDGV.Columns["Points"].HeaderText = "PTS";
            teamsStandingDGV.Columns["Wins"].HeaderText = "W";
            teamsStandingDGV.Columns["Loses"].HeaderText = "L";

            if (playersCount != 0)
            {
                labelPlayersNumber.Text = playersCount.ToString();
            }
            else
            {
                labelPlayersNumber.Text = "0";
            }
            if (victories != null)
            {
                labelWinsNumber.Text = victories.ToString();
            }
            else
            {
                labelWinsNumber.Text = "0";
            }
            if (nextMatch != null)
            {
                labelTimeNextMatch.Text = nextMatch.MatchDate.ToString("MMMM d, yyyy");
                labelRival.Text = nextMatch.RivalTeamName;
            }
            else
            {
                labelTimeNextMatch.Text = "No match scheduled";
                labelRival.Text = "No match scheduled";
            }
        }

        private async void PDFBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                GenerateTeamDashboardPDFAsync();
            }
            finally
            {
                PDFBtn.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private static void CreateHeaderCell(QuestContainer container, string text)
        {
            container.Background(Colors.Blue.Darken3)
                .Padding(5)
                .AlignCenter()
                .Text(text)
                .FontColor(Colors.White)
                .Bold()
                .FontSize(9);
        }

        private async Task GenerateTeamDashboardPDFAsync()
        {
            try
            {
                // Get all required data
                NextMatchDto nextMatch = _matchService.GetNextMatch(_userId);
                int victories = _teamService.GetTeamVictoriesCount(_userId);
                int playersCount = _teamService.GetTeamPlayersCount(_userId);
                var standings = _teamService.GetTeamStandings().ToList();

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4.Landscape());
                        page.Margin(1, Unit.Centimetre);

                        page.Header().Height(40)
                            .Background(Colors.Blue.Darken3)
                            .Padding(10)
                            .Row(row =>
                            {
                                row.RelativeItem().Text("Team Dashboard Report")
                                    .Bold()
                                    .FontColor(Colors.White)
                                    .FontSize(16);

                                row.RelativeItem().AlignRight()
                                    .Text(DateTime.Now.ToString("MMMM dd, yyyy"))
                                    .FontColor(Colors.Grey.Lighten3)
                                    .FontSize(10);
                            });

                        page.Content().Column(column =>
                        {
                            column.Item().Background(Colors.Grey.Lighten4)
                                .Padding(10)
                                .Row(row =>
                                {
                                    row.RelativeItem(2).Column(c =>
                                    {
                                        c.Item().Text("Next Match").Bold().FontSize(11);
                                        c.Item().Text(nextMatch != null
                                            ? $"{nextMatch.RivalTeamName} - {nextMatch.MatchDate:MMMM d, yyyy}"
                                            : "No match scheduled")
                                            .FontSize(10);
                                    });

                                    row.RelativeItem().Column(c =>
                                    {
                                        c.Item().Text("Total Players").Bold().FontSize(11);
                                        c.Item().Text(playersCount.ToString()).FontSize(10);
                                    });

                                    row.RelativeItem().Column(c =>
                                    {
                                        c.Item().Text("Total Victories").Bold().FontSize(11);
                                        c.Item().Text(victories.ToString()).FontSize(10);
                                    });
                                });

                            column.Item().PaddingVertical(5);

                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(40);
                                    columns.RelativeColumn(4);
                                    columns.ConstantColumn(60);
                                    columns.ConstantColumn(60);
                                    columns.ConstantColumn(60);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Element(container => CreateHeaderCell(container, "Pos"));
                                    header.Cell().Element(container => CreateHeaderCell(container, "Team"));
                                    header.Cell().Element(container => CreateHeaderCell(container, "PTS"));
                                    header.Cell().Element(container => CreateHeaderCell(container, "W"));
                                    header.Cell().Element(container => CreateHeaderCell(container, "L"));
                                });

                                foreach (var (team, index) in standings.Select((t, i) => (t, i)))
                                {
                                    var backgroundColor = index % 2 == 0 ? Colors.White : Colors.Grey.Lighten4;

                                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2)
                                        .Background(backgroundColor)
                                        .Padding(5)
                                        .AlignCenter()
                                        .Text(team.Position.ToString())
                                        .Bold()
                                        .FontSize(9);

                                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2)
                                        .Background(backgroundColor)
                                        .Padding(5)
                                        .Text(team.TeamName)
                                        .FontSize(9);

                                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2)
                                        .Background(backgroundColor)
                                        .Padding(5)
                                        .AlignCenter()
                                        .Text(team.Points.ToString())
                                        .Bold()
                                        .FontSize(9);

                                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2)
                                        .Background(backgroundColor)
                                        .Padding(5)
                                        .AlignCenter()
                                        .Text(team.Wins.ToString())
                                        .FontSize(9);

                                    table.Cell().BorderBottom(0.5f).BorderColor(Colors.Grey.Lighten2)
                                        .Background(backgroundColor)
                                        .Padding(5)
                                        .AlignCenter()
                                        .Text(team.Loses.ToString())
                                        .FontSize(9);
                                }
                            });
                        });

                        page.Footer()
                            .AlignCenter()
                            .Text(text =>
                            {
                                text.Span("Generated: ")
                                    .FontSize(8);
                                text.Span(DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
                                    .FontSize(8);
                            });
                    });
                });

                await Task.Run(() => document.GeneratePdfAndShow());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
