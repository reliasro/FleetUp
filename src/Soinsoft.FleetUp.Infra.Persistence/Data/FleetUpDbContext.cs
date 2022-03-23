using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soinsoft.FleetUp.Domain.Entities;


namespace Soinsoft.FleetUp.Infra.Persistence.Data
{
    public class FleetUpDbContext : DbContext
    {
        public FleetUpDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FleetUpDbInitializer.Seed(modelBuilder);

        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
    }
}