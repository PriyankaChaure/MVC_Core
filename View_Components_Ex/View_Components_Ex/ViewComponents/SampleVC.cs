
using Microsoft.AspNetCore.Mvc;

namespace View_Components_Ex.ViewComponents
{
    public class SampleVC:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
