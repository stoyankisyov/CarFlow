using CarFlow.Core.Models;

namespace CarFlow.Core.Repositories;

public interface IMakeRepository
{
    Task AddAsync(Make make);
    Task DeleteAsync(int id);
    Task<Make?> GetAsync(int id);
    Task<List<Make>> GetAllAsync();
    Task<Model?> GetModelAsync(int id);
    Task<List<Model>> GetAllModelsAsync();
    Task<Page<Make>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(Make updateMake);
}