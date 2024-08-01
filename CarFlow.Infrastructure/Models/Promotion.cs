namespace CarFlow.Infrastructure.Models;

public class Promotion
{
    public int Id { get; set; }

    public int CarAdId { get; set; }

    public int PromotionTypeId { get; set; }

    public DateTime ExpirationDate { get; set; }

    public virtual CarAd CarAd { get; set; } = null!;

    public virtual PromotionType PromotionType { get; set; } = null!;
}