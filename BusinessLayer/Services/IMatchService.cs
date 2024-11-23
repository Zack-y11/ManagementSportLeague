using CommonLayer.Models;

namespace BusinessLayer.Services
{
    public interface IMatchService
    {
        IEnumerable<Match> GetMatches();
    }
}