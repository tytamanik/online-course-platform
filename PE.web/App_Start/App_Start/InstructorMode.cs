using PE.BusinessLogic;
using PE.web.Controllers;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using static PE.Domain.Enums.Roles;

namespace PE.web.App_Start
{
    public class InstructorModeAttribute : AuthorizeAttribute
    {
        protected BusinessLogic.BusinessLogic _businessLogic;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            // Check if the user is authenticated
            var cookie = httpContext.Request.Cookies["X-Jay"];
            if (cookie == null)
                return false;
            _businessLogic = new BusinessLogic.BusinessLogic();
            var currentUserId = _businessLogic.Session.GetCurrentSession(cookie);
            var user = _businessLogic.GetUserById(currentUserId);

            // Check the user's role
            if (user != null && user.Role == URoles.instructor)
                return true;

            return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
            {
                controller = "Base",
                action = "Error"
            }));
        }
    }
}
