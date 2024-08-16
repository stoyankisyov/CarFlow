#nullable disable

namespace CarFlow.WebAPI.Models;

public class BrandContract
{
    public int Id { get; init; }

    public string Name { get; init; }

    public List<ModelContract> Models { get; init; }
}