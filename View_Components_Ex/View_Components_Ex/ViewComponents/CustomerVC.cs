using Microsoft.AspNetCore.Mvc;
using View_Components_Ex.Models;

namespace View_Components_Ex.ViewComponents
{
    public class CustomerVC:ViewComponent
    {
        public IViewComponentResult Invoke(decimal crl)
        {
            Customer c = new Customer();
            var v = c.GetCustomers().Where(p=>p.CreaditLimit>crl);
            return View(v);
        }
    }
}
