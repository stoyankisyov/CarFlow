#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class EngineManagementOptionsViewModel
{
    public List<FuelTypeViewModel> FuelTypes { get; init; }

    public List<EngineConfigurationViewModel> Configurations { get; init; }

    public List<EngineAspirationViewModel> Aspirations { get; init; }
}