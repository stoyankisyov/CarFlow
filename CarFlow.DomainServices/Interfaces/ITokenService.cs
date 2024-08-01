using System.Security.Claims;

namespace CarFlow.DomainServices.Interfaces;

public interface ITokenService
{
    string GenerateToken(IEnumerable<Claim> claims);
}