using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class RegisterVM
    {
        [Required,StringLength(150)]
        public string FullName { get; set; }
        [Required, StringLength(150)]
        public string UserName { get; set; }
        [Required, EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
         [Required, Compare(nameof(Password)), DataType(DataType.EmailAddress)]
        public string RepeatPassword { get; set; }


    }
}
