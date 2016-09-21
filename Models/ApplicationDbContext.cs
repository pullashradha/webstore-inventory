using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreInventory.Models
{
    public class ApplicationDbContext : DbContext
    {
		public DbSet<ApplicationProduct> Products { get; set; }

        public DbSet<ApplicationProductItem> Inventory { get; set; }

        public DbSet<ApplicationOrderItem> OrderItems { get; set; }

        public DbSet<ApplicationOrder> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WebStoreInventory;integrated security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
