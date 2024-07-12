using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.DomainServices.IService;

namespace CarFlow.DomainServices.Services
{
    public class TransmissionService(ITransmissionRepository transmissionRepository) : ITransmissionService
    {
        public async Task AddAsync(Transmission transmission) => await transmissionRepository.AddAsync(transmission);

        public async Task DeleteAsync(int id) => await transmissionRepository.DeleteAsync(id);

        public async Task<Transmission> GetAsync(int id) => await transmissionRepository.GetAsync(id);

        public async Task<List<Transmission>> GetAllAsync() => await transmissionRepository.GetAllAsync();

        public async Task<List<TransmissionVariant>> GetAllVariantsAsync() => await transmissionRepository.GetAllVariantsAsync();

        public async Task<Page<Transmission>> GetPageAsync(int currentPage, int pageSize) => await transmissionRepository.GetPageAsync(currentPage, pageSize);

        public async Task UpdateAsync(Transmission updateTransmission) => await transmissionRepository.UpdateAsync(updateTransmission);
    }
}
