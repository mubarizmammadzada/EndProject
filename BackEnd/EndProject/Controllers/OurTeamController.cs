using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.Controllers
{
    public class OurTeamController : Controller
    {
        private readonly AppDbContext _db;
        public OurTeamController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<OurTeam> team = _db.OurTeams.ToList();
            return View(team);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            OurTeam worker = _db.OurTeams.Find(id);
            return View(worker);
        }
    }
}