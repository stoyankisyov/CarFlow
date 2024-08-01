#nullable disable

namespace CarFlow.WebAPI.Models;

public class EngineContract
{
    public int Id { get; init; }
    public string Model { get; init; }
    public int Displacement { get; init; }
    public int Horsepower { get; init; }
    public int Torque { get; init; }
    public FuelTypeContract FuelType { get; init; }
    public EngineConfigurationContract Configuration { get; init; }
    public EngineAspirationContract Aspiration { get; init; }
}