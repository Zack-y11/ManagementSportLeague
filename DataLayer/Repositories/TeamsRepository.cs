using CommonLayer.Models;
using Dapper;
using DataLayer.DbConnection;
using DataLayer.Repositories;


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly ISqlDataAccess _dbConnection;
        public TeamsRepository(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Team> GetTeams()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
                SELECT
                    u.UserId AS ManagerId,
                    t.TeamName AS TeamName,
                    t.Wins,
                    t.Loses,
                    t.Points,
                    u.Name AS Manager,
                    t.TeamId AS TeamId
                FROM Teams t
                JOIN Users u ON t.ManagerId = u.UserId;";
                return connection.Query<Team>(query);
            }
        }
        public void AddTeam(Team team)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Teams (ManagerId, TeamName, Wins, Loses, Points)
                        VALUES (@ManagerId, @TeamName, @Wins, @Loses, @Points);";
                connection.Execute(query, team);
            }
        }
        public void updateTeam(Team team)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Teams SET ManagerId = @ManagerId, TeamName = @TeamName, Wins = @Wins, Loses = @Loses, Points = @Points
                        WHERE TeamId = @TeamId;";
                connection.Execute(query, team);
            }
        }
        public void DeleteTeam(int teamId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Teams WHERE TeamId = @TeamId;";
                connection.Execute(query, new { TeamId = teamId });
            }
        }

        public IEnumerable<Team> SearchTeam(string search)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                            t.TeamName AS Name,
                            u.UserId AS Manager,
                            t.Wins,
                            t.Loses,
                            t.Points
                            FROM Teams t
                            JOIN Users u ON t.ManagerId = u.UserId
                            WHERE t.TeamName LIKE @search;";
                return connection.Query<Team>(query, new { search });
            }
        }
        public IEnumerable<User> GetManagers()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT UserId, Name FROM Users WHERE RoleId = 2;";
                return connection.Query<User>(query);
            }
        }
    }
}
