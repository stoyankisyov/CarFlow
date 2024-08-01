using CarFlow.UI.Interfaces;
using CarFlow.UI.Managers;

namespace CarFlow.UI.Extensions;

public static class ManagerExtensions
{
    public static IServiceCollection AddManagers(this IServiceCollection services)
    {
        services.AddScoped<ICarOptionsManager, CarOptionsManager>();
        services.AddScoped<IEngineOptionsManager, EngineOptionsManager>();

        return services;
    }
}