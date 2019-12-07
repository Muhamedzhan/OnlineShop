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
using Shops.Services;
using Shops.ViewModels;

namespace Shops.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        private readonly AccountServices _context;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat, AccountServices carsContext)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
            _context = carsContext;
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
                
                await _context.AddAndSave(car);
                return RedirectToAction("Index", "Home");
            }
            return View(car);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["categoryId"] = new SelectList(_allCategories.AllCategories, "id", "id");
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.DetailsCars(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,shortDesc,longDesc,img,price,isFavourite,available,categoryId")] Car car)
        {
            if (id != car.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Update(car);
                    TempData["id2"] = car.name;
                  
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            return View(car);
        }

        private bool CarExists(int id)
        {
            return _context.CarExis(id);
        }

        // GET: Car/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.DetailsCars(id);
           
            if (car == null)
            {
                return NotFound();
            }

            

            return View(car);
        }

        // POST: Car/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.DetailsCars(id);
            await _context.Delete(car);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.GetCars());
        }
    }
}
