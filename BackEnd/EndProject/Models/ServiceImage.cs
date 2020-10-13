using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class ServiceImage
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public bool IsMain { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Name { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }


    }
}
