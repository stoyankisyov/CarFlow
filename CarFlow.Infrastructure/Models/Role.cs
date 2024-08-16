namespace CarFlow.Infrastructure.Models;

public class Role(int id, string name)
{
    public int Id { get; init; } = id;

    public string Name { get; set; } = name;

    public ICollection<AccountRole> AccountRoles { get; set; } = new List<AccountRole>();
}