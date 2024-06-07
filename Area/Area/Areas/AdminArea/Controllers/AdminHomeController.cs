using Microsoft.AspNetCore.Mvc;

namespace Area.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
