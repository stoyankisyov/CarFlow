using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class EngineAspirationMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EngineAspiration" /> to a contract of type
    ///     <see cref="EngineAspirationContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EngineAspirationContract" /> representing the contract.</returns>
    public static EngineAspirationContract ToContract(this Core.Models.EngineAspiration domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };
}