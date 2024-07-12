using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class BodyVariantMapper
    {
        /// <summary>
        /// Converts Core.Models.BodyVariant/DM/ to BodyVariantViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> BodyVariantViewModel </returns>
        public static BodyVariantViewModel ToViewModel(this Core.Models.BodyVariant domainModel)
            => new()
            {
                Id = domainModel.Id,
                DoorCout = domainModel.DoorCount,
                SeatCount = domainModel.SeatCount,
                BodyId = domainModel.BodyId
            };

        /// <summary>
        /// Converts List of Core.Models.BodyVariant/DM/ to List of BodyVariantViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of BodyVariantViewModel </returns>
        public static List<BodyVariantViewModel> ToViewModel(this List<Core.Models.BodyVariant> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts BodyVariantViewModel/VM/ to Core.Models.BodyVariant/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.BodyVariant </returns>
        public static Core.Models.BodyVariant ToDomainModel(this BodyVariantViewModel viewModel)
            => new(viewModel.Id, viewModel.BodyId, viewModel.DoorCout, viewModel.SeatCount);
    }
}
