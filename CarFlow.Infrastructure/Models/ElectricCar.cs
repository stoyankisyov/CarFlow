namespace CarFlow.Infrastructure.Models;

public partial class ElectricCar
{
    public int Id { get; set; }

    public int Horsepower { get; set; }

    public int Torque { get; set; }

    public int BatteryCapacity { get; set; }

    public int Range { get; set; }

    public int MotorCount { get; set; }

    public virtual Car IdNavigation { get; set; } = null!;
}
