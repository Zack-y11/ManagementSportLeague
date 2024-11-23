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

namespace PresentationLayer.Forms
{

    public partial class TeamsForm : Form
    {
        private readonly ITeamService _teamService;
        public TeamsForm(
            ITeamService teamService
            )
        {
            InitializeComponent();
            _teamService = teamService;
            LoadData();
            this.activeTeamsDataGrip.Columns["Id"].Visible = false;
        }
        public void LoadData()
        {
            activeTeamsDataGrip.DataSource = _teamService.GetTeams();
        }

       
    }
}
