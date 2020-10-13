using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Models;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SaleController : Controller
    {
        private readonly AppDbContext _db;
        public SaleController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Sale> saleList = _db.Sales.OrderByDescending(s => s.Id).ToList();
            return View(saleList);
        }
        public IActionResult Detail(int? id)
        {
            Sale sale = _db.Sales.Include(s => s.SaleProducts).ThenInclude(s => s.Product).ThenInclude(p=>p.ProductImages).FirstOrDefault(s=>s.Id==id);
            List<ProductImage> images = _db.ProductImages.Where(i=>i.IsMain==true).ToList();
            SaleVM saleVM = new SaleVM
            {
                Sale = sale,
                ProductImages = images
            };

            return View(sale);
        }
    }
}