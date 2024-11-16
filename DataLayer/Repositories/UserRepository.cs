using CommonLayer.Models;
using Dapper;
using DataLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISqlDataAccess _dbConnection;

        public UserRepository(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public User? GetUserByEmailAndPassword(string email, string password)
        {
            var query = @"SELECT UserId, Name, Email, Password, RoleId
                          FROM Users
                          WHERE Email = @Email AND Password = @Password";

            using (var connection = _dbConnection.GetConnection())
            {
                return connection.QueryFirstOrDefault<User>(query, new { email, password });
            }
        }
    }
}
