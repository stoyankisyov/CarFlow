using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Role = CarFlow.Core.Models.Role;

namespace CarFlow.Infrastructure.Repositories;

public class RoleRepository(CarFlowContext context) : IRoleRepository
{
    public async Task<Role?> GetUserRoleAsync()
    {
        var roleEntity = await context.Roles.SingleOrDefaultAsync(x => x.Name == "User");

        if (roleEntity is not null)
        {
            context.Roles.Entry(roleEntity).State = EntityState.Detached;
        }

        return roleEntity?.ToDomainModel();
    }
}