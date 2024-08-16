using CarFlow.Core.Models;

namespace CarFlow.Core.Repositories;

public interface IBrandRepository
{
    Task AddAsync(Brand brand);
    Task DeleteAsync(int id);
    Task<Brand?> GetAsync(int id);
    Task<List<Brand>> GetAllAsync();
    Task<Model?> GetModelAsync(int id);
    Task<List<Model>> GetAllModelsAsync();
    Task<Page<Brand>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(Brand updateBrand);
}