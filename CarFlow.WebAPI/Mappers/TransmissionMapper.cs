using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class TransmissionMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Transmission" /> to a contract of type
    ///     <see cref="TransmissionContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="TransmissionContract" /> representing the contract.</returns>
    public static TransmissionContract ToContract(this Core.Models.Transmission domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            TransmissionVariants = domainModel.TransmissionVariants.ToContract()
        };
}