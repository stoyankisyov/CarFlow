namespace CarFlow.Infrastructure.Models;

public class AccountFavouriteAdvertisement(int accountId, int advertisementId)
{
    public int AccountId { get; init; } = accountId;

    public int AdvertisementId { get; init; } = advertisementId;

    public Account Account { get; set; } = null!;

    public CarAdvertisement CarAdvertisement { get; set; } = null!;
}