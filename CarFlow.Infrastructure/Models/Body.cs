namespace CarFlow.Infrastructure.Models;

public class Body(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<BodyVariant> BodyVariants { get; set; } = new List<BodyVariant>();
}