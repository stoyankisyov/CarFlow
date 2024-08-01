#nullable disable

namespace CarFlow.Core.Models;

public abstract class Car(
    int id,
    Make make,
    Model model,
    string generation,
    Body body,
    BodyVariant bodyVariant,
    Transmission transmission,
    TransmissionVariant transmissionVariant,
    Drivetrain drivetrain,
    DateOnly startYear,
    DateOnly? endYear
)
{
    public int Id { get; } = id;
    public Make Make { get; } = make;
    public Model Model { get; } = model;
    public string Generation { get; } = generation;
    public Body Body { get; } = body;
    public BodyVariant BodyVariant { get; } = bodyVariant;
    public Transmission Transmission { get; } = transmission;
    public TransmissionVariant TransmissionVariant { get; } = transmissionVariant;
    public Drivetrain Drivetrain { get; } = drivetrain;
    public DateOnly StartYear { get; } = startYear;
    public DateOnly? EndYear { get; } = endYear;
}