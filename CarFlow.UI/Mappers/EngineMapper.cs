using CarFlow.UI.Models.ViewModels;
using Microsoft.Extensions.Options;

namespace CarFlow.UI.Mappers
{
    public static class EngineMapper
    {
        /// <summary>
        /// Converts Core.Models.Engine/DM/ to EngineViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> EngineViewModel </returns>
        public static EngineViewModel ToViewModel(this Core.Models.Engine domainModel)
            => new()
            {
                Id = domainModel.Id,
                Model = domainModel.Model,
                Displacement = domainModel.Displacement,
                Horsepower = domainModel.Horsepower,
                Torque = domainModel.Torque,
                FuelType = domainModel.FuelType.ToViewModel(),
                Configuration = domainModel.Configuration.ToViewModel(),
                Aspiration = domainModel.Aspiration.ToViewModel()
            };

        /// <summary>
        /// Converts List of Core.Models.Engine/DM/ to List of EngineViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of EngineViewModel </returns>
        public static List<EngineViewModel> ToViewModel(this List<Core.Models.Engine> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts Core.Models.Engine/DM/ to EngineManagementViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> EngineManagementViewModel </returns>
        public static EngineManagementViewModel ToEngineManagementViewModel(this Core.Models.Engine domainModel)
            => new()
            {
                Id = domainModel.Id,
                Model = domainModel.Model,
                Displacement = domainModel.Displacement,
                Horsepower = domainModel.Horsepower,
                Torque = domainModel.Torque,
                FuelType = domainModel.FuelType.ToViewModel(),
                Configuration = domainModel.Configuration.ToViewModel(),
                Aspiration = domainModel.Aspiration.ToViewModel(),
                Options = new EngineManagementOptionsViewModel()
            };

        /// <summary>
        /// Converts EngineViewModel/VM/ to Core.Models.Engine/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Engine </returns>
        public static Core.Models.Engine ToDomainModel(this EngineViewModel viewModel)
            => new(viewModel.Id, viewModel.Model, viewModel.Displacement, viewModel.Horsepower, viewModel.Torque,
                viewModel.FuelType.ToDomainModel(), viewModel.Configuration.ToDomainModel(), viewModel.Aspiration.ToDomainModel());
    }
}
