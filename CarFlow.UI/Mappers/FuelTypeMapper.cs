using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class FuelTypeMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="FuelTypeViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.FuelType" />.
    /// </summary>
    /// <param name="fuelType">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.FuelType" /> representing the domain model.</returns>
    public static Core.Models.FuelType ToDomainModel(this FuelTypeViewModel fuelType)
        => new(fuelType.Id, fuelType.Name);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.FuelType" /> to a view model of type
    ///     <see cref="FuelTypeViewModel" />.
    /// </summary>
    /// <param name="fuelType">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="FuelTypeViewModel" /> representing the view model.</returns>
    public static FuelTypeViewModel ToViewModel(this Core.Models.FuelType fuelType)
        => new()
        {
            Id = fuelType.Id,
            Name = fuelType.Name
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.FuelType" /> to a list of view
    ///     models of type
    ///     <see cref="FuelTypeViewModel" />.
    /// </summary>
    /// <param name="fuelTypes">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="FuelTypeViewModel" /> representing the view models.</returns>
    public static List<FuelTypeViewModel> ToViewModel(this IEnumerable<Core.Models.FuelType> fuelTypes)
        => fuelTypes.Select(x => x.ToViewModel()).ToList();
}