using Smartest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Repositories
{
    public class ChallengeRepository : Smartest.Repositories.IRepository<Challenge>
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


    }
}