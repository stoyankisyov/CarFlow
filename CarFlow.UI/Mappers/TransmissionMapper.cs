using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class TransmissionMapper
    {
        /// <summary>
        /// Converts Core.Models.Transmission/DM/ to TransmissionViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> TransmissionViewModel </returns>
        public static TransmissionViewModel ToViewModel(this Core.Models.Transmission domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                TransmissionVariants = domainModel.TransmissionVariants.ToViewModel()
            };

        /// <summary>
        /// Converts List of Core.Models.Transmission/DM/ to List of TransmissionViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of TransmissionViewModel </returns>
        public static List<TransmissionViewModel> ToViewModel(this List<Core.Models.Transmission> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts TransmissionViewModel/VM/ to Core.Models.Transmission/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Transmission </returns>
        public static Core.Models.Transmission ToDomainModel(this TransmissionViewModel viewModel)
            => new(viewModel.Id, viewModel.Name, viewModel.TransmissionVariants.ToDomainModel());
    }
}
