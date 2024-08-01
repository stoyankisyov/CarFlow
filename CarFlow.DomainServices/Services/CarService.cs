using CarFlow.Core.Models;
using CarFlow.Core.Models.Commands;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Factories;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Services;

public class CarService(
    ICarRepository carRepository,
    CarCommandHandlerFactory carServiceFactory)
    : ICarService
{
    public async Task DeleteAsync(int id)
        => await carRepository.DeleteAsync(id);

    public async Task<Car?> GetAsync(int id)
        => await carRepository.GetAsync(id);

    public async Task<IEnumerable<Car>> GetAllAsync()
        => await carRepository.GetAllAsync();

    public async Task<Page<Car>> GetPageAsync(int currentPage, int pageSize)
        => await carRepository.GetPageAsync(currentPage, pageSize);

    public async Task UpdateAsync(CarUpdateCommand command)
    {
        var service = carServiceFactory.Resolve(command);

        var car = await service.Handle(command);

        await carRepository.UpdateAsync(car);
    }

    public async Task AddAsync(CarCreateCommand command)
    {
        var service = carServiceFactory.Resolve(command);

        var car = await service.Handle(command);

        await carRepository.AddAsync(car);
    }
}