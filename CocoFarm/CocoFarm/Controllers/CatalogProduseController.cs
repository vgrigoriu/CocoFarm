using CocoFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CocoFarm.Controllers
{
    public class CatalogProduseController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Produs> produse = new List<Produs>(){
                new Produs() { Id = 1, Cod = "ASP_Byer_500", Denumire = "Aspirină Byer 500 mg" },
                new Produs() { Id = 2, Cod = "ASP_Byer_1000", Denumire = "Aspirină Byer 1000 mg" },
                new Produs() { Id = 3, Cod = "PAR_Sicomed_500", Denumire = "Paracetamol 500 mg" }
            };
            return View(produse);
        }

        public ActionResult Details(int id)
        {
            Produs produs = new Produs();
            return View(produs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produs produs)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Produs produs)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Produs produs)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
