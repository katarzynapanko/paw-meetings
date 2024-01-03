using FluentResults;
using Microsoft.AspNetCore.Identity;
using PetsFile.Application.Authentication;
using PetsFile.Authentication.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PetsFile.Authentication.Services
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenFactory _tokenFactory;

        public LoginService(ITokenFactory tokenFactory, UserManager<IdentityUser> userManager)
        {
            _tokenFactory = tokenFactory;
            _userManager = userManager;
        }

        public async Task<Result<TokenResult>> Login(LoginModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                return Result.Fail("Unauthorized");
            }
            var userRoles = await _userManager.GetRolesAsync(user);
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }
            var token = _tokenFactory.GetToken(authClaims);
            var loginResult = new TokenResult(new JwtSecurityTokenHandler().WriteToken(token), token.ValidTo);
            return loginResult;
        }
    }
}
