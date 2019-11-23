using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Shops.Data.Models
{
    public class ShopCart
    {

        private readonly CarsContext carsContext;

        public ShopCart(CarsContext carsContext)
        {
            this.carsContext = carsContext;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<CarsContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context)
            {
                ShopCartId = shopCartId
            };
        }

        public void AddToCart(Car car)
        {
            carsContext.ShopCartItem.Add(new ShopCartItem {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });

            carsContext.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return carsContext.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }

    }
}
