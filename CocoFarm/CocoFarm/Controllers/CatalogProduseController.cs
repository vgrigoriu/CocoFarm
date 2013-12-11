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

        public CatalogProduseController(IDataStore<Product, Guid> store)
        {
            this.store = store;
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
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product produs)
        {
            if (ModelState.IsValid)
            {
                store.Create(produs);
                return RedirectToAction("Index");
            }

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
