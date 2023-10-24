using FluentResults;
using MediatR;

namespace PetsFile.Application.Owners.Messages.Commands
{
    public record RegisterOwnerAddressCommand(Guid OwnerId, string Street,
        string District, string City, string Country, string PostalCode) : IRequest<Result>
    {
    }
}
