namespace CarFlow.Infrastructure.Mappers
{
    public static class BodyVariantMapper
    {
        /// <summary>
        /// Converts Models.BodyVariant/Entity/ to Core.Models.BodyVariant/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.BodyVariant </returns>
        public static Core.Models.BodyVariant ToDomainModel(this Models.BodyVariant entity)
            => new(entity.Id, entity.BodyId, entity.DoorCount, entity.SeatCount);
    }
}
