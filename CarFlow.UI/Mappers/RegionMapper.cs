using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class RegionMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="RegionViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Region" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Region" /> representing the domain model.</returns>
    public static Core.Models.Region ToDomainModel(this RegionViewModel viewModel)
        => new(viewModel.Id, viewModel.Name, viewModel.Subregions.ToDomainModel());

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Region" /> to a view model of type
    ///     <see cref="RegionViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="RegionViewModel" /> representing the view model.</returns>
    public static RegionViewModel ToViewModel(this Core.Models.Region domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Subregions = domainModel.Subregions.ToViewModel()
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Region" /> to a list of view
    ///     models of type
    ///     <see cref="RegionViewModel" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="RegionViewModel" /> representing the view models.</returns>
    public static List<RegionViewModel> ToViewModel(this IEnumerable<Core.Models.Region> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}