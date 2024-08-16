namespace CarFlow.Infrastructure.Models;

public class ModelStandardFeature(int modelId, int featureId)
{
    public int ModelId { get; init; } = modelId;

    public int FeatureId { get; init; } = featureId;

    public Model Model { get; set; } = null!;

    public Feature Feature { get; set; } = null!;
}