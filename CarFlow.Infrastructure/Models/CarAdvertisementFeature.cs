namespace CarFlow.Infrastructure.Models;

public class CarAdvertisementFeature(int carAdvertisementId, int featureId)
{
    public int CarAdvertisementId { get; init; } = carAdvertisementId;

    public int FeatureId { get; init; } = featureId;

    public CarAdvertisement CarAdvertisement { get; set; } = null!;

    public Feature Feature { get; set; } = null!;
}