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
    public partial class MatchesListForm : Form
    {
        private readonly ITeamService _teamService;
        private IMatchService _matchService;
        bool isUpdating = false;

        public MatchesListForm(IMatchService matchService, ITeamService teamService)
        {
            InitializeComponent();
            _matchService = matchService;
            LoadData();
            matchInformation.Columns["HomeTeamId"].Visible = false;
            matchInformation.Columns["AwayTeamId"].Visible = false;
            matchInformation.Columns["StatusId"].Visible = false;
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            _teamService = teamService;
            _matchService = matchService;
            _teamService = teamService;
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
            try
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
                    MatchValidation matchValidation = new MatchValidation();
                    var result = matchValidation.Validate(match);
                    if (!result.IsValid)
                    {
                        DisplayMatchValidation(result);
                        MessageBox.Show("Match have don't be updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _matchService.UpdateMatch(match);
                        isUpdating = false;
                        MessageBox.Show("Match updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearData();
                    }
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
                        Fouls = 0,
                        Corners = 0
                    };
                    MatchValidation matchValidation = new MatchValidation();
                    var result = matchValidation.Validate(match);
                    if (!result.IsValid)
                    {
                        DisplayMatchValidation(result);
                        MessageBox.Show("Match have don't be added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _matchService.AddMatch(match);
                        MessageBox.Show("Match added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearData();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void DisplayMatchValidation(ValidationResult result)
        {
            matchErrorProvider.Clear();
            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case "HomeTeamId":
                        matchErrorProvider.SetError(homeTeamComboBox, error.ErrorMessage);
                        break;
                    case "AwayTeamId":
                        matchErrorProvider.SetError(awayTeamComboBox, error.ErrorMessage);
                        break;
                    case "StatusId":
                        matchErrorProvider.SetError(statusComboBox, error.ErrorMessage);
                        break;
                    case "Score":
                        matchErrorProvider.SetError(scoreTextBox, error.ErrorMessage);
                        break;
                    case "MatchDate":
                        matchErrorProvider.SetError(matchDateTimePicker, error.ErrorMessage);
                        break;
                    case "Fouls":
                        matchErrorProvider.SetError(foulsTextBox, error.ErrorMessage);
                        break;
                    case "Corners":
                        matchErrorProvider.SetError(cornersTextBox, error.ErrorMessage);
                        break;
                }
            }
        }
        public void ClearData()
        {
            foulsTextBox.Text = string.Empty;
            cornersTextBox.Text = string.Empty;
            scoreTextBox.Text = string.Empty;
        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {

            var matchList = new List<Match>();

            foreach (DataGridViewRow row in matchInformation.Rows)
            {
                if (row.IsNewRow) continue;

                var homeTeamName = row.Cells["HomeTeam"].Value?.ToString() ?? string.Empty;
                var awayTeamName = row.Cells["AwayTeam"].Value?.ToString() ?? string.Empty;

                var match = new Match
                {
                    HomeTeam = homeTeamName,
                    AwayTeam = awayTeamName,
                    Status = row.Cells["Status"].Value?.ToString() ?? string.Empty,
                    Score = row.Cells["Score"].Value?.ToString() ?? string.Empty,
                    MatchDate = DateTime.TryParse(row.Cells["MatchDate"].Value?.ToString(), out DateTime matchDate) ? matchDate : DateTime.MinValue,
                    Fouls = int.TryParse(row.Cells["Fouls"].Value?.ToString(), out int fouls) ? fouls : 0,
                    Corners = int.TryParse(row.Cells["Corners"].Value?.ToString(), out int corners) ? corners : 0
                };

                matchList.Add(match);
            }
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A3.Landscape()); // Wider page size
                    page.Margin(1, Unit.Centimetre);

                    page.Header().Height(50).Background(Colors.Green.Accent4)
                        .Text("List of Matches Report")
                        .Bold().AlignCenter().FontSize(24).FontColor(Colors.White);

                    page.Content()
                        .Column(column =>
                        {
                            column.Item().Padding(1, Unit.Centimetre).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(2); // Home Team
                                    columns.RelativeColumn(2); // Away Team
                                    columns.RelativeColumn(3); // Status
                                    columns.RelativeColumn(1); // Score
                                    columns.RelativeColumn(3); // Match Date
                                    columns.RelativeColumn(1); // Fouls
                                    columns.RelativeColumn(1); // Corners
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Element(x => CellStyle(x)).Background(Colors.Grey.Lighten1)
                                        .Text("Home Team").Bold().FontColor(Colors.White);

                                    header.Cell().Element(x => CellStyle(x)).Background(Colors.Grey.Lighten1)
                                        .Text("Away Team").Bold().FontColor(Colors.White);

                                    header.Cell().Element(x => CellStyle(x)).Background(Colors.Grey.Lighten1)
                                        .Text("Status").Bold().FontColor(Colors.White);

                                    header.Cell().Element(x => CellStyle(x)).Background(Colors.Grey.Lighten1)
                                        .Text("Score").Bold().FontColor(Colors.White);

                                    header.Cell().Element(x => CellStyle(x)).Background(Colors.Grey.Lighten1)
                                        .Text("Match Date").Bold().FontColor(Colors.White);

                                    header.Cell().Element(x => CellStyle(x)).Background(Colors.Grey.Lighten1)
                                        .Text("Fouls").Bold().FontColor(Colors.White);

                                    header.Cell().Element(x => CellStyle(x)).Background(Colors.Grey.Lighten1)
                                        .Text("Corners").Bold().FontColor(Colors.White);
                                });

                                bool isAlternate = false;
                                foreach (var match in matchList)
                                {
                                    var backgroundColor = isAlternate ? Colors.Grey.Lighten3 : Colors.White;
                                    isAlternate = !isAlternate;

                                    table.Cell().Element(x => CellStyle(x)).Background(backgroundColor)
                                        .Text(match.HomeTeam)
                                        .Style(TextStyle.Default.Size(12)); // Wrapping is automatic

                                    table.Cell().Element(x => CellStyle(x)).Background(backgroundColor)
                                        .Text(match.AwayTeam)
                                        .Style(TextStyle.Default.Size(12));

                                    table.Cell().Element(x => CellStyle(x)).Background(backgroundColor)
                                        .Text(match.Status)
                                        .Style(TextStyle.Default.Size(12));

                                    table.Cell().Element(x => CellStyle(x)).Background(backgroundColor)
                                        .Text(match.Score)
                                        .Style(TextStyle.Default.Size(12));

                                    table.Cell().Element(x => CellStyle(x)).Background(backgroundColor)
                                        .Text(match.MatchDate.ToShortDateString())
                                        .Style(TextStyle.Default.Size(12));

                                    table.Cell().Element(x => CellStyle(x)).Background(backgroundColor)
                                        .Text(match.Fouls.ToString())
                                        .Style(TextStyle.Default.Size(12));

                                    table.Cell().Element(x => CellStyle(x)).Background(backgroundColor)
                                        .Text(match.Corners.ToString())
                                        .Style(TextStyle.Default.Size(12));
                                }

                                QuestPDF.Infrastructure.IContainer CellStyle(QuestPDF.Infrastructure.IContainer container) => container
                                    .Border(1)
                                    .BorderColor(Colors.Grey.Darken1);
                            });
                        });
                });
            }).GeneratePdfAndShow();

            MessageBox.Show("Reporte PDF generado exitosamente!");


        }
    }

 }
