using Smartest.Data;
using System;
using System.Linq;

namespace Smartest.Repositories
{
    public interface IGameRepository
    {
        IQueryable<Game> GetAll();

        void CreateGame(string player1, string player2);
    }
}
