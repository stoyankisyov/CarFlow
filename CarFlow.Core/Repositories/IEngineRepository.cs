using CarFlow.Core.Models;

namespace CarFlow.Core.Repositories;

public interface IEngineRepository
{
    Task AddAsync(Engine engine);
    Task DeleteAsync(int id);
    Task<Engine?> GetAsync(int id);
    Task<List<Engine>> GetAllAsync();
    Task<Page<Engine>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(Engine updateEngine);
}