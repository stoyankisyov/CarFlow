﻿using CarFlow.DomainServices.Interfaces;
using CarFlow.UI.Interfaces;
using CarFlow.UI.Mappers;
using CarFlow.UI.Models.ViewModels;

namespace CarFlow.UI.Managers;

public class CarOptionsManager(
    IMakeService makeService,
    ITransmissionService transmissionService,
    IDrivetrainService drivetrainService,
    IEngineService engineService)
    : ICarOptionsManager
{
    public async Task<CarBaseManagementOptionsViewModel> GetCarBaseOptionsAsync()
        => new()
        {
            Makes = (await makeService.GetAllAsync()).ToViewModel(),
            Models = (await makeService.GetAllModelsAsync()).ToViewModel(),
            Transmissions = (await transmissionService.GetAllAsync()).ToViewModel(),
            TransmissionVariants = (await transmissionService.GetAllVariantsAsync()).ToViewModel(),
            Drivetrains = (await drivetrainService.GetAllAsync()).ToViewModel()
        };

    // TODO: story 86
    public async Task<CombustionEngineCarManagementOptionsViewModel> GetCombustionEngineCarOptionsAsync()
        => new()
        {
            Engines = (await engineService.GetAllAsync()).ToViewModel(),
            EuroStandards = []
        };
}