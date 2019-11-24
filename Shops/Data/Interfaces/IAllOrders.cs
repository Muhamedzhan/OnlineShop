using System;
using Shops.Data.Models;

namespace Shops.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
