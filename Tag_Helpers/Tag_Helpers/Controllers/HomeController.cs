using Microsoft.AspNetCore.Mvc;
using Tag_Helpers.Models;

namespace Tag_Helpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            return View();
        }
    }
}
