using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class AcademicsController : Controller
    {
        // GET: Academics
        public ActionResult Index()
        {
            return View();
        }  
        
        [ActionName("academic-programmes")]
        public ActionResult Programs()
        {
            return View("academics_programmes");
        }

        [ActionName("international-collaboration")]
        public ActionResult IntCollaboration()
        {
            return View("academics_collaboration");
        }

        [ActionName("international-student-affairs")]
        public ActionResult IntStudentsAffair()
        {
            return View("academics_affairs");
        }

        [ActionName("training-consultations")]
        public ActionResult TrainingConsultation()
        {
            return View("academics_training");
        }

        [ActionName("research-publication")]
        public ActionResult ResearchPublication()
        {
            return View("academics_research_publication");
        }

        [ActionName("anti-ragging")]
        public ActionResult AntiRagging()
        {
            return View("academics_ragging");
        }

        [ActionName("national-academic-depository")]
        public ActionResult Nad()
        {
            return View("academics_depository");
        }
    }
}