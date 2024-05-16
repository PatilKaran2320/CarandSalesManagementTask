namespace CarandsalemanagementMVC.Services.IServices
{
    public interface ICarModelService
    {
        Task<CarModel> GetCarModelAsync(int id);
        Task<IEnumerable<CarModel>> GetAllCarModelsAsync();
        Task<CarModel> CreateCarModelAsync(CarModel carModel);
        Task<CarModel> UpdateCarModelAsync(int id, CarModel carModel);
        Task<bool> DeleteCarModelAsync(int id);
    }
}
