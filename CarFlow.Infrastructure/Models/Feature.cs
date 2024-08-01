namespace CarFlow.Infrastructure.Models;

public class Feature
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CarAd> CarAds { get; set; } = new List<CarAd>();

    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}