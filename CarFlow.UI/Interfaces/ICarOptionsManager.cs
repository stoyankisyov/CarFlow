using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Interfaces;

public interface ICarOptionsManager
{
    Task<CarBaseManagementOptionsViewModel> GetCarBaseOptionsAsync();
    Task<CombustionEngineCarManagementOptionsViewModel> GetCombustionEngineCarOptionsAsync();
}