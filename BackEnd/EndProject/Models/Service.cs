using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string FrontBrakesRepair { get; set; }
        [Required]
        public string RearBrakesRepair { get; set; }
        [Required]
        public string RearBrakesShoes { get; set; }
        [Required]
        public string Axle { get; set; }
        [Required]
        public string StartersAlternators { get; set; }
        public ICollection<ServiceImage> ServiceImages { get; set; }
        public int ServiceCategoryId { get; set; }
        public ServiceCategory ServiceCategory { get; set; }


    }
}
