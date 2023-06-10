using PE.Domain.Entities.User;
using PE.web.Models;
using System.Web;
using System;
using System.Web.Mvc;
using PE.BusinessLogic;

namespace PE.web.Controllers
{
    public class ULoginController : BaseController
    {
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(userRegistration model)
        {
            if (ModelState.IsValid)
            {
                var user = new userDbTable { LastName = model.LastName, FirstName = model.FirstName, Username = model.Username, Email = model.Email, Password = model.Password };
                _businessLogic.AddUser(user);
                return RedirectToAction("Login", "ULogin");
            }
            return View(model);
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(userLogin model)
        {
            var user = _businessLogic.GetUserByUsername(model.Username);
            if (user != null)
            {
                Session["UserID"] = user.Id;
                Session["Usename"] = user.Username;
                var cookie = _businessLogic.Session.SetCurrentSession(user);
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Home", user);
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is wrong");
            }
            return View(model);
        }
    }
}