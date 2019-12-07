using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Data.Repository
{
    public class CarsRepo : ICarsRepo
    {
        readonly CarsContext _context;
        public CarsRepo(CarsContext context)
        {
            _context = context;
        }

        public void Add(Car car)
        {
            _context.Add(car);
        }

        public void Update(Car car)
        {
            _context.Update(car);
        }

        public void Delete(Car car)
        {
            _context.Remove(car);
        }

        public bool Exist(int ? id)
        {
            return _context.Car.Any(m => m.id == id);
        }

        public Task<List<Car>> GetAll()
        {
            return _context.Car.ToListAsync();
        }

        public Task<Car> GetDetail(int ? id)
        {
            return _context.Car.FirstOrDefaultAsync(m => m.id == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
