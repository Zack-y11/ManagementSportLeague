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
        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public IEnumerable<Player> GetAll()
        {
            return _playerRepository.GetAll();
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
        public void CreateUserPlayer(int creatorId, string email, string password, string name, string position, DateTime birthDate)
        {
            _playerRepository.CreateUserPlayer(creatorId, email, password, name, position, birthDate);
        }
    }
}
