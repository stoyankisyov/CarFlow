using CarFlow.DomainServices.IService;
using CarFlow.UI.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Managers
{
    public class EngineOptionsManager(
        IFuelTypeService fuelTypeService,
        IEngineConfigurationService engineConfigurationService,
        IEngineAspirationService engineAspirationService)
        : IEngineOptionsManager
    {
        public async Task<EngineManagementOptionsViewModel> GetEngineOptionsAsync()
            => new()
            {
                FuelTypes = (await fuelTypeService.GetAllAsync()).ToViewModel(),
                Configurations = (await engineConfigurationService.GetAllAsync()).ToViewModel(),
                Aspirations = (await engineAspirationService.GetAllAsync()).ToViewModel()
            };
    }
}
