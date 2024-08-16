namespace CarFlow.Infrastructure.Models;

public class Engine(
    int id,
    string? model,
    int displacement,
    int horsepower,
    int torque,
    int fuelTypeId,
    int configurationId,
    int aspirationId)
{
    public int Id { get; init; } = id;

    public string? Model { get; set; } = model;

    public int Displacement { get; set; } = displacement;

    public int Horsepower { get; set; } = horsepower;

    public int Torque { get; set; } = torque;

    public int FuelTypeId { get; set; } = fuelTypeId;

    public int ConfigurationId { get; set; } = configurationId;

    public int AspirationId { get; set; } = aspirationId;

    public FuelType FuelType { get; set; } = null!;

    public EngineConfiguration Configuration { get; set; } = null!;

    public EngineAspiration Aspiration { get; set; } = null!;

    public ICollection<CombustionEngineCar> CombustionEngineCars { get; set; } =
        new List<CombustionEngineCar>();
}