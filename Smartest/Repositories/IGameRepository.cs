using Smartest.Data;
using System;
using System.Linq;

namespace Smartest.Repositories
{
    public interface IGameRepository
    {
        IQueryable<Game> GetAll();

        void CreateGame(int  challengeId, string opponent);
    }
}
