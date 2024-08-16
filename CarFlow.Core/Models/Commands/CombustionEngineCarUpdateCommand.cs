namespace CarFlow.Core.Models.Commands;

public class CombustionEngineCarUpdateCommand(
    int id,
    Model model,
    string? generation,
    BodyVariant bodyVariant,
    TransmissionVariant transmissionVariant,
    Drivetrain drivetrain,
    DateOnly startYear,
    DateOnly? endYear,
    int engineId,
    EuroStandard euroStandard,
    decimal? cityFuel,
    decimal? combinedFuel,
    decimal? highwayFuel)
    : CarUpdateCommand(id, model, generation, bodyVariant, transmissionVariant, drivetrain, startYear, endYear)
{
    public int EngineId { get; } = engineId;

    public EuroStandard EuroStandard { get; } = euroStandard;

    public decimal? CityFuel { get; } = cityFuel;

    public decimal? CombinedFuel { get; } = combinedFuel;

    public decimal? HighwayFuel { get; } = highwayFuel;
}