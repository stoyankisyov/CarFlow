using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class EngineAspirationMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="EngineAspirationViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.EngineAspiration" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.EngineAspiration" /> representing the domain model.</returns>
    public static Core.Models.EngineAspiration ToDomainModel(this EngineAspirationViewModel viewModel)
        => new(viewModel.Id, viewModel.Name);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EngineAspiration" /> to a view model of type
    ///     <see cref="EngineAspirationViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EngineAspirationViewModel" /> representing the view model.</returns>
    public static EngineAspirationViewModel ToViewModel(this Core.Models.EngineAspiration domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.EngineAspiration" /> to a list of
    ///     view models of type
    ///     <see cref="EngineAspirationViewModel" />.
    /// </summary>
    /// <param name="domainModels">The collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="EngineAspirationViewModel" /> representing the view models.</returns>
    public static List<EngineAspirationViewModel> ToViewModel(
        this IEnumerable<Core.Models.EngineAspiration> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}