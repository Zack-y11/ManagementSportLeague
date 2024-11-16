using CommonLayer.Entities;
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
    }
}
