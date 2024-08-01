using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Interfaces;

public interface IDrivetrainService
{
    Task AddAsync(Drivetrain drivetrain);
    Task DeleteAsync(int id);
    Task<Drivetrain?> GetAsync(int id);
    Task<List<Drivetrain>> GetAllAsync();
    Task<Page<Drivetrain>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(Drivetrain updateDrivetrain);
}