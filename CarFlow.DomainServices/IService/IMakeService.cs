using CarFlow.Core.Models;

namespace CarFlow.DomainServices.IService
{
    public interface IMakeService
    {
        Task AddAsync(Make make);
        Task DeleteAsync(int id);
        Task<Make> GetAsync(int id);
        Task<List<Make>> GetAllAsync();
        Task<List<Model>> GetAllModelsAsync();
        Task<Page<Make>> GetPageAsync(int currentPage, int pageSize);
        Task UpdateAsync(Make updateMake);
    }
}
