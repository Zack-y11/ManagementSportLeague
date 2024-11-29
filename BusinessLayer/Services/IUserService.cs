using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IUserService
    {
        User? Login(string email, string password);
        IEnumerable<User> GetUsers();
        public void CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int userId);
        IEnumerable<User> GetRoles();
        IEnumerable<User> SearchUser(string search);
    }
}
