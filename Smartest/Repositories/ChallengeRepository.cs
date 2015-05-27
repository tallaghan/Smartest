using Smartest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Repositories
{
    public class ChallengeRepository : IChallengeRepository
    {
        private SmartestDbContext db = new SmartestDbContext();

        public IQueryable<Challenge> GetAll()
        {
            return db.Challenges.AsQueryable();
        }

        public void CreateChallenge(string challenger, string connectionId)
        {
            db.Challenges.Add(new Challenge { Challenger = challenger, ConnectionId = connectionId });
            db.SaveChanges();
        }

        public void AcceptChallenge(int challengeId, string opponent, string connectionIdOpponent)
        {
            db.Games.Add(new Game { ChallengeId = challengeId, Opponent = opponent, ConnectionIdOpponent = connectionIdOpponent });

            Challenge thisChallenge = db.Challenges.Where(x => x.Id == challengeId).FirstOrDefault();

            thisChallenge.Active = false;

            db.SaveChanges();
        }


    }
}