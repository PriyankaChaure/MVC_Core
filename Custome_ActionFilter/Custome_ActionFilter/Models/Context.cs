using Microsoft.EntityFrameworkCore;

namespace Custome_ActionFilter.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opt):base(opt) { }
       public DbSet<ActionLog> Log { get; set; }
    }
}
