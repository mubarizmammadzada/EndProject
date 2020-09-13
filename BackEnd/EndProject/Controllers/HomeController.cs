using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EndProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM()
            {
                Sliders=_db.Sliders.OrderByDescending(s=>s.Id).Take(3).ToList(),
                Services=_db.Services.Include(s=>s.ServiceImages).OrderByDescending(s=>s.Id).Take(3).ToList(),
                Servicess=_db.Services.Include(s=>s.ServiceImages).OrderByDescending(s=>s.Id).Take(4).ToList()
            };
            return View(home);
        }
    }
}