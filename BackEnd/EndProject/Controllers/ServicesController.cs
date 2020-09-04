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
    public class ServicesController : Controller
    {
        private readonly AppDbContext _db;
        public ServicesController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Service> service = _db.Services.Include(s=>s.ServiceImages).ToList();
            return View(service);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            ServiceVM serviceVM = new ServiceVM()
            {
                Services = _db.Services.Include(s => s.ServiceImages).ToList(),
                Servicee = _db.Services.Find(id),
                ServiceImages = _db.ServiceImages.Where(s=>s.ServiceId==id).Take(2).ToList()
            };            

            return View(serviceVM);

        }
       

    }
}