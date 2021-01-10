using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class AboutController :   Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Vision()
        {
           // ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Act() { return View(); }
        public ActionResult Bodies() { return View(); }
        public ActionResult Committee() { return View(); }
        public ActionResult Forums() { return View(); }
        public ActionResult Contact() { return View(); }
        public ActionResult Nirf(){return View(); }
        public ActionResult Organisation() { return View(); }
        public ActionResult Regulatorybodies() { return View(); }
        public ActionResult Rti() { return View(); }
        public ActionResult Vc() { return View(); }
    }
}