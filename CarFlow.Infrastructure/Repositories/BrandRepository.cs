using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Model = CarFlow.Core.Models.Model;

namespace CarFlow.Infrastructure.Repositories;

public class BrandRepository(CarFlowContext context) : IBrandRepository
{
    public async Task DeleteAsync(int id)
    {
        var brand = await context.Brands
            .Include(x => x.Models)
            .SingleAsync(x => x.Id == id);

        context.Models.RemoveRange(brand.Models);
        context.Brands.Remove(brand);

        await context.SaveChangesAsync();
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

    public async Task AddAsync(Core.Models.Brand brand)
    {
        await context.Brands.AddAsync(brand.ToEntity());

        await context.SaveChangesAsync();
    }

    public async Task<Core.Models.Brand?> GetAsync(int id)
    {
        var brand = await context.Brands
            .Include(x => x.Models)
            .SingleOrDefaultAsync(x => x.Id == id);

        return brand?.ToDomainModel();
    }

    public async Task<List<Core.Models.Brand>> GetAllAsync()
    {
        var brands = await context.Brands.ToListAsync();

        return brands.ToDomainModel();
    }

    public async Task<Page<Core.Models.Brand>> GetPageAsync(int currentPage, int pageSize)
    {
        var offset = (currentPage - 1) * pageSize;

        var brandsList = await context.Brands
            .OrderBy(x => x.Id)
            .Skip(offset)
            .Take(pageSize)
            .ToListAsync();

        var recordCount = await context.Brands.CountAsync();
        var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

        return new Page<Core.Models.Brand>(currentPage, pageCount, pageSize, brandsList.ToDomainModel());
    }

    public async Task UpdateAsync(Core.Models.Brand updateBrand)
    {
        updateBrand.Models.ForEach(x => x.BrandId = updateBrand.Id);

        var existingBrand = await context.Brands
            .Include(x => x.Models)
            .FirstAsync(x => x.Id == updateBrand.Id);

        existingBrand.Name = updateBrand.Name;

        foreach (var existingModel in existingBrand.Models)
        {
            var updateModel = updateBrand.Models.FirstOrDefault(x => x.Id == existingModel.Id);

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

        var newModels = updateBrand.Models
            .Where(updateModel => existingBrand.Models.All(existingModel => existingModel.Id != updateModel.Id))
            .ToList();

        await context.Models.AddRangeAsync(newModels.ToEntity());

        await context.SaveChangesAsync();
    }
}