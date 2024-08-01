using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Interfaces;

public interface IEngineAspirationService
{
    Task AddAsync(EngineAspiration engineAspiration);
    Task DeleteAsync(int id);
    Task<EngineAspiration?> GetAsync(int id);
    Task<List<EngineAspiration>> GetAllAsync();
    Task<Page<EngineAspiration>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(EngineAspiration updateEngineAspiration);
}