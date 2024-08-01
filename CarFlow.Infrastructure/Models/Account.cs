namespace CarFlow.Infrastructure.Models;

public class Account
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Address { get; set; }

    public virtual ICollection<CarAd> CarAdsNavigation { get; set; } = new List<CarAd>();

    public virtual ICollection<CarAd> CarAds { get; set; } = new List<CarAd>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<Role> RolesNavigation { get; set; } = new List<Role>();
}