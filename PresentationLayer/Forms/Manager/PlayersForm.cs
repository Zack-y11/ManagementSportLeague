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
            // get data from 
            // playerEmailTextBox
            // playerPasswordTextBox
            // textBoxName
            // playerBirthdateDateTimePicker
            // positionTextbox

            string email = playerEmailTextBox.Text;
            string password = playerPasswordTextBox.Text;
            string name = textBoxName.Text;
            DateTime birthdate = playerBirthdateDateTimePicker.Value;
            string position = positionTextbox.Text;

            // create player
            if (_userId == null)
            {

               MessageBox.Show("User not found");
                return;
            } else if (_playerService == null)
            {
                MessageBox.Show("Player service not found");
                return;
            }
            _playerService.CreateUserPlayer(_userId, email, password, name, position, birthdate);
        }
    }
}
