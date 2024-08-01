namespace CarFlow.Infrastructure.Mappers;

public static class ModelMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.Model" /> to a domain model of type
    ///     <see cref="Core.Models.Model" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Model" /> representing the domain model.</returns>
    public static Core.Models.Model ToDomainModel(this Models.Model entity)
        => new(entity.Id, entity.Name, entity.MakeId, entity.ModelVariant);

    /// <summary>
    ///     Converts an enumerable collection of entity models of type <see cref="Models.Model" /> to a list of domain models
    ///     of type
    ///     <see cref="Core.Models.Model" />.
    /// </summary>
    /// <param name="entities">The collection of entity models to be converted.</param>
    /// <returns>A new list of <see cref="Core.Models.Model" /> representing the domain models.</returns>
    public static List<Core.Models.Model> ToDomainModel(this IEnumerable<Models.Model> entities)
        => entities.Select(x => x.ToDomainModel()).ToList();

    /// <summary>
    ///     Converts a list of domain models of type <see cref="Core.Models.Model" /> to a list of entity models of type
    ///     <see cref="Models.Model" />.
    /// </summary>
    /// <param name="domainModels">The list of domain models to be converted.</param>
    /// <returns>A new list of <see cref="Models.Model" /> representing the entity models.</returns>
    public static List<Models.Model> ToEntity(this List<Core.Models.Model> domainModels)
        => domainModels.Select(x => x.ToEntity()).ToList();

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Model" /> to an entity model of type
    ///     <see cref="Models.Model" />.
    /// </summary>
    /// <param name="domainModel">The domain model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Models.Model" /> representing the entity model.</returns>
    private static Models.Model ToEntity(this Core.Models.Model domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            ModelVariant = domainModel.ModelVariant,
            MakeId = domainModel.MakeId
        };
}