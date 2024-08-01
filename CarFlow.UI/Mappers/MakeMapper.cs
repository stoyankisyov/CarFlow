using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class MakeMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="MakeViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Make" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Make" /> representing the domain model.</returns>
    public static Core.Models.Make ToDomainModel(this MakeViewModel viewModel)
        => new(viewModel.Id, viewModel.Name, viewModel.Models.ToDomainModel());

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Make" /> to a view model of type
    ///     <see cref="MakeViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="MakeViewModel" /> representing the view model.</returns>
    public static MakeViewModel ToViewModel(this Core.Models.Make domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Models = domainModel.Models.ToViewModel()
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Make" /> to a list of view models
    ///     of type
    ///     <see cref="MakeViewModel" />.
    /// </summary>
    /// <param name="domainModels">The collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="MakeViewModel" /> representing the view models.</returns>
    public static List<MakeViewModel> ToViewModel(this IEnumerable<Core.Models.Make> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}