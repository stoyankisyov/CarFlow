namespace CarFlow.Infrastructure.Models;

public partial class CombustionEngineCar
{
    public int Id { get; set; }

    public int EngineId { get; set; }

    public int EuroStandardId { get; set; }

    public decimal? CityFuel { get; set; }

    public decimal? CombinedFuel { get; set; }

    public decimal? HighwayFuel { get; set; }

    public virtual Engine Engine { get; set; } = null!;

    public virtual EuroStandard EuroStandard { get; set; } = null!;

    public virtual Car IdNavigation { get; set; } = null!;
}
