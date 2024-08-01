namespace CarFlow.DomainServices.Interfaces;

public interface IPasswordHasherService
{
    string HashPassword(string password);
    bool VerifyHashedPassword(string providedPassword, string hashedPassword);
}