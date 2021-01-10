using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace gbuweb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "HomePlacements",
                url: "placements",
                new { controller = "Page", action = "placements" }
                );


            routes.MapRoute(
           name: "HomeExams",
           url: "examinations",
           new { controller = "Page", action = "examinations" }
           );
   routes.MapRoute(
           name: "HomeExamsNews",
           url: "examinations/phd-news",
           new { controller = "Page", action = "examinationsPhdNews" }
           );
            routes.MapRoute(
               name: "HomeResearch",
               url: "researchs",
               new { controller = "Page", action = "research" }
               );
            routes.MapRoute(
                name: "HomeRecruitment",
                url: "recruitment",
                new { controller = "Page", action = "recruitment" }
                );
            routes.MapRoute(
              name: "HomeFaq",
              url: "faqs",
              new { controller = "Page", action = "faqs" }
              );
            routes.MapRoute(
               name: "HomeGallery",
               url: "photogallery",
               new { controller = "Page", action = "gallery" }
               );
            routes.MapRoute(
              name: "HomeMOU",
              url: "mou",
              new { controller = "Page", action = "mous" }
              );
            routes.MapRoute(
              name: "HomeContact",
              url: "contact-us",
              new { controller = "Page", action = "Contact" }
              );
            routes.MapRoute(
              name: "HomeStudyCircle",
              url: "StudyCircle",
              new { controller = "Page", action = "Studycircle" }
              );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
