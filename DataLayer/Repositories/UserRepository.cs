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

        public void CreateUser(User user)
        {
            string query = @"INSERT INTO Users (Name, Password, Email, RoleId)
                                VALUES(@Name, @Password, @Email, @RoleId)";
            using (var connection = _dbConnection.GetConnection())
            {
                connection.Execute(query, user);
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Users WHERE UserId = @UserId;";
                connection.Execute(query, new { UserId = userId });
            }
        }

        public IEnumerable<User> GetRoles()
        {
            string query = @"SELECT RoleId, RolelName FROM Roles WHERE RolelName != 'Player';";
            using (var connection = _dbConnection.GetConnection())
            {
                return connection.Query<User>(query);
            }
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

        public IEnumerable<User> GetUsers()
        {
            string query = @"SELECT
                                u.userid,
                                u.name,
                                u.password,
                                u.email,
                                r.roleId,
                                r.RolelName
                                FROM
                                users u
                                JOIN
                                roles r ON u.roleId = r.roleId;";
            using (var connection = _dbConnection.GetConnection())
            {
                return connection.Query<User>(query);
            }
        }

        public IEnumerable<User> SearchUser(string search)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
                        SELECT
                            u.userid,
                            u.name,
                            u.password,
                            u.email,
                            r.roleId,
                            r.RolelName
                        FROM
                            users u
                        JOIN
                            roles r ON u.roleId = r.roleId
                        WHERE
                            u.name LIKE @Name;";
                return connection.Query<User>(query, new { Name = "%" + search + "%" });
            }
        }

        public void UpdateUser(User user)
        {
            string query = @"UPDATE Users 
                     SET Name = @Name, 
                         Password = @Password, 
                         Email = @Email,
                         RoleId = @RoleId 
                     WHERE UserId = @UserId";
            using (var connection = _dbConnection.GetConnection())
            {
                connection.Execute(query, user);
            };
        }
    }
}
