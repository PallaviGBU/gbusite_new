using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class CampuslifeController : Controller
    {
        // GET: Campuslife
        public ActionResult Index()
        {
            return View("campus");
        }
    }
}