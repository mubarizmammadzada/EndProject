using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _db;
        public BlogCategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<BlogCategory> category = _db.BlogCategories.ToList();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCategory category)
        {
            BlogCategory blogCategory = new BlogCategory()
            {
                Name = category.Name
            };
            _db.BlogCategories.Add(blogCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            BlogCategory category = _db.BlogCategories.Find(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,BlogCategory categoryy)
        {
             if (id == null) return NotFound();
            BlogCategory category = _db.BlogCategories.Find(id);
            if (category == null) return NotFound();
            category.Name = categoryy.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            BlogCategory category = _db.BlogCategories.Find(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            BlogCategory category = _db.BlogCategories.Find(id);
            if (category == null) return NotFound();
            _db.BlogCategories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
            
        }
    }
}