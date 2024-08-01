namespace CarFlow.Infrastructure.Models;

public class Region
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Subregion> Subregions { get; set; } = new List<Subregion>();
}