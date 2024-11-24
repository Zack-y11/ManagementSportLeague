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
        public DashboardForm(IMatchService matchService, int userId)
        {
            InitializeComponent();
            _userId = userId;
            _matchService = matchService;
            LoadData();
        }

        private void LoadData()
        {
            NextMatchDto nextMatch = _matchService.GetNextMatch(_userId);
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
