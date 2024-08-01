using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Model = CarFlow.Core.Models.Model;

namespace CarFlow.Infrastructure.Repositories;

public class MakeRepository(CarFlowContext context) : IMakeRepository
{
    public async Task AddAsync(Core.Models.Make make)
    {
        await context.Makes.AddAsync(make.ToEntity());

        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var make = await context.Makes
            .Include(x => x.Models)
            .SingleAsync(x => x.Id == id);

        context.Models.RemoveRange(make.Models);
        context.Makes.Remove(make);

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.Make?> GetAsync(int id)
    {
        var make = await context.Makes
            .Include(x => x.Models)
            .SingleOrDefaultAsync(x => x.Id == id);

        return make?.ToDomainModel();
    }

    public async Task<List<Core.Models.Make>> GetAllAsync()
    {
        var makes = await context.Makes.ToListAsync();

        return makes.ToDomainModel();
    }

    public async Task<Model?> GetModelAsync(int id)
    {
        var model = await context.Models.SingleOrDefaultAsync(x => x.Id == id);

        return model?.ToDomainModel();
    }

    public async Task<List<Model>> GetAllModelsAsync()
    {
        var models = await context.Models.ToListAsync();

        return models.ToDomainModel();
    }

    public async Task<Page<Core.Models.Make>> GetPageAsync(int currentPage, int pageSize)
    {
        var offset = (currentPage - 1) * pageSize;

        var makeList = await context.Makes
            .OrderBy(x => x.Id)
            .Skip(offset)
            .Take(pageSize)
            .ToListAsync();

        var recordCount = await context.Makes.CountAsync();
        var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

        return new Page<Core.Models.Make>(currentPage, pageCount, pageSize, makeList.ToDomainModel());
    }

    public async Task UpdateAsync(Core.Models.Make updateMake)
    {
        updateMake.Models.ForEach(x => x.MakeId = updateMake.Id);

        var existingMake = await context.Makes
            .Include(x => x.Models)
            .FirstAsync(x => x.Id == updateMake.Id);

        existingMake.Name = updateMake.Name;

        foreach (var existingModel in existingMake.Models)
        {
            var updateModel = updateMake.Models.FirstOrDefault(x => x.Id == existingModel.Id);

            if (updateModel is null)
            {
                context.Models.Remove(existingModel);
            }
            else
            {
                existingModel.Name = updateModel.Name;
                existingModel.ModelVariant = updateModel.ModelVariant;
            }
        }

        var newModels = updateMake.Models
            .Where(updateModel => existingMake.Models.All(existingModel => existingModel.Id != updateModel.Id))
            .ToList();

        await context.Models.AddRangeAsync(newModels.ToEntity());

        await context.SaveChangesAsync();
    }
}