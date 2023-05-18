using System.Web.Mvc;
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
        public ActionResult Contact()
        {
            return View();
        }
    }
}