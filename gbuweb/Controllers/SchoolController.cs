using gbuweb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gbuweb.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            return View("school");
        }

        public ActionResult Sob()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("sob", "_LayoutSchool", json);
            }
        }
        public ActionResult Sobs()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("sobs", "_LayoutSchool", json);
            }
        }
        public ActionResult Soe()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("soe", "_LayoutSchool", json);
            }
        }
        public ActionResult Soh()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("soh", "_LayoutSchool", json);
            }
        }
        public ActionResult Soict()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("soict", "_LayoutSchool", json);
            }
        }
        public ActionResult Soljg()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("soljg", "_LayoutSchool", json);
            }
        }
        public ActionResult Som()
        {

            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("som", "_LayoutSchool", json);
            }

        }
        public ActionResult Sovs()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/App_Data/tdata2.json")))
            {
                var json = JsonConvert.DeserializeObject<List<Faculty>>(sr.ReadToEnd());
                return View("sovs", "_LayoutSchool", json);
            }
        }
    }
}