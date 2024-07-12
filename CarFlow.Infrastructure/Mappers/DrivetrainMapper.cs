namespace CarFlow.Infrastructure.Mappers
{
    public static class DrivetrainMapper
    {
        /// <summary>
        /// Converts Models.Drivetrain/Entity/ to Core.Models.Drivetrain/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.Drivetrain </returns>
        public static Core.Models.Drivetrain ToDomainModel(this Models.Drivetrain entity)
            => new(entity.Id, entity.Name);

        /// <summary>
        /// Converts ICollection of Models.Drivetrain/Entity/ to List of Core.Models.Drivetrain/DM/
        /// </summary>
        /// <param name="entities"></param>
        /// <returns> List of Core.Models.Drivetrain </returns>
        public static List<Core.Models.Drivetrain> ToDomainModel(this ICollection<Models.Drivetrain> entities)
            => entities.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.Drivetrain/DM/ to Models.Drivetrain/Entity/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> Models.Drivetrain </returns>
        public static Models.Drivetrain ToEntity(this Core.Models.Drivetrain domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name
            };
    }
}