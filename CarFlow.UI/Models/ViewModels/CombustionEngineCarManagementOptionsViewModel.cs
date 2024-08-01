#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class CombustionEngineCarManagementOptionsViewModel
{
    public List<EngineViewModel> Engines { get; init; }
    public List<EuroStandardViewModel> EuroStandards { get; set; }
}