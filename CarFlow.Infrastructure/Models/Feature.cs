namespace CarFlow.Infrastructure.Models;

public class Feature(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<CarAdvertisementFeature> CarAdvertisementFeatures { get; set; } =
        new List<CarAdvertisementFeature>();

    public ICollection<ModelStandardFeature> ModelStandardFeatures { get; set; } = new List<ModelStandardFeature>();
}