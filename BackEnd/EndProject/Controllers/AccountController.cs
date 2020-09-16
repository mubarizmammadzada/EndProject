using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndProject.DAL;
using EndProject.Helpers;
using EndProject.Models;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EndProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);
            AppUser newUser = new AppUser()
            {
                Fullname = register.FullName,
                Email = register.Email,
                UserName = register.UserName
                
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach(var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(newUser, Helper.UserRoles.Members.ToString());
            await _signInManager.SignInAsync(newUser, true);

            return RedirectToAction("Index","Home");
        }
        public async Task<IActionResult> LogOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);
            AppUser loginUser =await _userManager.FindByEmailAsync(login.Email);
            if (loginUser == null)
            {
                ModelState.AddModelError("", "Qaqi get qeydiyyatdan kech");
                return View(login);
            }
            Microsoft.AspNetCore.Identity.SignInResult signinResult =
                await _signInManager.PasswordSignInAsync(loginUser, login.Password, false, true);
            if (!signinResult.Succeeded)
            {
                 ModelState.AddModelError("", "Qaqi get qeydiyyatdan kech");
                return View(login);
            }

            return RedirectToAction("Index", "Home");
        }
        public async Task CreateRole()
        {
            if (!await _roleManager.RoleExistsAsync(Helper.UserRoles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.UserRoles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Helper.UserRoles.Members.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.UserRoles.Members.ToString()));
            }
        }

    }
}