using Microsoft.AspNetCore.Mvc;
using usedefaultfiles.Models;
using System;
using System.Collections.Generic;



namespace usedefaultfiles.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetCustomers()
        {
            CustomerController cust = new CustomerController();
            var r = cust.GetCustomers();
            return View(r);
        }
    }
}
