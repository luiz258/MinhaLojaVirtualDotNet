using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaLojaVirtual.Models;
using System;

namespace MinhaLojaVirtual.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            ViewData["Title"] = "Produtos";

            var products = new List<ProductModel>
                {
                new ProductModel { id = new Guid(), name = "Product 1", value = 10.50, description = "Category A", quantity = 10, isActive = true },
                new ProductModel { id = new Guid(), name = "Product 2", value = 10.50, description = "Category A", quantity = 10, isActive = true },
                new ProductModel { id = new Guid(), name = "Product 3", value = 10.50, description = "Category A", quantity = 10, isActive = true },
                };

            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewData["Title"] = "Criar Produtos";
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
