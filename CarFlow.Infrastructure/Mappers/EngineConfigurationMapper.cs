namespace CarFlow.Infrastructure.Mappers
{
    public static class EngineConfigurationMapper
    {
        /// <summary>
        /// Converts Models.EngineConfiguration/Entity/ to Core.Models.EngineConfiguration/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.EngineConfiguration </returns>
        public static Core.Models.EngineConfiguration ToDomainModel(this Models.EngineConfiguration entity)
            => new(entity.Id, entity.Name, entity.CylinderCount);

        /// <summary>
        /// Converts ICollection of Models.EngineConfiguration/Entity/ to List of Core.Models.EngineConfiguration/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.EngineConfiguration </returns>
        public static List<Core.Models.EngineConfiguration> ToDomainModel(this ICollection<Models.EngineConfiguration> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.EngineConfiguration/DM/ to Models.EngineConfiguration/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.EngineConfiguration </returns>
        public static Models.EngineConfiguration ToEntity(this Core.Models.EngineConfiguration domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                CylinderCount = domainModel.CylinderCount
            };
    }
}
