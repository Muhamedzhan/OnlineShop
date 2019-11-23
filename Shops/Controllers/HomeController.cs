using System;
using Microsoft.AspNetCore.Mvc;
using Shops.Data.Interfaces;
using Shops.ViewModels;

namespace Shops.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _allCars;

        public HomeController(IAllCars allCars)
        {
            _allCars = allCars;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _allCars.getFavCars
            };
            return View(homeCars);
        }
    }
}
