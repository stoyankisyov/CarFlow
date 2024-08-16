namespace CarFlow.Infrastructure.Models;

public class Model(int id, int brandId, string name, string? modelVariant)
{
    public int Id { get; init; } = id;

    public int BrandId { get; init; } = brandId;

    public string Name { get; set; } = name;

    public string? ModelVariant { get; set; } = modelVariant;

    public Brand Brand { get; set; } = null!;

    public ICollection<Car> Cars { get; set; } = new List<Car>();

    public ICollection<ModelStandardFeature> ModelStandardFeatures { get; set; } = new List<ModelStandardFeature>();
}