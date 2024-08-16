namespace CarFlow.Core.Models;

public class ElectricCar(
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
    int horsepower,
    int torque,
    int batteryCapacity,
    int range,
    int motorCount)
    : Car(id, brand, model, generation, body, bodyVariant, transmission, transmissionVariant, drivetrain, startYear,
        endYear)
{
    public int Horsepower { get; } = horsepower;
    public int Torque { get; } = torque;
    public int BatteryCapacity { get; } = batteryCapacity;
    public int Range { get; } = range;
    public int MotorCount { get; } = motorCount;
}