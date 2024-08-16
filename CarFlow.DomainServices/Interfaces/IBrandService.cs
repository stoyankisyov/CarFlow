using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Interfaces;

public interface IBrandService
{
    Task AddAsync(Brand brand);
    Task DeleteAsync(int id);
    Task<Brand?> GetAsync(int id);
    Task<List<Brand>> GetAllAsync();
    Task<List<Model>> GetAllModelsAsync();
    Task<Page<Brand>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(Brand updateBrand);
}