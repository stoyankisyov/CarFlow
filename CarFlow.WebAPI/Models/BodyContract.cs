#nullable disable

namespace CarFlow.WebAPI.Models;

public class BodyContract
{
    public int Id { get; init; }
    public string Name { get; init; }
    public List<BodyVariantContract> Variants { get; init; }
}