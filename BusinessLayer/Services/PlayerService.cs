using CommonLayer.Models;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IEmailService _emailService;

        public PlayerService(IPlayerRepository playerRepository, IEmailService emailService)
        {
            _playerRepository = playerRepository;
            _emailService = emailService;
        }
        public IEnumerable<Player> GetAll()
        {
            return _playerRepository.GetAll();
        }
        public IEnumerable<CoachPlayer> GetCoachPlayers(int _userId)
        {
            return _playerRepository.GetCoachPlayers(_userId);
        }
        public IEnumerable<CoachPlayer> GetCoachPlayerInfo(int _userId)
        {
            return _playerRepository.GetCoachPlayerInfo(_userId);
        }
        public void Add(Player player)
        {
            _playerRepository.Add(player);
        }
        public void Update(Player player)
        {
            _playerRepository.Update(player);
        }
        public void Delete(int playerId)
        {
            _playerRepository.Delete(playerId);
        }
        public void CreateUserPlayer(int creatorId, string email, string password, string name, string position, DateTime birthDate, int goals, int assists)
        {
            _playerRepository.CreateUserPlayer(creatorId, email, password, name, position, birthDate, goals, assists);
            Task.Run(() => _emailService.SendWelcomeEmailAsync(email, name, password));
        }
    }
}
