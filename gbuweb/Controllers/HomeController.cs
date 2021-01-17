using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
   
    public class HomeController : Controller
    { 
        private gbuweb.Models.MyDbContext _db = new gbuweb.Models.MyDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult EntityList()
        {

            IList<Models.Entity> entities = new List<Models.Entity>();
            entities = (from s in _db.Entities select s).ToList();

            return PartialView("home_entity", entities);
        }

        public ActionResult About()
        {
            
            return View();
        }

        public JsonResult getRecentNews(int? userId)
        {
            IList<Models.Recent> Recents = new List<Models.Recent>();

            Recents = Models.Recent.getRecentNews();

            return Json(new { Recents = Recents }, JsonRequestBehavior.AllowGet);
        }

    }
}