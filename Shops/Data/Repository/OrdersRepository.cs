using System;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly CarsContext carsContext;
        private readonly ShopCart shopCart;

        public OrdersRepository(CarsContext carsContext, ShopCart shopCart)
        {
            this.carsContext = carsContext;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.dateTime = DateTime.Now;
            carsContext.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    carID = el.car.id,
                    order = order,
                    price = el.car.price
                };
                carsContext.OrderDetail.Add(orderDetail);
            }
            carsContext.SaveChanges();
        }
    }
}
