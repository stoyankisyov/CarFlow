namespace CarFlow.Infrastructure.Models;

public class EngineAspiration(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<Engine> Engines { get; set; } = new List<Engine>();
}