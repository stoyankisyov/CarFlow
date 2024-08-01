#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class EngineViewModel
{
    public int Id { get; init; }
    public string Model { get; init; }
    public int Displacement { get; init; }
    public int Horsepower { get; init; }
    public int Torque { get; init; }
    public FuelTypeViewModel FuelType { get; init; }
    public EngineConfigurationViewModel Configuration { get; init; }
    public EngineAspirationViewModel Aspiration { get; init; }
}