namespace CarFlow.Infrastructure.Mappers;

public static class EuroStandardMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.EuroStandard" /> to a domain model of type
    ///     <see cref="Core.Models.EuroStandard" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.EuroStandard" /> representing the domain model.</returns>
    public static Core.Models.EuroStandard ToDomainModel(this Models.EuroStandard entity)
        => new(entity.Id, entity.Name);
}