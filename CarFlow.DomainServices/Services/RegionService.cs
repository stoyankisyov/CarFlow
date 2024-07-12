using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.DomainServices.IService;

namespace CarFlow.DomainServices.Services
{
    public class RegionService(IRegionRepository regionRepository) : IRegionService
    {
        public async Task AddAsync(Region region) => await regionRepository.AddAsync(region);

        public async Task DeleteAsync(int id) => await regionRepository.DeleteAsync(id);

        public async Task<Region> GetAsync(int id) => await regionRepository.GetAsync(id);

        public async Task<Page<Region>> GetPageAsync(int currentPage, int pageSize) => await regionRepository.GetPageAsync(currentPage, pageSize);

        public async Task UpdateAsync(Region updateRegion) => await regionRepository.UpdateAsync(updateRegion);
    }
}
