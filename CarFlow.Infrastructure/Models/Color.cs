namespace CarFlow.Infrastructure.Models;

public class Color(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<CarAdvertisement> CarAdvertisementExteriorColors { get; set; } = new List<CarAdvertisement>();

    public ICollection<CarAdvertisement> CarAdvertisementInteriorColors { get; set; } = new List<CarAdvertisement>();
}