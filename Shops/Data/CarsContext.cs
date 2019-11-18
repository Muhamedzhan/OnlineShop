using System;
using Microsoft.EntityFrameworkCore;
using Shops.Data.Models;

namespace Shops.Data
{
    public class CarsContext : DbContext
    {
        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car
            {
                id = 1,
                name = ""
            });
        }
    }
}
