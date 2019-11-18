using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Data.Repository
{
    public class CarRepository : IAllCars
    {

        private readonly CarsContext carsContext;

        public CarRepository(CarsContext carsContext)
        {
            this.carsContext = carsContext;
        }

        public IEnumerable<Car> Cars => carsContext.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => carsContext.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => carsContext.Car.FirstOrDefault(p => p.id == carId); 
    }
}
