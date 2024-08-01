using CarFlow.Core.Models;
using CarFlow.UI.Enums;
using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class CarMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="CarViewModel" /> to a command of type
    ///     <see cref="Core.Models.Commands.CarCreateCommand" />.
    /// </summary>
    /// <param name="viewViewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Commands.CarCreateCommand" /> representing the command.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the view model is of an unknown type.</exception>
    /// <remarks>
    ///     This method uses pattern matching to determine the type of the <see cref="CarViewModel" />.
    ///     It converts the view model to the appropriate create command based on whether it is an
    ///     <see cref="ElectricCarViewViewModel" />
    ///     or a <see cref="CombustionEngineCarViewViewModel" />. If the view model type is unknown, an exception is thrown.
    /// </remarks>
    public static Core.Models.Commands.CarCreateCommand ToCreateCommand(this CarViewModel viewViewModel)
        => viewViewModel switch
        {
            ElectricCarViewViewModel electricCarViewModel => electricCarViewModel.ToCreateCommand(),
            CombustionEngineCarViewViewModel combustionEngineCarViewModel =>
                combustionEngineCarViewModel.ToCreateCommand(),
            _ => throw new InvalidOperationException("Unknown view model type")
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Car" /> to a list of view models
    ///     of type
    ///     <see cref="CarViewModel" />.
    /// </summary>
    /// <param name="domainModels">The list of domain models to be converted.</param>
    /// <returns>A new list of <see cref="CarViewModel" /> representing the view models.</returns>
    /// <remarks>
    ///     This method iterates through the collection of domain models and converts each one to the appropriate view model
    ///     based on whether it is a combustion engine car or an electric car.
    /// </remarks>
    public static List<CarViewModel> ToViewModel(this IEnumerable<Car> domainModels)
    {
        var carViewModelList = new List<CarViewModel>();

        foreach (var car in domainModels)
        {
            switch (car)
            {
                case CombustionEngineCar combustionEngineCar:
                    carViewModelList.Add(combustionEngineCar.ToViewModel());
                    break;
                case ElectricCar electricCar:
                    carViewModelList.Add(electricCar.ToViewModel());
                    break;
            }
        }

        return carViewModelList;
    }

    /// <summary>
    ///     Converts a domain model of type <see cref="Car" /> to a view model of type <see cref="CarViewModel" />.
    /// </summary>
    /// <param name="viewModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="CarViewModel" /> representing the view model.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the domain model is of an unknown type.</exception>
    /// <remarks>
    ///     This method uses pattern matching to determine the type of the <see cref="Car" /> domain model.
    ///     It converts the domain model to the appropriate view model based on whether it is an <see cref="ElectricCar" />
    ///     or a <see cref="CombustionEngineCar" />. If the domain model type is unknown, an exception is thrown.
    /// </remarks>
    public static CarViewModel ToViewModel(this Car viewModel)
        => viewModel switch
        {
            ElectricCar electricCarDomainModel => electricCarDomainModel.ToViewModel(),
            CombustionEngineCar combustionEngineCarDomainModel => combustionEngineCarDomainModel.ToViewModel(),
            _ => throw new InvalidOperationException("Unknown view model type")
        };


    /// <summary>
    ///     Converts a view model of type <see cref="CarViewModel" /> to a command of type
    ///     <see cref="Core.Models.Commands.CarUpdateCommand" />.
    /// </summary>
    /// <param name="viewViewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Commands.CarUpdateCommand" /> representing the command.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the view model is of an unknown type.</exception>
    /// <remarks>
    ///     This method uses pattern matching to determine the type of the <see cref="CarViewModel" />.
    ///     It converts the view model to the appropriate update command based on whether it is an
    ///     <see cref="ElectricCarViewViewModel" />
    ///     or a <see cref="CombustionEngineCarViewViewModel" />. If the view model type is unknown, an exception is thrown.
    /// </remarks>
    public static Core.Models.Commands.CarUpdateCommand ToUpdateCommand(this CarViewModel viewViewModel)
        => viewViewModel switch
        {
            ElectricCarViewViewModel electricCarViewModel => electricCarViewModel.ToUpdateCommand(),
            CombustionEngineCarViewViewModel combustionEngineCarViewModel =>
                combustionEngineCarViewModel.ToUpdateCommand(),
            _ => throw new InvalidOperationException("Unknown view model type")
        };

    /// <summary>
    ///     Converts a view model of type <see cref="CombustionEngineCarViewViewModel" /> to a command of type
    ///     <see cref="Core.Models.Commands.CombustionEngineCarCreateCommand" />.
    /// </summary>
    /// <param name="viewViewModel">The view model to be converted.</param>
    /// <returns>
    ///     A new instance of <see cref="Core.Models.Commands.CombustionEngineCarCreateCommand" /> representing the
    ///     command.
    /// </returns>
    private static Core.Models.Commands.CombustionEngineCarCreateCommand ToCreateCommand(
        this CombustionEngineCarViewViewModel viewViewModel)
        => new(viewViewModel.Model.ToDomainModel(),
            viewViewModel.Generation, viewViewModel.BodyVariant.ToDomainModel(),
            viewViewModel.TransmissionVariant.ToDomainModel(), viewViewModel.Drivetrain.ToDomainModel(),
            viewViewModel.StartYear, viewViewModel.EndYear, viewViewModel.Engine.Id,
            viewViewModel.Eurostandard.ToDomainModel(), viewViewModel.CityFuel,
            viewViewModel.CombinedFuel, viewViewModel.HighwayFuel);

    /// <summary>
    ///     Converts a view model of type <see cref="CombustionEngineCarViewViewModel" /> to a command of type
    ///     <see cref="Core.Models.Commands.CombustionEngineCarUpdateCommand" />.
    /// </summary>
    /// <param name="viewViewModel">The view model to be converted.</param>
    /// <returns>
    ///     A new instance of <see cref="Core.Models.Commands.CombustionEngineCarUpdateCommand" /> representing the
    ///     command.
    /// </returns>
    private static Core.Models.Commands.CombustionEngineCarUpdateCommand ToUpdateCommand(
        this CombustionEngineCarViewViewModel viewViewModel)
        => new(viewViewModel.Id, viewViewModel.Model.ToDomainModel(),
            viewViewModel.Generation, viewViewModel.BodyVariant.ToDomainModel(),
            viewViewModel.TransmissionVariant.ToDomainModel(), viewViewModel.Drivetrain.ToDomainModel(),
            viewViewModel.StartYear, viewViewModel.EndYear, viewViewModel.Engine.Id,
            viewViewModel.Eurostandard.ToDomainModel(), viewViewModel.CityFuel,
            viewViewModel.CombinedFuel, viewViewModel.HighwayFuel);

    /// <summary>
    ///     Converts a view model of type <see cref="ElectricCarViewViewModel" /> to a command of type
    ///     <see cref="Core.Models.Commands.ElectricCarCreateCommand" />.
    /// </summary>
    /// <param name="viewViewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Commands.ElectricCarCreateCommand" /> representing the command.</returns>
    private static Core.Models.Commands.ElectricCarCreateCommand ToCreateCommand(
        this ElectricCarViewViewModel viewViewModel)
        => new(viewViewModel.Model.ToDomainModel(),
            viewViewModel.Generation, viewViewModel.BodyVariant.ToDomainModel(),
            viewViewModel.TransmissionVariant.ToDomainModel(),
            viewViewModel.Drivetrain.ToDomainModel(), viewViewModel.StartYear, viewViewModel.EndYear,
            viewViewModel.Horsepower, viewViewModel.Torque,
            viewViewModel.BatteryCapacity, viewViewModel.Range, viewViewModel.MotorCount);

    /// <summary>
    ///     Converts a view model of type <see cref="ElectricCarViewViewModel" /> to a command of type
    ///     <see cref="Core.Models.Commands.ElectricCarUpdateCommand" />.
    /// </summary>
    /// <param name="viewViewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Commands.ElectricCarUpdateCommand" /> representing the command.</returns>
    private static Core.Models.Commands.ElectricCarUpdateCommand ToUpdateCommand(
        this ElectricCarViewViewModel viewViewModel)
        => new(viewViewModel.Id, viewViewModel.Model.ToDomainModel(),
            viewViewModel.Generation, viewViewModel.BodyVariant.ToDomainModel(),
            viewViewModel.TransmissionVariant.ToDomainModel(),
            viewViewModel.Drivetrain.ToDomainModel(), viewViewModel.StartYear, viewViewModel.EndYear,
            viewViewModel.Horsepower, viewViewModel.Torque,
            viewViewModel.BatteryCapacity, viewViewModel.Range, viewViewModel.MotorCount);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.CombustionEngineCar" /> to a view model of type
    ///     <see cref="CombustionEngineCarViewViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="CombustionEngineCarViewViewModel" /> representing the view model.</returns>
    private static CombustionEngineCarViewViewModel ToViewModel(this CombustionEngineCar domainModel)
        => new()
        {
            Id = domainModel.Id,
            CarType = CarType.CombustionEngineCar,
            Generation = domainModel.Generation,
            StartYear = domainModel.StartYear,
            EndYear = domainModel.EndYear,
            Make = domainModel.Make.ToViewModel(),
            Model = domainModel.Model.ToViewModel(),
            Body = domainModel.Body.ToViewModel(),
            BodyVariant = domainModel.BodyVariant.ToViewModel(),
            Transmission = domainModel.Transmission.ToViewModel(),
            TransmissionVariant = domainModel.TransmissionVariant.ToViewModel(),
            Drivetrain = domainModel.Drivetrain.ToViewModel(),
            Engine = domainModel.Engine.ToViewModel(),
            Eurostandard = domainModel.EuroStandard.ToViewModel(),
            CityFuel = domainModel.CityFuel,
            CombinedFuel = domainModel.CombinedFuel,
            HighwayFuel = domainModel.HighwayFuel
        };

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.ElectricCar" /> to a view model of type
    ///     <see cref="ElectricCarViewViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="ElectricCarViewViewModel" /> representing the view model.</returns>
    private static ElectricCarViewViewModel ToViewModel(this ElectricCar domainModel)
        => new()
        {
            Id = domainModel.Id,
            CarType = CarType.ElectricCar,
            Make = domainModel.Make.ToViewModel(),
            Model = domainModel.Model.ToViewModel(),
            Generation = domainModel.Generation,
            Body = domainModel.Body.ToViewModel(),
            BodyVariant = domainModel.BodyVariant.ToViewModel(),
            Transmission = domainModel.Transmission.ToViewModel(),
            TransmissionVariant = domainModel.TransmissionVariant.ToViewModel(),
            Drivetrain = domainModel.Drivetrain.ToViewModel(),
            StartYear = domainModel.StartYear,
            EndYear = domainModel.EndYear,
            Horsepower = domainModel.Horsepower,
            Torque = domainModel.Torque,
            BatteryCapacity = domainModel.BatteryCapacity,
            Range = domainModel.Range,
            MotorCount = domainModel.MotorCount
        };
}