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
    public class ProductCategoryController : Controller
    {
        private readonly AppDbContext _db;
        public ProductCategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ProductCategory> categories = _db.ProductCategories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCategory category)
        {
            ProductCategory productCategory = new ProductCategory()
            {
                Name = category.Name
            };
            _db.ProductCategories.Add(productCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            ProductCategory category = _db.ProductCategories.Find(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ProductCategory categoryy)
        {
            if (id == null) return NotFound();
            ProductCategory category = _db.ProductCategories.Find(id);
            if (category == null) return NotFound();
            category.Name = categoryy.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            ProductCategory category = _db.ProductCategories.Find(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            ProductCategory category = _db.ProductCategories.Find(id);
            if (category == null) return NotFound();
            _db.ProductCategories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}