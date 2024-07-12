using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.DomainServices.IService;

namespace CarFlow.DomainServices.Services
{
    public class CarService(
        ICarRepository carRepository)
        : ICarService
    {
        public async Task AddAsync(Car car) => await carRepository.AddAsync(car);

        public async Task DeleteAsync(int id) => await carRepository.DeleteAsync(id);

        public async Task<Car> GetAsync(int id) => await carRepository.GetAsync(id);

        public async Task<Page<Car>> GetPageAsync(int currentPage, int pageSize) => await carRepository.GetPageAsync(currentPage, pageSize);

        public async Task UpdateAsync(Car updateCar) => await carRepository.UpdateAsync(updateCar);
    }
}
