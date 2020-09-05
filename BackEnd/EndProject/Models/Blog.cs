using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string AboutBlog { get; set; }

        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }
    }
}
