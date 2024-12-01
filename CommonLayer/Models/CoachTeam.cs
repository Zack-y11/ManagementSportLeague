using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
    public class CoachTeam
    {
        public string TeamName { get; set; }
        public string Email { get; set; }
        public string ManagerName { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Points { get; set; }
    }
}
