using System;
using System.Collections.Generic;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName="Sport", desc="Fast cars"},
                    new Category {categoryName="Classic", desc="Classic type of cars"}
                };
            }
        }
    }
}
