using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Interfaces;

namespace CarFlow.DomainServices.Services;

public class DrivetrainService(IDrivetrainRepository drivetrainRepository) : IDrivetrainService
{
    public async Task AddAsync(Drivetrain drivetrain)
        => await drivetrainRepository.AddAsync(drivetrain);

    public async Task DeleteAsync(int id)
        => await drivetrainRepository.DeleteAsync(id);

    public async Task<Drivetrain?> GetAsync(int id)
        => await drivetrainRepository.GetAsync(id);

    public async Task<List<Drivetrain>> GetAllAsync()
        => await drivetrainRepository.GetAllAsync();

    public async Task<Page<Drivetrain>> GetPageAsync(int currentPage, int pageSize)
        => await drivetrainRepository.GetPageAsync(currentPage, pageSize);

    public async Task UpdateAsync(Drivetrain updateDrivetrain)
        => await drivetrainRepository.UpdateAsync(updateDrivetrain);
}