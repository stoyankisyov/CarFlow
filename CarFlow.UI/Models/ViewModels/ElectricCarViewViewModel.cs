namespace CarFlow.UI.Models.ViewModels;

public class ElectricCarViewViewModel : CarViewModel
{
    public int Horsepower { get; init; }

    public int Torque { get; init; }

    public int BatteryCapacity { get; init; }

    public int Range { get; init; }

    public int MotorCount { get; init; }
}