using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shops.Data.Interfaces;
using Shops.Data.Models;

namespace Shops.Services
{
    public class AccountServices
    {
        private readonly ICarsRepo _carsRepo;
        public AccountServices(ICarsRepo carsRepo)
        {
            _carsRepo = carsRepo;
        }


        public async Task<List<Car>> GetCars()
        {
            return await _carsRepo.GetAll();
            //return await _context.Roles.ToListAsync();
        }


        public async Task<Car> DetailsCars(int ? id)
        {
            return await _carsRepo.GetDetail(id);
            //return await _context.Roles.FirstOrDefaultAsync(m => m.Id == id);
        }

        public bool CarExis(int id)
        {
            return _carsRepo.Exist(id);
            //return _context.Roles.Any(m => m.Id == id);
        }

        public async Task AddAndSave(Car car)
        {
            _carsRepo.Add(car);
            await _carsRepo.Save();
            //_context.Roles.Add(role);
            //await _context.SaveChangesAsync();
        }


        public async Task Update(Car car)
        {
            _carsRepo.Update(car);
            await _carsRepo.Save();
            //_context.Roles.Update(role);
            //await _context.SaveChangesAsync();
        }

        //public Task DetailsCars(int id)
        //{
            
          //  return _carsRepo.GetDetail(id);
        //}

        public async Task Delete(Car car)
        {
            _carsRepo.Delete(car);
            await _carsRepo.Save();
            //_context.Roles.Remove(role);
            //await _context.SaveChangesAsync();
        }

        //internal void Delete(Task car)
        //{
          //  throw new NotImplementedException();
        //}
    }
}
