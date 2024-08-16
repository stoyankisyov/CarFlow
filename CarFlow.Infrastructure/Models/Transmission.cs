namespace CarFlow.Infrastructure.Models;

public class Transmission(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<TransmissionVariant> TransmissionVariants { get; set; } =
        new List<TransmissionVariant>();
}