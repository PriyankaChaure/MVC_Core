using Custome_ActionFilter.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Custome_ActionFilter.CustomeFilter
{
    public class ActionLogFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
           
            var contextInfo = context.HttpContext.RequestServices.GetRequiredService<Context>();
            ActionLog al = new ActionLog();
            al.ActionLogDate = DateTime.Now;
            //   al.ActionName = context.ActionDescriptor.DisplayName;
            al.ActionName = context.RouteData.Values["action"].ToString();
            al.ControllerName = context.RouteData.Values["controller"].ToString();
            contextInfo.Log.Add(al);
            contextInfo.SaveChanges();
        }
    }
}
