using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using Supermarket.DAL;

namespace Supermarket.Areas.Admin.Controllers
{ 
    public class ProductsAdminController : Controller
    {
        private SupermarketEntities db = new SupermarketEntities();

        //
        // GET: /Admin/Products/
        
        
        public ViewResult Index()
        {
            if (!User.Identity.IsAuthenticated || !User.IsInRole("Administrator"))
            {
                throw new HttpException(403, "You must be logged in to access this resource.");
            }
            else
            {
                var products = db.Products.Include("Manifactor");
                return View(products.ToList());
            }
           
        }

        //
        // GET: /Admin/Products/Details/5

        public ViewResult Details(int id)
        {
            Product product = db.Products.Single(p => p.ProductId == id);
            return View(product);
        }

        //
        // GET: /Admin/Products/Create

        public ActionResult Create()
        {
            ViewBag.ManifactorId = new SelectList(db.Manifactors, "ManifactorId", "Name");
            return View();
        } 

        //
        // POST: /Admin/Products/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.AddObject(product);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ManifactorId = new SelectList(db.Manifactors, "ManifactorId", "Name", product.ManifactorId);
            return View(product);
        }
        
        //
        // GET: /Admin/Products/Edit/5
 
        public ActionResult Edit(int id)
        {
            Product product = db.Products.Single(p => p.ProductId == id);
            ViewBag.ManifactorId = new SelectList(db.Manifactors, "ManifactorId", "Name", product.ManifactorId);
            return View(product);
        }

        //
        // POST: /Admin/Products/Edit/5

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Attach(product);
                db.ObjectStateManager.ChangeObjectState(product, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ManifactorId = new SelectList(db.Manifactors, "ManifactorId", "Name", product.ManifactorId);
            return View(product);
        }

        //
        // GET: /Admin/Products/Delete/5
 
        public ActionResult Delete(int id)
        {
            Product product = db.Products.Single(p => p.ProductId == id);
            return View(product);
        }

        //
        // POST: /Admin/Products/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Product product = db.Products.Single(p => p.ProductId == id);
            db.Products.DeleteObject(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}