namespace CarFlow.WebAPI.Extensions;

public static class AuthorizationExtensions
{
    public static IServiceCollection AddPolicyAuthorization(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
            options.AddPolicy("ManagerPolicy", policy => policy.RequireRole("Manager"));
            options.AddPolicy("UserPolicy", policy => policy.RequireRole("User"));
        });

        return services;
    }
}