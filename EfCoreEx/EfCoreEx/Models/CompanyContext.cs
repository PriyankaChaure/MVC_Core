using Microsoft.EntityFrameworkCore;

namespace EfCoreEx.Models
{
    public class CompanyContext : DbContext
    {
       public CompanyContext(DbContextOptions<CompanyContext> opt) :base(opt) { }
       

        public DbSet<Category> Categories {  get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
