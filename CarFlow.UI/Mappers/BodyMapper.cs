using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class BodyMapper
{
    /// <summary>
    ///     Converts a domain model of type <see cref="Core.Models.Body" /> to a view model of type
    ///     <see cref="BodyViewModel" />.
    /// </summary>
    /// <param name="domainModel">The <see cref="Core.Models.Body" /> domain model to be converted.</param>
    /// <returns>A new instance of <see cref="BodyViewModel" /> representing the view model.</returns>
    public static BodyViewModel ToViewModel(this Core.Models.Body domainModel)
        => new()
        {
            Id = domainModel.Id,
            Name = domainModel.Name,
            Variants = domainModel.Variants.ToViewModel()
        };
}