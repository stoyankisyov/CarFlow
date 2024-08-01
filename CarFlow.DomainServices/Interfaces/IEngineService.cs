using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Interfaces;

public interface IEngineService
{
    Task AddAsync(Engine engine);
    Task DeleteAsync(int id);
    Task<Engine?> GetAsync(int id);
    Task<List<Engine>> GetAllAsync();
    Task<Page<Engine>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(Engine updateEngine);
}