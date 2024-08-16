namespace CarFlow.Core.Models;

public class CombustionEngineCar(
    int id,
    Brand brand,
    Model model,
    string? generation,
    Body body,
    BodyVariant bodyVariant,
    Transmission transmission,
    TransmissionVariant transmissionVariant,
    Drivetrain drivetrain,
    DateOnly startYear,
    DateOnly? endYear,
    Engine engine,
    EuroStandard euroStandard,
    decimal? cityFuel,
    decimal? combinedFuel,
    decimal? highwayFuel)
    : Car(id, brand, model, generation, body, bodyVariant, transmission, transmissionVariant, drivetrain, startYear,
        endYear)
{
    public Engine Engine { get; } = engine;
    public EuroStandard EuroStandard { get; } = euroStandard;
    public decimal? CityFuel { get; } = cityFuel;
    public decimal? CombinedFuel { get; } = combinedFuel;
    public decimal? HighwayFuel { get; } = highwayFuel;
}