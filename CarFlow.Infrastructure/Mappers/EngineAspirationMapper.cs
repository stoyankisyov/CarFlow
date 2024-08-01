namespace CarFlow.Infrastructure.Mappers;

public static class EngineAspirationMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.EngineAspiration" /> to a domain model of type
    ///     <see cref="Core.Models.EngineAspiration" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.EngineAspiration" /> representing the domain model.</returns>
    public static Core.Models.EngineAspiration ToDomainModel(this Models.EngineAspiration entity)
        => new(entity.Id, entity.Name);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.EngineAspiration" /> to a list of
    ///     domain models of
    ///     type <see cref="Core.Models.EngineAspiration" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.EngineAspiration" /> representing the domain models.</returns>
    public static List<Core.Models.EngineAspiration> ToDomainModel(this IEnumerable<Models.EngineAspiration> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EngineAspiration" /> to an entity model of type
    ///     <see cref="Models.EngineAspiration" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.EngineAspiration" /> representing the entity model.</returns>
    public static Models.EngineAspiration ToEntity(this Core.Models.EngineAspiration domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };
}