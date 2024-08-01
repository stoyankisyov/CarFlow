namespace CarFlow.Core.Models;

public class Transmission(int id, string name, List<TransmissionVariant> transmissionVariants)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public List<TransmissionVariant> TransmissionVariants { get; } = transmissionVariants;
}