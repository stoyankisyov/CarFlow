using CarFlow.Core.Models;

namespace CarFlow.DomainServices.IService
{
    public interface ICarService
    {
        Task AddAsync(Car car);
        Task DeleteAsync(int id);
        Task<Car> GetAsync(int id);
        Task<Page<Car>> GetPageAsync(int currentPage, int pageSize);
        Task UpdateAsync(Car updateCar);
    }
}
