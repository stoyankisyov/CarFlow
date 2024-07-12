using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class ModelMapper
    {
        /// <summary>
        /// Converts Core.Models.Model/DM/ to ModelViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> ModelViewModel </returns>
        public static ModelViewModel ToViewModel(this Core.Models.Model domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                ModelVariant = domainModel.ModelVariant,
                MakeId = domainModel.MakeId
            };

        /// <summary>
        /// Converts List of Core.Models.Model/DM/ to List of ModelViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of ModelViewModel </returns>
        public static List<ModelViewModel> ToViewModel(this List<Core.Models.Model> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts ModelViewModel/VM/ to Core.Models.Model/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Model </returns>
        public static Core.Models.Model ToDomainModel(this ModelViewModel viewModel)
            => new(viewModel.Id, viewModel.Name, viewModel.MakeId, viewModel.ModelVariant);

        /// <summary>
        /// Converts List of ModelViewModel/VM/ to List of Core.Models.Model/DM/
        /// </summary>
        /// <param name="viewModels"></param>
        /// <returns> List of Core.Models.Model </returns>
        public static List<Core.Models.Model> ToDomainModel(this List<ModelViewModel> viewModels)
            => viewModels.Select(x => x.ToDomainModel()).ToList();
    }
}
