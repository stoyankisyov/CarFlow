using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Services;

public class EngineService(IEngineRepository engineRepository) : IEngineService
{
    public async Task AddAsync(Engine engine)
        => await engineRepository.AddAsync(engine);

    public async Task DeleteAsync(int id)
        => await engineRepository.DeleteAsync(id);

    public async Task<Engine?> GetAsync(int id)
        => await engineRepository.GetAsync(id);

    public async Task<List<Engine>> GetAllAsync()
        => await engineRepository.GetAllAsync();

    public async Task<Page<Engine>> GetPageAsync(int currentPage, int pageSize)
        => await engineRepository.GetPageAsync(currentPage, pageSize);

    public async Task UpdateAsync(Engine updateEngine)
        => await engineRepository.UpdateAsync(updateEngine);
}