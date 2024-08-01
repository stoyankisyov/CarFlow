using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Interfaces;

public interface IEngineOptionsManager
{
    Task<EngineManagementOptionsViewModel> GetEngineOptionsAsync();
}