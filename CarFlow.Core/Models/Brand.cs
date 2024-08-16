namespace CarFlow.Core.Models;

public class Brand(int id, string name, List<Model> models)
{
    public int Id { get; } = id;

    public string Name { get; } = name;

    public List<Model> Models { get; } = models;
}