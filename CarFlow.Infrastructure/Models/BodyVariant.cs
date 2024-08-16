namespace CarFlow.Infrastructure.Models;

public class BodyVariant(int id, int bodyId, int doorCount, int seatCount)
{
    public int Id { get; init; } = id;

    public int BodyId { get; init; } = bodyId;

    public int DoorCount { get; set; } = doorCount;

    public int SeatCount { get; set; } = seatCount;

    public Body Body { get; set; } = null!;

    public ICollection<Car> Cars { get; set; } = new List<Car>();
}