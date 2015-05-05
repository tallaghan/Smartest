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
        private IRepository<Game> _gamesRepository;

        public GamesService(IRepository<Game> gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }


    }
}