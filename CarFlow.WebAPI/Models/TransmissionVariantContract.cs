namespace CarFlow.WebAPI.Models;

public class TransmissionVariantContract
{
    public int Id { get; init; }
    public int TransmissionId { get; init; }
    public int GearCount { get; init; }
}