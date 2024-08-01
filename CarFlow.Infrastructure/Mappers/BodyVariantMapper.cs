namespace CarFlow.Infrastructure.Mappers;

public static class BodyVariantMapper
{
    /// <summary>
    ///     Converts an entity model of type <see cref="Models.BodyVariant" /> to a domain model of type
    ///     <see cref="Core.Models.BodyVariant" />.
    /// </summary>
    /// <param name="entity">The entity model instance to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.BodyVariant" /> representing the domain model.</returns>
    public static Core.Models.BodyVariant ToDomainModel(this Models.BodyVariant entity)
        => new(entity.Id, entity.BodyId, entity.DoorCount, entity.SeatCount);
}