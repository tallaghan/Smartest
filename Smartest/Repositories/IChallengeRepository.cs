﻿using Smartest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartest.Repositories
{
    public interface IChallengeRepository
    {
        void CreateChallenge(string challenger, string connectionId);

        void AcceptChallenge(int challengeId, string opponent, string connectionIdOpponent);

        IQueryable<Challenge> GetAll();
    }
}
