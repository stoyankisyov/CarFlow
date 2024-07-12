using CarFlow.Core.Models;
using System.Security.Claims;

namespace CarFlow.DomainServices.IService
{
    public interface IAccountService
    {
        Task AddAccountAsync(Account account);
        Task<ClaimsPrincipal?> AuthenticateAsync(string email, string password);
    }
}
