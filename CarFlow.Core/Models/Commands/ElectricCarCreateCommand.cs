namespace CarFlow.Core.Models.Commands;

public class ElectricCarCreateCommand(
    Model model,
    string? generation,
    BodyVariant bodyVariant,
    TransmissionVariant transmissionVariant,
    Drivetrain drivetrain,
    DateOnly startYear,
    DateOnly? endYear,
    int horsepower,
    int torque,
    int batteryCapacity,
    int range,
    int motorCount)
    : CarCreateCommand(model, generation, bodyVariant, transmissionVariant, drivetrain, startYear, endYear)
{
    public int Horsepower { get; } = horsepower;
    public int Torque { get; } = torque;
    public int BatteryCapacity { get; } = batteryCapacity;
    public int Range { get; } = range;
    public int MotorCount { get; } = motorCount;
}