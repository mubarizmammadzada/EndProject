using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
