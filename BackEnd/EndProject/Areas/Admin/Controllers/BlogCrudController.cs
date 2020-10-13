using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Extentions;
using EndProject.Helpers;
using EndProject.Models;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogCrudController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public BlogCrudController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Blog> blog = _db.Blogs.OrderByDescending(b => b.Id).Take(5).ToList();
            return View(blog);
        }
        public IActionResult Create()
        {
            BlogCrudVM blogCrud = new BlogCrudVM()
            {
                BlogCategories = _db.BlogCategories.ToList()
            };
            return View(blogCrud);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCrudVM blogCrud)
        {
            if (blogCrud.Blog.Photo == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa shekil sechin");
                return View();
            }
            if (!blogCrud.Blog.Photo.IsImage())
            {
                ModelState.AddModelError("", "Shekil formatinda bir file sechin");
                return View();
            }
            if (blogCrud.Blog.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("", "Shekilin olchusu max 1400kb ola biler");
                return View();
            }
            Blog blog = new Blog()
            {
                AboutBlog = blogCrud.Blog.AboutBlog,
                AuthorName = blogCrud.Blog.AuthorName,
                Date = blogCrud.Blog.Date,
                Description = blogCrud.Blog.Description,
                Name = blogCrud.Blog.Name
            };
            blog.Image = await blogCrud.Blog.Photo.SaveImage(_env.WebRootPath, "img/services");

            string a = Request.Form["categories"];
            BlogCategory category = _db.BlogCategories.FirstOrDefault(c => c.Name.ToLower().Trim() == a.ToLower().Trim());
            blog.BlogCategoryId = category.Id;
            _db.Blogs.Add(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");


        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            BlogCrudVM blogCrud = new BlogCrudVM()
            {
                Blog = _db.Blogs.Find(id),
                BlogCategories = _db.BlogCategories.ToList()
            };
            Blog blog = _db.Blogs.Find(id);
            if (blog == null) return NotFound();
            return View(blogCrud);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, BlogCrudVM blogCrud)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Find(id);
            if (blog == null) return NotFound();
            if (blogCrud.Blog.Photo != null)
            {
                if (!blogCrud.Blog.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Shekil formatinda file sechin");
                    return View();
                }
                if (blogCrud.Blog.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("", "Shekilin olchusu max 1400kb ola biler");
                    return View();
                }

                Helper.DeleteImg(_env.WebRootPath, "img/services", blog.Image);
                blog.Image = await blogCrud.Blog.Photo.SaveImage(_env.WebRootPath, "img/services");
                blog.AboutBlog = blogCrud.Blog.AboutBlog;
                blog.AuthorName = blogCrud.Blog.AuthorName;
                blog.Date = blogCrud.Blog.Date;
                blog.Description = blogCrud.Blog.Description;
                blog.Name = blogCrud.Blog.Name;
                string b = Request.Form["categories"];
                BlogCategory categoryy = _db.BlogCategories.FirstOrDefault(c => c.Name.ToLower().Trim() == b.ToLower().Trim());
                blog.BlogCategoryId = categoryy.Id;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            blog.AboutBlog = blogCrud.Blog.AboutBlog;
            blog.AuthorName = blogCrud.Blog.AuthorName;
            blog.Date = blogCrud.Blog.Date;
            blog.Description = blogCrud.Blog.Description;
            blog.Name = blogCrud.Blog.Name;
            string a = Request.Form["categories"];
            BlogCategory category = _db.BlogCategories.FirstOrDefault(c => c.Name.ToLower().Trim() == a.ToLower().Trim());
            blog.BlogCategoryId = category.Id;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Find(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Find(id);
            if (blog == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/services", blog.Image);
            _db.Blogs.Remove(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}