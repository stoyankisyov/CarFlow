using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Services;

public class EngineAspirationService(IEngineAspirationRepository engineAspirationRepository)
    : IEngineAspirationService
{
    public async Task AddAsync(EngineAspiration engineAspiration)
        => await engineAspirationRepository.AddAsync(engineAspiration);

    public async Task DeleteAsync(int id)
        => await engineAspirationRepository.DeleteAsync(id);

    public async Task<EngineAspiration?> GetAsync(int id)
        => await engineAspirationRepository.GetAsync(id);

    public async Task<List<EngineAspiration>> GetAllAsync()
        => await engineAspirationRepository.GetAllAsync();

    public async Task<Page<EngineAspiration>> GetPageAsync(int currentPage, int pageSize)
        => await engineAspirationRepository.GetPageAsync(currentPage, pageSize);

    public async Task UpdateAsync(EngineAspiration updateEngineAspiration)
        => await engineAspirationRepository.UpdateAsync(updateEngineAspiration);
}