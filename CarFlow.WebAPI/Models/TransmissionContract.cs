#nullable disable

namespace CarFlow.WebAPI.Models;

public class TransmissionContract
{
    public int Id { get; init; }

    public string Name { get; init; }

    public List<TransmissionVariantContract> TransmissionVariants { get; init; }
}