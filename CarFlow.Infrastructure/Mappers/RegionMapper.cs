namespace CarFlow.Infrastructure.Mappers;

public static class RegionMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Region" /> to a domain model of type
    ///     <see cref="Core.Models.Region" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Region" /> representing the domain model.</returns>
    public static Core.Models.Region ToDomainModel(this Models.Region entity)
        => new(entity.Id, entity.Name, entity.Subregions.ToDomainModel());

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Region" /> to a list of domain models
    ///     of type
    ///     <see cref="Core.Models.Region" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Region" /> representing the domain models.</returns>
    public static List<Core.Models.Region> ToDomainModel(this IEnumerable<Models.Region> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Region" /> to an entity model of type
    ///     <see cref="Models.Region" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Region" /> representing the entity model.</returns>
    public static Models.Region ToEntity(this Core.Models.Region domainModel)
        => new(domainModel.Id, domainModel.Name)
        {
            Subregions = domainModel.Subregions.ToEntity()
        };
}