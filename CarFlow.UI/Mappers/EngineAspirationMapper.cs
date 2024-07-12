using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class EngineAspirationMapper
    {
        /// <summary>
        /// Converts Core.Models.EngineAspiration/DM/ to EngineAspirationViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> EngineAspirationViewModel </returns>
        public static EngineAspirationViewModel ToViewModel(this Core.Models.EngineAspiration domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name
            };

        /// <summary>
        /// Converts List of Core.Models.EngineAspiration/DM/ to List of EngineAspirationViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of EngineAspirationViewModel </returns>
        public static List<EngineAspirationViewModel> ToViewModel(this List<Core.Models.EngineAspiration> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts EngineAspirationViewModel/VM/ to Core.Models.EngineAspiration/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.EngineAspiration </returns>
        public static Core.Models.EngineAspiration ToDomainModel(this EngineAspirationViewModel viewModel)
            => new(viewModel.Id, viewModel.Name);
    }
}
