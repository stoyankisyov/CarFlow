using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories;

public class RegionRepository(CarFlowContext context) : IRegionRepository
{
    public async Task AddAsync(Core.Models.Region region)
    {
        await context.Regions.AddAsync(region.ToEntity());

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var region = await context.Regions
            .Include(x => x.Subregions)
            .SingleAsync(x => x.Id == id);

        context.Subregions.RemoveRange(region.Subregions);
        context.Regions.Remove(region);

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.Region?> GetAsync(int id)
    {
        var region = await context.Regions
            .Include(x => x.Subregions)
            .SingleOrDefaultAsync(x => x.Id == id);

        return region?.ToDomainModel();
    }

    public async Task<Page<Core.Models.Region>> GetPageAsync(int currentPage, int pageSize)
    {
        var offset = (currentPage - 1) * pageSize;

        var regionList = await context.Regions
            .OrderBy(x => x.Id)
            .Skip(offset)
            .Take(pageSize)
            .ToListAsync();

        var recordCount = await context.Regions.CountAsync();
        var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

        return new Page<Core.Models.Region>(currentPage, pageCount, pageSize, regionList.ToDomainModel());
    }

    public async Task UpdateAsync(Core.Models.Region updateRegion)
    {
        updateRegion.Subregions.ForEach(x => x.RegionId = updateRegion.Id);

        var existingRegion = await context.Regions
            .Include(x => x.Subregions)
            .FirstAsync(x => x.Id == updateRegion.Id);

        existingRegion.Name = updateRegion.Name;

        foreach (var existingSubregion in existingRegion.Subregions)
        {
            var updateSubregion = updateRegion.Subregions.FirstOrDefault(x => x.Id == existingSubregion.Id);

            if (updateSubregion is null)
            {
                context.Subregions.Remove(existingSubregion);
            }
            else
            {
                existingSubregion.Name = updateSubregion.Name;
            }
        }

        var newSubregions = updateRegion.Subregions
            .Where(updateSubregion =>
                existingRegion.Subregions.All(existingSubregion => existingSubregion.Id != updateSubregion.Id))
            .ToList();

        await context.Subregions.AddRangeAsync(newSubregions.ToEntity());

        await context.SaveChangesAsync();
    }
}