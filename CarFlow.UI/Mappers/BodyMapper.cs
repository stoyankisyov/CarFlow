using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class BodyMapper
    {
        /// <summary>
        /// Converts Core.Models.Body/DM/ to BodyViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> BodyViewModel </returns>
        public static BodyViewModel ToViewModel(this Core.Models.Body domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                Variants = domainModel.Variants.ToViewModel()
            };
    }
}
