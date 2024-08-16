namespace CarFlow.Infrastructure.Models;

public class PromotionType(int id, string name, decimal price)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public decimal Price { get; set; } = price;

    public ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();
}