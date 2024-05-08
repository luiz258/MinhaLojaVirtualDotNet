using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaLojaVirtual.Infra.IRepository;
using MinhaLojaVirtual.Models;
using System;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace MinhaLojaVirtual.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: ProductController
        public async Task<IActionResult> Index(int quantity , double value, string name)
        {
            ViewData["Title"] = "Produtos";
     

            var list = await _productRepository.GetFilteredProducts(quantity, value, name);

            return View(list);
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
        public async Task<IActionResult> Create(ProductModel model)
        {
            try
            {
                var product = new ProductModel(model.name, model.value, model.quantity, model.description);
               await _productRepository.Save(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["Title"] = "Erro!";    

                return View();
            }
        }

        // GET: ProductController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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

        private Expression<Func<T, bool>> FilterByProperty<T>(string propertyName, object propertyValue)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "entity");
            MemberExpression property = Expression.Property(parameter, propertyName);
            ConstantExpression value = Expression.Constant(propertyValue);

            BinaryExpression comparison = Expression.Equal(property, value);

            Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(comparison, parameter);

            return lambda;
        }
    }
}
