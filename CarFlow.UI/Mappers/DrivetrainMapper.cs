using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class DrivetrainMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="DrivetrainViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Drivetrain" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Drivetrain" /> representing the domain model.</returns>
    public static Core.Models.Drivetrain ToDomainModel(this DrivetrainViewModel viewModel)
        => new(viewModel.Id, viewModel.Name);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Drivetrain" /> to a view model of type
    ///     <see cref="DrivetrainViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="DrivetrainViewModel" /> representing the view model.</returns>
    public static DrivetrainViewModel ToViewModel(this Core.Models.Drivetrain domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Drivetrain" /> to a list of view
    ///     models of type
    ///     <see cref="DrivetrainViewModel" />.
    /// </summary>
    /// <param name="domainModels">The collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="DrivetrainViewModel" /> representing the view models.</returns>
    public static List<DrivetrainViewModel> ToViewModel(this IEnumerable<Core.Models.Drivetrain> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}