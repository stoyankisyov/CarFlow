namespace CarFlow.Infrastructure.Mappers;

public static class TransmissionMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Transmission" /> to a domain model of type
    ///     <see cref="Core.Models.Transmission" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Transmission" /> representing the domain model.</returns>
    public static Core.Models.Transmission ToDomainModel(this Models.Transmission entity)
        => new(entity.Id, entity.Name, entity.TransmissionVariants.ToDomainModel());

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Transmission" /> to a list of domain
    ///     models of
    ///     type <see cref="Core.Models.Transmission" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Transmission" /> representing the domain models.</returns>
    public static List<Core.Models.Transmission> ToDomainModel(this IEnumerable<Models.Transmission> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Transmission" /> to an entity model of type
    ///     <see cref="Models.Transmission" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Transmission" /> representing the entity model.</returns>
    public static Models.Transmission ToEntity(this Core.Models.Transmission domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            TransmissionVariants = domainModel.TransmissionVariants.ToEntity()
        };
}