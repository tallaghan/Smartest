using Smartest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Repositories
{
    public class GameRepository : Smartest.Repositories.IRepository<Game>
    {
        private SmartestDbContext db = new SmartestDbContext();

        public IQueryable<Game> GetAll()
        {
            return db.Games.AsQueryable();
        }

        public void CreateGame(string player1, string player2)
        {
            db.Games.Add(new Game { Player1 = player1, Player2 = player2 });
            db.SaveChanges();
        }

    }
}