namespace CarFlow.Infrastructure.Mappers;

public static class MakeMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Make" /> to a domain model of type
    ///     <see cref="Core.Models.Make" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Make" /> representing the domain model.</returns>
    public static Core.Models.Make ToDomainModel(this Models.Make entity)
        => new(entity.Id, entity.Name, entity.Models.ToDomainModel());

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Make" /> to a list of domain models of
    ///     type
    ///     <see cref="Core.Models.Make" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Make" /> representing the domain models.</returns>
    public static List<Core.Models.Make> ToDomainModel(this IEnumerable<Models.Make> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Make" /> to an entity model of type
    ///     <see cref="Models.Make" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Make" /> representing the entity model.</returns>
    public static Models.Make ToEntity(this Core.Models.Make domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Models = domainModel.Models.ToEntity()
        };
}