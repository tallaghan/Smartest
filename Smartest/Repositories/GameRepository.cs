using Smartest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Repositories
{
    public class GameRepository : IGameRepository
    {
        private SmartestDbContext db = new SmartestDbContext();

        public IQueryable<Game> GetAll()
        {
            return db.Games.AsQueryable();
        }

        public void CreateGame( int challengeId, string opponent)
        {
            db.Games.Add(new Game { ChallengeId = challengeId, Opponent = opponent });
            db.SaveChanges();
        }

    }
}