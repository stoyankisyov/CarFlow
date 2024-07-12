namespace CarFlow.Infrastructure.Models;

public partial class Color
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CarAd> CarAdExteriorColors { get; set; } = new List<CarAd>();

    public virtual ICollection<CarAd> CarAdInteriorColors { get; set; } = new List<CarAd>();
}
