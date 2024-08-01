using System.Security.Claims;
using CarFlow.Core.Models;

namespace CarFlow.DomainServices.Interfaces;

public interface IAccountService
{
    Task AddAccountAsync(Account account);
    Task<ClaimsPrincipal?> AuthenticateAsync(string email, string password);
    Task<string?> AuthenticateTokenAsync(string email, string password);
}