using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class MakeMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Make" /> to a contract of type <see cref="MakeContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="MakeContract" /> representing the contract.</returns>
    public static MakeContract ToContract(this Core.Models.Make domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Models = domainModel.Models.ToContract()
        };
}