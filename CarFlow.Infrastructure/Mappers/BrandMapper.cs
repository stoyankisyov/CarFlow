namespace CarFlow.Infrastructure.Mappers;

public static class BrandMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Brand" /> to a domain model of type
    ///     <see cref="Core.Models.Brand" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Brand" /> representing the domain model.</returns>
    /// s>
    public static Core.Models.Brand ToDomainModel(this Models.Brand entity)
        => new(entity.Id, entity.Name, entity.Models.ToDomainModel());

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Brand" /> to a list of domain models
    ///     of
    ///     type
    ///     <see cref="Core.Models.Brand" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Brand" /> representing the domain models.</returns>
    /// urns>
    public static List<Core.Models.Brand> ToDomainModel(this IEnumerable<Models.Brand> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Brand" /> to an entity model of type
    ///     <see cref="Models.Brand" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Brand" /> representing the entity model.</returns>
    /// eturns>
    public static Models.Brand ToEntity(this Core.Models.Brand domainModel)
        => new(domainModel.Id, domainModel.Name)
        {
            Models = domainModel.Models.ToEntity()
        };
}