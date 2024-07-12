using CarFlow.Core.Models;

namespace CarFlow.Core.IRepository
{
    public interface IEngineAspirationRepository
    {
        Task AddAsync(EngineAspiration engineAspiration);
        Task DeleteAsync(int id);
        Task<EngineAspiration> GetAsync(int id);
        Task<List<EngineAspiration>> GetAllAsync();
        Task<Page<EngineAspiration>> GetPageAsync(int currentPage, int pageSize);
        Task UpdateAsync(EngineAspiration updateEngineAspiration);
    }
}
