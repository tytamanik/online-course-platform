using PE.web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PE.web.Controllers
{
    public class UserController : Controller
    {
        private readonly BusinessLogic.BusinessLogic _businessLogic;
        public UserController()
        {
            _businessLogic = new BusinessLogic.BusinessLogic();
        }
        // GET: User
        [AdminMode]
        public ActionResult Index()
        {
            var users = _businessLogic.GetUsers();
            return View(users);
        }
        [Authorize]
        public ActionResult UserDashboard()
        {
            return View();
        }
    }
}