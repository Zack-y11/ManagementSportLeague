﻿using BusinessLayer.Services;
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
        private IEmailService _emailService;
        bool isUpdating = false;

        public MatchesListForm(IMatchService matchService, ITeamService teamService, IEmailService emailService)
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
            _emailService = emailService;
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
                        MessageBox.Show("The match has not been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("The match has not been added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _matchService.AddMatch(match);
                        var coach1 = _teamService.GetManagerFromTeam(match.HomeTeamId); 
                        var coach2 = _teamService.GetManagerFromTeam(match.AwayTeamId);
                        _emailService.SendMatchCreatedEmailAsync(coach1.Email, coach1.TeamName, coach2.Email, coach2.TeamName, match.MatchDate);
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
                MessageBox.Show("You must select a row to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var delete = new DialogResult();
                delete = MessageBox.Show("Are you sure you want to delete the match?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(matchInformation.SelectedRows[0].Cells["MatchId"].Value);
                    _matchService.DeleteMatch(id);
                    MessageBox.Show("Match Deleted Successfully");
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
            GenerateMatchPDFAsync();
        }


        private async Task GenerateMatchPDFAsync()
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var matchList = new List<Match>();

                foreach (DataGridViewRow row in matchInformation.Rows)
                {
                    if (row.IsNewRow) continue;

                    var match = new Match
                    {
                        HomeTeam = row.Cells["HomeTeam"].Value?.ToString() ?? string.Empty,
                        AwayTeam = row.Cells["AwayTeam"].Value?.ToString() ?? string.Empty,
                        Status = row.Cells["Status"].Value?.ToString() ?? string.Empty,
                        Score = row.Cells["Score"].Value?.ToString() ?? string.Empty,
                        MatchDate = DateTime.TryParse(row.Cells["MatchDate"].Value?.ToString(), out DateTime matchDate) ? matchDate : DateTime.MinValue,
                        Fouls = int.TryParse(row.Cells["Fouls"].Value?.ToString(), out int fouls) ? fouls : 0,
                        Corners = int.TryParse(row.Cells["Corners"].Value?.ToString(), out int corners) ? corners : 0
                    };

                    matchList.Add(match);
                }

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A3.Landscape());
                        page.Margin(2, Unit.Centimetre);

                        page.Header().Height(80).DefaultTextStyle(x => x.FontSize(28))
                            .Background(Colors.Blue.Darken3)
                            .Padding(20)
                            .Row(row =>
                            {
                                row.RelativeItem().Text("Match Statistics Report")
                                    .Bold()
                                    .FontColor(Colors.White);

                                row.RelativeItem().AlignRight()
                                    .Text(DateTime.Now.ToString("MMMM dd, yyyy"))
                                    .FontColor(Colors.Grey.Lighten3)
                                    .FontSize(14);
                            });

                        page.Content().PaddingVertical(1, Unit.Centimetre)
                            .Column(column =>
                            {
                                // Summary section
                                column.Item().PaddingBottom(1, Unit.Centimetre)
                                    .Background(Colors.Grey.Lighten4)
                                    .Padding(20)
                                    .Row(row =>
                                    {
                                        row.RelativeItem().Text($"Total Matches: {matchList.Count}")
                                            .Bold().FontSize(14);
                                        row.RelativeItem().Text($"Report Generated: {DateTime.Now}")
                                            .FontSize(14);
                                    });

                                // Table
                                column.Item().Table(table =>
                                {
                                    // Column definitions
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(2);     // Home Team
                                        columns.RelativeColumn(2);     // Away Team
                                        columns.RelativeColumn(1.5f);  // Status
                                        columns.RelativeColumn(1);     // Score
                                        columns.RelativeColumn(1.5f);  // Match Date
                                        columns.RelativeColumn(1);     // Fouls
                                        columns.RelativeColumn(1);     // Corners
                                    });

                                    // Header
                                    table.Header(header =>
                                    {
                                        table.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5).AlignCenter()
                                            .Text("Home Team").Bold().FontColor(Colors.White).FontSize(12);

                                        table.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5).AlignCenter()
                                            .Text("Away Team").Bold().FontColor(Colors.White).FontSize(12);

                                        table.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5).AlignCenter()
                                            .Text("Status").Bold().FontColor(Colors.White).FontSize(12);

                                        table.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5).AlignCenter()
                                            .Text("Score").Bold().FontColor(Colors.White).FontSize(12);

                                        table.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5).AlignCenter()
                                            .Text("Match Date").Bold().FontColor(Colors.White).FontSize(12);

                                        table.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5).AlignCenter()
                                            .Text("Fouls").Bold().FontColor(Colors.White).FontSize(12);

                                        table.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5).AlignCenter()
                                            .Text("Corners").Bold().FontColor(Colors.White).FontSize(12);
                                    });

                                    foreach (var (match, index) in matchList.Select((m, i) => (m, i)))
                                    {
                                        var backgroundColor = index % 2 == 0 ? Colors.White : Colors.Grey.Lighten4;

                                        // Home Team
                                        table.Cell().Background(backgroundColor)
                                            .Padding(5)
                                            .Text(match.HomeTeam).FontSize(11);

                                        // Away Team
                                        table.Cell().Background(backgroundColor)
                                            .Padding(5)
                                            .Text(match.AwayTeam).FontSize(11);

                                        // Status
                                        var statusColor = match.Status.ToLower() switch
                                        {
                                            "completed" => Colors.Green.Medium,
                                            "cancelled" => Colors.Red.Medium,
                                            "postponed" => Colors.Orange.Medium,
                                            _ => Colors.Grey.Medium
                                        };

                                        table.Cell().Background(backgroundColor)
                                            .Padding(5)
                                            .Text(match.Status)
                                            .FontColor(statusColor)
                                            .Bold()
                                            .FontSize(11)
                                            .AlignCenter();

                                        // Score
                                        table.Cell().Background(backgroundColor)
                                            .Padding(5)
                                            .Text(match.Score)
                                            .FontSize(11)
                                            .AlignCenter();

                                        // Match Date
                                        table.Cell().Background(backgroundColor)
                                            .Padding(5)
                                            .Text(match.MatchDate.ToString("MMM dd, yyyy"))
                                            .FontSize(11);

                                        // Fouls
                                        table.Cell().Background(backgroundColor)
                                            .Padding(5)
                                            .Text(match.Fouls.ToString())
                                            .FontSize(11)
                                            .AlignCenter();

                                        // Corners
                                        table.Cell().Background(backgroundColor)
                                            .Padding(5)
                                            .Text(match.Corners.ToString())
                                            .FontSize(11)
                                            .AlignCenter();
                                    }
                                });

                                // Footer
                                column.Item().PaddingTop(1, Unit.Centimetre)
                                    .Text(text =>
                                    {
                                        text.Span("Generated by ").FontSize(10);
                                        text.Span("Match Statistics System").Bold().FontSize(10);
                                        text.Span($" • Page 1 of 1").FontSize(10);
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
