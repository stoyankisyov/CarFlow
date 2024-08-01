using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class EuroStandardMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EuroStandard" /> to a contract of type
    ///     <see cref="EuroStandardContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EuroStandardContract" /> representing the contract.</returns>
    public static EuroStandardContract ToContract(this Core.Models.EuroStandard domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };
}