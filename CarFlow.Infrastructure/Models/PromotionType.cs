namespace CarFlow.Infrastructure.Models;

public class PromotionType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();
}