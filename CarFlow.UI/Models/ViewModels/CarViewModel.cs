#nullable disable

using CarFlow.UI.Enums;

namespace CarFlow.UI.Models.ViewModels;

public abstract class CarViewModel
{
    public int Id { get; init; }
    public CarType CarType { get; init; }
    public MakeViewModel Make { get; set; }
    public ModelViewModel Model { get; init; }
    public string Generation { get; init; }
    public BodyViewModel Body { get; set; }
    public BodyVariantViewModel BodyVariant { get; init; }
    public TransmissionViewModel Transmission { get; set; }
    public TransmissionVariantViewModel TransmissionVariant { get; init; }
    public DrivetrainViewModel Drivetrain { get; init; }
    public DateOnly StartYear { get; init; }
    public DateOnly? EndYear { get; init; }
}