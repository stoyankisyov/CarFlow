using System.Security.Claims;
using CarFlow.Core.Models;
using CarFlow.Core.Repositories;
using CarFlow.DomainServices.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CarFlow.DomainServices.Services;

public class AccountService(
    IPasswordHasherService passwordHasherService,
    IAccountRepositоry accountRepositоry,
    IRoleRepository roleRepository,
    ITokenService tokenService)
    : IAccountService
{
    public async Task AddAccountAsync(Account account)
    {
        account.Password = passwordHasherService.HashPassword(account.Password);

        var userRole = await roleRepository.GetUserRoleAsync();
        account.Roles.Add(userRole);

        await accountRepositоry.AddAccountAsync(account);
    }

    public async Task<ClaimsPrincipal?> AuthenticateAsync(string email, string providedPassword)
    {
        var account = await accountRepositоry.GetAccountByEmailAsync(email);

        if (account is null || !passwordHasherService.VerifyHashedPassword(providedPassword, account.Password))
        {
            return null;
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Email, account.Email)
        };

        account.Roles.ForEach(x => claims.Add(new Claim(ClaimTypes.Role, x.Name)));

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        return new ClaimsPrincipal(claimsIdentity);
    }

    public async Task<string?> AuthenticateTokenAsync(string email, string providedPassword)
    {
        var account = await accountRepositоry.GetAccountByEmailAsync(email);

        if (account is null || !passwordHasherService.VerifyHashedPassword(providedPassword, account.Password))
        {
            return null;
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Email, account.Email),
            new(ClaimTypes.Name, account.Email)
        };

        account.Roles.ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role.Name)));

        var token = tokenService.GenerateToken(claims);

        return token;
    }
}