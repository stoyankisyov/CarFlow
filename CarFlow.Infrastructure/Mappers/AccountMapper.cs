namespace CarFlow.Infrastructure.Mappers;

public static class AccountMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Account" /> to a domain model of type
    ///     <see cref="Core.Models.Account" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Account" /> representing the domain model.</returns>
    public static Core.Models.Account ToDomainModel(this Models.Account entity)
        => new(entity.Id, entity.Roles.ToDomainModel(), entity.Name, entity.Email, entity.Phone, entity.Password,
            entity.Address);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Account" /> to an entity model of type
    ///     <see cref="Models.Account" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Account" /> representing the entity model.</returns>
    public static Models.Account ToEntity(this Core.Models.Account domainModel)
        => new()
        {
            Id = domainModel.Id,
            Roles = domainModel.Roles.ToEntity(),
            Name = domainModel.Name,
            Email = domainModel.Email,
            Phone = domainModel.Phone,
            Password = domainModel.Password,
            Address = domainModel.Address
        };
}