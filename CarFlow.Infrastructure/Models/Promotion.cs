namespace CarFlow.Infrastructure.Models;

public class Promotion(int id, int carAdvertisementId, int promotionTypeId, DateTime expirationDate)
{
    public int Id { get; init; } = id;

    public int CarAdvertisementId { get; init; } = carAdvertisementId;

    public int PromotionTypeId { get; set; } = promotionTypeId;

    public DateTime ExpirationDate { get; set; } = expirationDate;

    public CarAdvertisement CarAdvertisement { get; set; } = null!;

    public PromotionType PromotionType { get; set; } = null!;
}