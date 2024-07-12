using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class MakeMapper
    {
        /// <summary>
        /// Converts Core.Models.Make/DM/ to MakeViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> MakeViewModel </returns>
        public static MakeViewModel ToViewModel(this Core.Models.Make domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                Models = domainModel.Models.ToViewModel()
            };

        /// <summary>
        /// Converts List of Core.Models.Make/DM/ to List of MakeViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of MakeViewModel </returns>
        public static List<MakeViewModel> ToViewModel(this List<Core.Models.Make> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts MakeViewModel/VM/ to Core.Models.Make/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Make </returns>
        public static Core.Models.Make ToDomainModel(this MakeViewModel viewModel)
            => new(viewModel.Id, viewModel.Name, viewModel.Models.ToDomainModel());
    }
}
