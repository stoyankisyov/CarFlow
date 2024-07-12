using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.Infrastructure.Mappers;
using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace CarFlow.Infrastructure.Repositories
{
    public class EngineRepository(CarFlowContext context) : IEngineRepository
    {
        public async Task AddAsync(Core.Models.Engine engine)
        {
            await context.Engines.AddAsync(engine.ToEntity());

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var engine = await context.Engines.SingleAsync(x => x.Id == id);

            context.Engines.Remove(engine);

            await context.SaveChangesAsync();
        }

        public async Task<Core.Models.Engine> GetAsync(int id)
        {
            var engine = await context.Engines
                .Include(x => x.FuelType)
                .Include(x => x.Configuration)
                .Include(x => x.Aspiration)
                .SingleAsync(x => x.Id == id);

            return engine.ToDomainModel();
        }

        public async Task<List<Core.Models.Engine>> GetAllAsync()
        {
            var engines = await context.Engines
                .Include(x => x.FuelType)
                .Include(x => x.Configuration)
                .Include(x => x.Aspiration)
                .ToListAsync();

            return engines.ToDomainModel();
        }

        public async Task<Page<Core.Models.Engine>> GetPageAsync(int currentPage, int pageSize)
        {
            var offset = (currentPage - 1) * pageSize;

            var engineList = await context.Engines
                .OrderBy(x => x.Id)
                .Skip(offset)
                .Include(x => x.FuelType)
                .Include(x => x.Configuration)
                .Include(x => x.Aspiration)
                .Take(pageSize)
                .ToListAsync();

            var recordCount = await context.Engines.CountAsync();
            var pageCount = (int)Math.Ceiling((double)recordCount / pageSize);

            return new Page<Core.Models.Engine>(currentPage, pageCount, pageSize, engineList.ToDomainModel());
        }

        public async Task UpdateAsync(Core.Models.Engine updateEngine)
        {
            var existingEngine = await context.Engines.SingleAsync(x => x.Id == updateEngine.Id);
            existingEngine.Model = updateEngine.Model;
            existingEngine.Displacement = updateEngine.Displacement;
            existingEngine.Horsepower = updateEngine.Horsepower;
            existingEngine.Torque = updateEngine.Torque;
            existingEngine.FuelTypeId = updateEngine.FuelType.Id;
            existingEngine.ConfigurationId = updateEngine.Configuration.Id;
            existingEngine.AspirationId = updateEngine.Aspiration.Id;

            await context.SaveChangesAsync();
        }
    }
}
