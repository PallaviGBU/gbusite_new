using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class IprController : Controller
    {
        // GET: Ipr
        public ActionResult Index()
        {
            return View("iprcell_home");
        }
        public ActionResult Home()
        {
            return View("iprcell_home");
        }

        public ActionResult People()
        {
            return View("iprcell_people");
        }

        public ActionResult Courses()
        {
            return View("iprcell_courses");
        }

        public ActionResult Policy()
        {
            return View("iprcell_policy");
        }

        public ActionResult Iprs()
        {
            return View("iprs");
        }

        public ActionResult Links()
        {
            return View("iprcell_links");
        }
        [ActionName("contact-us")]
        public ActionResult Contact()
        {
            return View("iprcell_contact");
        }

    }
}