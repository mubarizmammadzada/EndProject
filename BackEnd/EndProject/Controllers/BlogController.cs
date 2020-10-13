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
        public IActionResult Index(int? page,string blogCategory)
        {
            if (blogCategory!=null) 
            {
                ViewBag.Page = page;
                ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Where(b=>b.BlogCategory.Name== blogCategory).Count() / 3);
                if (page == null)
                {
                    BlogVM blogVM = new BlogVM()
                    {
                        Blogs = _db.Blogs.Where(b=>b.BlogCategory.Name== blogCategory.ToLower().Trim()).Take(3).OrderByDescending(b => b.Id).ToList(),
                        LatestBlogs = _db.Blogs.Include(b => b.BlogCategory).Take(4).OrderByDescending(b => b.Id).ToList(),
                        BlogCategories = _db.BlogCategories.ToList()
                    };
                    return View(blogVM);
                }
                else
                {
                    BlogVM blogVM = new BlogVM()
                    {
                        Blogs = _db.Blogs.Skip(((int)page - 1) * 3).Take(3).OrderByDescending(b => b.Id).ToList(),
                        LatestBlogs = _db.Blogs.Include(b => b.BlogCategory).Take(4).OrderByDescending(b => b.Id).ToList(),
                        BlogCategories = _db.BlogCategories.ToList()
                    };
                    return View(blogVM);
                }
            }
            else
            {
                ViewBag.Page = page;
                ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count() / 3);
                if (page == null)
                {
                    BlogVM blogVM = new BlogVM()
                    {
                        Blogs = _db.Blogs.Take(3).OrderByDescending(b => b.Id).ToList(),
                        LatestBlogs = _db.Blogs.Include(b => b.BlogCategory).Take(4).OrderByDescending(b => b.Id).ToList(),
                        BlogCategories = _db.BlogCategories.ToList()
                    };
                    return View(blogVM);
                }
                else
                {
                    BlogVM blogVM = new BlogVM()
                    {
                        Blogs = _db.Blogs.Skip(((int)page - 1) * 3).Take(3).OrderByDescending(b => b.Id).ToList(),
                        LatestBlogs = _db.Blogs.Include(b => b.BlogCategory).Take(4).OrderByDescending(b => b.Id).ToList(),
                        BlogCategories = _db.BlogCategories.ToList()
                    };
                    return View(blogVM);
                }
               
            }
            
        }
       
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            BlogVM blogVM = new BlogVM()
            {
                Blog = _db.Blogs.Find(id),
                Blogs = _db.Blogs.Take(4).OrderByDescending(b => b.Id).ToList(),
                BlogCategories = _db.BlogCategories.ToList()
            };
            return View(blogVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Detail")]
        public async Task<IActionResult> SendMessage(BlogVM blog)
        {
            Message message1 = new Message()
            {
                Name = blog.Name,
                MessageText = blog.MessageText,
                Email = blog.Email,
                PhoneNumber = blog.PhoneNumber
            };
            await _db.Messages.AddAsync(message1);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}