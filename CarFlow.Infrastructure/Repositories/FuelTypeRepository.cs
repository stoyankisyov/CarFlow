using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories;

public class FuelTypeRepository(CarFlowContext context) : IFuelTypeRepository
{
    public async Task AddAsync(Core.Models.FuelType fuelType)
    {
        await context.FuelTypes.AddAsync(fuelType.ToEntity());

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var fuelType = await context.FuelTypes.SingleAsync(x => x.Id == id);

        context.FuelTypes.Remove(fuelType);

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.FuelType?> GetAsync(int id)
    {
        var fuelType = await context.FuelTypes.SingleOrDefaultAsync(x => x.Id == id);

        return fuelType?.ToDomainModel();
    }

    public async Task<List<Core.Models.FuelType>> GetAllAsync()
    {
        var fuelTypes = await context.FuelTypes.ToListAsync();

        return fuelTypes.ToDomainModel();
    }

    public async Task<Page<Core.Models.FuelType>> GetPageAsync(int currentPage, int pageSize)
    {
        var offset = (currentPage - 1) * pageSize;

        var fuelTypeList = await context.FuelTypes
            .OrderBy(x => x.Id)
            .Skip(offset)
            .Take(pageSize)
            .ToListAsync();

        var recordCount = await context.FuelTypes.CountAsync();
        var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

        return new Page<Core.Models.FuelType>(currentPage, pageCount, pageSize, fuelTypeList.ToDomainModel());
    }

    public async Task UpdateAsync(Core.Models.FuelType updateFuelType)
    {
        var existingFuelType = await context.FuelTypes.SingleAsync(x => x.Id == updateFuelType.Id);
        existingFuelType.Name = updateFuelType.Name;

        await context.SaveChangesAsync();
    }
}