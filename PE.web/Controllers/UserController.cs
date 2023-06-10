using PE.Domain.Entities.User;
using PE.web.App_Start;
using System.Web.Mvc;

namespace PE.web.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
            var users = _businessLogic.GetUsers();
            return View(users);
        }
        public ActionResult UserDashboard()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RemoveUser(int id)
        { 
            _businessLogic.RemoveUserbyId(id);
            return RedirectToAction("Index");
        }
    }
}
