using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTuorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string text = "Hello";
            System.IO.File.WriteAllText(@"C:\Users\Cody\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MVCTuorial\log.txt", text);
            return View();
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
    }
}