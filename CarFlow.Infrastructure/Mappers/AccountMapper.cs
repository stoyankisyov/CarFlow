using CarFlow.Infrastructure.Models;

namespace CarFlow.Infrastructure.Mappers;

public static class AccountMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Account" /> to a domain model of type
    ///     <see cref="Core.Models.Account" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Account" /> representing the domain model.</returns>
    public static Core.Models.Account ToDomainModel(this Account entity)
        => new(
            entity.Id,
            entity.AccountRoles.ToDomainModel(),
            entity.Name,
            entity.Email,
            entity.Phone,
            entity.Password,
            entity.StreetAddress
        );

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Account" /> to an entity model of type
    ///     <see cref="Models.Account" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Account" /> representing the entity model.</returns>
    public static Account ToEntity(this Core.Models.Account domainModel)
        => new(
            domainModel.Id,
            domainModel.Name,
            domainModel.Email,
            domainModel.Phone,
            domainModel.Password,
            domainModel.Address)
        {
            AccountRoles = domainModel.ToAccountRoleEntities()
        };
}