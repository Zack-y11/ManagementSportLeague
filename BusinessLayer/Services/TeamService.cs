using DataLayer.Repositories;
using CommonLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{

    public class TeamService : ITeamService
    {
        private readonly ITeamsRepository _teamsRepository;
        public TeamService(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }
        public IEnumerable<Team> GetTeams()
        {
            return _teamsRepository.GetTeams();
        }
        public void AddTeam(Team team)
        {
            _teamsRepository.AddTeam(team);
        }
        public void UpdateTeam(Team team)
        {
            _teamsRepository.updateTeam(team);
        }
        public void DeleteTeam(int teamId)
        {
            _teamsRepository.DeleteTeam(teamId);
        }
        public IEnumerable<Team> SearchTeam(string search)
        {
            return _teamsRepository.SearchTeam(search);
        }
    }
}
