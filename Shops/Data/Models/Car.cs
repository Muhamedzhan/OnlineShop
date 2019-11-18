using System;
using System.ComponentModel.DataAnnotations;

namespace Shops.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        [Key]
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
