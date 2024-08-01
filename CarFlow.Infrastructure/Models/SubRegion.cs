namespace CarFlow.Infrastructure.Models;

public class Subregion
{
    public int Id { get; set; }

    public int RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CarAd> CarAds { get; set; } = new List<CarAd>();

    public virtual Region Region { get; set; } = null!;
}