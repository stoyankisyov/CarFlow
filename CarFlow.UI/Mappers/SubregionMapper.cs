using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class SubregionMapper
    {
        /// <summary>
        /// Converts List of Core.Models.Subregion/DM/ to List of SubregionViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of SubregionViewModel </returns>
        public static List<SubregionViewModel> ToViewModel(this List<Core.Models.Subregion> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts List of SubregionViewModel/VM/ to List of Core.Models.Subregion/DM/
        /// </summary>
        /// <param name="viewModels"></param>
        /// <returns> List of Core.Models.Subregion </returns>
        public static List<Core.Models.Subregion> ToDomainModel(this List<SubregionViewModel> viewModels)
            => viewModels.Select(x => x.ToDomainModel()).ToList();

        /// <summary>
        /// Converts Core.Models.Subregion/DM/ to SubregionViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> SubregionViewModel </returns>
        private static SubregionViewModel ToViewModel(this Core.Models.Subregion domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                RegionId = domainModel.RegionId
            };

        /// <summary>
        /// Converts SubregionViewModel/VM/ to Core.Models.Subregion/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Subregion </returns>
        private static Core.Models.Subregion ToDomainModel(this SubregionViewModel viewModel)
            => new(viewModel.Id, viewModel.RegionId, viewModel.Name);
    }
}