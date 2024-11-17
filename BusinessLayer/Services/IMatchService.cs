using CommonLayer.Entities;

namespace BusinessLayer.Services
{
    public interface IMatchService
    {
        IEnumerable<Match> GetMatches();
    }
}