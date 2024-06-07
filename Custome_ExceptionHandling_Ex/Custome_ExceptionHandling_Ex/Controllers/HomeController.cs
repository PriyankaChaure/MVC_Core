using Microsoft.AspNetCore.Mvc;

namespace Custome_ExceptionHandling_Ex.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int dodivision(int a, int b)
        {
            return a / b;
        }
    }
}
