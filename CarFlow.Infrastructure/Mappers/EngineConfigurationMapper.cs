namespace CarFlow.Infrastructure.Mappers;

public static class EngineConfigurationMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.EngineConfiguration" /> to a domain model of type
    ///     <see cref="Core.Models.EngineConfiguration" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.EngineConfiguration" /> representing the domain model.</returns>
    public static Core.Models.EngineConfiguration ToDomainModel(this Models.EngineConfiguration entity)
        => new(entity.Id, entity.Name, entity.CylinderCount);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.EngineConfiguration" /> to a list of
    ///     domain models
    ///     of type <see cref="Core.Models.EngineConfiguration" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.EngineConfiguration" /> representing the domain models.</returns>
    public static List<Core.Models.EngineConfiguration> ToDomainModel(
        this IEnumerable<Models.EngineConfiguration> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EngineConfiguration" /> to an entity model of type
    ///     <see cref="Models.EngineConfiguration" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.EngineConfiguration" /> representing the entity model.</returns>
    public static Models.EngineConfiguration ToEntity(this Core.Models.EngineConfiguration domainModel)
        => new(domainModel.Id, domainModel.Name, domainModel.CylinderCount);
}