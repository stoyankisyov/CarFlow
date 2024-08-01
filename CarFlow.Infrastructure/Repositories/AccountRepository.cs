﻿using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories;

public class AccountRepository(CarFlowContext context) : IAccountRepositоry
{
    public async Task AddAccountAsync(Core.Models.Account account)
    {
        var accountEntity = account.ToEntity();

        foreach (var accountEntityRole in accountEntity.Roles)
        {
            context.Roles.Attach(accountEntityRole);
        }

        await context.Accounts.AddAsync(accountEntity);

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.Account?> GetAccountByEmailAsync(string email)
    {
        var accountEntity = await context.Accounts
            .Include(x => x.Roles)
            .SingleOrDefaultAsync(x => x.Email == email);

        return accountEntity?.ToDomainModel();
    }
}