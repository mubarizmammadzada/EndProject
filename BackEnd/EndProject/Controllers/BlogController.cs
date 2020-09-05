using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Models;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EndProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            BlogVM blogVM = new BlogVM()
            {
                Blogs = _db.Blogs.Take(3).OrderByDescending(b => b.Id).ToList(),
                LatestBlogs = _db.Blogs.Include(b => b.BlogCategory).Take(4).OrderByDescending(b => b.Id).ToList(),
                BlogCategories = _db.BlogCategories.ToList()
        };
            return View(blogVM);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            BlogVM blogVM = new BlogVM()
            {
                Blog=_db.Blogs.Find(id),
                Blogs=_db.Blogs.Take(4).OrderByDescending(b=>b.Id).ToList(),
                BlogCategories=_db.BlogCategories.ToList()
            };
            return View(blogVM);
        }

    }
}