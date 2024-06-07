using Microsoft.AspNetCore.Mvc;

namespace View_Components_Ex.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
