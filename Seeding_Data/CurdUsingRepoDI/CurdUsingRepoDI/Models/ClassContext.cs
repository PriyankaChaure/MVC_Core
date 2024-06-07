using Microsoft.EntityFrameworkCore;

namespace CurdUsingRepoDI.Models
{
    public class ClassContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder mb)
        {
           // base.OnModelCreating(mb);
           mb.Entity<Dept>().HasData
               (
                  new Dept() { DeptId=1,DeptName="Cpmputer"},
                  new Dept() { DeptId = 2, DeptName = "Mechanical" },
                  new Dept() { DeptId = 3, DeptName = "Civil" },
                  new Dept() { DeptId = 4, DeptName = "ENTC" }
               );
            mb.Entity<Emp>().HasData
                (
                  new Emp() { EmpId=1,EmpName="Priyanka",EmpAddress="Pune",EmpEmailId="priya@gmail.com",EmpMobileNo="9876543210",EmpSalary=9876,DeptId=1},
                  new Emp() { EmpId = 2, EmpName = "Sweety", EmpAddress = "Pune", EmpEmailId = "sweety@gmail.com", EmpMobileNo = "9999543210", EmpSalary = 9777, DeptId = 2 },
                  new Emp() { EmpId = 3, EmpName = "Guddi", EmpAddress = "Pune", EmpEmailId = "guddi@gmail.com", EmpMobileNo = "9888543210", EmpSalary = 9555, DeptId = 3 }
                );
        }
        public ClassContext(DbContextOptions<ClassContext> opt):base(opt) { }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Dept> Depts { get; set; }

    }
}
