using Microsoft.AspNetCore.Mvc;

namespace LoggingEx.Controllers
{
    public class HomeController : Controller
    {
        ILogger<HomeController> logger;
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }
        public IActionResult Index()
        {
            this.logger.LogInformation("Index Action Called!!!!!!!!!!!!!!");
            return View();
        }
        public IActionResult About()
        {
            this.logger.LogInformation("About Action Called!!!!!!!!!!!!!!");
            return View();
        }
        public IActionResult Contact()
        {
            this.logger.LogInformation("Contact Action Called!!!!!!!!!!!!!!");
            return View();
        }
    }
}
