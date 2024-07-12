namespace CarFlow.Infrastructure.Models;

public partial class CarAd
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public int ConditionId { get; set; }

    public int CarId { get; set; }

    public int ExteriorColorId { get; set; }

    public int InteriorColorId { get; set; }

    public int SeatsMaterialId { get; set; }

    public int SubregionId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public int AdViews { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int Mileage { get; set; }

    public int Price { get; set; }

    public DateOnly ManufactureYear { get; set; }

    public DateOnly? RegistrationYear { get; set; }

    public DateOnly? Warranty { get; set; }

    public string? Vin { get; set; }

    public int? OwnerCount { get; set; }

    public string? VideoUrl { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;

    public virtual ICollection<CarAdImage> CarAdImages { get; set; } = new List<CarAdImage>();

    public virtual Condition Condition { get; set; } = null!;

    public virtual Color ExteriorColor { get; set; } = null!;

    public virtual Color InteriorColor { get; set; } = null!;

    public virtual ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();

    public virtual SeatsMaterial SeatsMaterial { get; set; } = null!;

    public virtual Subregion Subregion { get; set; } = null!;

    public virtual TunedCarDetail? TunedCarDetail { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Feature> Features { get; set; } = new List<Feature>();
}
