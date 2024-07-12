namespace CarFlow.Infrastructure.Models;

public partial class Car
{
    public int Id { get; set; }

    public int ModelId { get; set; }

    public string? Generation { get; set; }

    public int BodyVariantId { get; set; }

    public int TransmissionVariantId { get; set; }

    public int DrivetrainId { get; set; }

    public DateOnly StartYear { get; set; }

    public DateOnly? EndYear { get; set; }

    public virtual BodyVariant BodyVariant { get; set; } = null!;

    public virtual ICollection<CarAd> CarAds { get; set; } = new List<CarAd>();

    public virtual CombustionEngineCar? CombustionEngineCar { get; set; }

    public virtual Drivetrain Drivetrain { get; set; } = null!;

    public virtual ElectricCar? ElectricCar { get; set; }

    public virtual Model Model { get; set; } = null!;

    public virtual TransmissionVariant TransmissionVariant { get; set; } = null!;
}
