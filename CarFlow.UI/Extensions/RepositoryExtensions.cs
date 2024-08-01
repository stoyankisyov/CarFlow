using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Repositories;

namespace CarFlow.UI.Extensions;

public static class RepositoryExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepositоry, AccountRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IMakeRepository, MakeRepository>();
        services.AddScoped<ITransmissionRepository, TransmissionRepository>();
        services.AddScoped<IDrivetrainRepository, DrivetrainRepository>();
        services.AddScoped<IEngineRepository, EngineRepository>();
        services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
        services.AddScoped<IEngineAspirationRepository, EngineAspirationRepository>();
        services.AddScoped<IEngineConfigurationRepository, EngineConfigurationRepository>();
        services.AddScoped<IRegionRepository, RegionRepository>();

        return services;
    }
}