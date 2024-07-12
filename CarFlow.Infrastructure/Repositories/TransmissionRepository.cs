using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories
{
    public class TransmissionRepository(CarFlowContext context) : ITransmissionRepository
    {
        public async Task AddAsync(Core.Models.Transmission transmission)
        {
            await context.Transmissions.AddAsync(transmission.ToEntity());

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var transmission = await context.Transmissions
                .Include(x => x.TransmissionVariants)
                .SingleAsync(x => x.Id == id);
            context.TransmissionVariants.RemoveRange(transmission.TransmissionVariants);
            context.Transmissions.Remove(transmission);

            await context.SaveChangesAsync();
        }

        public async Task<Core.Models.Transmission> GetAsync(int id)
        {
            var transmission = await context.Transmissions
                .Include(x => x.TransmissionVariants)
                .SingleAsync(x => x.Id == id);

            return transmission.ToDomainModel();
        }

        public async Task<List<Core.Models.Transmission>> GetAllAsync()
        {
            var transmissions = await context.Transmissions.ToListAsync();

            return transmissions.ToDomainModel();
        }

        public async Task<List<Core.Models.TransmissionVariant>> GetAllVariantsAsync()
        {
            var transmissionVariants = await context.TransmissionVariants.ToListAsync();

            return transmissionVariants.ToDomainModel();
        }

        public async Task<Page<Core.Models.Transmission>> GetPageAsync(int currentPage, int pageSize)
        {
            var offset = (currentPage - 1) * pageSize;

            var transmissionList = await context.Transmissions
                .OrderBy(x => x.Id)
                .Skip(offset)
                .Take(pageSize)
                .ToListAsync();

            var recordCount = await context.Transmissions.CountAsync();
            var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

            return new Page<Core.Models.Transmission>(currentPage, pageCount, pageSize, transmissionList.ToDomainModel());
        }

        public async Task UpdateAsync(Core.Models.Transmission updateTransmission)
        {
            updateTransmission.TransmissionVariants.ForEach(x => x.TransmissionId = updateTransmission.Id);

            var existingTransmission = await context.Transmissions
                .Include(x => x.TransmissionVariants)
                .FirstAsync(x => x.Id == updateTransmission.Id);

            existingTransmission.Name = updateTransmission.Name;

            foreach (var existingTransmissionVariant in existingTransmission.TransmissionVariants)
            {
                var updateTransmissionVariant = updateTransmission.TransmissionVariants.FirstOrDefault(x => x.Id == existingTransmissionVariant.Id);

                if (updateTransmissionVariant is null)
                {
                    context.TransmissionVariants.Remove(existingTransmissionVariant);
                }
                else
                {
                    existingTransmissionVariant.GearCount = updateTransmissionVariant.GearCount;
                }
            }

            var newTransmissionVariants = updateTransmission.TransmissionVariants
                .Where(updateTransmissionVariant => existingTransmission.TransmissionVariants.All(existingTransmissionVariant => existingTransmissionVariant.Id != updateTransmissionVariant.Id))
                .ToList();

            await context.TransmissionVariants.AddRangeAsync(newTransmissionVariants.ToEntity());

            await context.SaveChangesAsync();
        }
    }
}
