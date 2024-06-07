using Microsoft.EntityFrameworkCore;

namespace ExamCore.Models
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> opt) : base(opt) { }
        public DbSet<City> Cities { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<FlightFacility> FlightFacilities { get; set; }
    }
}
