using System;
using System.ComponentModel.DataAnnotations;

namespace Shops.Data.Models
{
    public class ShopCartItem
    {
        [Key]
        public int id { get; set; }
        public Car car { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
