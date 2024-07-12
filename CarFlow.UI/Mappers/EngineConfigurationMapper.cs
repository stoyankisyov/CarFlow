using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class EngineConfigurationMapper
    {
        /// <summary>
        /// Converts Core.Models.EngineConfiguration/DM/ to EngineConfigurationViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> EngineConfigurationViewModel </returns>
        public static EngineConfigurationViewModel ToViewModel(this Core.Models.EngineConfiguration domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                CylinderCount = domainModel.CylinderCount
            };

        /// <summary>
        /// Converts List of Core.Models.EngineConfiguration/DM/ to List of EngineConfigurationViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of EngineConfigurationViewModel </returns>
        public static List<EngineConfigurationViewModel> ToViewModel(this List<Core.Models.EngineConfiguration> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts EngineConfigurationViewModel/VM/ to Core.Models.EngineConfiguration/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.EngineConfiguration </returns>
        public static Core.Models.EngineConfiguration ToDomainModel(this EngineConfigurationViewModel viewModel)
            => new(viewModel.Id, viewModel.Name, viewModel.CylinderCount);
    }
}
