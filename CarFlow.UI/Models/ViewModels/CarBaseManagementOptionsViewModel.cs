#nullable disable

namespace CarFlow.UI.Models.ViewModels;

public class CarBaseManagementOptionsViewModel
{
    public List<MakeViewModel> Makes { get; init; }
    public List<ModelViewModel> Models { get; init; }
    public List<TransmissionViewModel> Transmissions { get; init; }
    public List<TransmissionVariantViewModel> TransmissionVariants { get; init; }
    public List<DrivetrainViewModel> Drivetrains { get; init; }
}