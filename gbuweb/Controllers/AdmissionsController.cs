using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class AdmissionsController : Controller
    {
        // GET: Admissions
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View("admission_contact");
        }
        public ActionResult Query()
        {
            return View("admission_query");
        }
        public ActionResult Internationalstudents()
        {
            return View("admissions_international_students");
        }
        public ActionResult Dates()
        {
            return View("admission_dates");
        }
        public ActionResult Feestructure()
        {
            return View("admission_fee_structure");
        }
        public ActionResult Program()
        {
            return View("admission_programm");
        }
        public ActionResult Team()
        {
            return View("admission_team");
        }

    }
}