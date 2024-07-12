namespace CarFlow.Infrastructure.Mappers
{
    public static class EuroStandardMapper
    {
        /// <summary>
        /// Converts Models.EuroStandard/Entity/ to Core.Models.EuroStandard/DM/
        /// </summary>
        /// <param name="entity"></param>
        /// <returns> Core.Models.EuroStandard </returns>
        public static Core.Models.EuroStandard ToDomainModel(this Models.EuroStandard entity)
            => new(entity.Id, entity.Name);
    }
}
