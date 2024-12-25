using crud.Models;

namespace crud.Services
{
    public class ProductService
    {
        // Get Products
        public List<Product> allProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Product 1", Description = "Description 1", price = 10.00, quantity = 10, Status = ProductStatus.InStock });
            products.Add(new Product { Id = 2, Name = "Product 2", Description = "Description 2", price = 20.00, quantity = 20, Status = ProductStatus.OutOfStock });
            products.Add(new Product { Id = 3, Name = "Product 3", Description = "Description 3", price = 30.00, quantity = 30, Status = ProductStatus.Discontinued });
            return products;
        }
    }
}
