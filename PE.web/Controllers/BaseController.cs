using PE.Domain.Entities.User;
using PE.web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace PE.web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly BusinessLogic.BusinessLogic _businessLogic;
        protected int? currentUserId;

        // GET: Base
        public BaseController()
        {
            _businessLogic = new BusinessLogic.BusinessLogic();
            currentUserId = null;
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            currentUserId = GetCookie();
            ViewBag.Exception = true;
            if (currentUserId != null)
            {
                ViewBag.CurrentUser = _businessLogic.GetUserById(currentUserId);
            }
            else ViewBag.Exception = false;
            base.OnActionExecuting(filterContext);
        }

        public int? GetCookie()
        {
            HttpCookie cookie = Request.Cookies["X-Jay"];
            return _businessLogic.Session.GetCurrentSession(cookie);
        }

        public ActionResult Error()
        {
            return View();
        }
        public ActionResult RemoveCookie()
        {
            HttpCookie cookie = new HttpCookie("X-Jay");
            cookie.Value = "";

            return RedirectToAction("Index", "Home"); // Redirect to an appropriate action
        }
    }
}