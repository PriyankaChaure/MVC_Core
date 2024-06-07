using Custome_Authorization_Filter.CustomFilter;
using Microsoft.AspNetCore.Mvc;

namespace Custome_Authorization_Filter.Areas.User_Area.Controllers
{
    [Area("User_Area")]
    [UserAuth]
    public class UserHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
