namespace CarFlow.Infrastructure.Models;

public class EuroStandard
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CombustionEngineCar> CombustionEngineCars { get; set; } =
        new List<CombustionEngineCar>();
}