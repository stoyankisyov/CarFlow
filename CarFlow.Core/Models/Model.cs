namespace CarFlow.Core.Models;

public class Model(int id, string name, int brandId, string? modelVariant)
{
    public int Id { get; } = id;

    public string Name { get; } = name;

    public int BrandId { get; set; } = brandId;

    public string? ModelVariant { get; } = modelVariant;
}