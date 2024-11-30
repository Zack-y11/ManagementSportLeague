using BusinessLayer.Services;
using CommonLayer.Models;
using PresentationLayer.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var player = new CoachPlayer
            {
                Email = email,
                Password = password,
                PlayerName = name,
                Birthdate = birthdate.ToString(),
                Position = position,
                Goals = goals,
                Assists = assists
            };
            var validator = new UserPlayerValidation();
            var result = validator.Validate(player);
            if (result.IsValid)
            {
                _playerService.CreateUserPlayer(_userId, email, password, name, position, birthdate, goals, assists);
                playerEmailTextBox.Text = "";
                playerPasswordTextBox.Text = "";
                textBoxName.Text = "";
                positionTextbox.Text = "";
                goalsNumeric.Value = 0;
                assistsNumeric.Value = 0;
                LoadPlayers();
            } else
            {
                DisplayValidatorPlayer(result);
                MessageBox.Show("The player has not been created.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void DisplayValidatorPlayer(ValidationResult result)
        {
            playerErrorProvider.Clear();
            foreach (var failure in result.Errors)
            {
                switch (failure.PropertyName)
                {
                    case "Email":
                        playerErrorProvider.SetError(playerEmailTextBox, failure.ErrorMessage);
                        break;
                    case "PlayerName":
                        playerErrorProvider.SetError(textBoxName, failure.ErrorMessage);
                        break;
                    case "Position":
                        playerErrorProvider.SetError(positionTextbox, failure.ErrorMessage);
                        break;
                    case "Goals":
                        playerErrorProvider.SetError(goalsNumeric, failure.ErrorMessage);
                        break;
                    case "Assists":
                        playerErrorProvider.SetError(assistsNumeric, failure.ErrorMessage);
                        break;
                    case "Birthdate":
                        playerErrorProvider.SetError(playerBirthdateDateTimePicker, failure.ErrorMessage);
                        break;
                    case "Password":
                        playerErrorProvider.SetError(playerPasswordTextBox, failure.ErrorMessage);
                        break;

                }
            }
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
                    } catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting player: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
