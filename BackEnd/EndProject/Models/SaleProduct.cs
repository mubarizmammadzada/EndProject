using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class SaleProduct
    {
        public int Id { get; set; }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
    }
}
