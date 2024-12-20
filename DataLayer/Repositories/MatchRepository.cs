﻿using CommonLayer.Models;
using Dapper;
using DataLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Data;
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
                 m.HomeTeamId, m.AwayTeamId, m.StatusId, m.Score, m.MatchDate, m.Fouls, m.Corners, m.MatchId,
                    ht.TeamName AS HomeTeam,
                    at.TeamName AS AwayTeam,
                    ms.Status AS Status
                    FROM Matches m
                    JOIN Teams ht ON m.HomeTeamId = ht.TeamId
                    JOIN Teams at ON m.AwayTeamId = at.TeamId
                    JOIN MatchStatus ms ON m.StatusId = ms.StatusId;";
                return connection.Query<Match>(query);
            }
        }
        public NextMatchDto? GetNextMatch(int userId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "GetNextMatchRivalTeamAndDate";

                return connection.QueryFirstOrDefault<NextMatchDto>(query,
                    new { userId },
                    commandType: CommandType.StoredProcedure);
            }
        }


        public void AddMatch(Match match)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Matches (HomeTeamId, AwayTeamId, StatusId, Score, MatchDate, Fouls, Corners)
                    VALUES (@HomeTeamId, @AwayTeamId, @StatusId, @Score, @MatchDate, @Fouls, @Corners);";
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
                 m.MatchId, m.HomeTeamId, m.AwayTeamId, m.StatusId, m.Score, m.MatchDate, m.Fouls, m.Corners,
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
        public IEnumerable<Team>GetTeamIdAndName()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT TeamId, TeamName FROM Teams;";
                return connection.Query<Team>(query);
            }
        }

        public IEnumerable<Match> MatchStatus()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT StatusId, Status FROM MatchStatus;";
                return connection.Query<Match>(query);
                }
            
        }
    }
}
