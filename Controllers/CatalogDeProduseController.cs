using ProiectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProiectFinal.Controllers;
using ProiectFinal.Models;

namespace ProiectFinal.Controllers
{
    public class CatalogDeProduseController : Controller
    {
        private CatalogDeProduseDbContext cdpdbCtx = new CatalogDeProduseDbContext();
        private CosDeProduseModelDbContext cosdbCtx = new CosDeProduseModelDbContext();
        // GET: CatalogDeProduse
        public ActionResult Index()
        {
            return View(cdpdbCtx.CatalogDeProduse.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            CatalogDeProduseModel cdp = new CatalogDeProduseModel();
            return View(cdp);
        }

        [HttpPost]
        public ActionResult Create(CatalogDeProduseModel produs)
        {
            cdpdbCtx.CatalogDeProduse.Add(produs);
            cdpdbCtx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            CatalogDeProduseModel produs = cdpdbCtx.CatalogDeProduse.Find(id);
            if (produs == null)
            {
                return HttpNotFound();
            }
            return View(produs);
        }

        public ActionResult Cumpara(int id)
        {
            CatalogDeProduseModel produs = cdpdbCtx.CatalogDeProduse.Find(id);
            if (produs == null)
            {
                return HttpNotFound();
            }
            else
            {
                cosdbCtx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produs);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CatalogDeProduseModel produs = cdpdbCtx.CatalogDeProduse.Find(id);

            return View(produs);
        }

        [HttpPost]
        public ActionResult Edit(CatalogDeProduseModel produs)
        {
            cdpdbCtx.Entry(produs).State = System.Data.Entity.EntityState.Modified;
            cdpdbCtx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}