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
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PresentationLayer.Forms.Player
{
    public partial class PlayerTeamForm : Form
    {
        private ITeamService _teamService;
        public PlayerTeamForm(ITeamService teamService)
        {
            InitializeComponent();
            _teamService = teamService;
            LoadData();
        }
        public void LoadData()
        {

            var result = _teamService.GetCoachTeamFromPlayer(AuthenticatedUser.UserId);
            if (result is not null)
            {
                teamDataGrip.DataSource = result;
            }

        }

        private void PDFBtn_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
