namespace CarFlow.Core.Models
{
    public class BodyVariant(int id, int bodyId, int doorCount, int seatCount)
    {
        public int Id { get; } = id;
        public int BodyId { get; } = bodyId;
        public int DoorCount { get; } = doorCount;
        public int SeatCount { get; } = seatCount;
    }
}
