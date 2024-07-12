using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories
{
    public class DrivetrainRepository(CarFlowContext context) : IDrivetrainRepository
    {
        public async Task AddAsync(Core.Models.Drivetrain drivetrain)
        {
            await context.Drivetrains.AddAsync(drivetrain.ToEntity());

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var drivetrain = await context.Drivetrains.SingleAsync(x => x.Id == id);
            context.Drivetrains.Remove(drivetrain);

            await context.SaveChangesAsync();
        }

        public async Task<Core.Models.Drivetrain> GetAsync(int id)
        {
            var drivetrain = await context.Drivetrains.SingleAsync(x => x.Id == id);

            return drivetrain.ToDomainModel();
        }

        public async Task<List<Core.Models.Drivetrain>> GetAllAsync()
        {
            var drivetrains = await context.Drivetrains.ToListAsync();

            return drivetrains.ToDomainModel();
        }

        public async Task<Page<Core.Models.Drivetrain>> GetPageAsync(int currentPage, int pageSize)
        {
            var offset = (currentPage - 1) * pageSize;

            var drivetrainList = await context.Drivetrains
                .OrderBy(x => x.Id)
                .Skip(offset)
                .Take(pageSize)
                .ToListAsync();

            var recordCount = await context.Drivetrains.CountAsync();
            var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

            return new Page<Core.Models.Drivetrain>(currentPage, pageCount, pageSize, drivetrainList.ToDomainModel());
        }

        public async Task UpdateAsync(Core.Models.Drivetrain updateDrivetrain)
        {
            var existingDrivetrain = await context.Drivetrains.SingleAsync(x => x.Id == updateDrivetrain.Id);
            existingDrivetrain.Name = updateDrivetrain.Name;

            await context.SaveChangesAsync();
        }
    }
}
