namespace CarFlow.Core.Models;

public class FuelType(int id, string name)
{
    public int Id { get; } = id;

    public string Name { get; } = name;
}