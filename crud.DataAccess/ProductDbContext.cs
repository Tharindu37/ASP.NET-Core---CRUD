using crud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.DataAccess
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=127.0.0.1;Database=ProductDb;User Id=sa;Password=Password123@;Trusted_Connection=False;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1-db", Description = "Description 1", price = 10.00, quantity = 10, Status = ProductStatus.InStock },
                new Product { Id = 2, Name = "Product 2-db", Description = "Description 2", price = 20.00, quantity = 20, Status = ProductStatus.OutOfStock },
                new Product { Id = 3, Name = "Product 3-db", Description = "Description 3", price = 30.00, quantity = 30, Status = ProductStatus.Discontinued }
            );
        }
    }
}
