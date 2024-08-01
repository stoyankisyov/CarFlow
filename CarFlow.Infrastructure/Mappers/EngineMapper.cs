namespace CarFlow.Infrastructure.Mappers;

public static class EngineMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Engine" /> to a domain model of type
    ///     <see cref="Core.Models.Engine" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Engine" /> representing the domain model.</returns>
    public static Core.Models.Engine ToDomainModel(this Models.Engine entity)
        => new(entity.Id, entity.Model, entity.Displacement, entity.Horsepower,
            entity.Torque, entity.FuelType.ToDomainModel(), entity.Configuration.ToDomainModel(),
            entity.Aspiration.ToDomainModel());

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Engine" /> to a list of domain models
    ///     of type
    ///     <see cref="Core.Models.Engine" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Engine" /> representing the domain models.</returns>
    public static List<Core.Models.Engine> ToDomainModel(this IEnumerable<Models.Engine> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Engine" /> to an entity model of type
    ///     <see cref="Models.Engine" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Engine" /> representing the entity model.</returns>
    public static Models.Engine ToEntity(this Core.Models.Engine domainModel)
        => new()
        {
            Id = domainModel.Id,
            Model = domainModel.Model,
            Displacement = domainModel.Displacement,
            Horsepower = domainModel.Horsepower,
            Torque = domainModel.Torque,
            FuelTypeId = domainModel.FuelType.Id,
            ConfigurationId = domainModel.Configuration.Id,
            AspirationId = domainModel.Aspiration.Id
        };
}