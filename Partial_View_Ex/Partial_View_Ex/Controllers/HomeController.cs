using Microsoft.AspNetCore.Mvc;
using Partial_View_Ex.Models;

namespace Partial_View_Ex.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product p= new Product();
            return View(p);
        }
    }
}
