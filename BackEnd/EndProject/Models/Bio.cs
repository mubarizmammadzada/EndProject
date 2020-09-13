using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string AsistancePhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string FacebookAddress { get; set; }
        [Required]
        public string TwitterAddress { get; set; }
        [Required]
        public string LinkedinAddress { get; set; }
        [Required]
        public string PinterestAddress { get; set; }
    }
}
