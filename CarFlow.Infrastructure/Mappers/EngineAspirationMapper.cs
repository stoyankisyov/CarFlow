namespace CarFlow.Infrastructure.Mappers
{
    public static class EngineAspirationMapper
    {
        /// <summary>
        /// Converts Models.EngineAspiration/Entity/ to Core.Models.EngineAspiration/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.EngineAspiration </returns>
        public static Core.Models.EngineAspiration ToDomainModel(this Models.EngineAspiration entity)
            => new(entity.Id, entity.Name);

        /// <summary>
        /// Converts ICollection of Models.EngineAspiration/Entity/ to List of Core.Models.EngineAspiration/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.EngineAspiration </returns>
        public static List<Core.Models.EngineAspiration> ToDomainModel(this ICollection<Models.EngineAspiration> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.EngineAspiration/DM/ to Models.EngineAspiration/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.EngineAspiration </returns>
        public static Models.EngineAspiration ToEntity(this Core.Models.EngineAspiration domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name
            };
    }
}
