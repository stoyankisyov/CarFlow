using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Extensions;

internal static class CarExtensions
{
    public static IQueryable<Car> IncludeCarDetails(this IQueryable<Car> query)
        => query
            .Include(x => x.Model)
            .ThenInclude(x => x.Brand)
            .Include(x => x.BodyVariant)
            .ThenInclude(x => x.Body)
            .Include(x => x.TransmissionVariant)
            .ThenInclude(x => x.Transmission)
            .Include(x => x.Drivetrain)
            .Include(x => x.CombustionEngineCar)
            .ThenInclude(y => y!.Engine)
            .ThenInclude(z => z.FuelType)
            .Include(x => x.CombustionEngineCar)
            .ThenInclude(y => y!.Engine)
            .ThenInclude(z => z.Configuration)
            .Include(x => x.CombustionEngineCar)
            .ThenInclude(y => y!.Engine)
            .ThenInclude(z => z.Aspiration)
            .Include(x => x.CombustionEngineCar)
            .ThenInclude(y => y!.EuroStandard)
            .Include(x => x.ElectricCar);
}