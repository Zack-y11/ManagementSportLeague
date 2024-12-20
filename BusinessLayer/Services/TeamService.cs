﻿using DataLayer.Repositories;
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

        public IEnumerable<User> GetManagers()
        {
            return _teamsRepository.GetManagers();
        }
        public int GetTeamVictoriesCount(int teamId)
        {
            return _teamsRepository.GetTeamVictoriesCount(teamId);
        }
        public int GetTeamPlayersCount(int userId)
        {
            return _teamsRepository.GetTeamPlayersCount(userId);
        }
        public IEnumerable<TeamStandingsDto> GetTeamStandings()
        {
            return _teamsRepository.GetTeamStandings();
        }

        public IEnumerable<Team> GetRankedTeams()
        {
            return _teamsRepository.GetRankedTeams();
        }
        public int GetMatchesCount()
        {
            return _teamsRepository.GetTotalMatchesCount();
        }

        public int GetFouslCount()
        {
            return _teamsRepository.GetTotalFoulsCount();
        }

        public int GetCornersCount()
        {
            return _teamsRepository.GetTotalCornersCount();
        }

        public CoachTeam GetManagerFromTeam(int teamId)
        {
            return _teamsRepository.GetManagerFromTeam(teamId);

        }
        public IEnumerable<CoachTeam> GetCoachTeamFromPlayer(int playerId)
        {
            return _teamsRepository.GetCoachTeamFromPlayer(playerId);
        }
    }
}
