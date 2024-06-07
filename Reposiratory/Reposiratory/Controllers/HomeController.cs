using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Models;
using Reposiratory.Repositories;
using System;
using System.Linq;

namespace Reposiratory.Controllers
{
    public class HomeController : Controller
    {
        EmpInterface rep;
        public HomeController(EmpInterface ep)
        {
           this.rep = ep;
        }
        public IActionResult Index()
        {
            return View(this.rep.getemployee());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee record)
        {
            this.rep.addemployee(record);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public  IActionResult searchbyname(string EmpName)
        {
            ViewBag.EmpId = new SelectList(this.rep.getemployee(), "EmpId", "Empname");
            if (EmpName == "")
                return RedirectToAction("Index");
            else
            {
                var v = EmpName.StartsWith(EmpName); 
                return View("Index", v);
            }
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.rep.getemployee().SingleOrDefault(p => p.EmpId == id);
            return View(rec);
        }
        [HttpPost]
        public ActionResult Edit(Employee rec)
        {
          
            return RedirectToAction("Index");
        }
    }
}
