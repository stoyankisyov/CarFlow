namespace CarFlow.Infrastructure.Models;

public partial class TunedCarDetail
{
    public int Id { get; set; }

    public int CarAdId { get; set; }

    public int Horsepower { get; set; }

    public virtual CarAd CarAd { get; set; } = null!;
}
