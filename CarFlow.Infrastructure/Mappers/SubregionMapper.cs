namespace CarFlow.Infrastructure.Mappers;

public static class SubregionMapper
{
    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Subregion" /> to a list of domain
    ///     models of type
    ///     <see cref="Core.Models.Subregion" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Subregion" /> representing the domain models.</returns>
    public static List<Core.Models.Subregion> ToDomainModel(this IEnumerable<Models.Subregion> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Subregion" /> to a list of entity
    ///     models of type
    ///     <see cref="Models.Subregion" />.
    /// </summary>
    /// <param name="domainModels">The list of domain models to be converted.</param>
    /// <returns>A new list of <see cref="Models.Subregion" /> representing the entity models.</returns>
    public static List<Models.Subregion> ToEntity(this IEnumerable<Core.Models.Subregion> domainModels)
        => domainModels.Select(x => x.ToEntity()).ToList();

    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Subregion" /> to a domain model of type
    ///     <see cref="Core.Models.Subregion" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Subregion" /> representing the domain model.</returns>
    private static Core.Models.Subregion ToDomainModel(this Models.Subregion entity)
        => new(entity.Id, entity.RegionId, entity.Name);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Subregion" /> to an entity model of type
    ///     <see cref="Models.Subregion" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Subregion" /> representing the entity model.</returns>
    private static Models.Subregion ToEntity(this Core.Models.Subregion domainModel)
        => new(domainModel.Id, domainModel.RegionId, domainModel.Name);
}