using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.ViewModels;
using EndProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EndProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _db;
        public ShopController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ProductVM productVM = new ProductVM()
            {
                Products = _db.Products.Include(p=>p.ProductImages).ToList(),
                ProductCategories = _db.ProductCategories.ToList()
            };
            return View(productVM);
        }
        
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Product product = _db.Products.Find(id);
            ProductVM productVM = new ProductVM()
            {
                Productt = _db.Products.Find(id),
                ProductCategories = _db.ProductCategories.ToList(),
                ProductImages = _db.ProductImages.Where(p => p.ProductId == product.Id).ToList(),
                Products = _db.Products.Include(p=>p.ProductImages).Where(p => p.ProductCategoryId == product.ProductCategoryId).ToList()
            };

            return View(productVM);
        }
    }
}