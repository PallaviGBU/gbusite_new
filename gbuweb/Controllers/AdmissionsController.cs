//using gbuweb.Models;
using System.Linq;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class AdmissionsController : Controller
    {
        // GET: Admissions
        private gbuweb.Models.MyDbContext _db = new gbuweb.Models.MyDbContext();
        // GET: Home  
        
        public ActionResult Index()
        {
            //var data = (from s in N select s).ToList();
            // var data = (from s in _db.Notices select s ).ToList();
            var data = _db.Notices.ToList();
           // ViewBag.users = data;
          //  ViewBag.title = "MVC5 - Hello World";
            return View(data);
        }
         public ActionResult Program(int? id)
        {
            IQueryable<Models.Program>  data;
            if (id == null)
            {
                
                data = from s in _db.Programs select s;
                return View("admission_programm_all", data);
            }
            else
            {
                var pid = id;
                data = from s in _db.Programs where s.id == pid select s;
                return View("admission_programm", data);
            }

            
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
        public ActionResult Program11()
        {
            return View("admission_programm");
        }
        public ActionResult Team()
        {
            return View("admission_team");
        }

    }
}