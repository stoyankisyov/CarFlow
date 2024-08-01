namespace CarFlow.WebAPI.Models;

public class BodyVariantContract
{
    public int Id { get; init; }
    public int BodyId { get; init; }
    public int DoorCount { get; init; }
    public int SeatCount { get; init; }
}