namespace CarFlow.Infrastructure.Models;

public class CarAdvertisementImage(int id, int carAdvertisementId, byte[] imageData)
{
    public int Id { get; init; } = id;

    public int CarAdvertisementId { get; init; } = carAdvertisementId;

    public byte[] ImageData { get; set; } = imageData;

    public CarAdvertisement CarAdvertisement { get; set; } = null!;
}