using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class TransmissionVariantMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="TransmissionVariantViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.TransmissionVariant" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.TransmissionVariant" /> representing the domain model.</returns>
    public static Core.Models.TransmissionVariant ToDomainModel(this TransmissionVariantViewModel viewModel)
        => new(viewModel.Id, viewModel.GearCount, viewModel.TransmissionId);

    /// <summary>
    ///     Converts an enumerable collection of view models of type <see cref="TransmissionVariantViewModel" /> to a list of
    ///     domain models of type
    ///     <see cref="Core.Models.TransmissionVariant" />.
    /// </summary>
    /// <param name="viewModels">The enumerable collection of view models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.TransmissionVariant" /> representing the domain models.</returns>
    public static List<Core.Models.TransmissionVariant> ToDomainModel(
        this IEnumerable<TransmissionVariantViewModel> viewModels)
        => viewModels.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.TransmissionVariant" /> to a view model of type
    ///     <see cref="TransmissionVariantViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="TransmissionVariantViewModel" /> representing the view model.</returns>
    public static TransmissionVariantViewModel ToViewModel(this Core.Models.TransmissionVariant domainModel)
        => new()
        {
            Id = domainModel.Id,
            TransmissionId = domainModel.TransmissionId,
            GearCount = domainModel.GearCount
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.TransmissionVariant" /> to a list
    ///     of view models
    ///     <see cref="TransmissionVariantViewModel" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="TransmissionVariantViewModel" /> representing the view models.</returns>
    public static List<TransmissionVariantViewModel> ToViewModel(
        this IEnumerable<Core.Models.TransmissionVariant> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}