using CarFlow.WebAPI.Enums;
using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class CarMapper
{
    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Car" /> to a list of contracts of
    ///     type
    ///     <see cref="CarContract" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="CarContract" /> representing the contracts.</returns>
    /// <remarks>
    ///     This method iterates through the collection of domain models and converts each one to the appropriate view model
    ///     based on whether it is a combustion engine car or an electric car.
    /// </remarks>
    public static List<CarContract> ToContract(this IEnumerable<Core.Models.Car> domainModels)
    {
        var carContractsList = new List<CarContract>();

        foreach (var car in domainModels)
        {
            switch (car)
            {
                case Core.Models.CombustionEngineCar combustionEngineCar:
                    carContractsList.Add(combustionEngineCar.ToContract());
                    break;
                case Core.Models.ElectricCar electricCar:
                    carContractsList.Add(electricCar.ToContract());
                    break;
            }
        }

        return carContractsList;
    }

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.CombustionEngineCar" /> to a contract of type
    ///     <see cref="CombustionEngineCarContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="CombustionEngineCarContract" /> representing the contract.</returns>
    private static CombustionEngineCarContract ToContract(this Core.Models.CombustionEngineCar domainModel)
        => new()
        {
            Id = domainModel.Id,
            CarType = CarType.CombustionEngineCar,
            Generation = domainModel.Generation,
            StartYear = domainModel.StartYear,
            EndYear = domainModel.EndYear,
            Make = domainModel.Make.ToContract(),
            Model = domainModel.Model.ToContract(),
            Body = domainModel.Body.ToContract(),
            BodyVariant = domainModel.BodyVariant.ToContract(),
            Transmission = domainModel.Transmission.ToContract(),
            TransmissionVariant = domainModel.TransmissionVariant.ToContract(),
            Drivetrain = domainModel.Drivetrain.ToContract(),
            Engine = domainModel.Engine.ToContract(),
            EuroStandard = domainModel.EuroStandard.ToContract(),
            CityFuel = domainModel.CityFuel,
            CombinedFuel = domainModel.CombinedFuel,
            HighwayFuel = domainModel.HighwayFuel
        };

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.ElectricCar" /> to a contract of type
    ///     <see cref="ElectricCarContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="ElectricCarContract" /> representing the contract.</returns>
    private static ElectricCarContract ToContract(this Core.Models.ElectricCar domainModel)
        => new()
        {
            Id = domainModel.Id,
            CarType = CarType.ElectricCar,
            Make = domainModel.Make.ToContract(),
            Model = domainModel.Model.ToContract(),
            Body = domainModel.Body.ToContract(),
            BodyVariant = domainModel.BodyVariant.ToContract(),
            Transmission = domainModel.Transmission.ToContract(),
            TransmissionVariant = domainModel.TransmissionVariant.ToContract(),
            Drivetrain = domainModel.Drivetrain.ToContract(),
            StartYear = domainModel.StartYear,
            EndYear = domainModel.EndYear,
            Horsepower = domainModel.Horsepower,
            Torque = domainModel.Torque,
            BatteryCapacity = domainModel.BatteryCapacity,
            Range = domainModel.Range,
            MotorCount = domainModel.MotorCount
        };
}