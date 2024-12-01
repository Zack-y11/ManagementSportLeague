using CommonLayer.Models;

namespace DataLayer.Repositories
{
    public interface ITeamsRepository
    {
        void AddTeam(Team team);
        void DeleteTeam(int teamId);
        IEnumerable<Team> GetTeams();
        void updateTeam(Team team);
        IEnumerable<Team> SearchTeam(string search);
        IEnumerable<User> GetManagers();
        int GetTeamVictoriesCount(int teamId);
        int GetTeamPlayersCount(int userId);
        IEnumerable<TeamStandingsDto> GetTeamStandings();
        CoachTeam GetManagerFromTeam (int teamId);
        IEnumerable<CoachTeam> GetCoachTeamFromPlayer(int playerId);
    }
}