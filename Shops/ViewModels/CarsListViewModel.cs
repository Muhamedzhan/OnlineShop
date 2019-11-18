using System;
using System.Collections.Generic;
using Shops.Data.Models;

namespace Shops.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public string currCategory { get; set; }
    }
}
