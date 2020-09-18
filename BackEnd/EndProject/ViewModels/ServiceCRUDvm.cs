using EndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class ServiceCRUDvm
    {
        public Service Service { get; set; }
        public List<ServiceImage> ServiceImages { get; set; }
        public List<ServiceCategory> ServiceCategories { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
    }
}
