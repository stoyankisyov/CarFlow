namespace CarFlow.Core.Models;

public class Body(int id, string name, List<BodyVariant> variants)
{
    public int Id { get; } = id;

    public string Name { get; } = name;

    public List<BodyVariant> Variants { get; } = variants;
}