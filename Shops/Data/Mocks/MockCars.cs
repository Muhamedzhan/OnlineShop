using System;
using System.Collections.Generic;
using System.Linq;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name="Nissan GT-R",
                        shortDesc="Fast car",
                        longDesc="The Nissan GT-R is a sports car produced by Nissan, which was unveiled in 2007. It is the successor to the Skyline GT-R, although no longer part of the Skyline range itself, that name now being used for Nissan's luxury-sport market.",
                        img="/img/car1.jpg",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name="Jaguar F-Type",
                        shortDesc="True sporting specialism",
                        longDesc="On usability, it comes up short next to plenty of sports cars, having only two seats, offering slightly cramped accommodation even for two, and limited boot space in convertible forms.",
                        img="/img/car2.jpg",
                        price=55000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name="Lotus Evora",
                        shortDesc="2+2 Porsche-chaser",
                        longDesc="It retains a chassis and steering system that both truly deserve top billing. Few sports cars have such immersive, positive steering, or a ride and handling compromise so suited to life on British roads.",
                        img="/img/car3.jpg",
                        price=40000,
                        isFavourite=false,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name="Toyota Camry LE",
                        shortDesc="Classic Car from Japan",
                        longDesc="The latest Camry, which is the eighth generation of the global Camry model, and known as the XV70 was introduced at the January 2017 North American International Auto Show.",
                        img="/img/car4.jpg",
                        price=30000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
