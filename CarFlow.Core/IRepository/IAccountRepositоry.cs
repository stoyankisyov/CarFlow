using CarFlow.Core.Models;

namespace CarFlow.Core.IRepository
{
    public interface IAccountRepositоry
    {
        Task AddAccountAsync(Account account);
        Task<Account?> GetAccountByEmailAsync(string email);
    }
}
