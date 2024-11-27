using Azure.Identity;
using CommonLayer.Enums;
using CommonLayer.Models;
using Dapper;
using DataLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ISqlDataAccess _dbConnection;
        public PlayerRepository(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Player> GetAll()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                p.PlayerId, 
                                p.TeamId, 
                                t.TeamName AS TeamName, 
                                u.Name, 
                                p.Position, 
                                p.Birthdate, 
                                p.Goals, 
                                p.Assists
                                FROM Players p
                                INNER JOIN Teams t ON p.TeamId = t.TeamId
                                INNER JOIN Users u ON u.UserId = p.UserId
                                WHERE u.RoleId = 1;";//rol for player
                return connection.Query<Player>(query);
            }
        }
        public void CreateUserPlayer(int creatorId, string email, string password, string name, string position, DateTime birthDate)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Users (Email, Password, Name, RoleId)
                        VALUES (@Email, @Password, @Name, @RoleId);
                        SELECT CAST(SCOPE_IDENTITY() as int);";
                int userId = connection.QuerySingle<int>(query, new { Email = email, Password = password, Name = name, RoleId = Roles.Player });

                query = @"SELECT TeamId FROM Teams WHERE ManagerId = @ManagerId;";
                int newTeamId = connection.QuerySingle<int>(query, new { ManagerId = creatorId });

                query = @"INSERT INTO Players (UserId, TeamId, Position, Birthdate, Goals, Assists)
                        VALUES ((SELECT UserId FROM Users WHERE Email = @Email), @TeamId, @Position, @Birthdate, 0, 0);";
                connection.Execute(query, new { Email = email, TeamId = newTeamId, Position = position, Birthdate = birthDate });
            }
        }
        public void Add(Player player)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Players (UserId, TeamId, Position, Birthdate, Goals, Assists)
                                VALUES (@UserId, @TeamId, @Position, @Birthdate, @Goals, @Assists);";
                connection.Execute(query, player);
            }
        }
        public void Update(Player player)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Players SET UserId = @UserId, TeamId = @TeamId, Position = @Position, Birthdate = @Birthdate, Goals = @Goals, Assists = @Assists
                                WHERE PlayerId = @PlayerId;";
                connection.Execute(query, player);
            }
        }
        public void Delete(int playerId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Players WHERE PlayerId = @PlayerId;";
                connection.Execute(query, new { PlayerId = playerId });
            }
        }
    }
}
