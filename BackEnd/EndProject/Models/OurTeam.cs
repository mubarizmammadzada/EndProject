using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class OurTeam
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Profession { get; set; }

        [Required]
        public string Image { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int TireandWheelServices { get; set; }
        [Required]
        public int LubeOilandFilters { get; set; }
        [Required]
        public int BeltsandHoses { get; set; }
        [Required]
        public int EngineDiagnostics { get; set; }
        [Required]
        public int BrakeRepair { get; set; }
        [Required]
        public int AirConditioning { get; set; }
        [Required]
        public string FacebookAddress { get; set; }
        [Required]
        public string TwitterAddress { get; set; }
        [Required]
        public string LinkedinAddress { get; set; }
        

    }
}
