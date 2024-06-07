using Microsoft.EntityFrameworkCore;
namespace MultipleInput.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> opt):base(opt) { }
        public DbSet<Emp> Emps { get; set; }    
        public DbSet<Skill> Skills { get; set; }
        public DbSet<EmpSkill> EmpSkills { get; set; }  
    }
}
