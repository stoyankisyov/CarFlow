using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class FuelTypeMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.FuelType" /> to a contract of type
    ///     <see cref="FuelTypeContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="FuelTypeContract" /> representing the contract.</returns>
    public static FuelTypeContract ToContract(this Core.Models.FuelType domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };
}