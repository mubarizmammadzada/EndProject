using EndProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class ProductCrudVM
    {
        public string Name { get; set; }
        public string About { get; set; }
        public decimal Price { get; set; }
        public IFormFile Photo { get; set; }
        public int Count { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public Product Product  { get; set; }
        public ProductImage ProductImage { get; set; }
        public List<Product> Products { get; set; }

    }
}
