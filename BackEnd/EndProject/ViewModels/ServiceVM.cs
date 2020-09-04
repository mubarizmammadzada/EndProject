using EndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class ServiceVM
    {
        public Service Servicee { get; set; }
        public List<Service> Services { get; set; }
        public List<ServiceImage> ServiceImages { get; set; }

    }
}
