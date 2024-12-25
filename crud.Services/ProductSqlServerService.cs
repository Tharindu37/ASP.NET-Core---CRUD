using crud.DataAccess;
using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services
{
    public class ProductSqlServerService : IProductRepository
    {
        private readonly ProductDbContext _context = new ProductDbContext();
        public List<Product> allProducts()
        {
            return _context.Products.ToList();
        }
    }
}
