namespace CarFlow.Infrastructure.Models;

public class SeatsMaterial
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CarAd> CarAds { get; set; } = new List<CarAd>();
}