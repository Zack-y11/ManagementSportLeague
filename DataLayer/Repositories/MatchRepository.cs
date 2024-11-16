using CommonLayer.Entities;
using Dapper;
using DataLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly ISqlDataAccess _dbConnection;
        public MatchRepository(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public IEnumerable<Match> GetMatches()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                 m.MatchId, m.Score, m.MatchDate, m.Fouls, m.Corners,
                    ht.TeamName AS HomeTeam,
                    at.TeamName AS AwayTeam,
                    ms.Status AS MatchStatus
                    FROM Matches m
                    JOIN Teams ht ON m.HomeTeamId = ht.TeamId
                    JOIN Teams at ON m.AwayTeamId = at.TeamId
                    JOIN MatchStatus ms ON m.StatusId = ms.StatusId;";
                return connection.Query<Match>(query);
            }
        }
        public void AddMatch(Match match)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Matches (Score, MatchDate, Fouls, Corners, HomeTeamId, AwayTeamId, StatusId)
                    VALUES (@Score, @MatchDate, @Fouls, @Corners, @HomeTeamId, @AwayTeamId, @StatusId);";
                connection.Query(query, match);
            }
        }
        public void UpdateMatch(Match match)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Matches SET Score = @Score, MatchDate = @MatchDate, Fouls = @Fouls, Corners = @Corners, HomeTeamId = @HomeTeamId, AwayTeamId = @AwayTeamId, StatusId = @StatusId
                    WHERE MatchId = @MatchId;";
                connection.Query(query, match);
            }
        }
        public void DeleteMatch(int matchId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Matches WHERE MatchId = @MatchId;";
                connection.Query(query, new { MatchId = matchId });
            }
        }
        public IEnumerable<Match> GetMatchFilterByDate(DateTime start, DateTime end)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                 m.MatchId, m.Score, m.MatchDate, m.Fouls, m.Corners,
                    ht.TeamName AS HomeTeam,
                    at.TeamName AS AwayTeam,
                    ms.Status AS MatchStatus
                    FROM Matches m
                    JOIN Teams ht ON m.HomeTeamId = ht.TeamId
                    JOIN Teams at ON m.AwayTeamId = at.TeamId
                    JOIN MatchStatus ms ON m.StatusId = ms.StatusId
                    WHERE m.MatchDate BETWEEN @start AND @end;";
                return connection.Query<Match>(query, new { start, end });
            }
        }
    }
}
