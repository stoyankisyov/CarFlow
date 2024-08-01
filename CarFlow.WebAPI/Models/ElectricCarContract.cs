namespace CarFlow.WebAPI.Models;

public class ElectricCarContract : CarContract
{
    public int Horsepower { get; set; }
    public int Torque { get; set; }
    public int BatteryCapacity { get; set; }
    public int Range { get; set; }
    public int MotorCount { get; set; }
}