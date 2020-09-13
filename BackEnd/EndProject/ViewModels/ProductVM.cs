using EndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class ProductVM
    {
        public List<Product> Products { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductImage> ProductImage { get; set; }
        public Product Productt { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
