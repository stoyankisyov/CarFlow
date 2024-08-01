namespace CarFlow.Infrastructure.Models;

public class Transmission
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TransmissionVariant> TransmissionVariants { get; set; } =
        new List<TransmissionVariant>();
}