using Microsoft.AspNetCore.Mvc;

namespace EndPointRounting_Ex.Controllers
{
    public class HomeController : Controller
    {
        [Route("h/i")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
