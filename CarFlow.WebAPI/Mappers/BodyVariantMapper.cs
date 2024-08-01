using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class BodyVariantMapper
{
    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.BodyVariant" /> to a list of
    ///     contracts of type
    ///     <see cref="BodyVariantContract" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="BodyVariantContract" /> representing the contracts.</returns>
    public static List<BodyVariantContract> ToContract(this IEnumerable<Core.Models.BodyVariant> domainModels)
        => domainModels.Select(x => x.ToContract()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.BodyVariant" /> to a contract of type
    ///     <see cref="BodyVariantContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="BodyVariantContract" /> representing the contract.</returns>
    public static BodyVariantContract ToContract(this Core.Models.BodyVariant domainModel)
        => new()
        {
            Id = domainModel.Id,
            DoorCount = domainModel.DoorCount,
            SeatCount = domainModel.SeatCount,
            BodyId = domainModel.BodyId
        };
}