namespace CarFlow.Infrastructure.Models;

public class CombustionEngineCar(
    int id,
    int modelId,
    string? generation,
    int bodyVariantId,
    int transmissionVariantId,
    int drivetrainId,
    DateOnly startYear,
    DateOnly? endYear,
    int engineId,
    int euroStandardId,
    decimal? cityFuel,
    decimal? combinedFuel,
    decimal? highwayFuel)
    : Car(id, modelId, generation, bodyVariantId, transmissionVariantId, drivetrainId, startYear, endYear)
{
    public int EngineId { get; set; } = engineId;

    public int EuroStandardId { get; set; } = euroStandardId;

    public decimal? CityFuel { get; set; } = cityFuel;

    public decimal? CombinedFuel { get; set; } = combinedFuel;

    public decimal? HighwayFuel { get; set; } = highwayFuel;

    public Engine Engine { get; set; } = null!;

    public EuroStandard EuroStandard { get; set; } = null!;

    public Car IdNavigation { get; set; } = null!;
}