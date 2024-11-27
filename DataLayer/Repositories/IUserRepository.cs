﻿using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IUserRepository
    { 
        User? GetUserByEmailAndPassword(string email, string password);
        IEnumerable<User> GetUsers();
        public void CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int userId);
        //get roles
        IEnumerable<User> GetRoles();
    }
}
