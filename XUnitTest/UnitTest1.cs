using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Shops.Data.Interfaces;
using Shops.Data.Models;
using Shops.Services;
using Xunit;


namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task AddTest()
        {
            var fake = Mock.Of<ICarsRepo>();
            var carService = new AccountServices(fake);

            var car = new Car() { name = "admin admin" };
            await carService.AddAndSave(car);
        }
        [Fact]
        public async Task UpdateTest()
        {
            var fake = Mock.Of<ICarsRepo>();
            var carService = new AccountServices(fake);

            var car = new Car() { name = "admin 1" };
            await carService.Update(car);
        }
        [Fact]
        public async Task RemoveTest()
        {
            var fake = Mock.Of<ICarsRepo>();
            var carService = new AccountServices(fake);
            var car = new Car() { name = "admin 1" };
            await carService.Delete(car);
        }
        [Fact]
        public async Task DetailTest()
        {
            var fake = Mock.Of<ICarsRepo>();
            var carService = new AccountServices(fake);
            var id = 2;
            await carService.DetailsCars(id);
        }
        [Fact]
        public async Task GetCarsTest()
        {
            var roles = new List<Car>
            {
                new Car() { name = "super admin" },
                new Car() { name = "invalid user" },
            };

            var fakeRepositoryMock = new Mock<ICarsRepo>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(roles);


            var carService = new AccountServices(fakeRepositoryMock.Object);

            var resultCars = await carService.GetCars();

            Assert.Collection(resultCars, car =>
            {
                Assert.Equal("super admin", car.name);
            },
            car =>
            {
                Assert.Equal("invalid user", car.name);
            });
        }
    }
}
