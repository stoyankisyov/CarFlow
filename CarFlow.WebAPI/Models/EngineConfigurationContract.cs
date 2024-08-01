#nullable disable

namespace CarFlow.WebAPI.Models;

public class EngineConfigurationContract
{
    public int Id { get; init; }
    public string Name { get; init; }
    public int CylinderCount { get; init; }
}