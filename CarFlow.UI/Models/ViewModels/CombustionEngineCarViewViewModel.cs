#nullable disable

namespace CarFlow.UI.Models.ViewModels
{
    public class CombustionEngineCarViewViewModel : CarViewModel
    {
        public EngineViewModel Engine { get; set; }
        public EuroStandardViewModel Eurostandard { get; init; }
        public decimal? CityFuel { get; init; }
        public decimal? CombinedFuel { get; init; }
        public decimal? HighwayFuel { get; init; }
    }
}
