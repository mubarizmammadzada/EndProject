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
    public class GalleryController : Controller
    {
        private readonly AppDbContext _db;
        public GalleryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            GalleryVM gallery = new GalleryVM()
            {
                Services = _db.Services.Include(s=>s.ServiceImages).ToList(),
                ServiceCategories = _db.ServiceCategories.ToList()
            };
            return View(gallery);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            GalleryVM gallery = new GalleryVM()
            {
                ServiceImages = _db.ServiceImages.Where(s => s.ServiceId == id).Take(2).ToList(),
                Servicee = _db.Services.Find(id)
            };
            
            return View(gallery);
        }
    }
}