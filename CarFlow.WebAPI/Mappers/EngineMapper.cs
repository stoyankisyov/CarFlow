using CarFlow.WebAPI.Models;

namespace CarFlow.WebAPI.Mappers;

public static class EngineMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Engine" /> to a contract of type
    ///     <see cref="EngineContract" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EngineContract" /> representing the contract.</returns>
    public static EngineContract ToContract(this Core.Models.Engine domainModel)
        => new()
        {
            Id = domainModel.Id,
            Model = domainModel.Model,
            Displacement = domainModel.Displacement,
            Horsepower = domainModel.Horsepower,
            Torque = domainModel.Torque,
            FuelType = domainModel.FuelType.ToContract(),
            Configuration = domainModel.Configuration.ToContract(),
            Aspiration = domainModel.Aspiration.ToContract()
        };
}