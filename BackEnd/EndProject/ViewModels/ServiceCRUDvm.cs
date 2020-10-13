using EndProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class ServiceCRUDvm
    {
        public Service Service { get; set; }
        public List<Service> Services { get; set; }
        public List<ServiceImage> ServiceImages { get; set; }
        public List<ServiceCategory> ServiceCategories { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public ServiceImage ServiceImage { get; set; }
        public IFormFile Photo { get; set; }
        public string Name { get; set; }

    }
}
