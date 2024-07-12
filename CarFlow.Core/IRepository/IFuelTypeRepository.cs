using CarFlow.Core.Models;

namespace CarFlow.Core.IRepository
{
    public interface IFuelTypeRepository
    {
        Task AddAsync(FuelType fuelType);
        Task DeleteAsync(int id);
        Task<FuelType> GetAsync(int id);
        Task<List<FuelType>> GetAllAsync();
        Task<Page<FuelType>> GetPageAsync(int currentPage, int pageSize);
        Task UpdateAsync(FuelType updateFuelType);
    }
}
