namespace CarFlow.Infrastructure.Mappers
{
    public static class MakeMapper
    {
        /// <summary>
        /// Converts Models.Make/Entity/ to Core.Models.Make/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Make </returns>
        public static Core.Models.Make ToDomainModel(this Models.Make entity)
            => new(entity.Id, entity.Name, entity.Models.ToDomainModel());

        /// <summary>
        /// Converts ICollection of Models.Make/Entity/ to List of Core.Models.Make/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Make </returns>
        public static List<Core.Models.Make> ToDomainModel(this ICollection<Models.Make> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.Make/DM/ to Models.Make/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Make </returns>
        public static Models.Make ToEntity(this Core.Models.Make domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                Models = domainModel.Models.ToEntity()
            };
    }
}
