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
    }
}
