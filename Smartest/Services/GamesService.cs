using Smartest.Data;
using Smartest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Services
{
    public class GamesService
    {
        private IGameRepository _gamesRepository;

        public GamesService(IGameRepository gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }


    }
}