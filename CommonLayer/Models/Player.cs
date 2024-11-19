﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TeamId { get; set; }
        public int Position { get; set; }
        public DateTime Birthdate { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
    }
}