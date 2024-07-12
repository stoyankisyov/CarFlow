namespace CarFlow.Infrastructure.Mappers
{
    public static class RegionMapper
    {
        /// <summary>
        /// Converts Models.Region/Entity/ to Core.Models.Region/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Region </returns>
        public static Core.Models.Region ToDomainModel(this Models.Region entity)
            => new(entity.Id, entity.Name, entity.Subregions.ToDomainModel());

        /// <summary>
        /// Converts ICollection of Models.Region/Entity/ to List of Core.Models.Region/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Region </returns>
        public static List<Core.Models.Region> ToDomainModel(this ICollection<Models.Region> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.Region/DM/ to Models.Region/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Region </returns>
        public static Models.Region ToEntity(this Core.Models.Region domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                Subregions = domainModel.Subregions.ToEntity()
            };
    }
}