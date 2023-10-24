using FluentResults;
using MediatR;

namespace PetsFile.Application.PetsMetadata.Messages.Commands
{
    public record SaveTraitCommand(string Trait) : IRequest<Result>
    {
    }
}
