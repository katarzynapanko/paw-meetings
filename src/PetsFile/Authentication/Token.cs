using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;

namespace PetsFile.Authentication
{
    public record TokenResult
    {
        public string Token { get; init; } = string.Empty;
        public DateTime Expiration { get; init; }

        public TokenResult(string token, DateTime expiration)
        {
            Token = token;
            Expiration = expiration;

        }
    }
}
