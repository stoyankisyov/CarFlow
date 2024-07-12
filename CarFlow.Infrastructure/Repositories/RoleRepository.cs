using System.Data;
using CarFlow.Core.IRepository;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Role = CarFlow.Core.Models.Role;

namespace CarFlow.Infrastructure.Repositories
{
    public class RoleRepository(CarFlowContext context) : IRoleRepository
    {
        public async Task<Role> GetUserRoleAsync()
        {
            var roleEntity = await context.Roles.SingleOrDefaultAsync(x => x.Name == "User");

            return roleEntity is not null ? roleEntity.ToDomainModel() : throw new DataException("User role not found.");
        }
    }
}
