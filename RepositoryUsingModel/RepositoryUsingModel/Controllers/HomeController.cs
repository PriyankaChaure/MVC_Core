using Microsoft.AspNetCore.Mvc;
using RepositoryUsingModel.Repositories;

namespace RepositoryUsingModel.Models
{
    public class HomeController : Controller
    {
        CustInterface repo;
        public HomeController(CustInterface inter)
        {
            this.repo = inter;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer record)
        {
            this.repo.addcustomer(record);
           // return RedirectToAction("Index");
           return View();
        }
    }
}
