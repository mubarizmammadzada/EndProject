using EndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewModels
{
    public class BlogVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> LatestBlogs{ get; set; }
        public List<BlogCategory> BlogCategories { get; set; }
        public Blog Blog { get; set; }
    }
}
