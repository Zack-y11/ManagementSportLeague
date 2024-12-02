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

    }
}
