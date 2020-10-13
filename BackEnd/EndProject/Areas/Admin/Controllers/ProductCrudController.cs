using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Models;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductCrudController : Controller
    {
        private readonly AppDbContext _db;
        public ProductCrudController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> product = _db.Products.Include(p => p.ProductImages).ToList();
            return View(product);
        }
        public IActionResult Create()
        {
            ProductCrudVM productCrud = new ProductCrudVM()
            {
                ProductCategories = _db.ProductCategories.ToList()
            };
            return View(productCrud);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCrudVM product)
        {
            Product product1 = new Product()
            {
                About = product.About,
                Count = product.Count,
                Name = product.Name,
                Price = product.Price
            };
            string a = Request.Form["categories"];
            ProductCategory category = _db.ProductCategories.FirstOrDefault(p => p.Name.ToLower().Trim() == a.ToLower().Trim());
            product1.ProductCategoryId = category.Id;
            await _db.AddAsync(product1);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Product p = _db.Products.Include(a=>a.ProductCategory).FirstOrDefault(a=>a.Id==id);
            ProductCrudVM productCrud = new ProductCrudVM()
            {
                ProductCategories = _db.ProductCategories.ToList(),
                Name = p.Name,
                Price = p.Price,
                Count = p.Count,
                About = p.About,
                Product=p
            };
            if (productCrud == null) return NotFound();
            return View(productCrud);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ProductCrudVM productt)
        {
            if (id == null) return NotFound();
            Product product = _db.Products.Find(id);
            if (product == null) return NotFound();
            product.About = productt.About;
            product.Count = productt.Count;
            product.Name = productt.Name;
            product.Price = productt.Price;
            string a = Request.Form["categories"];
            ProductCategory category = _db.ProductCategories.FirstOrDefault(p => p.Name.ToLower().Trim() == a.ToLower().Trim());
            product.ProductCategoryId = category.Id;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Product product = _db.Products.Include(p => p.ProductImages).FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {

            if (id == null) return NotFound();
            Product product = _db.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}