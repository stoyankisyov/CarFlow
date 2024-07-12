using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class DrivetrainMapper
    {
        /// <summary>
        /// Converts Core.Models.Drivetrain/DM/ to DrivetrainViewModel/VM/
        /// </summary>
        /// <param name="domainModel"></param>
        /// <returns> DrivetrainViewModel </returns>
        public static DrivetrainViewModel ToViewModel(this Core.Models.Drivetrain domainModel)
            => new()
            {
                Id = domainModel.Id,
                Name = domainModel.Name
            };

        /// <summary>
        /// Converts List of Core.Models.Drivetrain/DM/ to List of DrivetrainViewModel/VM/
        /// </summary>
        /// <param name="domainModels"></param>
        /// <returns> List of DrivetrainViewModel </returns>
        public static List<DrivetrainViewModel> ToViewModel(this List<Core.Models.Drivetrain> domainModels)
            => domainModels.Select(x => x.ToViewModel()).ToList();

        /// <summary>
        /// Converts DrivetrainViewModel/VM/ to Core.Models.Drivetrain/DM/
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Drivetrain </returns>
        public static Core.Models.Drivetrain ToDomainModel(this DrivetrainViewModel viewModel)
            => new(viewModel.Id, viewModel.Name);
    }
}
