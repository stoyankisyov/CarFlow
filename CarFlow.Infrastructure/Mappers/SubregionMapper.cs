namespace CarFlow.Infrastructure.Mappers
{
    public static class SubregionMapper
    {
        /// <summary>
        /// Converts ICollection of Models.Subregion/Entity/ to List of Core.Models.Subregion/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Subregion </returns>
        public static List<Core.Models.Subregion> ToDomainModel(this ICollection<Models.Subregion> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts List of Core.Models.Subregion/DM/ to List of Models.Subregion/Entity/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of Models.Subregion </returns>
        public static List<Models.Subregion> ToEntity(this List<Core.Models.Subregion> domainModels)
            => domainModels.Select(x => x.ToEntity()).ToList();

        /// <summary>
        /// Converts Models.Subregion/Entity/ to Core.Models.Subregion/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Subregion </returns>
        private static Core.Models.Subregion ToDomainModel(this Models.Subregion entity)
            => new(entity.Id, entity.RegionId, entity.Name);

        /// <summary>
        /// Converts Core.Models.Subregion/DM/ to Models.Subregion/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Subregion </returns>
        private static Models.Subregion ToEntity(this Core.Models.Subregion domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                RegionId = domainModel.RegionId
            };
    }
}
