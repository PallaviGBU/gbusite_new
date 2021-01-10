using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class ClubController : Controller
    {
        // GET: Clubs
        public ActionResult Index()
        {
            return View("clubs");
        }

        public ActionResult Adventure()
        {
            return View("club_adventure");
        }
        [ActionName("art-painting")]
        public ActionResult Art()
        {
            return View("club_art");
        }


        public ActionResult Audio()
        {
            return View("club_audio");
        }
        [ActionName("bodhi-mindfulness")]
        public ActionResult Bodhi()
        {
            return View("club_bodhi");
        }
        public ActionResult Creativity()
        {
            return View("club_creativity");
        }
        public ActionResult Dance()
        {
            return View("club_dance");
        }
        [ActionName("dhristikon")]
        public ActionResult Debating()
        {
            return View("club_debating");
        }
        public ActionResult Drama()
        {
            return View("club_drama");
        }
        public ActionResult literary()
        {
            return View("club_literary");
        }
        public ActionResult Music()
        {
            return View("club_music");
        }
        public ActionResult Nature()
        {
            return View("club_nature");
        }
        public ActionResult Photography()
        {
            return View("club_Photography");
        }

        public ActionResult Social()
        {
            return View("club_social");
        }

        public ActionResult Techno()
        {
            return View("club_techno");
        }
        [ActionName("website-council")]
        public ActionResult website()
        {
            return View("club_website");
        }
    }
}

