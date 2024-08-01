#nullable disable

namespace CarFlow.WebAPI.Models;

public class CombustionEngineCarContract : CarContract
{
    public EngineContract Engine { get; set; }
    public EuroStandardContract EuroStandard { get; set; }
    public decimal? CityFuel { get; set; }
    public decimal? CombinedFuel { get; set; }
    public decimal? HighwayFuel { get; set; }
}