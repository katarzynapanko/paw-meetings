using FluentResults;
using MediatR;

namespace PetsFile.Application.PetsMetadata.Messages.Commands
{
    public record SavePetTypeCommand(string Type) : IRequest<Result>
    {
    }
}
