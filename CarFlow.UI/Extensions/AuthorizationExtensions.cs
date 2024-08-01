namespace CarFlow.UI.Extensions;

public static class AuthorizationExtensions
{
    public static IServiceCollection AddPolicyAuthorization(this IServiceCollection services)
    {
        services.AddAuthorization(option =>
        {
            option.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
            option.AddPolicy("ManagerPolicy", policy => policy.RequireRole("Manager"));
            option.AddPolicy("UserPolicy", policy => policy.RequireRole("User"));
        });

        return services;
    }
}