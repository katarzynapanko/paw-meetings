using Microsoft.AspNetCore.Identity;
using PetsFile.Application.Authentication.Interfaces;
using PetsFile.Application.Authentication.Messages.Commands;

namespace PetsFile.Application.Authentication
{
    public class IdentityUserFactory : IIdentityUserFactory
    {
        public IdentityUser CreateUser(RegisterUserCommand request)
        {
            return new IdentityUser()
            {
                UserName = request.Email,
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
            };
        }
    }
}
