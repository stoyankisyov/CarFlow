#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class CarManagementOptionsViewModel
{
    public CarBaseManagementOptionsViewModel BaseOptions { get; init; }
    public CombustionEngineCarManagementOptionsViewModel CombustionEngineCarOptions { get; init; }
}