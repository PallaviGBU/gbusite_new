using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Views
{
    public class PageController : Controller
    {
       

        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult campuslife()
        {
            return View("campus");
        }

        public ActionResult clubs()
        {
            return View();
        }

        public ActionResult Contact()
        {
                        return View();
        }

           public ActionResult Recruitment()
        {
                        return View();
        }
  public ActionResult examinations()
        {
            return View();
        }

        public ActionResult examinationsPhdNews()
        {
            return View("examinations_phd_news");

        }
        public ActionResult Research()
        {
            return View();
        }

        public ActionResult Placements()
        {
            return View("placements", "_LayoutCRC");
        }

        public ActionResult Faqs()
        {
            return View("faqs");
        }
        public ActionResult Studycircle()
        {
            return View();
        }
        public ActionResult Mous()
        {
            return View("mous");
        }

        public ActionResult Gallery()
        {
            return View("gallery");
        }

        public ActionResult Ccc()
        {
            return View();
        }

        public ActionResult Crc()
        {
            return View();
        }
        public ActionResult Tender()
        {
            return View();
        }

        public ActionResult Etender()
        {
            return View();
        }

        public ActionResult Ipr()
        {
            return View("iprs");
        }

        public ActionResult Media()
        {
            return View();
        }

        public ActionResult Ecell()
        {
            return View();
        }
        [ActionName("cultural-council")]
        public ActionResult Culturalcouncil()
        {
            return View("cultural-council");
        }

        [ActionName("sport-council")]
        public ActionResult Sportcouncil()
        {
            return View("sport-council");
        }
        [ActionName("meditation-center")]
        public ActionResult Meditation()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        public ActionResult Sitemap()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult Hostel()
        {
            return View();
        }

        public ActionResult Event(int? id)
        {
            var _db = new Models.MyDbContext();
            var data = from s in _db.Entities where s.id == id select s;
            return View("entity",data);
        }
    }
}