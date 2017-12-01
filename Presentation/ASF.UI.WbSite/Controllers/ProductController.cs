using ASF.Entities;
using ASF.UI.Process;
using ASF.UI.WbSite.Constants.HomeController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASF.UI.WbSite.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        
        public ActionResult Index()
        {
            var pp = new ProductProcess();
            return View(pp.SelectList());
        }

        // GET: Dealer/Create
        public ActionResult Create()
        {
            var dealer = new DealerProcess().SelectList();

            ViewBag.Dealer = new SelectList(dealer, "Id", "FirstName");

            return View();
        }

        // POST: Dealer/Create
        [HttpPost]
        public ActionResult Create(Product product, string Dealer)
        {
            try
            {
                var pp = new ProductProcess();

                product.DealerId = Int32.Parse(Dealer);

                pp.insertProduct(product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            var pp = new ProductProcess();

            return View(pp.findProduct(id));
        }

        public ActionResult Edit(int id)
        {
            var pp = new ProductProcess();

            return View(pp.findProduct(id));
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                var pp = new ProductProcess();
                pp.editProduct(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var pp = new ProductProcess();

            return View(pp.findProduct(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                var pp = new ProductProcess();
                pp.deleteProduct(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}