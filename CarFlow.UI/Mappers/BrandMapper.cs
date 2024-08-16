using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class BrandMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="BrandViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Brand" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Brand" /> representing the domain model.</returns>
    /// s>
    public static Core.Models.Brand ToDomainModel(this BrandViewModel viewModel)
        => new(viewModel.Id, viewModel.Name, viewModel.Models.ToDomainModel());

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Brand" /> to a view model of type
    ///     <see cref="BrandViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="BrandViewModel" /> representing the view model.</returns>
    /// rns>
    public static BrandViewModel ToViewModel(this Core.Models.Brand domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Models = domainModel.Models.ToViewModel()
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Brand" /> to a list of view
    ///     models
    ///     of type
    ///     <see cref="BrandViewModel" />.
    /// </summary>
    /// <param name="domainModels">The collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="BrandViewModel" /> representing the view models.</returns>
    /// turns>
    public static List<BrandViewModel> ToViewModel(this IEnumerable<Core.Models.Brand> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}