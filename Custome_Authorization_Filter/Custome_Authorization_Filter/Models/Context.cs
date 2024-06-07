using Microsoft.EntityFrameworkCore;

namespace Custome_Authorization_Filter.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>opt) :base(opt){ }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<User>().HasData(
                new User { UserId=1,FirstName="Priya",LastName="Chaure",EmailId="priya@24gmail.com",MobileNo="99999999",Password="123"}
                );
        }
        public DbSet<User> Users { get; set; }  
    }
}
