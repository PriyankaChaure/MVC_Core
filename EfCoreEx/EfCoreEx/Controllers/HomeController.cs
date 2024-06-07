using EfCoreEx.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace EfCoreEx.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;
        public HomeController(CompanyContext cc)
        {
            this.cc = cc;
        }

        public IActionResult Index()
        {
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName");
            return View(this.cc.Products.ToList());
        }
        [HttpPost]
        public IActionResult searchbyproductname(string proname="")
        {
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName");
            if (proname==null)
            {
                return View("Index", this.cc.Products.ToList());
            }
            else
            {
                var v = this.cc.Products.Where(p => p.Productname.StartsWith(proname));
                return View("Index", v.ToList());
            }
        }
        [HttpPost]
        public IActionResult searchbycategory(Int64 catid=0)
        {
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName");

            if (catid==0)
            {
                return View("Index", this.cc.Products.ToList());
            }
            else
            {
                var v = this.cc.Products.Where(p => p.CategoryId == catid);
                return View("Index", v.ToList());
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName");

            return View();  
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName");

            if (ModelState.IsValid)
            {
                if (rec.Price % 2 == 0)
                {
                    this.cc.Products.Add(rec);
                    this.cc.SaveChanges();
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("Price", "Price should be even!");
                return View();
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.cc.Products.Find(id);
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName",rec.CategoryId);
            return View (rec);
        }
        [HttpPost]
        public IActionResult Edit(Product rec)
        {
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName", rec.CategoryId);
            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
               
                this.cc.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec=this.cc.Products.Find(id);
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {

            var rec = this.cc.Products.Find(id);
            ViewBag.categories = new SelectList(this.cc.Categories.ToList(), "CategoryId", "CategoryName", rec.CategoryId);
            return View(rec);
        }
    }
}
