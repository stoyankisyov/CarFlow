namespace CarFlow.Infrastructure.Mappers;

public static class RoleMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Role" /> to a domain model of type
    ///     <see cref="Core.Models.Role" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Role" /> representing the domain model.</returns>
    public static Core.Models.Role ToDomainModel(this Models.Role entity)
        => new(entity.Id, entity.Name);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Role" /> to a list of domain models of
    ///     type <see cref="Core.Models.Role" />.
    /// </summary>
    /// <param name="entities">The enumerable collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Role" /> representing the domain models.</returns>
    public static List<Core.Models.Role> ToDomainModel(this IEnumerable<Models.Role> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Role" /> to a list of entity
    ///     models of type
    ///     <see cref="Models.Role" />.
    /// </summary>
    /// <param name="domainModels">The list of domain models to be converted.</param>
    /// <returns>A new list of <see cref="Models.Role" /> representing the entity models.</returns>
    public static List<Models.Role> ToEntity(this IEnumerable<Core.Models.Role> domainModels)
        => domainModels.Select(x => x.ToEntity()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Role" /> to an entity model of type
    ///     <see cref="Models.Role" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Role" /> representing the entity model.</returns>
    private static Models.Role ToEntity(this Core.Models.Role domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };
}