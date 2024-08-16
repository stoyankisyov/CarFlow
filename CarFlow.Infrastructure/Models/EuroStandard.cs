namespace CarFlow.Infrastructure.Models;

public class EuroStandard(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<CombustionEngineCar> CombustionEngineCars { get; set; } =
        new List<CombustionEngineCar>();
}