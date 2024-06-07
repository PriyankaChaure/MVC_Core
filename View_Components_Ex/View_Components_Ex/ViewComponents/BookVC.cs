using Microsoft.AspNetCore.Mvc;
using View_Components_Ex.Models;

namespace View_Components_Ex.ViewComponents
{
    public class BookVC:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Book book = new Book();
            return View(book);
        }
    }
}
