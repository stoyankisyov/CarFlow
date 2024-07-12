namespace CarFlow.Infrastructure.Mappers
{
    public static class TransmissionMapper
    {
        /// <summary>
        /// Converts Models.Transmission/Entity/ to Core.Models.Transmission/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Transmission </returns>
        public static Core.Models.Transmission ToDomainModel(this Models.Transmission entity)
            => new(entity.Id, entity.Name, entity.TransmissionVariants.ToDomainModel());

        /// <summary>
        /// Converts ICollection of Models.Transmission/Entity/ to List of Core.Models.Transmission/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Transmission </returns>
        public static List<Core.Models.Transmission> ToDomainModel(this ICollection<Models.Transmission> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.Transmission/DM/ to Models.Transmission/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Transmission </returns>
        public static Models.Transmission ToEntity(this Core.Models.Transmission domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                TransmissionVariants = domainModel.TransmissionVariants.ToEntity()
            };
    }
}
