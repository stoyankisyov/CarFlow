#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class TransmissionViewModel
{
    public int Id { get; init; }

    public string Name { get; init; }

    public List<TransmissionVariantViewModel> TransmissionVariants { get; init; }
}