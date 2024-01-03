using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PetsFile.Authentication.Interfaces
{
    public interface ITokenFactory
    {
        JwtSecurityToken GetToken(List<Claim> authClaims);
    }
}