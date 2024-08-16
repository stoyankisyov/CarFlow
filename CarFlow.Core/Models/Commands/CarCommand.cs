namespace CarFlow.Core.Models.Commands;

public abstract class CarCommand(
    Model model,
    string? generation,
    BodyVariant bodyVariant,
    TransmissionVariant transmissionVariant,
    Drivetrain drivetrain,
    DateOnly startYear,
    DateOnly? endYear)
    : Command
{
    public Model Model { get; } = model;

    public string? Generation { get; } = generation;

    public BodyVariant BodyVariant { get; } = bodyVariant;

    public TransmissionVariant TransmissionVariant { get; } = transmissionVariant;

    public Drivetrain Drivetrain { get; } = drivetrain;

    public DateOnly StartYear { get; } = startYear;

    public DateOnly? EndYear { get; } = endYear;
}