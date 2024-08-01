using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class BodyMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Body" /> to a contract of type <see cref="BodyContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="BodyContract" /> representing the contract.</returns>
    public static BodyContract ToContract(this Core.Models.Body domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Variants = domainModel.Variants.ToContract()
        };
}