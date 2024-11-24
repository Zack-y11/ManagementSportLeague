using BusinessLayer.Services;
using CommonLayer.Models;
using Microsoft.Extensions.Logging.Console;
using System;
using System.CodeDom;
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
    public partial class DashboardForm : Form
    {
        private readonly IMatchService _matchService;
        bool isUpdating = false;
        private int _userId;
        private readonly ITeamService _teamService;
        public DashboardForm(IMatchService matchService, ITeamService teamService, int userId)
        {
            InitializeComponent();
            _userId = userId;
            _matchService = matchService;
            _teamService = teamService;
            LoadData();
        }

        private void LoadData()
        {
            NextMatchDto nextMatch = _matchService.GetNextMatch(_userId);
            int victories = _teamService.GetTeamVictoriesCount(_userId);

            if (victories != null)
            {
                labelWinsNumber.Text = victories.ToString();
            }
            else
            {
                labelWinsNumber.Text = "0";
            }
            if (nextMatch != null)
            {
                labelTimeNextMatch.Text = nextMatch.MatchDate.ToString("MMMM d, yyyy");
                labelRival.Text = nextMatch.RivalTeamName;
            }
            else
            {
                labelTimeNextMatch.Text = "No match scheduled";
                labelRival.Text = "No match scheduled";
            }
            
        }
    }
}
