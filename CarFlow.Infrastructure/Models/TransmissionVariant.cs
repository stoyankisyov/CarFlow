namespace CarFlow.Infrastructure.Models;

public class TransmissionVariant(int id, int transmissionId, int gearCount)
{
    public int Id { get; init; } = id;

    public int TransmissionId { get; init; } = transmissionId;

    public int GearCount { get; set; } = gearCount;

    public Transmission Transmission { get; set; } = null!;

    public ICollection<Car> Cars { get; set; } = new List<Car>();
}