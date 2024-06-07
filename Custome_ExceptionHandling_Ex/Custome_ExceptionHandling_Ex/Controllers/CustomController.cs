using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Custome_ExceptionHandling_Ex.Controllers
{
    public class CustomController : Controller
    {
        [Route("CustomeError")]
        public IActionResult show()
        {
            var errorinfo = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.path = errorinfo.Path.ToString();
            ViewBag.error= errorinfo.Error.Message;
            return View();
        }
    }
}
