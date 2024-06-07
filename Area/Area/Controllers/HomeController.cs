using Microsoft.AspNetCore.Mvc;

namespace Area.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
