using System;
using CocoFarm.DataAccess;
using CocoFarm.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CocoFarm.Controllers
{
    public class CatalogProduseController : Controller
    {
        private readonly IDataStore<Product, Guid> store;

        public CatalogProduseController(IDataStore<Product, Guid> store)
        {
            this.store = store;
        }

        public ActionResult Index()
        {
            IEnumerable<Product> produse = store.GetAll();
            return View(produse);
        }

        public ActionResult Details(Guid id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                store.Create(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        public ActionResult Edit(Guid id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            store.Update(product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {

            store.Delete(product.Id);
            return RedirectToAction("Index");
        }
    }
}
