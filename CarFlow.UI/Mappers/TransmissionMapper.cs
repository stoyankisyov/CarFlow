using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class TransmissionMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="TransmissionViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Transmission" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Transmission" /> representing the domain model.</returns>
    public static Core.Models.Transmission ToDomainModel(this TransmissionViewModel viewModel)
        => new(viewModel.Id, viewModel.Name, viewModel.TransmissionVariants.ToDomainModel());

    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Transmission" /> to a view model of type
    ///     <see cref="TransmissionViewModel" />.
    /// </summary>
    /// <param name="domainModel">The domain model to be converted.</param>
    /// <returns>A new instance of <see cref="TransmissionViewModel" /> representing the view model.</returns>
    public static TransmissionViewModel ToViewModel(this Core.Models.Transmission domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            TransmissionVariants = domainModel.TransmissionVariants.ToViewModel()
        };

    /// <summary>
    ///     Converts an enumerable collection of domain models of type <see cref="Core.Models.Transmission" /> to a list of
    ///     view models of type
    ///     <see cref="TransmissionViewModel" />.
    /// </summary>
    /// <param name="domainModels">The enumerable collection of domain models to be converted.</param>
    /// <returns>A new list of <see cref="TransmissionViewModel" /> representing the view models.</returns>
    public static List<TransmissionViewModel> ToViewModel(this IEnumerable<Core.Models.Transmission> domainModels)
        => domainModels.Select(x => x.ToViewModel()).ToList();
}