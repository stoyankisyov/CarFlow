using CarFlow.Core.Models;

namespace CarFlow.Core.Repositories;

public interface IRoleRepository
{
    Task<Role?> GetUserRoleAsync();
}