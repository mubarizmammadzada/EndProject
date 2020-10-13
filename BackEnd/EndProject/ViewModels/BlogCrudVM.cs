using EndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class BlogCrudVM
    {
        public Blog Blog { get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
    }
}
