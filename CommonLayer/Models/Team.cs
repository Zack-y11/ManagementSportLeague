using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
    public class Team
    {
        public int ManagerId { get; set; }
        public string TeamName { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Points { get; set; }
        public string Manager { get; set; }
        public int TeamId { get; set; }
    }
}
