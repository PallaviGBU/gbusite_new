using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class LibController : Controller
    {
        // GET: Library
        public ActionResult Index()
        {
            return View("library","_LayoutLibrary");
        }
    }
}