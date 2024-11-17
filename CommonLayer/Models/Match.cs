using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public DateTime MatchDate { get; set; }
        public int Fouls { get; set; }
        public int Corners { get; set; }
        public string HomeTeamId { get; set; }
        public string AwayTeamId { get; set; }
        public string StatusId { get; set; }
    }
}
