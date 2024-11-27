using CommonLayer.Models;

namespace BusinessLayer.Services
{
    public interface IMatchService
    {
        IEnumerable<Match> GetMatches();
        void AddMatch(Match match);
        void UpdateMatch(Match match);
        void DeleteMatch(int matchId);
        NextMatchDto? GetNextMatch(int userId);
        IEnumerable<Team> GetTeamIdAndName();
        IEnumerable<Match> GetMatchStatuses();
    }
}