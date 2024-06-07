using Antiforgery_Teken.Models;
using Microsoft.AspNetCore.Mvc;

namespace Antiforgery_Teken.Controllers
{
    [AutoValidateAntiforgeryToken]
  //  [ValidateAntiForgeryToken]
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
        public IActionResult Create(Product rec)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}
