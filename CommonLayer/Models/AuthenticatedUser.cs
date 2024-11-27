using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Models
{
    public static class AuthenticatedUser
    {
        public static string Name { get; set; }
        public static int RoleId { get; set; }
        public static int UserId { get; set; }
    }
}
