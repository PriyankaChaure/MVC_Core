using Microsoft.EntityFrameworkCore;

namespace EF_Core_Exam.Models
{
    public class ClassContext:DbContext
    {
        public ClassContext (DbContextOptions<ClassContext> opt) :base(opt) 
        { }
        public DbSet<MFG> MFGs { get; set; }
        public DbSet<autoparts> autoarts { get; set; }
        public DbSet<brand> brands { get; set; }
        public DbSet<car> cars { get; set; }
    }
}
