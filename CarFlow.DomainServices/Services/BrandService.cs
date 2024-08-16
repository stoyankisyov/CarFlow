using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Services;

public class BrandService(IBrandRepository brandRepository) : IBrandService
{
    public async Task AddAsync(Brand brand)
        => await brandRepository.AddAsync(brand);

    public async Task DeleteAsync(int id)
        => await brandRepository.DeleteAsync(id);

    public async Task<Brand?> GetAsync(int id)
        => await brandRepository.GetAsync(id);

    public async Task<List<Brand>> GetAllAsync()
        => await brandRepository.GetAllAsync();

    public async Task<List<Model>> GetAllModelsAsync()
        => await brandRepository.GetAllModelsAsync();

    public async Task<Page<Brand>> GetPageAsync(int currentPage, int pageSize)
        => await brandRepository.GetPageAsync(currentPage, pageSize);

    public async Task UpdateAsync(Brand updateBrand)
        => await brandRepository.UpdateAsync(updateBrand);
}