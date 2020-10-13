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

namespace EndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductImageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public ProductImageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<ProductImage> product = _db.ProductImages.ToList();
            return View(product);
        }
        public IActionResult Create()
        {
            ProductCrudVM product = new ProductCrudVM()
            {
                Products = _db.Products.ToList(),
            };
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCrudVM productCrud)
        {

            ProductImage productImage = new ProductImage()
            {
                Name = productCrud.Name
            };
            if (productCrud.Photo == null)
            {
                ModelState.AddModelError("", "Shekil sechin");
                ProductCrudVM products = new ProductCrudVM()
                {
                    Products = _db.Products.ToList(),
                };
                return View(products);
            }
            if (!productCrud.Photo.IsImage())
            {
                ModelState.AddModelError("", "Shekil formatinda bir fayl sechin");
                ProductCrudVM products = new ProductCrudVM()
                {
                    Products = _db.Products.ToList(),
                };
                return View(products);
            }
            if (productCrud.Photo.MaxLength(1400))
            {

                ModelState.AddModelError("", "Shekilin olchusu max 1400kb ola biler");
                ProductCrudVM products = new ProductCrudVM()
                {
                    Products = _db.Products.ToList(),
                };
                return View(products);
            }
            productImage.Image = await productCrud.Photo.SaveImage(_env.WebRootPath, "img/shop");
            string aaaa = Request.Form["product"];
            Product product = _db.Products.FirstOrDefault(s => s.Name.ToLower().Trim() == aaaa.ToLower().Trim());
            productImage.ProductId = product.Id;
            string b = Request.Form["ismain"];
            if (b.ToLower().Trim() == "main")
            {
                productImage.IsMain = true;
            }
            else
            {
                productImage.IsMain = false;
            }
            _db.ProductImages.Add(productImage);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            ProductCrudVM productCrud = new ProductCrudVM
            {
                ProductImage= _db.ProductImages.Find(id),
                Products = _db.Products.ToList()
            };
            if (productCrud == null) return NotFound();
            return View(productCrud);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ProductCrudVM productImage)
        {
            if (id == null) return View();
            ProductImage productImage1 = _db.ProductImages.Find(id);
            if (productImage1 == null) return NotFound();
            if (productImage.Photo != null)
            {
                if (!productImage.Photo.IsImage())
                {
                    ModelState.AddModelError("", "Shekil formatinda bir fayl sechin");
                    return View();
                }
                if (productImage.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("", "Shekilin olchusu max 1400kb ola biler");
                    return View();
                }
                Helper.DeleteImg(_env.WebRootPath, "img/shop", productImage1.Image);
                productImage1.Image = await productImage.Photo.SaveImage(_env.WebRootPath, "img/shop");
                string aaaa = Request.Form["product"];
                Product product = _db.Products.FirstOrDefault(s => s.Name.ToLower().Trim() == aaaa.ToLower().Trim());
                productImage1.ProductId = product.Id;
                string b = Request.Form["ismain"];
                if (b.ToLower().Trim() == "main")
                {
                    productImage1.IsMain = true;
                }
                else
                {
                    productImage1.IsMain = false;
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            else
            {
                string aaaa = Request.Form["product"];
                Product product = _db.Products.FirstOrDefault(s => s.Name.ToLower().Trim() == aaaa.ToLower().Trim());
                productImage1.ProductId = product.Id;
                string b = Request.Form["ismain"];
                if (b.ToLower().Trim() == "main")
                {
                    productImage1.IsMain = true;
                }
                else
                {
                    productImage1.IsMain = false;
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            ProductImage productImage = _db.ProductImages.Find(id);
            if (productImage == null) return NotFound();
            return View(productImage);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            ProductImage productImage = _db.ProductImages.Find(id);
            if (productImage == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/shop", productImage.Image);
            _db.ProductImages.Remove(productImage);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}