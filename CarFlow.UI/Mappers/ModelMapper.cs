using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class ModelMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="ModelViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Model" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Model" /> representing the domain model.</returns>
    public static Core.Models.Model ToDomainModel(this ModelViewModel viewModel)
        => new(viewModel.Id, viewModel.Name, viewModel.MakeId, viewModel.ModelVariant);

    /// <summary>
    ///     Converts an enumerable collection of view models of type <see cref="ModelViewModel" /> to a list of domain models
    ///     of type
    ///     <see cref="Core.Models.Model" />.
    /// </summary>
    /// <param name="viewModels">The collection of view models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Model" /> representing the domain models.</returns>
    public static List<Core.Models.Model> ToDomainModel(this IEnumerable<ModelViewModel> viewModels)
        => viewModels.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Model" /> to a view model of type
    ///     <see cref="ModelViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="ModelViewModel" /> representing the view model.</returns>
    public static ModelViewModel ToViewModel(this Core.Models.Model domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            ModelVariant = domainModel.ModelVariant,
            MakeId = domainModel.MakeId
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Model" /> to a list of view
    ///     models of type
    ///     <see cref="ModelViewModel" />.
    /// </summary>
    /// <param name="domainModels">The collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="ModelViewModel" /> representing the view models.</returns>
    public static List<ModelViewModel> ToViewModel(this IEnumerable<Core.Models.Model> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}