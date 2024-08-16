using CarFlow.Core.Repositories;
using CarFlow.Infrastructure.Repositories;

namespace CarFlow.WebAPI.Extensions;

public static class RepositoryExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepositоry, AccountRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<ITransmissionRepository, TransmissionRepository>();
        services.AddScoped<IEngineRepository, EngineRepository>();

        return services;
    }
}