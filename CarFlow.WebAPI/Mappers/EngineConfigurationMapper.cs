using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class EngineConfigurationMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EngineConfiguration" /> to a contract of type
    ///     <see cref="EngineConfigurationContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EngineConfigurationContract" /> representing the contract.</returns>
    public static EngineConfigurationContract ToContract(this Core.Models.EngineConfiguration domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            CylinderCount = domainModel.CylinderCount
        };
}