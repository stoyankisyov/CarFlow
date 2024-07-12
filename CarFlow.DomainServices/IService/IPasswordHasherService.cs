namespace CarFlow.DomainServices.IService
{
    public interface IPasswordHasherService
    {
        string HashPassword(string password);
        bool VerifyHashedPassword(string providedPassword, string hashedPassword);
    }
}
