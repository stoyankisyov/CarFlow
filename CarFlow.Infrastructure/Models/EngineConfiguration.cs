namespace CarFlow.Infrastructure.Models;

public partial class EngineConfiguration
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CylinderCount { get; set; }

    public virtual ICollection<Engine> Engines { get; set; } = new List<Engine>();
}
