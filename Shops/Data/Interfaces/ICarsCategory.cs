using System;
using System.Collections.Generic;
using Shops.Data.Models;

namespace Shops.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
