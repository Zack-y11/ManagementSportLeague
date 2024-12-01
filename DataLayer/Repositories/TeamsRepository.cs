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
                string query = @"UPDATE Teams SET ManagerId = @ManagerId, TeamName = @TeamName,
                        Wins = @Wins, Loses = @Loses, Points = @Points
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
                                JOIN Users u ON t.ManagerId = u.UserId
                                WHERE t.TeamName LIKE @TeamName;";
                return connection.Query<Team>(query, new { TeamName = "%" + search + "%" });
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

        public CoachTeam GetManagerFromTeam(int teamId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT t.TeamName, u.Email as Email
                                FROM Teams t
                                INNER JOIN Users u ON t.ManagerId = u.UserId
                                WHERE t.TeamId = @teamId;";

                return connection.QuerySingle<CoachTeam>(query, new { teamId });
            }
        }

        public int GetTeamVictoriesCount(int userId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT T.Wins
                FROM Users U
                JOIN Teams T ON U.UserId = T.ManagerId
                WHERE U.UserId = @userId;";

                return connection.QueryFirstOrDefault<int>(query, new { userId });
            }
        }

        public int GetTeamPlayersCount(int userId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT COUNT(P.PlayerId) as PlayerCount
                FROM Teams T
                JOIN Players P ON T.TeamId = P.TeamId
                WHERE T.ManagerId = @userId";
                return connection.QueryFirstOrDefault<int>(query, new { userId });
            }
        }
        public IEnumerable<TeamStandingsDto> GetTeamStandings()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY Points DESC) as Position,
                    TeamName,
                    Points,
                    Wins,
                    Loses
                FROM Teams
                ORDER BY Points DESC
                ";

                return connection.Query<TeamStandingsDto>(query);
            }
        }
    }
}
