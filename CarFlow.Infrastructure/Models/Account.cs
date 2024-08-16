namespace CarFlow.Infrastructure.Models;

public class Account(int id, string name, string email, string phone, string password, string? streetAddress)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public string Email { get; set; } = email;

    public string Phone { get; set; } = phone;

    public string Password { get; set; } = password;

    public string? StreetAddress { get; set; } = streetAddress;

    public ICollection<AccountRole> AccountRoles { get; set; } = new List<AccountRole>();

    public ICollection<CarAdvertisement> CarAdvertisements { get; set; } = new List<CarAdvertisement>();

    public ICollection<AccountFavouriteAdvertisement> AccountFavouriteAdvertisements { get; set; } =
        new List<AccountFavouriteAdvertisement>();
}