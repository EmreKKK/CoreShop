﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShop.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public Product()
        {
            Images = new List<Image>();
        }
    }
}
