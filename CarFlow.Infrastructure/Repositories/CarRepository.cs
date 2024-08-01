using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Extensions;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Car = CarFlow.Core.Models.Car;

namespace CarFlow.Infrastructure.Repositories;

public class CarRepository(CarFlowContext context) : ICarRepository
{
    public async Task AddAsync(Car car)
    {
        switch (car)
        {
            case Core.Models.CombustionEngineCar combustionEngineCar:
                await context.CombustionEngineCars.AddAsync(combustionEngineCar.ToEntity());
                break;
            case Core.Models.ElectricCar electricCar:
                await context.ElectricCars.AddAsync(electricCar.ToEntity());
                break;
        }

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var car = await context.Cars
            .Include(x => x.CombustionEngineCar)
            .Include(x => x.ElectricCar)
            .SingleAsync(x => x.Id == id);

        if (car.CombustionEngineCar is not null)
        {
            var combustionEngineCar = await context.CombustionEngineCars.SingleAsync(x => x.Id == car.Id);

            context.CombustionEngineCars.Remove(combustionEngineCar);
        }

        else if (car.ElectricCar is not null)
        {
            var electricCar = await context.ElectricCars.SingleAsync(x => x.Id == car.Id);

            context.ElectricCars.Remove(electricCar);
        }

        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Car>> GetAllAsync()
    {
        var cars = await context.Cars
            .IncludeCarDetails()
            .ToListAsync();

        return cars.ToDomainModel();
    }

    public async Task<Car?> GetAsync(int id)
    {
        var car = await context.Cars
            .IncludeCarDetails()
            .SingleOrDefaultAsync(x => x.Id == id);

        return car?.ToDomainModel();
    }

    public async Task<Page<Car>> GetPageAsync(int currentPage, int pageSize)
    {
        var offset = (currentPage - 1) * pageSize;

        var carList = await context.Cars
            .OrderBy(x => x.Id)
            .Skip(offset)
            .Take(pageSize)
            .IncludeCarDetails()
            .ToListAsync();

        var recordCount = await context.Drivetrains.CountAsync();
        var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

        return new Page<Car>(currentPage, pageCount, pageSize, carList.ToDomainModel());
    }

    public async Task UpdateAsync(Car updateCar)
    {
        switch (updateCar)
        {
            case Core.Models.CombustionEngineCar updateCombustionEngineCar:
                await UpdateCombustionEngineCar(updateCombustionEngineCar);
                break;

            case Core.Models.ElectricCar updateElectricCar:
                await UpdateElectricCar(updateElectricCar);
                break;
        }

        await context.SaveChangesAsync();
    }

    private async Task UpdateCombustionEngineCar(Core.Models.CombustionEngineCar updateCar)
    {
        var existingCombustionEngineCar = await context.CombustionEngineCars
            .Include(x => x.Engine)
            .ThenInclude(x => x.FuelType)
            .Include(x => x.Engine)
            .ThenInclude(x => x.Configuration)
            .Include(x => x.Engine)
            .ThenInclude(x => x.Aspiration)
            .Include(x => x.EuroStandard)
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.Model)
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.BodyVariant)
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.TransmissionVariant)
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.Drivetrain)
            .SingleAsync(x => x.Id == updateCar.Id);

        existingCombustionEngineCar.IdNavigation.ModelId = updateCar.Model.Id;
        existingCombustionEngineCar.IdNavigation.Generation = updateCar.Generation;
        existingCombustionEngineCar.IdNavigation.BodyVariantId = updateCar.BodyVariant.Id;
        existingCombustionEngineCar.IdNavigation.TransmissionVariantId = updateCar.TransmissionVariant.Id;
        existingCombustionEngineCar.IdNavigation.DrivetrainId = updateCar.Drivetrain.Id;
        existingCombustionEngineCar.IdNavigation.StartYear = updateCar.StartYear;
        existingCombustionEngineCar.IdNavigation.EndYear = updateCar.EndYear;
        existingCombustionEngineCar.EngineId = updateCar.Engine.Id;
        existingCombustionEngineCar.EuroStandardId = updateCar.EuroStandard.Id;
        existingCombustionEngineCar.CityFuel = updateCar.CityFuel;
        existingCombustionEngineCar.CombinedFuel = updateCar.CombinedFuel;
        existingCombustionEngineCar.HighwayFuel = updateCar.HighwayFuel;
    }

    private async Task UpdateElectricCar(Core.Models.ElectricCar updateCar)
    {
        var existingElectricCar = await context.ElectricCars
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.Model)
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.BodyVariant)
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.TransmissionVariant)
            .Include(x => x.IdNavigation)
            .ThenInclude(x => x.Drivetrain)
            .SingleAsync(x => x.Id == updateCar.Id);

        existingElectricCar.IdNavigation.ModelId = updateCar.Model.Id;
        existingElectricCar.IdNavigation.Generation = updateCar.Generation;
        existingElectricCar.IdNavigation.BodyVariantId = updateCar.BodyVariant.Id;
        existingElectricCar.IdNavigation.TransmissionVariantId = updateCar.TransmissionVariant.Id;
        existingElectricCar.IdNavigation.DrivetrainId = updateCar.Drivetrain.Id;
        existingElectricCar.IdNavigation.StartYear = updateCar.StartYear;
        existingElectricCar.IdNavigation.EndYear = updateCar.EndYear;
        existingElectricCar.Horsepower = updateCar.Horsepower;
        existingElectricCar.Torque = updateCar.Torque;
        existingElectricCar.BatteryCapacity = updateCar.BatteryCapacity;
        existingElectricCar.Range = updateCar.Range;
        existingElectricCar.MotorCount = updateCar.MotorCount;
    }
}