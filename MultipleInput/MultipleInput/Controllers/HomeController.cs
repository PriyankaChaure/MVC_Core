using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultipleInput.Models;
using MultipleInput.Reposiratories;

namespace MultipleInput.Controllers
{
    public class HomeController : Controller
    {
        IEmp ie;
        ISkill isk;
        public HomeController(IEmp ie, ISkill isk)
        {
            this.ie = ie;
            this.isk = isk;
        }
        public IActionResult Index()
        {
            return View(this.ie.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Skill=new SelectList(this.isk.GetAllSkill(),"SkillId","SkillName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmpSkillVM rec)
        {
            ViewBag.Skill=new SelectList(this.isk.GetAllSkill(), "SkillId", "SkillName");
            this.ie.GetCreate(rec);
            return RedirectToAction("Index");
        }
    }
}
