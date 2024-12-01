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
using System.Windows.Controls;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PresentationLayer.ManagerForms
{
    public partial class PlayersForm : Form
    {
        private readonly IPlayerService _playerService;
        private readonly int _userId;
        public PlayersForm(IPlayerService playerService, int userId)
        {
            InitializeComponent();
            _playerService = playerService;
            _userId = userId;
            // load players for this coach's team
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            // get players for this coach's team
            var players = _playerService.GetCoachPlayers(_userId);
            // put these players to datagridview
            playersDataGridView.DataSource = players;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string email = playerEmailTextBox.Text;
            string password = playerPasswordTextBox.Text;
            string name = textBoxName.Text;
            DateTime birthdate = playerBirthdateDateTimePicker.Value;
            string position = positionTextbox.Text;
            int goals = (int)Math.Round(goalsNumeric.Value);
            int assists = (int)Math.Round(assistsNumeric.Value);

            // create player
            if (_userId == null)
            {
                MessageBox.Show("User not found");
                return;
            }
            else if (_playerService == null)
            {
                MessageBox.Show("Player service not found");
                return;
            }

            _playerService.CreateUserPlayer(_userId, email, password, name, position, birthdate, goals, assists);
            playerEmailTextBox.Text = "";
            playerPasswordTextBox.Text = "";
            textBoxName.Text = "";
            positionTextbox.Text = "";
            goalsNumeric.Value = 0;
            assistsNumeric.Value = 0;
            LoadPlayers();
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            if (playersDataGridView.SelectedRows.Count > 0)
            {
                textBoxName.Text = playersDataGridView.CurrentRow.Cells["PlayerName"].Value.ToString();
                playerEmailTextBox.Text = playersDataGridView.CurrentRow.Cells["Email"].Value.ToString();
                positionTextbox.Text = playersDataGridView.CurrentRow.Cells["Position"].Value.ToString();
                playerBirthdateDateTimePicker.Value = DateTime.Parse(playersDataGridView.CurrentRow.Cells["Birthdate"].Value.ToString());
                goalsNumeric.Value = (int)playersDataGridView.CurrentRow.Cells["Goals"].Value;
                assistsNumeric.Value = (int)playersDataGridView.CurrentRow.Cells["Assists"].Value;
                playerPasswordTextBox.Text = playersDataGridView.CurrentRow.Cells["Password"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una categoria para editar");
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (playersDataGridView.SelectedRows.Count > 0)
            {
                int playerId = (int)playersDataGridView.CurrentRow.Cells["PlayerId"].Value;
                var confirmResult = MessageBox.Show("Are you sure you want to delete this player?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _playerService.Delete(playerId);
                        LoadPlayers();
                        MessageBox.Show("Player deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting player: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {
            GeneratePlayersPDFAsync();  
        }

        private async Task GeneratePlayersPDFAsync()
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var playersList = new List<Player>();

                foreach (DataGridViewRow row in playersDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    var player = new Player
                    {
                        UserName = row.Cells["PlayerName"].Value?.ToString() ?? string.Empty,
                        Position = row.Cells["Position"].Value?.ToString() ?? string.Empty,
                        Birthdate = DateTime.TryParse(row.Cells["Birthdate"].Value?.ToString(), out DateTime birthdate) ? birthdate : DateTime.MinValue,
                        Goals = int.TryParse(row.Cells["Goals"].Value?.ToString(), out int goals) ? goals : 0,
                        Assists = int.TryParse(row.Cells["Assists"].Value?.ToString(), out int assists) ? assists : 0
                    };

                    playersList.Add(player);
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
                                row.RelativeItem().Text("Players Performance Report")
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
                                        row.RelativeItem().Text($"Total Players: {playersList.Count}")
                                            .Bold().FontSize(12);
                                        row.RelativeItem().Text($"Season Statistics")
                                            .FontSize(12);
                                    });

                                column.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.ConstantColumn(120);   
                                        columns.ConstantColumn(80);     
                                        columns.ConstantColumn(100);  
                                        columns.ConstantColumn(80);     
                                        columns.ConstantColumn(80);    
                                    });

                              
                                    table.Header(header =>
                                    {
                                        string[] headers = { "Player", "Position", "Birthdate", "Goals", "Assists" };
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

                           
                                    foreach (var (player, index) in playersList.Select((p, i) => (p, i)))
                                    {
                                        var backgroundColor = index % 2 == 0 ? Colors.White : Colors.Grey.Lighten4;

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .Text(player.UserName)
                                            .Bold()
                                            .FontSize(9);

                                        
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(player.Position)
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(player.Birthdate.ToString("dd/MM/yyyy"))
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(player.Goals.ToString())
                                            .FontColor(Colors.Green.Darken1)
                                            .Bold()
                                            .FontSize(9);

                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Background(backgroundColor)
                                            .Padding(8)
                                            .AlignCenter()
                                            .Text(player.Assists.ToString())
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
                                        row.RelativeItem().Text($"Total Goals: {playersList.Sum(p => p.Goals)}")
                                            .Bold().FontSize(10);
                                        row.RelativeItem().Text($"Total Assists: {playersList.Sum(p => p.Assists)}")
                                            .Bold().FontSize(10);
                                        row.RelativeItem().Text($"Players Average Age: {CalculateAverageAge(playersList):F1} years")
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
                MessageBox.Show("Player statistics PDF report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private double CalculateAverageAge(List<Player> players)
        {
            if (!players.Any())
            {
                return 0; 
            }
            return players.Average(p => (DateTime.Now - p.Birthdate).TotalDays / 365.25);
        }
    }
}
