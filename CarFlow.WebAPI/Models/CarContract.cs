#nullable disable

using CarFlow.WebAPI.Enums;

namespace CarFlow.WebAPI.Models;

public abstract class CarContract
{
    public int Id { get; set; }
    public CarType CarType { get; set; }
    public BrandContract Brand { get; set; }
    public ModelContract Model { get; set; }
    public string Generation { get; set; }
    public BodyContract Body { get; set; }
    public BodyVariantContract BodyVariant { get; set; }
    public TransmissionContract Transmission { get; set; }
    public TransmissionVariantContract TransmissionVariant { get; set; }
    public DrivetrainContract Drivetrain { get; set; }
    public DateOnly StartYear { get; set; }
    public DateOnly? EndYear { get; set; }
}