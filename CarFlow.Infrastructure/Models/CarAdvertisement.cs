namespace CarFlow.Infrastructure.Models;

public class CarAdvertisement(
    int id,
    int accountId,
    int conditionId,
    int carId,
    int exteriorColorId,
    int interiorColorId,
    int seatMaterialId,
    int subregionId,
    DateTime creationDate,
    DateTime expirationDate,
    int viewCount,
    string title,
    string? description,
    int mileage,
    int price,
    DateOnly manufactureYear,
    DateOnly? registrationYear,
    DateOnly? warranty,
    string? vin,
    int? ownerCount,
    string? videoUrl)
{
    public int Id { get; init; } = id;

    public int AccountId { get; init; } = accountId;

    public int ConditionId { get; set; } = conditionId;

    public int CarId { get; set; } = carId;

    public int ExteriorColorId { get; set; } = exteriorColorId;

    public int InteriorColorId { get; set; } = interiorColorId;

    public int SeatMaterialId { get; set; } = seatMaterialId;

    public int SubregionId { get; set; } = subregionId;

    public DateTime CreationDate { get; init; } = creationDate;

    public DateTime ExpirationDate { get; init; } = expirationDate;

    public int ViewCount { get; init; } = viewCount;

    public string Title { get; set; } = title;

    public string? Description { get; set; } = description;

    public int Mileage { get; set; } = mileage;

    public int Price { get; set; } = price;

    public DateOnly ManufactureYear { get; set; } = manufactureYear;

    public DateOnly? RegistrationYear { get; set; } = registrationYear;

    public DateOnly? Warranty { get; set; } = warranty;

    public string? Vin { get; set; } = vin;

    public int? OwnerCount { get; set; } = ownerCount;

    public string? VideoUrl { get; set; } = videoUrl;

    public Account Account { get; set; } = null!;

    public Condition Condition { get; set; } = null!;

    public Car Car { get; set; } = null!;

    public Color ExteriorColor { get; set; } = null!;

    public Color InteriorColor { get; set; } = null!;

    public SeatMaterial SeatMaterial { get; set; } = null!;

    public Subregion Subregion { get; set; } = null!;

    public TunedCarDetail TunedCarDetail { get; set; } = null!;

    public ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();

    public ICollection<CarAdvertisementFeature> CarAdvertisementFeature { get; set; } =
        new List<CarAdvertisementFeature>();

    public ICollection<CarAdvertisementImage> CarAdvertisementImages { get; set; } =
        new List<CarAdvertisementImage>();

    public ICollection<AccountFavouriteAdvertisement> AccountFavouriteAdvertisements { get; set; } =
        new List<AccountFavouriteAdvertisement>();
}