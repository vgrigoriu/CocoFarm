using System;
using System.Data.Entity;
using System.Linq;

using CocoFarm.DataAccess;
using CocoFarm.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CocoFarm.Controllers
{
    public class CatalogProduseController : Controller
    {
        private readonly IDataStore<Product, Guid> store;
        private readonly IDataStore<ProductCategory, Guid> categoryStore;

        public CatalogProduseController(
            IDataStore<Product, Guid> store,
            IDataStore<ProductCategory, Guid> categoryStore)
        {
            this.store = store;
            this.categoryStore = categoryStore;
        }

        public ActionResult Index()
        {
            var produse = ((DbSet<Product>)store.GetAll()).Include(p => p.Category);
            return View(produse.ToList());
        }

        public ActionResult Details(Guid id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        public ActionResult Create()
        {
            ViewBag.Categories = categoryStore.GetAll().ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product produs, Guid categoryId)
        {


            if (ModelState.IsValid)
            {
                produs.Category = categoryStore.GetById(categoryId);

                store.Create(produs);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = categoryStore.GetAll().ToList();
            return View(produs);
        }

        public ActionResult Edit(Guid id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        [HttpPost]
        public ActionResult Edit(Product produs)
        {
            store.Update(produs);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        [HttpPost]
        public ActionResult Delete(Product produs)
        {

            store.Delete(produs.Id);
            return RedirectToAction("Index");
        }
    }
}
