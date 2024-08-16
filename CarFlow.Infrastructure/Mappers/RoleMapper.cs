using CarFlow.Infrastructure.Models;

namespace CarFlow.Infrastructure.Mappers;

public static class RoleMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Role" /> to a domain model of type
    ///     <see cref="Core.Models.Role" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Role" /> representing the domain model.</returns>
    public static Core.Models.Role ToDomainModel(this Role entity)
        => new(entity.Id, entity.Name);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="AccountRole" /> to a list of domain models of
    ///     type
    ///     <see cref="Core.Models.Role" />.
    /// </summary>
    /// <param name="entities">The enumerable collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Role" /> representing the domain models.</returns>
    /// <remarks>
    ///     This method iterates through the account roles associated with the entity models and creates a corresponding list
    ///     of <see cref="Core.Models.Role" /> instances.
    /// </remarks>
    public static List<Core.Models.Role> ToDomainModel(this IEnumerable<AccountRole> entities)
        => entities.Select(x => x.Role.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Account" /> to a list of entity models of type
    ///     <see cref="AccountRole" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new list of <see cref="AccountRole" /> representing the entity models.</returns>
    /// <remarks>
    ///     This method iterates through the roles associated with the domain model and creates a corresponding list of
    ///     <see cref="AccountRole" /> instances, including their associated roles.
    /// </remarks>
    public static List<AccountRole> ToAccountRoleEntities(this Core.Models.Account domainModel)
        => domainModel.Roles.Select(x => new AccountRole(domainModel.Id, x.Id)).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Role" /> to an entity model of type
    ///     <see cref="Models.Role" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Role" /> representing the entity model.</returns>
    private static Role ToEntity(this Core.Models.Role domainModel)
        => new(domainModel.Id, domainModel.Name);
}