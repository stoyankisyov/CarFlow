namespace CarFlow.Infrastructure.Models;

public class Brand(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<Model> Models { get; set; } = new List<Model>();
}