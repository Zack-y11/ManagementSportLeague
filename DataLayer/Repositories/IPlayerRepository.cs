using CommonLayer.Models;

namespace DataLayer.Repositories
{
    public interface IPlayerRepository
    {
        void Add(Player player);
        void Delete(int playerId);
        IEnumerable<Player> GetAll();
        void Update(Player player);
    }
}