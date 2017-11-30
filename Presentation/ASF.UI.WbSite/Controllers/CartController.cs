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
    public class CartController : Controller
    {
        
        public ActionResult Index()
        {
            //return View();
            return View(Session["Carrito"]);
        }
        public ActionResult addCart(int id)
        {
            var producto = new ProductProcess().findProduct(id);

            if (Session["Carrito"] == null)
            {
                List<CartItemDTO> cartItem = new List<CartItemDTO>();
                var carritoItem = new CartItemDTO();
                carritoItem.ProductId = producto.Id;
                carritoItem.Title = producto.Title;
                carritoItem.Price = producto.Price;
                carritoItem.Quantity = producto.QuantitySold;

                cartItem.Add(carritoItem);
                Session["Carrito"] = cartItem;
            }
            else
            {
                List<CartItemDTO> cartItem = (List<CartItemDTO>)Session["Carrito"];
                var carritoItem = new CartItemDTO();
                carritoItem.ProductId = producto.Id;
                carritoItem.Title = producto.Title;
                carritoItem.Price = producto.Price;
                carritoItem.Quantity = producto.QuantitySold;
                int idexistente = controlarId(id);
                if (idexistente == -1)
                    cartItem.Add(carritoItem);
                else
                    cartItem[idexistente].Quantity++;
                Session["Carrito"] = cartItem;
            }
            return View();
        }

        private int controlarId(int id)
        {
            List<CartItemDTO> cartItem = (List<CartItemDTO>)Session["Carrito"];
            for (int i = 0; i < cartItem.Count; i++)
            {
                if (cartItem[i].ProductId == id)
                    return i;
            }
            return -1;
        }

        public ActionResult Delete(int id)
        {
            var cp = new CartProcess();

            return View(cp.findCart(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, Cart cart)
        {
            try
            {
                var cp = new CartProcess();
                cp.deteleCart(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}