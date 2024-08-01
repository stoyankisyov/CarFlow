namespace CarFlow.Core.Models;

public class Subregion(int id, int regionId, string name)
{
    public int Id { get; } = id;
    public int RegionId { get; set; } = regionId;
    public string Name { get; } = name;
}