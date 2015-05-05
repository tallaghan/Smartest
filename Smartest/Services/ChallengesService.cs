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

        private IRepository<Challenge> _challengesRepository;

        public ChallengesService(IRepository<Challenge> challengesRepository)
        {
            _challengesRepository = challengesRepository;
        }

    }
}