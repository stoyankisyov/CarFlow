using CarFlow.Core.Models;
using CarFlow.Core.Models.Commands;
using CarFlow.DomainServices.Factories;
using CarFlow.DomainServices.Handlers;
using CarFlow.DomainServices.Interfaces;
using CarFlow.DomainServices.Services;

namespace CarFlow.UI.Extensions;

public static class DomainExtensions
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IPasswordHasherService, PasswordHasherService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<IMakeService, MakeService>();
        services.AddScoped<ITransmissionService, TransmissionService>();
        services.AddScoped<IDrivetrainService, DrivetrainService>();
        services.AddScoped<IEngineService, EngineService>();
        services.AddScoped<IFuelTypeService, FuelTypeService>();
        services.AddScoped<IEngineAspirationService, EngineAspirationService>();
        services.AddScoped<IEngineConfigurationService, EngineConfigurationService>();
        services.AddScoped<IRegionService, RegionService>();

        return services;
    }

    public static IServiceCollection AddDomainHandlers(this IServiceCollection services)
    {
        services
            .AddTransient<IPolymorphicCommandHandler<CarCommand, CombustionEngineCarCreateCommand, Car>,
                CombustionEngineCarCreateHandler>();
        services
            .AddTransient<IPolymorphicCommandHandler<CarCommand, CombustionEngineCarUpdateCommand, Car>,
                CombustionEngineCarUpdateHandler>();
        services
            .AddTransient<IPolymorphicCommandHandler<CarCommand, ElectricCarCreateCommand, Car>,
                ElectricCarCreateHandler>();
        services
            .AddTransient<IPolymorphicCommandHandler<CarCommand, ElectricCarUpdateCommand, Car>,
                ElectricCarUpdateHandler>();

        return services;
    }

    public static IServiceCollection AddDomainFactories(this IServiceCollection services)
    {
        services.AddTransient<CarCommandHandlerFactory>();

        return services;
    }
}