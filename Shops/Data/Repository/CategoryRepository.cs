using System;
using System.Collections.Generic;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly CarsContext carsContext;

        public CategoryRepository(CarsContext carsContext)
        {
            this.carsContext = carsContext;
        }

        public IEnumerable<Category> AllCategories => carsContext.Category;
    }
}
