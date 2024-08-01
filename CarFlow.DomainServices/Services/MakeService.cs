using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Services;

public class MakeService(IMakeRepository makeRepository) : IMakeService
{
    public async Task AddAsync(Make make)
        => await makeRepository.AddAsync(make);

    public async Task DeleteAsync(int id)
        => await makeRepository.DeleteAsync(id);

    public async Task<Make?> GetAsync(int id)
        => await makeRepository.GetAsync(id);

    public async Task<List<Make>> GetAllAsync()
        => await makeRepository.GetAllAsync();

    public async Task<List<Model>> GetAllModelsAsync()
        => await makeRepository.GetAllModelsAsync();

    public async Task<Page<Make>> GetPageAsync(int currentPage, int pageSize)
        => await makeRepository.GetPageAsync(currentPage, pageSize);

    public async Task UpdateAsync(Make updateMake)
        => await makeRepository.UpdateAsync(updateMake);
}