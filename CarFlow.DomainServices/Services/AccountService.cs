using CarFlow.Core.IRepository;
using CarFlow.Core.Models;
using CarFlow.DomainServices.IService;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace CarFlow.DomainServices.Services
{
    public class AccountService(
        IPasswordHasherService passwordHasherService,
        IAccountRepositоry accountRepositоry,
        IRoleRepository roleRepository)
        : IAccountService
    {
        public async Task AddAccountAsync(Account account)
        {
            account.Password = passwordHasherService.HashPassword(account.Password);
            account.Roles.Add(await roleRepository.GetUserRoleAsync());

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
                new(ClaimTypes.Email, account.Email),
            };

            account.Roles.ForEach(x => claims.Add(new Claim(ClaimTypes.Role, x.Name)));

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            return new ClaimsPrincipal(claimsIdentity);
        }
    }
}
