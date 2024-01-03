using Microsoft.AspNetCore.Identity;
using PetsFile.Application.Authentication.Messages.Commands;

namespace PetsFile.Application.Authentication.Interfaces
{
    public interface IIdentityUserFactory
    {
        IdentityUser CreateUser(RegisterUserCommand request);
    }
}