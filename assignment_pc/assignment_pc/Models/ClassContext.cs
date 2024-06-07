using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assignment_pc.Models
{
    public class ClassContext:DbContext
    {
        public DbSet<Areatbl> Areatbls { get; set; }
        public DbSet<bill> bills { get; set; }
        public DbSet<citytbl> citytbls { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}