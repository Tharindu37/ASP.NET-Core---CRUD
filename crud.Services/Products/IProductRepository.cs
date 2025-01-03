﻿using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Products
{
    public interface IProductRepository
    {
        public List<Product> allProducts();
        public Product getProduct(int Id);

        public Product GetProduct(int userId, int Id);
        public List<Product> GetProducts(int userId);
        public Product AddProduct(int userId,  Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(Product product);
    }
}
