using CommonLayer.Models;

namespace BusinessLayer.Services
{
    public interface ITeamService
    {
        void AddTeam(Team team);
        void DeleteTeam(int teamId);
        IEnumerable<Team> GetTeams();
        IEnumerable<Team> SearchTeam(string search);
        void UpdateTeam(Team team);
        IEnumerable<User> GetManagers();
        int GetTeamVictoriesCount(int teamId);
        int GetTeamPlayersCount(int userId);
        IEnumerable<TeamStandingsDto> GetTeamStandings();
        CoachTeam GetManagerFromTeam(int teamId);
        IEnumerable<CoachTeam> GetCoachTeamFromPlayer(int playerId);
    }
}