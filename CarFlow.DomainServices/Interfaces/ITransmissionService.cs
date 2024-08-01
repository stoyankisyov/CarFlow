﻿using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Interfaces;

public interface ITransmissionService
{
    Task AddAsync(Transmission transmission);
    Task DeleteAsync(int id);
    Task<Transmission?> GetAsync(int id);
    Task<List<Transmission>> GetAllAsync();
    Task<List<TransmissionVariant>> GetAllVariantsAsync();
    Task<Page<Transmission>> GetPageAsync(int currentPage, int pageSize);
    Task UpdateAsync(Transmission updateTransmission);
}