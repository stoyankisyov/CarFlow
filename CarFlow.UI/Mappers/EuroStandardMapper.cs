using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class EuroStandardMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="EuroStandardViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.EuroStandard" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.EuroStandard" /> representing the domain model.</returns>
    public static Core.Models.EuroStandard ToDomainModel(this EuroStandardViewModel viewModel)
        => new(viewModel.Id, viewModel.Name);

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.EuroStandard" /> to a view model of type
    ///     <see cref="EuroStandardViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="EuroStandardViewModel" /> representing the view model.</returns>
    public static EuroStandardViewModel ToViewModel(this Core.Models.EuroStandard domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name
        };
}