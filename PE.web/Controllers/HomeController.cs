using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PE.web.Content
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Instructor()
        {
            return View();
        }
        public ActionResult Student()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}