using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories;

public class EngineAspirationRepository(CarFlowContext context) : IEngineAspirationRepository
{
    public async Task AddAsync(Core.Models.EngineAspiration engineAspiration)
    {
        await context.EngineAspirations.AddAsync(engineAspiration.ToEntity());

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var engineAspiration = await context.EngineAspirations.SingleAsync(x => x.Id == id);

        context.EngineAspirations.Remove(engineAspiration);

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.EngineAspiration?> GetAsync(int id)
    {
        var engineAspiration = await context.EngineAspirations.SingleOrDefaultAsync(x => x.Id == id);

        return engineAspiration?.ToDomainModel();
    }

    public async Task<List<Core.Models.EngineAspiration>> GetAllAsync()
    {
        var engineAspirationList = await context.EngineAspirations.ToListAsync();

        return engineAspirationList.ToDomainModel();
    }

    public async Task<Page<Core.Models.EngineAspiration>> GetPageAsync(int currentPage, int pageSize)
    {
        var offset = (currentPage - 1) * pageSize;

        var engineAspirationList = await context.EngineAspirations
            .OrderBy(x => x.Id)
            .Skip(offset)
            .Take(pageSize)
            .ToListAsync();

        var recordCount = await context.EngineAspirations.CountAsync();
        var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

        return new Page<Core.Models.EngineAspiration>(currentPage, pageCount, pageSize,
            engineAspirationList.ToDomainModel());
    }

    public async Task UpdateAsync(Core.Models.EngineAspiration updateEngineAspiration)
    {
        var existingEngineAspiration =
            await context.EngineAspirations.SingleAsync(x => x.Id == updateEngineAspiration.Id);
        existingEngineAspiration.Name = updateEngineAspiration.Name;

        await context.SaveChangesAsync();
    }
}