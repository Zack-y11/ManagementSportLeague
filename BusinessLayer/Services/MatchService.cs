using CommonLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepository;
        private readonly IEmailService _emailService;
        private readonly ITeamService _teamsService;
        public MatchService(IMatchRepository matchRepository, IEmailService emailService, ITeamService teamsService)
        {
            _matchRepository = matchRepository;
            _emailService = emailService;
            _teamsService = teamsService;
        }
        public IEnumerable<Match> GetMatches() => _matchRepository.GetMatches();

        public async void AddMatch(Match match) =>_matchRepository.AddMatch(match);
        public void UpdateMatch(Match match) => _matchRepository.UpdateMatch(match);
        public void DeleteMatch(int matchId) => _matchRepository.DeleteMatch(matchId);
        public NextMatchDto? GetNextMatch(int userId) => _matchRepository.GetNextMatch(userId);

        public IEnumerable<Team> GetTeamIdAndName() => _matchRepository.GetTeamIdAndName();

        public IEnumerable<Match> GetMatchStatuses() => _matchRepository.MatchStatus();
    }
}
