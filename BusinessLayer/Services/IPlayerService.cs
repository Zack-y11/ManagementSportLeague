using CommonLayer.Models;

namespace BusinessLayer.Services
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Delete(int playerId);
        IEnumerable<Player> GetAll();
        void Update(Player player);
    }
}