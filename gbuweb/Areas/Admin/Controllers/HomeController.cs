using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Areas.Admin.Controllers
{
    //if (name=='news' || name=='events' || name=='notices'||name=='workshops'||name=='conferences'||name=='activities')
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View("admin");
        }

        public ActionResult News()
        {
            return View("edit_admin");
        }

        public ActionResult events()
        {
            return View("edit_admin");
        }

        public ActionResult notices()
        {
            return View("edit_admin");
        }

        public ActionResult workshops()
        {
            return View("edit_admin");
        }

        public ActionResult conferences()
        {
            return View("edit_admin");
        }

        public ActionResult activities()
        {
            return View("edit_admin");
        }

  
        public ActionResult Etender()
        {
            return View("edit_e_tender");
        }
        public ActionResult Tender()
        {
            return View("edit_tender");
        }
        public ActionResult Recent()
        {
            return View("edit_recent");
        }

    }
}