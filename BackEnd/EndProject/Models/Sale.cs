using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }  
        [Required,StringLength(50)]
        public string FullName { get; set; }
        [Required, StringLength(50)]
        public string PhoneNumber { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; }

    }
}
