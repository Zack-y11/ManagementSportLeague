using CommonLayer.Models;

namespace DataLayer.Repositories
{
    public interface IMatchRepository
    {
        IEnumerable<Match> GetMatches();
        void AddMatch(Match match);
        void UpdateMatch(Match match);
        void DeleteMatch(int matchId);
        IEnumerable<Match> GetMatchFilterByDate(DateTime start, DateTime end);
        NextMatchDto? GetNextMatch(int userId);
        IEnumerable<Team> GetTeamIdAndName();
        IEnumerable<Match> MatchStatus();
    }
}