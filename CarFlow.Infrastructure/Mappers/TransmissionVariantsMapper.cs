namespace CarFlow.Infrastructure.Mappers;

public static class TransmissionVariantsMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.TransmissionVariant" /> to a domain model of type
    ///     <see cref="Core.Models.TransmissionVariant" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.TransmissionVariant" /> representing the domain model.</returns>
    public static Core.Models.TransmissionVariant ToDomainModel(this Models.TransmissionVariant entity)
        => new(entity.Id, entity.GearCount, entity.TransmissionId);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.TransmissionVariant" /> to a list of
    ///     domain models
    ///     of type <see cref="Core.Models.TransmissionVariant" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.TransmissionVariant" /> representing the domain models.</returns>
    public static List<Core.Models.TransmissionVariant> ToDomainModel(
        this IEnumerable<Models.TransmissionVariant> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.TransmissionVariant" /> to a list
    ///     of entity models
    ///     of type <see cref="Models.TransmissionVariant" />.
    /// </summary>
    /// <param name="domainModels">The list of domain models to be converted.</param>
    /// <returns>A new list of <see cref="Models.TransmissionVariant" /> representing the entity models.</returns>
    public static List<Models.TransmissionVariant> ToEntity(
        this IEnumerable<Core.Models.TransmissionVariant> domainModels)
        => domainModels.Select(x => x.ToEntity()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.TransmissionVariant" /> to an entity model of type
    ///     <see cref="Models.TransmissionVariant" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.TransmissionVariant" /> representing the entity model.</returns>
    private static Models.TransmissionVariant ToEntity(this Core.Models.TransmissionVariant domainModel)
        => new()
        {
            Id = domainModel.Id,
            TransmissionId = domainModel.TransmissionId,
            GearCount = domainModel.GearCount
        };
}