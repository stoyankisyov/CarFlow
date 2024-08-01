namespace CarFlow.Core.Models;

public class Region(int id, string name, List<Subregion> subregions)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public List<Subregion> Subregions { get; } = subregions;
}