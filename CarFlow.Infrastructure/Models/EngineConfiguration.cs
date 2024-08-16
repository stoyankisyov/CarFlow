namespace CarFlow.Infrastructure.Models;

public class EngineConfiguration(int id, string name, int cylinderCount)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public int CylinderCount { get; set; } = cylinderCount;

    public ICollection<Engine> Engines { get; set; } = new List<Engine>();
}