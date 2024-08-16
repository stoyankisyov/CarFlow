using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class BrandMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Brand" /> to a contract of type <see cref="BrandContract" />
    ///     .
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="BrandContract" /> representing the contract.</returns>
    public static BrandContract ToContract(this Core.Models.Brand domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Models = domainModel.Models.ToContract()
        };
}