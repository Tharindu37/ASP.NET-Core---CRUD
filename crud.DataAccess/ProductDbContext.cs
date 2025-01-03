﻿using crud.Models;
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
        public DbSet<User> Users { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=127.0.0.1;Database=ProductDb;User Id=sa;Password=Password123@;Trusted_Connection=False;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "User 1-db", AddressNo="42", Street="Street 1", City="Kurunegala", Type = "admin" },
                new User { Id = 2, Name = "User 2-db", AddressNo="33", Street="Street 2", City="Colombo", Type="admin" },
                new User { Id = 3, Name = "User 3-db", AddressNo="35", Street="Street 3", City="Colombo", Type="customer" },
                new User { Id = 4, Name = "User 4-db", AddressNo = "35", Street = "Street 4", City = "Colombo", Type = "customer" },
                new User { Id = 5, Name = "User 5-db", AddressNo = "44", Street = "Street 4", City = "Galgamuwa", Type = "customer" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1-db", Description = "Description 1", Price = 10.00, Quantity = 10, Status = ProductStatus.InStock , UserId = 1},
                new Product { Id = 2, Name = "Product 2-db", Description = "Description 2", Price = 20.00, Quantity = 20, Status = ProductStatus.OutOfStock, UserId = 1 },
                new Product { Id = 3, Name = "Product 3-db", Description = "Description 3", Price = 30.00, Quantity = 30, Status = ProductStatus.Discontinued, UserId = 2 }
            );
        }
    }
}
