using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
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
    public class ServiceController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public ServiceController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Service> service = _db.Services.Include(s=>s.ServiceImages).OrderByDescending(s => s.Id).Take(6).ToList();
            return View(service);
        }
        public IActionResult Create()
        {
            ServiceCRUDvm serviceVM = new ServiceCRUDvm
            {
                ServiceCategories=_db.ServiceCategories.ToList()
            };
            return View(serviceVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceCRUDvm serviceVM)
        {
           
            Service service = new Service
            {
                Name = serviceVM.Service.Name,
                Axle = serviceVM.Service.Axle,
                Description = serviceVM.Service.Description,
                FrontBrakesRepair = serviceVM.Service.FrontBrakesRepair,
                RearBrakesRepair = serviceVM.Service.RearBrakesRepair,
                RearBrakesShoes = serviceVM.Service.RearBrakesShoes,
                StartersAlternators=serviceVM.Service.StartersAlternators

            };
            string a = Request.Form["categories"];
            ServiceCategory serviceCategory = _db.ServiceCategories.FirstOrDefault(s => s.Name.ToLower().Trim() == a.ToLower().Trim());
            service.ServiceCategoryId = serviceCategory.Id;



            _db.Services.Add(service);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            ServiceCRUDvm serviceVM = new ServiceCRUDvm
            {
                Service= _db.Services.Find(id),
                ServiceCategories = _db.ServiceCategories.ToList()
            };
           
            if (serviceVM == null) return NotFound();
            return View(serviceVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ServiceCRUDvm serviceVm)
        {
            if (id == null) return NotFound();
            ServiceCRUDvm serviceVM = new ServiceCRUDvm
            {
                Service = _db.Services.Find(id),
                ServiceCategories = _db.ServiceCategories.ToList()
            };


            Service service = _db.Services.Find(id);
            if (service == null) return NotFound();
            service.Axle = serviceVm.Service.Axle;
            service.Description = serviceVm.Service.Description;
            service.Name = serviceVm.Service.Name;
            service.RearBrakesRepair = serviceVm.Service.RearBrakesRepair;
            service.RearBrakesShoes = serviceVm.Service.RearBrakesShoes;
            service.StartersAlternators = serviceVm.Service.StartersAlternators;
            service.FrontBrakesRepair = serviceVm.Service.FrontBrakesRepair;
            string a = Request.Form["categories"];
            ServiceCategory serviceCategory = _db.ServiceCategories.FirstOrDefault(s => s.Name.ToLower().Trim() == a.ToLower().Trim());
            service.ServiceCategoryId= serviceCategory.Id;
            await _db.SaveChangesAsync();
                
            return RedirectToAction("Index");



        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Service service = _db.Services.Include(s=>s.ServiceImages).FirstOrDefault(s=>s.Id==id);
            if (service == null) return NotFound();
            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Service service = _db.Services.Find(id);
            if (service == null) return NotFound();
            List<ServiceImage> serviceImage = _db.ServiceImages.Where(s => s.ServiceId == id).ToList();
            if (serviceImage.Count != 0)
            {
                foreach (ServiceImage image in serviceImage)
                {
                    Helper.DeleteImg(_env.WebRootPath, "img/service", image.Image);
                    _db.ServiceImages.Remove(image);
                    _db.Services.Remove(service);
                }

            }
            else
            {
                _db.Services.Remove(service);
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}