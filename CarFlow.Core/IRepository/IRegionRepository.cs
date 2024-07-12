using CarFlow.Core.Models;

namespace CarFlow.Core.IRepository
{
    public interface IRegionRepository
    {
        Task AddAsync(Region region);
        Task DeleteAsync(int id);
        Task<Region> GetAsync(int id);
        Task<Page<Region>> GetPageAsync(int currentPage, int pageSize);
        Task UpdateAsync(Region updateRegion);
    }
}
