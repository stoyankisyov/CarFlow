using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class EngineConfigurationMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="EngineConfigurationViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.EngineConfiguration" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.EngineConfiguration" /> representing the domain model.</returns>
    public static Core.Models.EngineConfiguration ToDomainModel(this EngineConfigurationViewModel viewModel)
        => new(viewModel.Id, viewModel.Name, viewModel.CylinderCount);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EngineConfiguration" /> to a view model of type
    ///     <see cref="EngineConfigurationViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EngineConfigurationViewModel" /> representing the view model.</returns>
    public static EngineConfigurationViewModel ToViewModel(this Core.Models.EngineConfiguration domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            CylinderCount = domainModel.CylinderCount
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.EngineConfiguration" /> to a list
    ///     of view models of type
    ///     <see cref="EngineConfigurationViewModel" />.
    /// </summary>
    /// <param name="domainModels">The collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="EngineConfigurationViewModel" /> representing the view models.</returns>
    public static List<EngineConfigurationViewModel> ToViewModel(
        this IEnumerable<Core.Models.EngineConfiguration> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}