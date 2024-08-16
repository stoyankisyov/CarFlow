#nullable disable

namespace CarFlow.WebAPI.Models;

public class ModelContract
{
    public int Id { get; init; }

    public string Name { get; init; }

    public int BrandId { get; init; }

    public string ModelVariant { get; init; }
}