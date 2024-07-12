namespace CarFlow.Infrastructure.Mappers
{
    public static class TransmissionVariantsMapper
    {
        /// <summary>
        /// Converts Models.TransmissionVariant/Entity/ to Core.Models.TransmissionVariant/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.TransmissionVariant </returns>
        public static Core.Models.TransmissionVariant ToDomainModel(this Models.TransmissionVariant entity)
            => new(entity.Id, entity.GearCount, entity.TransmissionId);

        /// <summary>
        /// Converts ICollection of Models.TransmissionVariant/Entity/ to List of Core.Models.TransmissionVariant/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.TransmissionVariant </returns>
        public static List<Core.Models.TransmissionVariant> ToDomainModel(this ICollection<Models.TransmissionVariant> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts List of Core.Models.TransmissionVariant/DM/ to List of Models.TransmissionVariant/Entity/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of Models.TransmissionVariant </returns>
        public static List<Models.TransmissionVariant> ToEntity(this List<Core.Models.TransmissionVariant> domainModels)
            => domainModels.Select(x => x.ToEntity()).ToList();

        /// <summary>
        /// Converts Core.Models.TransmissionVariant/DM/ to Models.TransmissionVariant/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.TransmissionVariant </returns>
        private static Models.TransmissionVariant ToEntity(this Core.Models.TransmissionVariant domainModel)
            => new()
            {
                Id = domainModel.Id,
                TransmissionId = domainModel.TransmissionId,
                GearCount = domainModel.GearCount
            };
    }
}
