namespace CarFlow.Infrastructure.Mappers
{
    public static class FuelTypeMapper
    {
        /// <summary>
        /// Converts Models.FuelType/Entity/ to Core.Models.FuelType/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>  Core.Models.FuelType </returns>
        public static Core.Models.FuelType ToDomainModel(this Models.FuelType entity)
            => new(entity.Id, entity.Name);

        /// <summary>
        /// Converts ICollection of Models.FuelType/Entity/ to List of Core.Models.FuelType/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.FuelType </returns>
        public static List<Core.Models.FuelType> ToDomainModel(this ICollection<Models.FuelType> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.FuelType/DM/ to Models.FuelType/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.FuelType </returns>
        public static Models.FuelType ToEntity(this Core.Models.FuelType domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name
            };
    }
}
