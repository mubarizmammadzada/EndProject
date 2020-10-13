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
    public class MessagesController : Controller
    {
        private readonly AppDbContext _db;
        public MessagesController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Message> messages = _db.Messages.OrderByDescending(m => m.Id).ToList();
            ViewBag.MessagesCount = messages.Count();
            return View(messages);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Message message = _db.Messages.Find(id);
            if (message == null) return NotFound();
            return View(message);
        }
        
    }
}