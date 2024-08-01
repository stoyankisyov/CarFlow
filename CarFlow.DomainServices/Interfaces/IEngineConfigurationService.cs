using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Interfaces;

public interface IEngineConfigurationService
{
    Task AddAsync(EngineConfiguration engineConfiguration);
    Task DeleteAsync(int id);
    Task<EngineConfiguration?> GetAsync(int id);
    Task<List<EngineConfiguration>> GetAllAsync();
    Task<Page<EngineConfiguration>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(EngineConfiguration updateEngineConfiguration);
}