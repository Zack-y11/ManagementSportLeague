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
        public IEnumerable<CoachPlayer> GetCoachPlayers(int _userId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    p.PlayerId,
                                    u.Name as PlayerName,
                                    p.Position,
                                    p.Goals,
                                    p.Assists,
                                    p.Birthdate,
                                    u.Email,
                                    u.Password
                                FROM Teams t
                                JOIN Players p ON t.TeamId = p.TeamId
                                JOIN Users u ON p.UserId = u.UserId
                                WHERE t.ManagerId = @UserId;";
                return connection.Query<CoachPlayer>(query, new { UserId = _userId });
            }
        }
        public IEnumerable<CoachPlayer> GetCoachPlayerInfo(int userId)
        {

           using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    p.PlayerId,
                                    u.Name as PlayerName,
                                    p.Position,
                                    p.Goals,
                                    p.Assists,
                                    p.Birthdate,
                                    u.Email,
                                    u.Password
                                FROM Players p
                                JOIN Users u ON p.UserId = u.UserId
                                WHERE u.UserId = @UserId;";
                return connection.Query<CoachPlayer>(query, new { UserId = userId });
            }
        }
        public void CreateUserPlayer(int creatorId, string email, string password, string name, string position, DateTime birthDate, int goals, int assists)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                // Get team ID first since we need it for both operations
                string teamQuery = "SELECT TeamId FROM Teams WHERE ManagerId = @ManagerId;";
                int teamId = connection.QuerySingle<int>(teamQuery, new { ManagerId = creatorId });

                // MERGE for Users and Players in one transaction
                string query = @"
            MERGE INTO Users AS target
            USING (SELECT @Email AS Email) AS source
            ON target.Email = source.Email
            WHEN MATCHED THEN
                UPDATE SET Password = @Password, Name = @Name
            WHEN NOT MATCHED THEN
                INSERT (Email, Password, Name, RoleId)
                VALUES (@Email, @Password, @Name, @RoleId);

            DECLARE @UserId int = (SELECT UserId FROM Users WHERE Email = @Email);

            MERGE INTO Players AS target
            USING (SELECT @UserId AS UserId) AS source
            ON target.UserId = source.UserId
            WHEN MATCHED THEN
                UPDATE SET 
                    TeamId = @TeamId,
                    Position = @Position,
                    Birthdate = @Birthdate,
                    Goals = @Goals,
                    Assists = @Assists
            WHEN NOT MATCHED THEN
                INSERT (UserId, TeamId, Position, Birthdate, Goals, Assists)
                VALUES (@UserId, @TeamId, @Position, @Birthdate, @Goals, @Assists);";

                connection.Execute(query, new
                {
                    Email = email,
                    Password = password,
                    Name = name,
                    RoleId = Roles.Player,
                    TeamId = teamId,
                    Position = position,
                    Birthdate = birthDate,
                    Goals = goals,
                    Assists = assists
                });
                
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
