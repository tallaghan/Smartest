using Smartest.Data;
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

        public ActionResult CreateChallenge(string challenger, string connectionId)
        {
            _challengesService.CreateChallenge(challenger, connectionId);

            return Json(challenger, JsonRequestBehavior.AllowGet); 

        }

        public ActionResult StartGame(int challengeId)
        {
            var model = _gamesService.GetAll().Where(x => x.Challenge.Id == challengeId).FirstOrDefault();

            return View("Game", Json(model));
        }


        public JsonResult GetActiveChallenges()
        {
            IList<Challenge> challenges = _challengesService.GetAll().Where(x => x.Active == true).ToList();

            return Json(challenges, JsonRequestBehavior.AllowGet);
        }


        public ActionResult AcceptChallenge(int challengeId, string opponent, string connectionIdOpponent)
        {
            _challengesService.AcceptChallenge(challengeId, opponent, connectionIdOpponent);

            
            return Json(challengeId, JsonRequestBehavior.AllowGet);

        }


    }
}