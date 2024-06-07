using Microsoft.AspNetCore.Mvc;
using View_Components_Ex.Models;

namespace View_Components_Ex.ViewComponents
{
    public class ProductVC:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Product p= new Product();
            return View(p);
        }
    }
}
