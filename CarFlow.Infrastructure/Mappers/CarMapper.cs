using CarFlow.Core.Models;

namespace CarFlow.Infrastructure.Mappers;

public static class CarMapper
{
    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Car" /> to a list of domain models of
    ///     type <see cref="Core.Models.Car" />.
    /// </summary>
    /// <param name="entities">The list of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Car" /> representing the domain models.</returns>
    /// <remarks>
    ///     This method iterates through the list of car entities and converts each one to the appropriate domain model
    ///     based on whether it is a combustion engine car or an electric car.
    /// </remarks>
    public static List<Car> ToDomainModel(this IEnumerable<Models.Car> entities)
    {
        var carList = new List<Car>();

        foreach (var car in entities)
        {
            switch (car)
            {
                case { CombustionEngineCar: not null }:
                    carList.Add(car.ToCombustionEngineCarDomainModel());
                    break;
                case { ElectricCar: not null }:
                    carList.Add(car.ToElectricCarDomainModel());
                    break;
            }
        }

        return carList;
    }

    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Car" /> to a domain model of type <see cref="Car" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Car" /> representing the domain model.</returns>
    /// <exception cref="InvalidDataException">Thrown when the car type is invalid.</exception>
    /// <remarks>
    ///     This method determines the car type and converts the entity model to the corresponding domain model,
    ///     either a combustion engine car or an electric car.
    /// </remarks>
    public static Car ToDomainModel(this Models.Car entity)
        => entity switch
        {
            { CombustionEngineCar: not null } => entity.ToCombustionEngineCarDomainModel(),
            { ElectricCar: not null } => entity.ToElectricCarDomainModel(),
            _ => throw new InvalidDataException("Invalid car type.")
        };

    /// <summary>
    ///     Converts a domain model of type <see cref="CombustionEngineCar" /> to an entity model of type
    ///     <see cref="Models.CombustionEngineCar" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.CombustionEngineCar" /> representing the entity model.</returns>
    public static Models.CombustionEngineCar ToEntity(this CombustionEngineCar domainModel)
        => new(domainModel.Id, domainModel.Model.Id, domainModel.Generation, domainModel.BodyVariant.Id,
            domainModel.TransmissionVariant.Id, domainModel.Drivetrain.Id, domainModel.StartYear, domainModel.EndYear,
            domainModel.Engine.Id, domainModel.EuroStandard.Id, domainModel.CityFuel, domainModel.CombinedFuel,
            domainModel.HighwayFuel);

    /// <summary>
    ///     Converts a domain model of type <see cref="ElectricCar" /> to an entity model of type
    ///     <see cref="Models.ElectricCar" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.ElectricCar" /> representing the entity model.</returns>
    public static Models.ElectricCar ToEntity(this ElectricCar domainModel)
        => new(domainModel.Id, domainModel.Model.Id, domainModel.Generation, domainModel.BodyVariant.Id,
            domainModel.TransmissionVariant.Id, domainModel.Drivetrain.Id, domainModel.StartYear, domainModel.EndYear,
            domainModel.Horsepower, domainModel.Torque, domainModel.BatteryCapacity, domainModel.Range,
            domainModel.MotorCount);

    /// <summary>
    ///     Converts a domain model of type <see cref="CombustionEngineCar" /> to a base car entity model of type
    ///     <see cref="Models.Car" />.
    /// </summary>
    /// <param name="domainModel">The combustion engine car domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Car" /> representing the base entity model.</returns>
    private static Models.Car ToCarEntity(this CombustionEngineCar domainModel)
        => new(domainModel.Id, domainModel.Model.Id, domainModel.Generation, domainModel.BodyVariant.Id,
            domainModel.TransmissionVariant.Id, domainModel.Drivetrain.Id, domainModel.StartYear, domainModel.EndYear);

    /// <summary>
    ///     Converts a domain model of type <see cref="ElectricCar" /> to a base car entity model of type
    ///     <see cref="Models.Car" />.
    /// </summary>
    /// <param name="domainModel">The electric car domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Car" /> representing the base entity model.</returns>
    private static Models.Car ToCarEntity(this ElectricCar domainModel)
        => new(domainModel.Id, domainModel.Model.Id, domainModel.Generation, domainModel.BodyVariant.Id,
            domainModel.TransmissionVariant.Id, domainModel.Drivetrain.Id, domainModel.StartYear, domainModel.EndYear);

    // TODO: story 87
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Car" /> to a domain model of type
    ///     <see cref="CombustionEngineCar" />.
    /// </summary>
    /// <param name="entity">The car entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="CombustionEngineCar" /> representing the combustion engine car domain model.</returns>
    private static CombustionEngineCar ToCombustionEngineCarDomainModel(this Models.Car entity)
        => new(entity.Id, entity.Model.Brand.ToDomainModel(), entity.Model.ToDomainModel(), entity.Generation, new Body(
                1, "Sedan",
                [entity.BodyVariant.ToDomainModel()]), entity.BodyVariant.ToDomainModel(),
            entity.TransmissionVariant.Transmission.ToDomainModel(),
            entity.TransmissionVariant.ToDomainModel(), entity.Drivetrain.ToDomainModel(), entity.StartYear,
            entity.EndYear, entity.CombustionEngineCar!.Engine.ToDomainModel(),
            entity.CombustionEngineCar.EuroStandard.ToDomainModel(), entity.CombustionEngineCar.CityFuel,
            entity.CombustionEngineCar.CombinedFuel, entity.CombustionEngineCar.HighwayFuel);

    // TODO: story 87
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Car" /> to a car domain model of type
    ///     <see cref="ElectricCar" />.
    /// </summary>
    /// <param name="entity">The car entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="ElectricCar" /> representing the electric car domain model.</returns>
    private static ElectricCar ToElectricCarDomainModel(this Models.Car entity)
        => new(entity.Id, entity.Model.Brand.ToDomainModel(), entity.Model.ToDomainModel(), entity.Generation, new Body(
                1, "Sedan",
                [entity.BodyVariant.ToDomainModel()]), entity.BodyVariant.ToDomainModel(),
            entity.TransmissionVariant.Transmission.ToDomainModel(),
            entity.TransmissionVariant.ToDomainModel(), entity.Drivetrain.ToDomainModel(), entity.StartYear,
            entity.EndYear,
            entity.ElectricCar!.Horsepower, entity.ElectricCar.Torque,
            entity.ElectricCar.BatteryCapacity, entity.ElectricCar.Range, entity.ElectricCar.MotorCount);
}