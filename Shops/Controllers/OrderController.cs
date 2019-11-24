using System;
using Microsoft.AspNetCore.Mvc;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {

            shopCart.listShopItems = shopCart.getShopItems();

            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "You must have at least 1 product!");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Your order was completelely approved!";
            return View();
        }
    }
}
