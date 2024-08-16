namespace CarFlow.Infrastructure.Models;

public class Car(
    int id,
    int modelId,
    string? generation,
    int bodyVariantId,
    int transmissionVariantId,
    int drivetrainId,
    DateOnly startYear,
    DateOnly? endYear)
{
    public int Id { get; init; } = id;

    public int ModelId { get; set; } = modelId;

    public string? Generation { get; set; } = generation;

    public int BodyVariantId { get; set; } = bodyVariantId;

    public int TransmissionVariantId { get; set; } = transmissionVariantId;

    public int DrivetrainId { get; set; } = drivetrainId;

    public DateOnly StartYear { get; set; } = startYear;

    public DateOnly? EndYear { get; set; } = endYear;

    public CombustionEngineCar? CombustionEngineCar { get; set; }

    public ElectricCar? ElectricCar { get; set; }

    public Model Model { get; set; } = null!;

    public BodyVariant BodyVariant { get; set; } = null!;

    public TransmissionVariant TransmissionVariant { get; set; } = null!;

    public Drivetrain Drivetrain { get; set; } = null!;

    public ICollection<CarAdvertisement> CarAdvertisements { get; set; } = new List<CarAdvertisement>();
}