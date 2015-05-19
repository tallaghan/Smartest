using Smartest.Data;
using Smartest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Services
{
    public class ChallengesService
    {
        private IChallengeRepository _challengesRepository;

        public ChallengesService(IChallengeRepository challengesRepository)
        {
            _challengesRepository = challengesRepository;
        }

        public void CreateChallenge(string challenger)
        {
            _challengesRepository.CreateChallenge(challenger);
        }


        public IList<Challenge> GetAll()
        {
            return _challengesRepository.GetAll().ToList();
        }
    }
}