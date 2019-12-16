using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Controllers
{
    public class HomeController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        public ActionResult Index()
        {
            var sidebars = db.SideBars.ToList();
            ViewBag.SideBars = sidebars;
            // var siteInfo = new WebsiteInfo("Demo", "RIGHT");
            //ViewBag.SiteInfo = siteInfo;

            // ViewData["SiteInfo"] = siteInfo;

            // if(new Random().Next(2)==0)

            // return View("~/Views/Home/View.cshtml");
            // else
           
             return View();

           // return View("~/Views/Home/View2.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]

        public ActionResult NavBar()
        {
            var site = new WebsiteInfo();
            ViewBag.Site = site;
            
            return PartialView("~/Views/Shared/NavBar.cshtml");
        }
        public ActionResult SideBar()
        {
            var sidebars = db.SideBars.ToList();
            ViewBag.SideBars = sidebars;

            return PartialView("~/Views/Shared/SideBar.cshtml");
        }

        
    }
}