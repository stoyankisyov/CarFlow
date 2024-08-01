using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class BodyVariantMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="BodyVariantViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.BodyVariant" />.
    /// </summary>
    /// <param name="viewModel">The <see cref="BodyVariantViewModel" /> view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.BodyVariant" /> representing the converted domain model.</returns>
    public static Core.Models.BodyVariant ToDomainModel(this BodyVariantViewModel viewModel)
        => new(viewModel.Id, viewModel.BodyId, viewModel.DoorCount, viewModel.SeatCount);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.BodyVariant" /> to a view model of type
    ///     <see cref="BodyVariantViewModel" />.
    /// </summary>
    /// <param name="domainModel">The <see cref="Core.Models.BodyVariant" /> domain model to be converted.</param>
    /// <returns>A new instance of <see cref="BodyVariantViewModel" /> representing the converted view model.</returns>
    public static BodyVariantViewModel ToViewModel(this Core.Models.BodyVariant domainModel)
        => new()
        {
            Id = domainModel.Id,
            DoorCount = domainModel.DoorCount,
            SeatCount = domainModel.SeatCount,
            BodyId = domainModel.BodyId
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.BodyVariant" /> to a list of view
    ///     models of type
    ///     <see cref="BodyVariantViewModel" />.
    /// </summary>
    /// <param name="domainModels">
    ///     The enumerable collection of <see cref="Core.Models.BodyVariant" /> domain models to be
    ///     converted.
    /// </param>
    /// <returns>A list of <see cref="BodyVariantViewModel" /> representing the converted view models.</returns>
    public static List<BodyVariantViewModel> ToViewModel(this IEnumerable<Core.Models.BodyVariant> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}