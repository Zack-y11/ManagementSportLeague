using CommonLayer.Enums;
using CommonLayer.Models;

namespace DataLayer.Repositories
{
    public interface IPlayerRepository
    {
        void Add(Player player);
        void Delete(int playerId);
        IEnumerable<Player> GetAll();
        IEnumerable<CoachPlayer> GetCoachPlayers(int _userId);
        void Update(Player player);
        void CreateUserPlayer(int creatorId, string email, string password, string name, string position, DateTime birthDate, int goals, int assists);
    }
}