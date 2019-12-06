using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shops.Data;
using Shops.Data.Interfaces;
using Shops.Data.Models;
using Shops.ViewModels;

namespace Shops.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        private readonly CarsContext _context;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            } else
            {
                if (string.Equals("sport", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Sport")).OrderBy(i => i.id);
                    currCategory = "Sport cars";
                } else if (string.Equals("classic", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Classic")).OrderBy(i => i.id);
                    currCategory = "Classic cars";
                }
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };

            ViewBag.Title = "Car page";
            
            return View(carObj);
        }

        
        public IActionResult Create()
        {
            ViewData["categoryId"] = new SelectList(_allCategories.AllCategories, "id", "id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,shortDesc,longDesc,img,price,isFavourite,available,categoryId")] Car car)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Car.ToListAsync());
        }
    }
}
