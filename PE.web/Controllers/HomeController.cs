using PE.web.Models;
using PE.Domain.Entities.User;
using System.Web.Mvc;

namespace PE.web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(userDbTable user)
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}