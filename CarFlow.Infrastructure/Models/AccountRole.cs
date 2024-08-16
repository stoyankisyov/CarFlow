namespace CarFlow.Infrastructure.Models;

public class AccountRole(int accountId, int roleId)
{
    public int AccountId { get; init; } = accountId;

    public int RoleId { get; init; } = roleId;

    public Account Account { get; set; } = null!;

    public Role Role { get; set; } = null!;
}