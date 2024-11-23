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
    }
}