using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class SubregionMapper
{
    /// <summary>
    ///     Converts an enumerable collection of view models of type <see cref="SubregionViewModel" /> to a list of domain
    ///     models of type
    ///     <see cref="Core.Models.Subregion" />.
    /// </summary>
    /// <param name="viewModels">The enumerable collection of view models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Subregion" /> representing the domain models.</returns>
    public static List<Core.Models.Subregion> ToDomainModel(this IEnumerable<SubregionViewModel> viewModels)
        => viewModels.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Subregion" /> to a list of view
    ///     models of type
    ///     <see cref="SubregionViewModel" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="SubregionViewModel" /> representing the view models.</returns>
    public static List<SubregionViewModel> ToViewModel(this IEnumerable<Core.Models.Subregion> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Subregion" /> to a view model of type
    ///     <see cref="SubregionViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="SubregionViewModel" /> representing the view model.</returns>
    private static SubregionViewModel ToViewModel(this Core.Models.Subregion domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            RegionId = domainModel.RegionId
        };

    /// <summary>
    ///     Converts a view model of type <see cref="SubregionViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Subregion" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Subregion" /> representing the domain model.</returns>
    private static Core.Models.Subregion ToDomainModel(this SubregionViewModel viewModel)
        => new(viewModel.Id, viewModel.RegionId, viewModel.Name);
}