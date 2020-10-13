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
    public class ServiceCategoryCRUDController : Controller
    {
        private readonly AppDbContext _db;
        public ServiceCategoryCRUDController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ServiceCategory> categories = _db.ServiceCategories.OrderByDescending(c=>c.Id).ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceCategory category)
        {
            ServiceCategory serviceCategory = new ServiceCategory()
            {
                Name = category.Name
            };
            _db.ServiceCategories.Add(serviceCategory);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            ServiceCategory category = _db.ServiceCategories.Find(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,ServiceCategory categoryy)
        {
            if (id == null) return NotFound();
            ServiceCategory category = _db.ServiceCategories.Find(id);
            if (category == null) return NotFound();
            category.Name = categoryy.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            ServiceCategory category = _db.ServiceCategories.Find(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            ServiceCategory category = _db.ServiceCategories.Find(id);
            if (category == null) return NotFound();
            _db.ServiceCategories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }




    }
}