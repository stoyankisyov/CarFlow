namespace CarFlow.Core.Models;

public class TransmissionVariant(int id, int gearCount, int transmissionId)
{
    public int Id { get; } = id;

    public int GearCount { get; } = gearCount;

    public int TransmissionId { get; set; } = transmissionId;
}