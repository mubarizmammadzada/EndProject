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
                Sliders=_db.Sliders.OrderByDescending(s=>s.Id).ToList(),
                Services=_db.Services.Include(s=>s.ServiceImages).Take(3).OrderBy(s=>s.Id).ToList(),
                Servicess=_db.Services.Include(s=>s.ServiceImages).Take(4).OrderBy(s=>s.Id).ToList()
            };
            return View(home);
        }
    }
}