using CarFlow.Core.Models;

namespace CarFlow.DomainServices.IService
{
    public interface IRegionService
    {
        Task AddAsync(Region region);
        Task DeleteAsync(int id);
        Task<Region> GetAsync(int id);
        Task<Page<Region>> GetPageAsync(int currentPage, int pageSize);
        Task UpdateAsync(Region updateRegion);
    }
}
