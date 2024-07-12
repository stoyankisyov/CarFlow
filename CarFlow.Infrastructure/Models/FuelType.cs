namespace CarFlow.Infrastructure.Models;

public partial class FuelType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Engine> Engines { get; set; } = new List<Engine>();
}
