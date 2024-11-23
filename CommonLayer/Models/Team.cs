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
        public string Manager { get; set; } //this is an Id that will be convert to int before to insert
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Points { get; set; }
    }
}
