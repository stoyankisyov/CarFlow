namespace CarFlow.Infrastructure.Mappers;

public static class FuelTypeMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.FuelType" /> to a domain model of type
    ///     <see cref="Core.Models.FuelType" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.FuelType" /> representing the domain model.</returns>
    public static Core.Models.FuelType ToDomainModel(this Models.FuelType entity)
        => new(entity.Id, entity.Name);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.FuelType" /> to a list of domain
    ///     models of type <see cref="Core.Models.FuelType" />.
    /// </summary>
    /// <param name="entities">The enumerable collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.FuelType" /> representing the domain models.</returns>
    public static List<Core.Models.FuelType> ToDomainModel(this IEnumerable<Models.FuelType> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.FuelType" /> to an entity model of type
    ///     <see cref="Models.FuelType" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.FuelType" /> representing the entity model.</returns>
    public static Models.FuelType ToEntity(this Core.Models.FuelType domainModel)
        => new(domainModel.Id, domainModel.Name);
}