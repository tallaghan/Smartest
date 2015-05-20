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

        public void CreateChallenge(string challenger)
        {
            db.Challenges.Add(new Challenge { Challenger = challenger });
            db.SaveChanges();
        }

        public void AcceptChallenge(int challengeId, string opponent)
        {
            db.Games.Add(new Game { ChallengeId = challengeId, Opponent = opponent });

            Challenge thisChallenge = db.Challenges.Where(x => x.Id == challengeId).FirstOrDefault();

            thisChallenge.Active = false;

            db.SaveChanges();
        }


    }
}