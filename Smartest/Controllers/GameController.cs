using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smartest.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Challenge()
        {
            return View();
        }

        public ActionResult CreateChallenge(string challenger)
        {
            return Json(challenger, JsonRequestBehavior.AllowGet); 

        }

    }
}