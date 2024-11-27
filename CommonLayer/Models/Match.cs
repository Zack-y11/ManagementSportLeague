using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
    public class Match
    {
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int StatusId { get; set; }
        public string Score { get; set; }
        public DateTime MatchDate { get; set; }
        public int Fouls { get; set; }
        public int Corners { get; set; }
        public int MatchId { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Status { get; set; }

    }
}
