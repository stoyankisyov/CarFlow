using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers;

public static class AccountMapper
{
    /// <summary>
    ///     Converts a view model of type <see cref="AccountViewModel" /> to a domain model of type
    ///     <see cref="Core.Models.Account" />.
    /// </summary>
    /// <param name="viewModel">The view model to be converted.</param>
    /// <returns>A new instance of <see cref="Core.Models.Account" /> representing the domain model.</returns>
    /// <remarks>
    ///     This method creates a domain model instance from the provided view model. The roles property is initialized
    ///     as an empty array, as role information is not included in the view model.
    /// </remarks>
    public static Core.Models.Account ToDomainModel(this AccountViewModel viewModel)
        => new(viewModel.Id, [], viewModel.Name, viewModel.Email, viewModel.Phone, viewModel.Password,
            viewModel.Address);
}