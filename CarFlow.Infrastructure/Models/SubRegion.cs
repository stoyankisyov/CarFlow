namespace CarFlow.Infrastructure.Models;

public class Subregion(int id, int regionId, string name)
{
    public int Id { get; init; } = id;

    public int RegionId { get; init; } = regionId;

    public string Name { get; set; } = name;

    public Region Region { get; set; } = null!;

    public ICollection<CarAdvertisement> CarAdvertisements { get; set; } = new List<CarAdvertisement>();
}