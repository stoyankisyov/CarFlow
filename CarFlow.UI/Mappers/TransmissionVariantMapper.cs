using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class TransmissionVariantMapper
    {
        /// <summary>
        /// Converts Core.Models.TransmissionVariant/DM/ to TransmissionVariantViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> TransmissionVariantViewModel </returns>
        public static TransmissionVariantViewModel ToViewModel(this Core.Models.TransmissionVariant domainModel)
            => new()
            {
                Id = domainModel.Id,
                TransmissionId = domainModel.TransmissionId,
                GearCount = domainModel.GearCount
            };

        /// <summary>
        /// Converts List of Core.Models.TransmissionVariant/DM/ to List of TransmissionVariantViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of TransmissionVariantViewModel </returns>
        public static List<TransmissionVariantViewModel> ToViewModel(this List<Core.Models.TransmissionVariant> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts TransmissionVariantViewModel/VM/ to Core.Models.TransmissionVariant/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.TransmissionVariant </returns>
        public static Core.Models.TransmissionVariant ToDomainModel(this TransmissionVariantViewModel viewModel)
            => new(viewModel.Id, viewModel.GearCount, viewModel.TransmissionId);

        /// <summary>
        /// Converts List of TransmissionVariantViewModel/VM/ to List of Core.Models.TransmissionVariant/DM/
        /// </summary>
        /// <param name="viewModels"></param>
        /// <returns> List of Core.Models.TransmissionVariant </returns>
        public static List<Core.Models.TransmissionVariant> ToDomainModel(this List<TransmissionVariantViewModel> viewModels)
            => viewModels.Select(x => x.ToDomainModel()).ToList();
    }
}
