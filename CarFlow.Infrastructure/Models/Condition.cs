namespace CarFlow.Infrastructure.Models;

public class Condition(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<CarAdvertisement> CarAdvertisements { get; set; } = new List<CarAdvertisement>();
}