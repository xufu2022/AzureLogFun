using AzureTangyFunc.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AzureTangyFunc.Data
{
    public class AzureTangyDbContext : DbContext
    {
        public AzureTangyDbContext(DbContextOptions<AzureTangyDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<SalesRequest> SalesRequests {  get; set; }
        public DbSet<GroceryItem> GroceryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SalesRequest>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            modelBuilder.Entity<GroceryItem>(entity =>
            {
                entity.HasKey(c => c.Id);
            });
        }
    }
}
