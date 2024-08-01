using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class EngineMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="EngineViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Engine" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Engine" /> representing the domain model.</returns>
    public static Core.Models.Engine ToDomainModel(this EngineViewModel viewModel)
        => new(viewModel.Id, viewModel.Model, viewModel.Displacement, viewModel.Horsepower, viewModel.Torque,
            viewModel.FuelType.ToDomainModel(), viewModel.Configuration.ToDomainModel(),
            viewModel.Aspiration.ToDomainModel());

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Engine" /> to a view model of type
    ///     <see cref="EngineViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EngineViewModel" /> representing the view model.</returns>
    public static EngineViewModel ToViewModel(this Core.Models.Engine domainModel)
        => new()
        {
            Id = domainModel.Id,
            Model = domainModel.Model,
            Displacement = domainModel.Displacement,
            Horsepower = domainModel.Horsepower,
            Torque = domainModel.Torque,
            FuelType = domainModel.FuelType.ToViewModel(),
            Configuration = domainModel.Configuration.ToViewModel(),
            Aspiration = domainModel.Aspiration.ToViewModel()
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Engine" /> to a list of view
    ///     models of type
    ///     <see cref="EngineViewModel" />.
    /// </summary>
    /// <param name="domainModels">The collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="EngineViewModel" /> representing the view models.</returns>
    public static List<EngineViewModel> ToViewModel(this IEnumerable<Core.Models.Engine> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Engine" /> to a view model of type
    ///     <see cref="EngineManagementViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EngineManagementViewModel" /> representing the view model.</returns>
    public static EngineManagementViewModel ToEngineManagementViewModel(this Core.Models.Engine domainModel)
        => new()
        {
            Id = domainModel.Id,
            Model = domainModel.Model,
            Displacement = domainModel.Displacement,
            Horsepower = domainModel.Horsepower,
            Torque = domainModel.Torque,
            FuelType = domainModel.FuelType.ToViewModel(),
            Configuration = domainModel.Configuration.ToViewModel(),
            Aspiration = domainModel.Aspiration.ToViewModel(),
            Options = new EngineManagementOptionsViewModel()
        };
}