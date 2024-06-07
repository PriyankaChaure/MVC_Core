﻿using CurdUsingRepoDI.Models;
using CurdUsingRepoDI.Reposiratories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CurdUsingRepoDI.Controllers
{
    public class HomeController : Controller
    {
       EmpInterface er;
        DeptInterface dr;
        public HomeController(EmpInterface er, DeptInterface dr)
        {
            this.er = er;
            this.dr = dr;
        }
        public IActionResult Index()
        {
            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName");
            return View(this.er.GetAllEmp());
        }
        [HttpGet]
        public IActionResult Search(Int64 DeptId)
        {
            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName",DeptId);
            var rec=this.er.GetDeptId(DeptId);
            return View("Index",rec.ToList());
        }
        [HttpGet]
        public IActionResult SearchbyAscending()
        {
            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName");
            var rec= this.er.SearchAscending();
            return View("Index", rec.ToList());  
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp rec)
        {
            if(ModelState.IsValid)
            {
                this.er.Add(rec);
                return RedirectToAction("Index");
            }
            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName", rec.DeptId);
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
           var rec= this.er.GetEmpById(id);

            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName",rec.DeptId);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Emp rec)
        {
            if (ModelState.IsValid)
            {
                this.er.Edit(rec); 
                return RedirectToAction("Index");
            }
            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName",rec.DeptId);
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.er.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.er.GetEmpById(id);
            ViewBag.DeptId = new SelectList(this.dr.GetAllDept(), "DeptId", "DeptName",rec.DeptId);
            return View(rec);
        }
    }
}