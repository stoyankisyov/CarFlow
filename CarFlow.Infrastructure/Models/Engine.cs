namespace CarFlow.Infrastructure.Models;

public class Engine
{
    public int Id { get; set; }

    public string? Model { get; set; }

    public int Displacement { get; set; }

    public int Horsepower { get; set; }

    public int Torque { get; set; }

    public int FuelTypeId { get; set; }

    public int ConfigurationId { get; set; }

    public int AspirationId { get; set; }

    public virtual EngineAspiration Aspiration { get; set; } = null!;

    public virtual ICollection<CombustionEngineCar> CombustionEngineCars { get; set; } =
        new List<CombustionEngineCar>();

    public virtual EngineConfiguration Configuration { get; set; } = null!;

    public virtual FuelType FuelType { get; set; } = null!;
}