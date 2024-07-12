using CarFlow.Core.Models;

namespace CarFlow.Core.IRepository
{
    public interface IRoleRepository
    {
        Task<Role> GetUserRoleAsync();
    }
}
