using Smartest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smartest.Controllers
{
    public class GameController : Controller
    {
        private ChallengesService _challengesService;
        private GamesService _gamesService;

        public GameController(ChallengesService challengesService, GamesService gamesService)
        {
            _challengesService = challengesService;
            _gamesService = gamesService;
        }

        // GET: Game
        public ActionResult Challenge()
        {
            return View();
        }

        public ActionResult CreateChallenge(string challenger)
        {

            _challengesService.CreateChallenge(challenger);

            return Json(challenger, JsonRequestBehavior.AllowGet); 

        }

    }
}