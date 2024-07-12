using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.DomainServices.IService;

namespace CarFlow.DomainServices.Services
{
    public class FuelTypeService(IFuelTypeRepository repository) : IFuelTypeService
    {
        public async Task AddAsync(FuelType fuelType) => await repository.AddAsync(fuelType);

        public async Task DeleteAsync(int id) => await repository.DeleteAsync(id);

        public async Task<FuelType> GetAsync(int id) => await repository.GetAsync(id);

        public async Task<List<FuelType>> GetAllAsync() => await repository.GetAllAsync();

        public async Task<Page<FuelType>> GetPageAsync(int currentPage, int pageSize) => await repository.GetPageAsync(currentPage, pageSize);

        public async Task UpdateAsync(FuelType updateFuelType) => await repository.UpdateAsync(updateFuelType);
    }
}
