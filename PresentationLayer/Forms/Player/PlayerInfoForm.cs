using BusinessLayer.Services;
using CommonLayer.Models;
using DataLayer.Repositories;
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
    public partial class PlayerInfoForm : Form
    {
        private IPlayerService _playerService;
        public PlayerInfoForm(IPlayerService playerService)
        {
            InitializeComponent();
            _playerService = playerService;
            LoadData();
        }

        public void LoadData()
        {
            playerDataGrip.DataSource = _playerService.GetCoachPlayerInfo(AuthenticatedUser.UserId);
        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {
            GeneratePlayerDataPDFAsync();
        }

        private async Task GeneratePlayerDataPDFAsync()
        {
            try
            {
                PDFBtn.Enabled = false;
                Cursor = Cursors.WaitCursor;

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4.Landscape());
                        page.Margin(2, Unit.Centimetre);

                        // Header
                        page.Header().Height(50)
                            .Background(Colors.Blue.Darken3)
                            .Padding(10)
                            .Text("Player Roster")
                            .Bold()
                            .FontColor(Colors.White)
                            .FontSize(20);

                        page.Content().PaddingTop(20)
                            .Table(table =>
                            {
                                // Define columns - adjusted to match headers
                                table.ColumnsDefinition(columns =>
                                {
                                 
                                    columns.RelativeColumn(3);  // Player Name
                                    columns.RelativeColumn(2);  // Position
                                    columns.RelativeColumn(1);  // Goals
                                    columns.RelativeColumn(1);  // Assists
                                });

                                // Header row
                                table.Header(header =>
                                {
                                    string[] headers = {"Player Name", "Position", "Goals", "Assists" };
                                    foreach (var headerText in headers)
                                    {
                                        header.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5)
                                            .Text(headerText)
                                            .Bold()
                                            .FontColor(Colors.White)
                                            .FontSize(10);
                                    }
                                });

                                // Data rows
                                foreach (DataGridViewRow row in playerDataGrip.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                       

                                        // Player Name
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Padding(5)
                                            .Text(row.Cells["PlayerName"].Value?.ToString() ?? "")
                                            .FontSize(9);

                                        // Position
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Padding(5)
                                            .Text(row.Cells["Position"].Value?.ToString() ?? "")
                                            .FontSize(9);

                                        // Goals
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Padding(5)
                                            .Text(row.Cells["Goals"].Value?.ToString() ?? "0")
                                            .FontSize(9);

                                        // Assists
                                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2)
                                            .Padding(5)
                                            .Text(row.Cells["Assists"].Value?.ToString() ?? "0")
                                            .FontSize(9);
                                    }
                                }
                            });

                        // Footer with generation date
                        page.Footer()
                            .AlignRight()
                            .Text(text =>
                            {
                                text.Span("Generated: ")
                                    .FontSize(8);
                                text.Span(DateTime.Now.ToString("MM/dd/yyyy HH:mm"))
                                    .FontSize(8);
                            });
                    });
                });

                await Task.Run(() => document.GeneratePdfAndShow());
                MessageBox.Show("Player roster PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
