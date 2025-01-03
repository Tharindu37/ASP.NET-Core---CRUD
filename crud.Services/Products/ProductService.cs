﻿using crud.Models;

namespace crud.Services.Products
{
    public class ProductService : IProductRepository
    {
        public Product AddProduct(int userId, Product product)
        {
            throw new NotImplementedException();
        }

        // Get Products
        public List<Product> allProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 10.00, Quantity = 10, Status = ProductStatus.InStock });
            products.Add(new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 20.00, Quantity = 20, Status = ProductStatus.OutOfStock });
            products.Add(new Product { Id = 3, Name = "Product 3", Description = "Description 3", Price = 30.00, Quantity = 30, Status = ProductStatus.Discontinued });
            return products;
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product getProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int userId, int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
