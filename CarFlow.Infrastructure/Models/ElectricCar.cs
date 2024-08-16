namespace CarFlow.Infrastructure.Models;

public class ElectricCar(
    int id,
    int modelId,
    string? generation,
    int bodyVariantId,
    int transmissionVariantId,
    int drivetrainId,
    DateOnly startYear,
    DateOnly? endYear,
    int horsepower,
    int torque,
    int batteryCapacity,
    int range,
    int motorCount)
    : Car(id, modelId, generation, bodyVariantId, transmissionVariantId, drivetrainId, startYear, endYear)
{
    public int Horsepower { get; set; } = horsepower;

    public int Torque { get; set; } = torque;

    public int BatteryCapacity { get; set; } = batteryCapacity;

    public int Range { get; set; } = range;

    public int MotorCount { get; set; } = motorCount;

    public Car IdNavigation { get; set; } = null!;
}