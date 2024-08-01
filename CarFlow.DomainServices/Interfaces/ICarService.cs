using CarFlow.Core.Models;
using CarFlow.Core.Models.Commands;

namespace CarFlow.DomainServices.Interfaces;

public interface ICarService
{
    Task AddAsync(CarCreateCommand command);
    Task DeleteAsync(int id);
    Task<Car?> GetAsync(int id);
    Task<IEnumerable<Car>> GetAllAsync();
    Task<Page<Car>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(CarUpdateCommand updateCar);
}