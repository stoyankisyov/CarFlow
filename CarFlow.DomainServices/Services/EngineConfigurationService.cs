using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.DomainServices.IService;

namespace CarFlow.DomainServices.Services
{
    public class EngineConfigurationService(IEngineConfigurationRepository engineConfigurationRepository)
        : IEngineConfigurationService
    {
        public async Task AddAsync(EngineConfiguration engineConfiguration) => await engineConfigurationRepository.AddAsync(engineConfiguration);

        public async Task DeleteAsync(int id) => await engineConfigurationRepository.DeleteAsync(id);

        public async Task<EngineConfiguration> Get(int id) => await engineConfigurationRepository.GetAsync(id);

        public async Task<List<EngineConfiguration>> GetAllAsync() => await engineConfigurationRepository.GetAllAsync();

        public async Task<Page<EngineConfiguration>> GetPageAsync(int currentPage, int pageSize) => await engineConfigurationRepository.GetPageAsync(currentPage, pageSize);

        public async Task UpdateAsync(EngineConfiguration updateEngineConfiguration) => await engineConfigurationRepository.UpdateAsync(updateEngineConfiguration);
    }
}
