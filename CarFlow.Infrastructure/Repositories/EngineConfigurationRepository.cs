using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories;

public class EngineConfigurationRepository(CarFlowContext context) : IEngineConfigurationRepository
{
    public async Task AddAsync(Core.Models.EngineConfiguration engineConfiguration)
    {
        await context.EngineConfigurations.AddAsync(engineConfiguration.ToEntity());

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var engineConfiguration = await context.EngineConfigurations.SingleAsync(x => x.Id == id);

        context.EngineConfigurations.Remove(engineConfiguration);

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.EngineConfiguration?> GetAsync(int id)
    {
        var engineConfiguration = await context.EngineConfigurations.SingleOrDefaultAsync(x => x.Id == id);

        return engineConfiguration?.ToDomainModel();
    }

    public async Task<List<Core.Models.EngineConfiguration>> GetAllAsync()
    {
        var engineConfigurationList = await context.EngineConfigurations.ToListAsync();

        return engineConfigurationList.ToDomainModel();
    }

    public async Task<Page<Core.Models.EngineConfiguration>> GetPageAsync(int currentPage, int pageSize)
    {
        var offset = (currentPage - 1) * pageSize;

        var engineConfigurationList = await context.EngineConfigurations
            .OrderBy(x => x.Id)
            .Skip(offset)
            .Take(pageSize)
            .ToListAsync();

        var recordCount = await context.EngineConfigurations.CountAsync();
        var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

        return new Page<Core.Models.EngineConfiguration>(currentPage, pageCount, pageSize,
            engineConfigurationList.ToDomainModel());
    }

    public async Task UpdateAsync(Core.Models.EngineConfiguration updateEngineConfiguration)
    {
        var existingEngineConfiguration =
            await context.EngineConfigurations.SingleAsync(x => x.Id == updateEngineConfiguration.Id);
        existingEngineConfiguration.Name = updateEngineConfiguration.Name;
        existingEngineConfiguration.CylinderCount = updateEngineConfiguration.CylinderCount;

        await context.SaveChangesAsync();
    }
}