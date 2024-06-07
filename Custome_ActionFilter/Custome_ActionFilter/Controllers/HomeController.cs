using Custome_ActionFilter.CustomeFilter;
using Microsoft.AspNetCore.Mvc;

namespace Custome_ActionFilter.Controllers
{
    //[ActionLogFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
