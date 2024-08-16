namespace CarFlow.Infrastructure.Models;

public class Region(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<Subregion> Subregions { get; set; } = new List<Subregion>();
}