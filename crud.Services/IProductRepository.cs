﻿using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services
{
    public interface IProductRepository
    {
        public List<Product> allProducts();
    }
}
