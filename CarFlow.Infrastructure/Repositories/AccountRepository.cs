using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories;

public class AccountRepository(CarFlowContext context) : IAccountRepositоry
{
    public async Task AddAccountAsync(Core.Models.Account account)
    {
        await context.Accounts.AddAsync(account.ToEntity());

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.Account?> GetAccountByEmailAsync(string email)
    {
        var accountEntity = await context.Accounts
            .Include(x => x.AccountRoles)
            .ThenInclude(ar => ar.Role)
            .SingleOrDefaultAsync(x => x.Email == email);

        return accountEntity?.ToDomainModel();
    }
}