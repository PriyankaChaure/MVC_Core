using Microsoft.EntityFrameworkCore;

namespace CurdUsingRepoDI.Models
{
    public class ClassContext:DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> opt):base(opt) { }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Dept> Depts { get; set; }

    }
}
