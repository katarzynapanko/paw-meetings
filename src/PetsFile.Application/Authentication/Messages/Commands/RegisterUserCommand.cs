using FluentResults;
using MediatR;

namespace PetsFile.Application.Authentication.Messages.Commands
{
    public sealed record RegisterUserCommand(
        DateTime DateOfBirth,
        string Name,
        string Surname,
        string Email,
        string Password,
        string Street,
        string District,
        string City,
        string Country,
        string PostalCode
        ) : IRequest<Result>
    {
    }
}
