namespace CarFlow.Core.Models.Commands;

public abstract class CarCreateCommand(
    Model model,
    string? generation,
    BodyVariant bodyVariant,
    TransmissionVariant transmissionVariant,
    Drivetrain drivetrain,
    DateOnly startYear,
    DateOnly? endYear)
    : CarCommand(model, generation, bodyVariant, transmissionVariant, drivetrain, startYear, endYear);