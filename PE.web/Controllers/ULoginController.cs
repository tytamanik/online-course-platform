using PE.BusinessLogic.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using PE.web.Models;
using PE.Domain.Entities.User;

namespace PE.web.Controllers
{
    public class ULoginController : Controller
    {
        // GET: 
        [HttpGet]
        public ActionResult Index()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return View(db.Users.ToList());
            }
        }

        public ActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(userDbTable user)
        {
            if (ModelState.IsValid)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + "Registration is successful.";
            }
            return View();
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(userDbTable user)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var usr = db.Users.Single(u => u.Username == user.Username && u.Password == user.Password);
                if (usr != null)
                {
                    Session["UserID"] = usr.Id.ToString();
                    Session["Usename"] = usr.Username.ToString();
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}