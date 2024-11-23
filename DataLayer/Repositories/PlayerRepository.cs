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
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ISqlDataAccess _dbConnection;
        PlayerRepository(ISqlDataAccess dbConnection)
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
