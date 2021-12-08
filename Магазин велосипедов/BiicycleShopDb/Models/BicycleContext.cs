using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiicycleShopDb.Models
{
    public class BicycleContext : DbContext
    {
        public BicycleContext(DbContextOptions<BicycleContext> option) : base(option)
        {
            Database.EnsureCreated();
        }
        public DbSet<Bicycle> Bicycle { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
