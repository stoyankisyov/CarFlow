namespace CarFlow.Infrastructure.Models;

public partial class CarAdImage
{
    public int Id { get; set; }

    public int CarAdId { get; set; }

    public byte[] ImageData { get; set; } = null!;

    public virtual CarAd CarAd { get; set; } = null!;
}
