namespace CarFlow.Core.Models;

public class Engine(
    int id,
    string? model,
    int displacement,
    int horsepower,
    int torque,
    FuelType fuelType,
    EngineConfiguration configuration,
    EngineAspiration aspiration)
{
    public int Id { get; } = id;
    public string? Model { get; } = model;
    public int Displacement { get; } = displacement;
    public int Horsepower { get; } = horsepower;
    public int Torque { get; } = torque;
    public FuelType FuelType { get; } = fuelType;
    public EngineConfiguration Configuration { get; } = configuration;
    public EngineAspiration Aspiration { get; } = aspiration;
}