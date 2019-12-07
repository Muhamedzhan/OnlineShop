using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shops.Data.Models;

namespace Shops.Data.Interfaces
{

    public interface ICarsRepo
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Task Save();
        Task<List<Car>> GetAll();
        Task<Car> GetDetail(int ?id);
        bool Exist(int ? id);
    }
}