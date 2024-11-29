using CommonLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            _userRepository.CreateUser(user);
        }

        public void DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);
        }

        public IEnumerable<User> GetRoles()=> _userRepository.GetRoles();

        public IEnumerable<User> GetUsers()=>_userRepository.GetUsers();

        public User? Login(string email, string password)
        {
            return _userRepository.GetUserByEmailAndPassword(email, password);
        }

        public IEnumerable<User> SearchUser(string search)
        {
            return _userRepository.SearchUser(search);
        }

        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }
    }
}
