using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using PE.BusinessLogic;
using PE.BusinessLogic.Core;
using PE.BusinessLogic.Interfaces;

namespace PE.web.Content
{
    public class HomeController : Controller
    {
        private readonly ISession _session;
        // GET: Home
        public HomeController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _session = bl.GetSessionBL();

        }
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