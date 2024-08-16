namespace CarFlow.Infrastructure.Mappers;

public static class DrivetrainMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Drivetrain" /> to a domain model of type
    ///     <see cref="Core.Models.Drivetrain" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Drivetrain" /> representing the domain model.</returns>
    public static Core.Models.Drivetrain ToDomainModel(this Models.Drivetrain entity)
        => new(entity.Id, entity.Name);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Drivetrain" /> to a list of domain
    ///     models of type
    ///     <see cref="Core.Models.Drivetrain" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Drivetrain" /> representing the domain models.</returns>
    public static List<Core.Models.Drivetrain> ToDomainModel(this IEnumerable<Models.Drivetrain> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Drivetrain" /> to an entity model of type
    ///     <see cref="Models.Drivetrain" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Drivetrain" /> representing the entity model.</returns>
    public static Models.Drivetrain ToEntity(this Core.Models.Drivetrain domainModel)
        => new(domainModel.Id, domainModel.Name);
}