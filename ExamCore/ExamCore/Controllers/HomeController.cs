using Microsoft.AspNetCore.Mvc;

namespace ExamCore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index view called";
        }
    }
}
