using CarandsalemanagementMVC.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace CarandsalemanagementMVC.Services
{
    public class CarModelService : ICarModelService
    {
        private readonly ApplicationDbContext _context;

        public CarModelService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CarModel> CreateCarModelAsync(CarModel carModel)
        {
            _context.CarModels.Add(carModel);
            await _context.SaveChangesAsync();
            return carModel;
        }

        public async Task<bool> DeleteCarModelAsync(int id)
        {
            var carModel = await _context.CarModels.FindAsync(id);
            if (carModel == null)
                return false;

            _context.CarModels.Remove(carModel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<CarModel>> GetAllCarModelsAsync()
        {
            return await _context.CarModels.ToListAsync();
        }

        public async Task<CarModel> GetCarModelAsync(int id)
        {
            return await _context.CarModels.FindAsync(id);
        }

        public async Task<CarModel> UpdateCarModelAsync(int id, CarModel carModel)
        {
            var existingCarModel = await _context.CarModels.FindAsync(id);
            if (existingCarModel == null)
                return null;

            existingCarModel.Brand = carModel.Brand;
            existingCarModel.Class = carModel.Class;
            existingCarModel.ModelName = carModel.ModelName;
            existingCarModel.ModelCode = carModel.ModelCode;
            existingCarModel.Description = carModel.Description;
            existingCarModel.Features = carModel.Features;
            existingCarModel.Price = carModel.Price;
            existingCarModel.DateOfManufacturing = carModel.DateOfManufacturing;
            existingCarModel.Active = carModel.Active;
            existingCarModel.SortOrder = carModel.SortOrder;

            _context.CarModels.Update(existingCarModel);
            await _context.SaveChangesAsync();

            return existingCarModel;
        }
    }
}
