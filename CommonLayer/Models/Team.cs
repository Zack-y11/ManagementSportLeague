using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Points { get; set; }
    }
}
