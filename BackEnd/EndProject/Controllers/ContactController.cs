using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Models;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM()
            {
                Bio = _db.Bio.FirstOrDefault()
                
            };
            return View(contactVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> SendMessage(ContactVM contact)
        {
            Message message1 = new Message()
            {
                Name = contact.Name,
                MessageText = contact.MessageText,
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber
            };
            await _db.Messages.AddAsync(message1);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}