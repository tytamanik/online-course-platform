using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using static PE.Domain.Enums.Roles;

namespace PE.web.App_Start
{
    public class AdminModeAttribute : ActionFilterAttribute
    {
        private readonly BusinessLogic.BusinessLogic _businessLogic;
        public AdminModeAttribute()
        {
            _businessLogic = new BusinessLogic.BusinessLogic();
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var currentUsername = (string)HttpContext.Current.Session["Username"];
            var user = _businessLogic.GetUserByUsermane(currentUsername);
            if (user != null && user.Role == URoles.admin)
            {
                HttpContext.Current.Session.Add("__SessionObject", user.Role);
                return;
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Error", Action = "Error404" }));
            }
        }
    }
}