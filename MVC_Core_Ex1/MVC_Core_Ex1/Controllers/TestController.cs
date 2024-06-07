using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_Ex1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
