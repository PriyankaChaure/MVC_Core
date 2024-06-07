
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Custome_Authorization_Filter.CustomFilter
{
    public class UserAuth:ActionFilterAttribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(context.HttpContext.Session.GetString("UserId") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home",Action="SignIn",Area=""}));
            }
        }

    }
}
