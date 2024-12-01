using BusinessLayer.Services;
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
    public partial class PositionForm : Form
    {
        private readonly ITeamService _teamService;
        public PositionForm(ITeamService teamService)
        {
            InitializeComponent();
            _teamService = teamService;
            LoadData();
        }
        public void LoadData()
        {
            leaguePositionDataGrip.DataSource = _teamService.GetTeamStandings();
        }
    }

}
