using CommonLayer.Models;

namespace BusinessLayer.Services
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Delete(int playerId);
        IEnumerable<Player> GetAll();
        IEnumerable<CoachPlayer> GetCoachPlayers(int userId);
        void Update(Player player);
        void CreateUserPlayer(int creatorId, string email, string password, string name, string position, DateTime birthDate, int goals, int assists);
    }
}