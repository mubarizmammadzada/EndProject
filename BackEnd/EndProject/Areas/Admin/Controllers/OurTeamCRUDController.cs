using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Extentions;
using EndProject.Helpers;
using EndProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurTeamCRUDController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public OurTeamCRUDController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<OurTeam> team = _db.OurTeams.ToList();
            return View(team);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OurTeam worker)
        {
            if (worker.Photo==null)
            {
                ModelState.AddModelError("", "Qaqi Shekil Sech ginen");
                return View();
            }
            if (!worker.Photo.IsImage())
            {
                ModelState.AddModelError("", "Shekil formati sechin");
                return View();
            }
            if (worker.Photo.MaxLength(1500))
            {
                ModelState.AddModelError("", "Shekilin olchusu max 1500kb ola biler");
            }
            OurTeam team = worker;
            team.Image = await worker.Photo.SaveImage(_env.WebRootPath, "img/OurTeam");
            await _db.OurTeams.AddAsync(team);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            OurTeam team = _db.OurTeams.Find(id);
            if (team == null) return NotFound();
            return View(team);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,OurTeam worker)
        {

            if (id == null) return NotFound();
            OurTeam dbTeam = _db.OurTeams.Find(id);
            if (dbTeam == null) return NotFound();
            if (worker.Photo != null)
            {
                if (!worker.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Shekil formati sechin");
                    return View();
                }
                if (worker.Photo.MaxLength(1500))
                {
                    ModelState.AddModelError("", "Shekilin olchusu max 1500kb ola biler");
                }
                Helper.DeleteImg(_env.WebRootPath, "img/OurTeam", dbTeam.Image);
                dbTeam.Image = await worker.Photo.SaveImage(_env.WebRootPath, "img/OurTeam");
                dbTeam.Address = worker.Address;
                dbTeam.AirConditioning = worker.AirConditioning;
                dbTeam.BeltsandHoses = worker.BeltsandHoses;
                dbTeam.BrakeRepair = worker.BrakeRepair;
                dbTeam.DateOfBirth = worker.DateOfBirth;
                dbTeam.Description = worker.Description;
                dbTeam.Email = worker.Email;
                dbTeam.EngineDiagnostics = worker.EngineDiagnostics;
                dbTeam.FacebookAddress = worker.FacebookAddress;
                dbTeam.Fullname = worker.Fullname;
                dbTeam.LinkedinAddress = worker.LinkedinAddress;
                dbTeam.LubeOilandFilters = worker.LubeOilandFilters;
                dbTeam.PhoneNumber = worker.PhoneNumber;
                dbTeam.Profession = worker.Profession;
                dbTeam.TireandWheelServices = worker.TireandWheelServices;
                dbTeam.TwitterAddress = worker.TwitterAddress;

                await _db.SaveChangesAsync();
                return RedirectToAction("Index");


            }
            else
            {
                dbTeam.Address = worker.Address;
                dbTeam.AirConditioning = worker.AirConditioning;
                dbTeam.BeltsandHoses = worker.BeltsandHoses;
                dbTeam.BrakeRepair = worker.BrakeRepair;
                dbTeam.DateOfBirth = worker.DateOfBirth;
                dbTeam.Description = worker.Description;
                dbTeam.Email = worker.Email;
                dbTeam.EngineDiagnostics = worker.EngineDiagnostics;
                dbTeam.FacebookAddress = worker.FacebookAddress;
                dbTeam.Fullname = worker.Fullname;
                dbTeam.LinkedinAddress = worker.LinkedinAddress;
                dbTeam.LubeOilandFilters = worker.LubeOilandFilters;
                dbTeam.PhoneNumber = worker.PhoneNumber;
                dbTeam.Profession = worker.Profession;
                dbTeam.TireandWheelServices = worker.TireandWheelServices;
                dbTeam.TwitterAddress = worker.TwitterAddress;

                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }

        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            OurTeam team = _db.OurTeams.Find(id);
            if (team == null) return NotFound();
            return View(team);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            OurTeam team = _db.OurTeams.Find(id);
            if (team == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/OurTeam", team.Image);
            _db.OurTeams.Remove(team);
            await _db.SaveChangesAsync();
           return RedirectToAction("Index");
        }

    }
}