using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class TransmissionVariantMapper
{
    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.TransmissionVariant" /> to a list
    ///     of contracts of type
    ///     <see cref="TransmissionVariantContract" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="TransmissionVariantContract" /> representing the contracts.</returns>
    public static List<TransmissionVariantContract> ToContract(
        this IEnumerable<Core.Models.TransmissionVariant> domainModels)
        => domainModels.Select(x => x.ToContract()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.TransmissionVariant" /> to a contract of type
    ///     <see cref="TransmissionVariantContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="TransmissionVariantContract" /> representing the contract.</returns>
    public static TransmissionVariantContract ToContract(this Core.Models.TransmissionVariant domainModel)
        => new()
        {
            TransmissionId = domainModel.TransmissionId,
            GearCount = domainModel.GearCount
        };
}