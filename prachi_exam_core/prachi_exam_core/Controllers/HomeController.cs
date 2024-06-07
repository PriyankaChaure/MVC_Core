using Microsoft.AspNetCore.Mvc;
using prachi_exam_core.Models;
using System.Linq;

namespace prachi_exam_core.Controllers
{
    public class HomeController : Controller
    {
        ContextClass cc;
        public HomeController(ContextClass cc)
        {
            this.cc = cc;
        }
        public IActionResult Index()
        {
            var v = from t1 in this.cc.Employees
                    join t2 in this.cc.EmpSalarys
                    on t1.EmpId equals t2.EmpId
                    join t3 in this.cc.SalaryAdditions
                    on t1.EmpId equals t3.EmpId
                    join t4 in this.cc.salayDeductions
                    on t1.EmpId equals t4.EmpId
                    group t1 by t1.FirstName into g
                    select new Emp_sal_dedu_Add_VM
                    {
                      FirstName=g.Key,
                      BasicAmount=g.Sum(p=>p.EmpSalaries.),
                      //TotalAdditions=g.Sum(p=>p.)
                    };
            return View(v.ToList());
        }
    }
}
