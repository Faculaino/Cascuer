using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASF.UI.Process;
using ASF.Entities;
using ASF.UI.WbSite.Services.Cache;

namespace ASF.UI.WbSite.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {

        public ActionResult Index()
        {
            return View(Session["Carrito"]);
            //return View();
        }

        //public ActionResult PaymentMethods()
        //{
        //    return View();
        //}

        //[Authorize]
        //public ActionResult finalizarCompra()
        //{
        //    List<CartItemDTO> compras = (List<CartItemDTO>)Session["Carrito"];

        //    Session.RemoveAll();
        //    return View();

        //}


        public ActionResult PaymentMethods()
        {
            List<CartItemDTO> compras = (List<CartItemDTO>)Session["Carrito"];

            if (compras != null && compras.Count > 0)
            {
                //CartItem cartitem = new CartItem();
                //List<CartItem> listcartitem = new List<CartItem>();

                foreach (var item in compras)
                {
                    //cartitem.ProductId = item.ProductId;
                    //cartitem.Quantity = item.Quantity;
                    //cartitem.Price = item.Price;

                    //listcartitem.Add(cartitem);
                    //CartProcess cp = new CartProcess();
                    //cp.insertCartItemDTO(item);
                }
                Session.RemoveAll();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
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
                {
                    cartItem.Add(carritoItem);
                }
                else
                {
                    cartItem[idexistente].Quantity++;
                    Session["Carrito"] = cartItem;
                }
                   
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ChangeQuantity(int id, int quantity)
        {
            List<CartItemDTO> cartItem = (List<CartItemDTO>)Session["Carrito"];
            cartItem.Where(x => x.ProductId == id).First().Quantity = quantity;
            return RedirectToAction("Index");
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

        public ActionResult finishCart()
        {

            Session.RemoveAll();
            return View();


        }

        // GET: Cart
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Cart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cart/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: Cart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        //[AllowAnonymous]
        //public ActionResult mostrarCarrito()
        //{
        //    return View(Session["Carrito"]);
        //}

        //[Authorize]
        //public ActionResult finalizarCompra()
        //{
        //    List<CartItemDTO> compras = (List<CartItemDTO>)Session["Carrito"];

        //    if (compras != null && compras.Count > 0)
        //    {
        //        //CartItem cartitem = new CartItem();
        //        //List<CartItem> listcartitem = new List<CartItem>();

        //        foreach (var item in compras)
        //        {
        //            //cartitem.ProductId = item.ProductId;
        //            //cartitem.Quantity = item.Quantity;
        //            //cartitem.Price = item.Price;

        //            //listcartitem.Add(cartitem);
        //            //CartProcess cp = new CartProcess();
        //            //cp.insertCartItemDTO(item);
        //        }
        //        Session.RemoveAll();
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Product");
        //    }
        //}

        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            List<CartItemDTO> cartItem = (List<CartItemDTO>)Session["Carrito"];
            cartItem.RemoveAt(controlarId(id));
            return View("Index");
        }

        // POST: Cart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}