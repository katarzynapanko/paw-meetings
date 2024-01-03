using FluentResults;
using PetsFile.Application.Authentication;

namespace PetsFile.Authentication.Interfaces
{
    public interface ILoginService
    {
        Task<Result<TokenResult>> Login(LoginModel model);
    }
}