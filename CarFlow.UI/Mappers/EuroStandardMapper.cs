using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class EuroStandardMapper
    {
        /// <summary>
        /// Converts Core.Models.EuroStandard/DM/ to EuroStandardViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> EuroStandardViewModel </returns>
        public static EuroStandardViewModel ToViewModel(this Core.Models.EuroStandard domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name
            };

        /// <summary>
        /// Converts EuroStandardViewModel/VM/ to Core.Models.EuroStandard/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.EuroStandard </returns>
        public static Core.Models.EuroStandard ToDomainModel(this EuroStandardViewModel viewModel)
            => new(viewModel.Id, viewModel.Name);
    }
}
