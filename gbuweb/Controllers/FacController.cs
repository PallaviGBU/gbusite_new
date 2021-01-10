using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gbuweb.Models;
using Newtonsoft.Json;

namespace gbuweb.Controllers
{
    public class FacController : Controller
    {
    

        // GET: Faculty
        public ActionResult Index()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                 var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
               //  return View("faculty", json);
                return View("faculty",json);
            }
        }

        public JsonResult GetFaculty()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {

                List<Faculty> json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
              
                return Json(json,JsonRequestBehavior.AllowGet);
            }



        }
        public ActionResult GetFaculty1(string searchString)
        {
            //  var faclist = new List<Faculty>
            //   {
            //     new Faculty{ id=1,name= "Amit",position="Assistant Professor"}
            //   };
            // var deserialized = JsonConvert.DeserializeObject<Root>(json);

            //return View(deserialized.Faculty);
            //  return View("get_faculty",faclist);

            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                if (!String.IsNullOrEmpty(searchString))
                {json = json.Where(s => s.name.Contains("sol")).ToList(); }
               
                return View("get_faculty",json);
            }
        }


        public ActionResult Tests()
        {
            var faclist = new List<Faculty>
            {
               new Faculty{ id=1,name= "Amit",position="Assistant Professor"}
            };


            return View("tests", faclist);
        }


    }
}