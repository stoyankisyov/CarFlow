namespace CarFlow.Infrastructure.Models;

public class TunedCarDetail(int id, int carAdvertisementId, int horsepower)
{
    public int Id { get; init; } = id;

    public int CarAdvertisementId { get; init; } = carAdvertisementId;

    public int Horsepower { get; set; } = horsepower;

    public CarAdvertisement CarAdvertisement { get; set; } = null!;
}