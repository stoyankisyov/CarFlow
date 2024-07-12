namespace CarFlow.Infrastructure.Mappers
{
    public static class ModelMapper
    {
        /// <summary>
        /// Converts Models.Model/Entity/ to Core.Models.Model/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Model </returns>
        public static Core.Models.Model ToDomainModel(this Models.Model entity)
            => new(entity.Id, entity.Name, entity.MakeId, entity.ModelVariant);

        /// <summary>
        /// Converts ICollection of Models.Model/Entity/ to List of Core.Models.Model/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Model </returns>
        public static List<Core.Models.Model> ToDomainModel(this ICollection<Models.Model> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts List of Core.Models.Model/DM/ to List of Models.Model/Entity/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of Models.Model </returns>
        public static List<Models.Model> ToEntity(this List<Core.Models.Model> domainModels)
            => domainModels.Select(x => x.ToEntity()).ToList();

        /// <summary>
        /// Converts Core.Models.Model/DM/ to Models.Model/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Model </returns>
        private static Models.Model ToEntity(this Core.Models.Model domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                ModelVariant = domainModel.ModelVariant,
                MakeId = domainModel.MakeId
            };
    }
}