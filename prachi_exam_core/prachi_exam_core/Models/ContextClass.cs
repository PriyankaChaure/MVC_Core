using Microsoft.EntityFrameworkCore;

namespace prachi_exam_core.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> opt) : base(opt)
        { }
        public DbSet<Emp> Employees { get; set; }
        public DbSet<EmpSalary> EmpSalarys { get; set;}
        public DbSet<SalaryAddition> SalaryAdditions { get; set; }
        public DbSet<SalayDeduction> salayDeductions { get; set; }

    }
}
