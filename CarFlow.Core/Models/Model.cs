namespace CarFlow.Core.Models;

public class Model(int id, string name, int makeId, string? modelVariant)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public int MakeId { get; set; } = makeId;
    public string? ModelVariant { get; } = modelVariant;
}