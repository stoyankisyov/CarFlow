using Microsoft.AspNetCore.Authentication.Cookies;

namespace CarFlow.UI.Extensions;

public static class AuthenticationExtensions
{
    public static IServiceCollection AddCookieAuthentication(this IServiceCollection services)
    {
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(option =>
            {
                option.LoginPath = "/Account/SignIn";
                option.LogoutPath = "/Account/SignOut";
            });

        return services;
    }
}