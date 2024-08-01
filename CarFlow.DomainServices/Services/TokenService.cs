using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CarFlow.Core.Models.Settings;
using CarFlow.DomainServices.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace CarFlow.DomainServices.Services;

public class TokenService(JwtSettings jwtSettings) : ITokenService
{
    public string GenerateToken(IEnumerable<Claim> claims)
    {
        var key = Encoding.ASCII.GetBytes(jwtSettings.Key);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddMinutes(jwtSettings.ExpiryMinutes),
            Issuer = jwtSettings.Issuer,
            Audience = jwtSettings.Audience,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}