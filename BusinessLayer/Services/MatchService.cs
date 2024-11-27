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
        public MatchService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public IEnumerable<Match> GetMatches() => _matchRepository.GetMatches();

        public  void AddMatch(Match match) => _matchRepository.AddMatch(match);
        public void UpdateMatch(Match match) => _matchRepository.UpdateMatch(match);
        public void DeleteMatch(int matchId) => _matchRepository.DeleteMatch(matchId);
        public NextMatchDto? GetNextMatch(int userId) => _matchRepository.GetNextMatch(userId);

        public IEnumerable<Team> GetTeamIdAndName() => _matchRepository.GetTeamIdAndName();

        public IEnumerable<Match> GetMatchStatuses() => _matchRepository.MatchStatus();
    }
}
