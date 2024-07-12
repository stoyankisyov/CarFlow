using CarFlow.DomainServices.IService;

namespace CarFlow.DomainServices.Services
{
    public class PasswordHasherService : IPasswordHasherService
    {
        public string HashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);

        public bool VerifyHashedPassword(string providedPassword, string hashedPassword) => BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
    }
}
