using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Extentions;
using EndProject.Helpers;
using EndProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
       
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Sliders.OrderByDescending(s=>s.Id).Take(3).ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider slider = _db.Sliders.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil sechin");
                return View(slider);
            }
            if (slider.Photo.MaxLength(1600))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1600kb ola biler");
                return View();
            }
            int count = _db.Sliders.Count();
            if (count > 5)
            {
                ModelState.AddModelError("", "Sliderda max 5 shekil ola biler");
                return View();
            }

            slider.Image = await slider.Photo.SaveImage(_env.WebRootPath, "img/slider");

            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = _db.Sliders.Find(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = _db.Sliders.Find(id);
            if (slider == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/slider", slider.Image);
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = _db.Sliders.Find(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Slider slider)
        {
            if (id == null) return NotFound();
            if(slider.Photo !=null)
            {
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Shekil sechin");
                    return View();
                }
                if (slider.Photo.MaxLength(1600))
                {
                    ModelState.AddModelError("Photo", "Shekilin olchusu max 1600kb ola biler");
                    return View();
                }
                Slider dbSlider = await _db.Sliders.FindAsync(id);
                Helper.DeleteImg(_env.WebRootPath, "img/slider", dbSlider.Image);
                dbSlider.Image = await slider.Photo.SaveImage(_env.WebRootPath, "img/slider");
                await _db.SaveChangesAsync();   
            }
            return RedirectToAction("Index");
        }
        
    }
}