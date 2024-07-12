using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Mappers
{
    public static class AccountMapper
    {
        /// <summary>
        /// Converts AccountViewModel/VM/ to Core.Models.Account/DM/ with no assigned roles
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns> Core.Models.Account </returns>
        public static Core.Models.Account ToDomainModel(this AccountViewModel viewModel)
            => new(viewModel.Id, [], viewModel.Name, viewModel.Email, viewModel.Phone, viewModel.Password, viewModel.Address);
    }
}
