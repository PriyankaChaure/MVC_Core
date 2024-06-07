using Microsoft.AspNetCore.Mvc;
using MVC_Ex.Models;
using System;

namespace MVC_Ex.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetCustomers()
        {
            Customer cust = new Customer();
            var r = cust.GetCustomers();
            return View(r);
        }
    }
}
