using PE.BusinessLogic.DBModel;
using System.Linq;
using System.Web.Mvc;
using PE.web.Models;
using PE.Domain.Entities.User;
using PE.BusinessLogic;

namespace PE.web.Controllers
{
    public class ULoginController : Controller
    {
        private readonly BusinessLogic.BusinessLogic _businessLogic;
        public ULoginController()
        {
            _businessLogic = new BusinessLogic.BusinessLogic();
        }
        // GET: 
        [HttpGet]

        public ActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(userRegistration model)
        {
            if (ModelState.IsValid)
            {
               /* var _businessLogic = new BusinessLogic.BusinessLogic();*/
                var user = new userDbTable { LastName = model.LastName, FirstName = model.FirstName, Username = model.Username, Email = model.Email, Password = model.Password };
                _businessLogic.AddUser(user);
                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + "Registration is successful.";
                return RedirectToAction("Index", "Home");
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
            var user = _businessLogic.GetUserByUsermane(model.Username);
                if (user != null)
                {
                    Session["UserID"] = user.Id.ToString();
                    Session["Usename"] = user.Username.ToString();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                ModelState.AddModelError("", "Username or Password is wrong");
            }
            return View(model);
        }
    }
}