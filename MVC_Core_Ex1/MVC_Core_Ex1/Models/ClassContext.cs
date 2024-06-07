using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Proxies;


namespace MVC_Core_Ex1.Models
{
    public class ClassContext:DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> opt) : base(opt) { }
        public DbSet<City> Cities { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<FlightFacility> FlightFacilities { get; set;}
    }
}
