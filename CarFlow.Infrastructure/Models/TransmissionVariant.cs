namespace CarFlow.Infrastructure.Models;

public partial class TransmissionVariant
{
    public int Id { get; set; }

    public int TransmissionId { get; set; }

    public int GearCount { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual Transmission Transmission { get; set; } = null!;
}
