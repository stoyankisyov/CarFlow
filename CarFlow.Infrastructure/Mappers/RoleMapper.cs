namespace CarFlow.Infrastructure.Mappers
{
    public static class RoleMapper
    {
        /// <summary>
        /// Converts Models.Roles/Entity/ to Core.Models.Roles/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Roles </returns>
        public static Core.Models.Role ToDomainModel(this Models.Role entity)
            => new(entity.Id, entity.Name);

        /// <summary>
        /// Converts IEnumerable of Models.Role/Entities/ to List of Core.Models.Role/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Role </returns>
        public static List<Core.Models.Role> ToDomainModel(this IEnumerable<Models.Role> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts List of Core.Models.Role/DM/ to List of Models.Role/Entities/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of Models.Role </returns>
        public static List<Models.Role> ToEntities(this List<Core.Models.Role> domainModels)
            => domainModels.Select(x => x.ToEntity()).ToList();

        /// <summary>
        /// Converts Core.Models.Role/DM/ to Models.Role/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Role </returns>
        private static Models.Role ToEntity(this Core.Models.Role domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name
            };
    }
}
