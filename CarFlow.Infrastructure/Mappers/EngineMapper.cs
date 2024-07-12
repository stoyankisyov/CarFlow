namespace CarFlow.Infrastructure.Mappers
{
    public static class EngineMapper
    {
        /// <summary>
        /// Converts Models.Engine/Entity/ to Core.Models.Engine/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Engine </returns>
        public static Core.Models.Engine ToDomainModel(this Models.Engine entity)
            => new(entity.Id, entity.Model, entity.Displacement, entity.Horsepower,
                entity.Torque, entity.FuelType.ToDomainModel(), entity.Configuration.ToDomainModel(),
                entity.Aspiration.ToDomainModel());

        /// <summary>
        /// Converts ICollection of Models.Engine/Entity/ to List of Core.Models.Engine/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Engine </returns>
        public static List<Core.Models.Engine> ToDomainModel(this ICollection<Models.Engine> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.Engine/DM/ to Models.Engine/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Engine </returns>
        public static Models.Engine ToEntity(this Core.Models.Engine domainModel)
            => new()
            {
                Id = domainModel.Id,
                Model = domainModel.Model,
                Displacement = domainModel.Displacement,
                Horsepower = domainModel.Horsepower,
                Torque = domainModel.Torque,
                FuelTypeId = domainModel.FuelType.Id,
                ConfigurationId = domainModel.Configuration.Id,
                AspirationId = domainModel.Aspiration.Id
            };
    }
}
