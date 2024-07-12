using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class RegionMapper
    {
        /// <summary>
        /// Converts Core.Models.Region/DM/ to RegionViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> RegionViewModel </returns>
        public static RegionViewModel ToViewModel(this Core.Models.Region domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                Subregions = domainModel.Subregions.ToViewModel()
            };

        /// <summary>
        /// Converts List of Core.Models.Region/DM/ to List of RegionViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of RegionViewModel </returns>
        public static List<RegionViewModel> ToViewModel(this List<Core.Models.Region> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts RegionViewModel/VM/ to Core.Models.Region/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Region </returns>
        public static Core.Models.Region ToDomainModel(this RegionViewModel viewModel)
            => new(viewModel.Id, viewModel.Name, viewModel.Subregions.ToDomainModel());
    }
}
