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
using Microsoft.EntityFrameworkCore;

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ServiceImagesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public ServiceImagesController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<ServiceImage> serviceImages = _db.ServiceImages.ToList();
            return View(serviceImages);
        }
        public IActionResult Create()
        {
            ServiceCRUDvm service = new ServiceCRUDvm
            {
                Services = _db.Services.ToList()
            };
            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceImage image)
        {
            ServiceImage serviceImage = new ServiceImage()
            {
                Name = image.Name
            };
            if (image.Photo == null)
            {
                ModelState.AddModelError("", "Shekil sechin");
                return View();
            }
            if (!image.Photo.IsImage())
            {
                ModelState.AddModelError("", "Shekil formatinda bir fayl sechin");
                return View();
            }
            if (image.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("", "Shekilin olchusu max 1400kb ola biler");
                return View();
            }
            serviceImage.Image = await image.Photo.SaveImage(_env.WebRootPath, "img/services");
            string aaaa = Request.Form["services"];
            Service serviceImage1 = _db.Services.FirstOrDefault(s => s.Name.ToLower().Trim() == aaaa.ToLower().Trim());
            serviceImage.ServiceId = serviceImage1.Id;
            string b = Request.Form["ismain"];
            if (b.ToLower().Trim() == "main")
            {
                serviceImage.IsMain = true;
            }
            else
            {
                serviceImage.IsMain = false;
            }
            _db.ServiceImages.Add(serviceImage);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            ServiceCRUDvm serviceCRU = new ServiceCRUDvm
            {
                ServiceImage = _db.ServiceImages.Find(id),
                Services = _db.Services.ToList()
            };
            if (serviceCRU == null) return NotFound();
            return View(serviceCRU);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ServiceCRUDvm serviceCRU)
        {
            if (id == null) return View();
            ServiceImage image = _db.ServiceImages.Find(id);
            if (image == null) return NotFound();
            if (serviceCRU.ServiceImage.Photo != null)
            {
                if (!serviceCRU.ServiceImage.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Shekil formatinda bir fayl sechin");
                    return View();
                }
                if (serviceCRU.ServiceImage.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("", "Shekilin olchusu max 1400kb ola biler");
                    return View();
                }
                Helper.DeleteImg(_env.WebRootPath, "img/services", image.Image);
                image.Image = await serviceCRU.ServiceImage.Photo.SaveImage(_env.WebRootPath, "img/services");
                string aaaa = Request.Form["services"];
                Service serviceImage1 = _db.Services.FirstOrDefault(s => s.Name.ToLower().Trim() == aaaa.ToLower().Trim());
                image.ServiceId = serviceImage1.Id;
                string b = Request.Form["ismain"];
                if (b.ToLower().Trim() == "main")
                {
                    image.IsMain = true;
                }
                else
                {
                    image.IsMain = false;
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            else
            {
                string aaaa = Request.Form["services"];
                Service serviceImage1 = _db.Services.FirstOrDefault(s => s.Name.ToLower().Trim() == aaaa.ToLower().Trim());
                image.ServiceId = serviceImage1.Id;
                string b = Request.Form["ismain"];
                if (b.ToLower().Trim() == "main")
                {
                    image.IsMain = true;
                }
                else
                {
                    image.IsMain = false;
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            ServiceImage serviceImage = _db.ServiceImages.Find(id);
            if (serviceImage == null) return NotFound();
            return View(serviceImage);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            ServiceImage serviceImage = _db.ServiceImages.Find(id);
            if (serviceImage == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/services", serviceImage.Image);
            _db.ServiceImages.Remove(serviceImage);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}